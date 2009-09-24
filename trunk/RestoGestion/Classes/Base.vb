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

Imports System.Data.SQLite
Imports System.Data

'//Classe pour la gestion de la base //
Public Class Base
	 
    Private Connexion As IDbConnection

    Public Sub New(ByVal BasePath As String)
        Dim ConnexionString As String
        ConnexionString = "data source=" + BasePath
        Connexion = New SQLiteConnection()
        Connexion.ConnectionString = ConnexionString
        Try
            Connexion.Open()
        Catch ex As Exception
            Connexion = Nothing
            Throw
        End Try
    End Sub

    Public Sub Close()
        Try
            Connexion.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ExecuteQuery(ByVal Query As String) As ArrayList
        Dim Command As IDbCommand
        Dim result As ArrayList
        Dim reader As IDataReader
        Dim row As Hashtable

        result = New ArrayList

        Command = Connexion.CreateCommand
        Command.CommandText = Query
        Try
            reader = Command.ExecuteReader()
            While reader.Read()
                row = New Hashtable(reader.FieldCount)
                For i As Integer = 0 To reader.FieldCount - 1
                    row.Add(reader.GetName(i), reader.GetValue(i))
                Next
                result.Add(row)
                row = Nothing
            End While
            reader.Close()
        Catch ex As Exception
            Throw
        Finally
            Command.Dispose()
        End Try

        Return result
    End Function

    Public Function ExecuteQuery(ByVal Query As String, ByVal params As ArrayList) As ArrayList
        Dim Command As IDbCommand
        Dim result As ArrayList
        Dim reader As IDataReader
        Dim row As Hashtable

        result = New ArrayList

        Command = Connexion.CreateCommand
        Command = PrepareQuery(Query, params)
        Try
            reader = Command.ExecuteReader
            While reader.Read()
                row = New Hashtable(reader.FieldCount)
                For i As Integer = 0 To reader.FieldCount - 1
                    row.Add(reader.GetName(i), reader.GetValue(i))
                Next
                result.Add(row)
                row = Nothing
            End While
            reader.Close()
        Catch ex As Exception
            Throw
        Finally
            Command.Dispose()
        End Try

        Return result
    End Function


    Public Function ExecuteNonQuery(ByVal Query As String) As Integer
        Dim Command As IDbCommand
        Dim result As Integer

        Command = Connexion.CreateCommand
        Command.CommandText = Query
        Try
            result = Command.ExecuteNonQuery
        Catch ex As Exception
            Throw
        Finally
            Command.Dispose()
        End Try

        Return result
    End Function

    Public Function ExecuteNonQuery(ByVal Query As String, ByVal params As ArrayList) As Integer
        Dim Command As IDbCommand
        Dim result As Integer

        Command = Connexion.CreateCommand
        Command = PrepareQuery(Query, params)
        Try
            result = Command.ExecuteNonQuery
        Catch ex As Exception
            Throw
        Finally
            Command.Dispose()
        End Try

        Return result
    End Function

    Private Function PrepareQuery(ByVal Query As String, ByVal params As ArrayList) As IDbCommand
        Dim it As IEnumerator
        Dim result As IDbCommand
        Dim param As IDbDataParameter

        result = Connexion.CreateCommand
        result.CommandText = Query
        it = params.GetEnumerator
        While it.MoveNext
            param = result.CreateParameter
            param.Value = it.Current
            result.Parameters.Add(param)
        End While
        result.Prepare()
        Return result
    End Function
End Class
