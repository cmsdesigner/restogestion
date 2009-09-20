Option Explicit On
Option Strict On

'***********************************************************
'*                                                         *
'* Copyright (C) 2006 by Sylvain Bodin                     *
'*                                                         *
'* This file is part of Resto Gestion                      *
'*                                                         *
'* Resto Gestion is free software; you can redistribute it *
'* and/or modify it under the terms of the GNU General     *
'* Public License as published by the Free Software        *
'* Foundation; either version 2 of the License, or any     *
'* later version.                                          *
'*                                                         *
'* This program is distributed in the hope that it will be *
'* useful, but WITHOUT ANY WARRANTY; without even the      *
'* implied warranty of MERCHANTABILITY or FITNESS FOR A    *
'* PARTICULAR PURPOSE.  See the GNU General Public License *
'* for more details.                                       *
'*                                                         *
'* You should have received a copy of the GNU General      *
'* Public License along with this program; if not, write   *
'* to the Free Software Foundation, Inc. at:               *
'*                                                         *
'*           Free Software Foundation, Inc.                *
'*           59 Temple Place - Suite 330                   *
'*           Boston, MA  02111-1307, USA.                  *
'*                                                         *
'***********************************************************
Imports System.Xml.Serialization
Imports System.IO
Public Class UpdateFile
    Inherits UpdateManifest

    Public Sub New()
        MyBase.Clear()
    End Sub

    Public Sub New(ByVal FilePath As String)
        FileLoad(FilePath)
    End Sub

    Public Sub FileLoad(ByVal FilePath As String)
        Try
            Dim items As New UpdateManifest
            Dim it As IEnumerator(Of Names)

            MyBase.Clear()

            Dim reader As StreamReader = New StreamReader(FilePath, System.Text.Encoding.Unicode)
            Dim serialize As XmlSerializer = New XmlSerializer(GetType(UpdateManifest))
            items = CType(serialize.Deserialize(reader), UpdateManifest)
            it = items.GetEnumerator
            While it.MoveNext
                MyBase.Add(it.Current)
            End While

            reader.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub WriteFile(ByVal FilePath As String)
        Try

            Dim writer As StreamWriter = New StreamWriter(FilePath, False, System.Text.Encoding.Unicode)
            Dim serialize As XmlSerializer = New XmlSerializer(GetType(UpdateManifest))
            serialize.Serialize(writer, Me)

            writer.Flush()
            writer.Close()

        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
