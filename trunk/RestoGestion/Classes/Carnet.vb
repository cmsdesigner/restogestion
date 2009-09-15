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
Public Class Carnet
    Inherits KeyedCollection(Of Integer, Client)

    Private connexion As Base

    Const INSERT_QUERY As String = "INSERT INTO Clients (ClientNom,ClientPrenom,ClientAdresse,ClientCP,ClientVille,ClientTelephone,ClientRemarque) VALUES (?,?,?,?,?,?,?);"
    Const DELETE_QUERY As String = "DELETE FROM Clients WHERE ClientId = ? ;"
    Const UPDATE_QUERY As String = "UPDATE Clients SET ClientNom = ?,ClientPrenom = ?,ClientAdresse = ?,ClientCP = ?,ClientVille = ?,ClientTelephone = ?,ClientRemarque = ? WHERE ClientId = ?;"
    Const DELETE_ALL_QUERY As String = "DELETE FROM Clients;"
    Const SELECT_ALL_QUERY As String = "SELECT ClientId,ClientNom,ClientPrenom,ClientAdresse,ClientCP,ClientVille,ClientTelephone,ClientRemarque FROM Clients;"
    Const SELECT_NEXT_ID_QUERY As String = "SELECT IFNULL(MAX(rowid),0) AS Id FROM Clients;"

    Public Sub New(ByVal Base As Base)
        connexion = Base
    End Sub

    Public Sub Load()
        Dim client As Client
        Dim result As ArrayList
        Dim it As IEnumerator
        Dim row As Hashtable

        Try
            MyBase.ClearItems()
            result = connexion.ExecuteQuery(SELECT_ALL_QUERY)
            it = result.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                client = New Client()
                client.Id = CInt(row("ClientId"))
                client.Nom = row("ClientNom").ToString
                client.Prenom = row("ClientPrenom").ToString
                client.Adresse = row("ClientAdresse").ToString
                client.CodePostal = row("ClientCP").ToString
                client.Ville = row("ClientVille").ToString
                client.Telephone = row("ClientTelephone").ToString
                client.Commentaire = row("ClientRemarque").ToString
                MyBase.InsertItem(Count, client)
            End While
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Overrides Function GetKeyForItem(ByVal item As Client) As Integer
        Return item.Id
    End Function

    Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As Client)
        Dim params As New ArrayList

        Try
            If item.Id = -1 Then
                item.Id = GetNextId()
            End If

            params.Add(item.Nom)
            params.Add(item.Prenom)
            params.Add(item.Adresse)
            params.Add(item.CodePostal)
            params.Add(item.Ville)
            params.Add(item.Telephone)
            params.Add(item.Commentaire)

            MyBase.InsertItem(index, item)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        Dim params As New ArrayList
        Dim client As Client

        Try
            client = Items(index)

            params.Add(client.Id)
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

    Public Sub UpdateItem(ByVal key As Integer, ByVal item As Client)
        Dim index As Integer
        Dim params As New ArrayList

        Try
            index = IndexOf(Me.Item(key))

            params.Add(item.Nom)
            params.Add(item.Prenom)
            params.Add(item.Adresse)
            params.Add(item.CodePostal)
            params.Add(item.Ville)
            params.Add(item.Telephone)
            params.Add(item.Commentaire)
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
        Dim reader As ArrayList
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
