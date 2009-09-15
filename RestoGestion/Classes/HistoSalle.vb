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

Public Class HistoSalle
    Inherits KeyedCollection(Of DateTime, HistoTable)

    Private connexion As Base

    Const INSERT_QUERY As String = "INSERT INTO HistoTables (HistoTableDate,HistoTableName,HistoTableCouvert,HistoTableRemise) VALUES (?,?,?,?);"
    Const DELETE_QUERY As String = "DELETE FROM HistoTables WHERE HistoTableDate = ? ;"
    Const DELETE_ALL_QUERY As String = "DELETE FROM HistoTables;"
    Const SELECT_ALL_QUERY As String = "SELECT HistoTableDate,HistoTableName,HistoTableCouvert,HistoTableRemise FROM HistoTables;"

    Public Sub New(ByVal Base As Base)
        connexion = Base
    End Sub

    Public Sub Load()
        Dim table As HistoTable
        Dim result As ArrayList
        Dim it As IEnumerator
        Dim row As Hashtable

        Try
            MyBase.ClearItems()
            result = connexion.ExecuteQuery(SELECT_ALL_QUERY)
            it = result.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                table = New HistoTable(connexion)
                table.HistoDate = CDate(row("HistoTableDate"))
                table.NbSet = row("HistoTableCouvert").ToString
                table.Name = row("HistoTableName").ToString
                table.TxDiscount = CSng(row("HistoTableRemise"))
                table.Load()
                MyBase.InsertItem(Count, table)
            End While
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Overrides Function GetKeyForItem(ByVal item As HistoTable) As DateTime
        Return item.HistoDate
    End Function

    Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As HistoTable)
        Dim params As New ArrayList

        Try
            item.Connexion = connexion
            params.Add(item.HistoDate)
            params.Add(item.Name)
            params.Add(item.NbSet)
            params.Add(item.TxDiscount)

            MyBase.InsertItem(index, item)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        Dim params As New ArrayList
        Dim table As HistoTable

        Try
            table = Items(index)
            table.Clear()
            params.Add(table.HistoDate)
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
End Class



