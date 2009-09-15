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

Imports System.Collections.ObjectModel

Public Class Menu
    Inherits KeyedCollection(Of String, Plat)

    Private connexion As Base
    Const INSERT_QUERY As String = "INSERT INTO Plats (PlatCode,PlatNom,PlatPrix,PlatTva) VALUES (?,?,?,?);"
    Const DELETE_QUERY As String = "DELETE FROM Plats WHERE PlatCode = ? ;"
    Const UPDATE_QUERY As String = "UPDATE Plats SET PlatCode = ?, PlatNom = ?,PlatPrix = ?,PlatTva = ? WHERE PlatCode = ? ;"
    Const DELETE_ALL_QUERY As String = "DELETE FROM Plats;"
    Const DELETE_ORDERS_QUERY As String = "DELETE FROM Commandes WHERE PlatCode = ? ;"
    Const SELECT_ALL_QUERY As String = "SELECT PlatCode,PlatNom,PlatPrix,PlatTva FROM Plats"

    Public Sub New(ByVal Base As Base)
        MyBase.New()
        connexion = Base
    End Sub

    Public Sub Load()
        Dim plat As Plat
        Dim result As ArrayList
        Dim it As IEnumerator
        Dim row As Hashtable

        Try
            MyBase.ClearItems()
            result = connexion.ExecuteQuery(SELECT_ALL_QUERY)
            it = result.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                plat = New Plat
                plat.Code = row("PlatCode").ToString
                plat.Designation = row("PlatNom").ToString
                plat.Prix = CSng(row("PlatPrix"))
                plat.Tva = CSng(row("PlatTva"))
                MyBase.InsertItem(Me.Count, plat)
            End While
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Overrides Function GetKeyForItem(ByVal item As Plat) As String
        Return item.Code
    End Function

    Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As Plat)
        Dim params As New Arraylist

        If Not Me.Contains(item.Code) Then
            Try
                params.Add(item.Code)
                params.Add(item.Designation)
                params.Add(item.Prix)
                params.Add(item.Tva)

                connexion.ExecuteNonQuery(INSERT_QUERY, params)
                MyBase.InsertItem(index, item)
            Catch ex As Exception
                Throw
            End Try
        Else
            MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.CODEEXIST).Value)
        End If
    End Sub

    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        Dim params As New Arraylist

        Try
            params.Add(Me.Item(index).Code)
            MyBase.RemoveItem(index)
            connexion.ExecuteNonQuery(DELETE_QUERY, params)
            connexion.ExecuteNonQuery(DELETE_ORDERS_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Protected Overrides Sub ClearItems()
        Try
            MyBase.ClearItems()
            connexion.ExecuteNonQuery(DELETE_ALL_QUERY)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateItem(ByVal index As Integer, ByVal item As Plat)
        Dim params As New Arraylist

        Try
            params.Add(item.Code)
            params.Add(item.Designation)
            params.Add(item.Prix)
            params.Add(item.Tva)
            params.Add(Me.Item(index).Code)
            SetItem(index, item)
            connexion.ExecuteNonQuery(UPDATE_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub UpdateItem(ByVal key As String, ByVal item As Plat)
        Dim index As Integer

        Try
            index = IndexOf(Me.Item(key))
            UpdateItem(index, item)
        Catch ex As Exception
            Throw
        End Try

    End Sub
End Class
