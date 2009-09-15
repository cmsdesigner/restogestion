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

Public Class Salle
    Inherits KeyedCollection(Of Integer, Table)

    Private connexion As Base

    Const INSERT_QUERY As String = "INSERT INTO Tables (TableWidth,TableHeight,TableTop,TableLeft,TableEnable,TableName,TableCouvert) VALUES (?,?,?,?,?,?,?);"
    Const DELETE_QUERY As String = "DELETE FROM Tables WHERE TableId = ? ;"
    Const UPDATE_QUERY As String = "UPDATE Tables SET TableWidth = ?,TableHeight = ?,TableTop = ?,TableLeft = ?,TableEnable = ?,TableName = ?,TableCouvert = ?,TableRemise = ? WHERE TableId = ?;"
    Const DELETE_ALL_QUERY As String = "DELETE FROM Tables;"
    Const SELECT_ALL_QUERY As String = "SELECT TableId,TableWidth,TableHeight,TableTop,TableLeft,TableEnable,TableName,TableCouvert,TableRemise FROM Tables;"
    Const SELECT_NEXT_ID_QUERY As String = "SELECT IFNULL(MAX(rowid),0) AS Id FROM Tables;"

    Public Sub New(ByVal Base As Base)
        connexion = Base
    End Sub

    Public Sub Load()
        Dim table As Table
        Dim result As Arraylist
        Dim it As IEnumerator
        Dim row As Hashtable

        Try
            MyBase.ClearItems()
            result = connexion.ExecuteQuery(SELECT_ALL_QUERY)
            it = result.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                table = New Table(connexion)
                table.Enable = CBool(row("TableEnable"))
                table.Height = CInt(row("TableHeight"))
                table.Width = CInt(row("TableWidth"))
                table.Left = CInt(row("TableLeft"))
                table.Top = CInt(row("TableTop"))
                table.NbSet = row("TableCouvert").ToString
                table.Name = row("TableName").ToString
                table.TxDiscount = CSng(row("TableRemise"))
                table.Id = CInt(row("TableId"))
                table.Load()
                MyBase.InsertItem(Count, table)
            End While
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Overrides Function GetKeyForItem(ByVal item As Table) As Integer
        Return item.Id
    End Function

    Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As Table)
        Dim params As New Arraylist

        Try
            If item.Id = -1 Then
                item.Id = GetNextId()
            End If

            item.Connexion = connexion
            params.Add(item.Width)
            params.Add(item.Height)
            params.Add(item.Top)
            params.Add(item.Left)
            params.Add(item.Enable)
            params.Add(item.Name)
            params.Add(item.NbSet)

            MyBase.InsertItem(index, item)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        Dim params As New Arraylist
        Dim table As Table

        Try
            table = Items(index)
            table.Clear()
            params.Add(table.Id)
            MyBase.RemoveItem(index)
            connexion.ExecuteNonQuery(DELETE_QUERY, params)
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

    Public Sub UpdateItem(ByVal key As Integer, ByVal item As Table)
        Dim index As Integer
        Dim params As New Arraylist

        Try
            index = IndexOf(Me.Item(key))

            params.Add(item.Width)
            params.Add(item.Height)
            params.Add(item.Top)
            params.Add(item.Left)
            params.Add(item.Enable)
            params.Add(item.Name)
            params.Add(item.NbSet)
            params.Add(item.TxDiscount)
            params.Add(key)

            SetItem(index, item)
            connexion.ExecuteNonQuery(UPDATE_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Function GetNextId() As Integer
        Dim it As IEnumerator
        Dim row As Hashtable
        Dim reader As Arraylist
        Dim result As Integer

        Try
            reader = connexion.ExecuteQuery(SELECT_NEXT_ID_QUERY)
            it = reader.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                result = CInt(row("Id")) + 1
            End While
        Catch ex As Exception
            Throw
        End Try

        Return result
    End Function

End Class



