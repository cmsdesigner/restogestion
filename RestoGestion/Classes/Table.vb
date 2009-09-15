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

Public Class Table
    Inherits KeyedCollection(Of String, Commande)

    Const INSERT_QUERY As String = "INSERT INTO Commandes (TableId,PlatCode,CmdeQte) VALUES (?,?,?);"
    Const DELETE_QUERY As String = "DELETE FROM Commandes WHERE TableId = ? AND PlatCode = ?;"
    Const UPDATE_QUERY As String = "UPDATE Commandes SET CmdeQte = ? WHERE TableId = ? AND PlatCode = ? ;"
    Const DELETE_ALL_QUERY As String = "DELETE FROM Commandes WHERE TableId = ?;"
    Const SELECT_ALL_QUERY As String = "SELECT PlatCode,CmdeQte FROM Commandes WHERE TableId = ?;"

    Public Sub New()
        MyBase.New()
        connexion = Nothing
    End Sub

    Public Sub New(ByVal Base As Base)
        MyBase.New()
        connexion = Base
    End Sub

    Public Function HasOrder() As Boolean
        Return CBool(Me.Count)
    End Function

    Protected Overrides Function GetKeyForItem(ByVal item As Commande) As String
        Return item.PlatCode
    End Function

    Public Sub Load()
        Dim order As Commande
        Dim result As Arraylist
        Dim it As IEnumerator
        Dim row As Hashtable
        Dim params As Arraylist

        Try
            MyBase.ClearItems()
            params = New Arraylist
            params.Add(Me.Id)
            result = connexion.ExecuteQuery(SELECT_ALL_QUERY, params)
            it = result.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                order = New Commande
                order.TableId = Me.Id
                order.PlatCode = row("PlatCode").ToString
                order.Quantite = CInt(row("CmdeQte"))
                MyBase.InsertItem(Me.Count, order)
            End While
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As Commande)
        Dim params As New Arraylist
        Dim order As Commande

        Try
            If Me.Contains(item.PlatCode) Then
                order = Me.Item(item.PlatCode)
                item.Quantite += order.Quantite
                If item.Quantite < 0 Then
                    Throw New ApplicationException(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.QUANTITYINVALID).Value)
                End If
                UpdateItem(IndexOf(order), item)
            Else
                params.Add(Me.Id)
                params.Add(item.PlatCode)
                params.Add(item.Quantite)

                connexion.ExecuteNonQuery(INSERT_QUERY, params)
                MyBase.InsertItem(index, item)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        Dim params As New Arraylist

        Try
            params.Add(Me.Id)
            params.Add(Me.Item(index).PlatCode)
            MyBase.RemoveItem(index)
            connexion.ExecuteNonQuery(DELETE_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Protected Overrides Sub ClearItems()
        Dim params As New Arraylist

        Try
            MyBase.ClearItems()
            params.Add(Me.Id)
            connexion.ExecuteNonQuery(DELETE_ALL_QUERY, params)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateItem(ByVal index As Integer, ByVal item As Commande)
        Dim params As New Arraylist
        Try
            params.Add(item.Quantite)
            params.Add(Me.Id)
            params.Add(item.PlatCode)

            SetItem(index, item)
            connexion.ExecuteNonQuery(UPDATE_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub UpdateItem(ByVal key As String, ByVal item As Commande)
        Dim index As Integer

        Try
            index = IndexOf(Me.Item(key))
            UpdateItem(index, item)
        Catch ex As Exception
            Throw
        End Try

    End Sub

#Region "Proprietés"
    '''''''''''''''''''
    '' Properties    ''
    '''''''''''''''''''
    Private m_Id As Integer
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(ByVal value As Integer)
            m_Id = value
        End Set
    End Property

    Private m_Left As Integer
    Public Property Left() As Integer
        Get
            Return m_Left
        End Get
        Set(ByVal value As Integer)
            m_Left = value
        End Set
    End Property

    Private m_Top As Integer
    Public Property Top() As Integer
        Get
            Return m_Top
        End Get
        Set(ByVal value As Integer)
            m_Top = value
        End Set
    End Property

    Private m_Width As Integer
    Public Property Width() As Integer
        Get
            Return m_Width
        End Get
        Set(ByVal value As Integer)
            m_Width = value
        End Set
    End Property

    Private m_Height As Integer
    Public Property Height() As Integer
        Get
            Return m_Height
        End Get
        Set(ByVal value As Integer)
            m_Height = value
        End Set
    End Property

    Private m_Name As String
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

    Private m_NbSet As String
    Public Property NbSet() As String
        Get
            Return m_NbSet
        End Get
        Set(ByVal value As String)
            m_NbSet = value
        End Set
    End Property

    Private m_TxDiscount As Single
    Public Property TxDiscount() As Single
        Get
            Return m_TxDiscount
        End Get
        Set(ByVal value As Single)
            m_TxDiscount = value
        End Set
    End Property

    Private m_Enable As Boolean
    Public Property Enable() As Boolean
        Get
            Return m_Enable
        End Get
        Set(ByVal value As Boolean)
            m_Enable = value
        End Set
    End Property

    Private m_Connexion As Base
    Public Property Connexion() As Base
        Get
            Return m_Connexion
        End Get
        Set(ByVal value As Base)
            m_Connexion = value
        End Set
    End Property

#End Region
End Class
