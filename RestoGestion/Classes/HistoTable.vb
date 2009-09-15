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

Public Class HistoTable
    Inherits KeyedCollection(Of String, HistoCommande)

    Const INSERT_QUERY As String = "INSERT INTO HistoCommandes (HistoTableDate,HistoPlatCode,HistoPlatNom,HistoPlatPrix,HistoPlatTva,HistoCmdeQte) VALUES (?,?,?,?,?,?);"
    Const DELETE_QUERY As String = "DELETE FROM HistoCommandes WHERE HistoTableDate = ? AND HistoPlatCode = ?;"
    Const DELETE_ALL_QUERY As String = "DELETE FROM HistoCommandes WHERE HistoTableDate = ?;"
    Const SELECT_ALL_QUERY As String = "SELECT HistoPlatCode,HistoPlatNom,HistoPlatPrix,HistoPlatTva,HistoCmdeQte FROM HistoCommandes WHERE HistoTableDate = ?;"

    Public Sub New()
        MyBase.New()
        Connexion = Nothing
        Total = 0
    End Sub

    Public Sub New(ByVal Base As Base)
        MyBase.New()
        Connexion = Base
        Total = 0
    End Sub

    Protected Overrides Function GetKeyForItem(ByVal item As HistoCommande) As String
        Return item.Code
    End Function

    Public Sub Load()
        Dim order As HistoCommande
        Dim result As ArrayList
        Dim it As IEnumerator
        Dim row As Hashtable
        Dim params As ArrayList

        Try
            MyBase.ClearItems()
            params = New ArrayList
            params.Add(Me.HistoDate)
            result = Connexion.ExecuteQuery(SELECT_ALL_QUERY, params)
            Total = 0
            it = result.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                order = New HistoCommande
                order.HistoDate = Me.HistoDate
                order.Code = row("HistoPlatCode").ToString
                order.Designation = row("HistoPlatNom").ToString
                order.Prix = CSng(row("HistoPlatPrix"))
                order.Tva = CSng(row("HistoPlatTva"))
                order.Quantite = CInt(row("HistoCmdeQte"))
                MyBase.InsertItem(Me.Count, order)
                Total = Total + (order.Prix * order.Quantite)
            End While
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As HistoCommande)
        Dim params As New ArrayList

        Try
            params.Add(Me.HistoDate)
            params.Add(item.Code)
            params.Add(item.Designation)
            params.Add(item.Prix)
            params.Add(item.Tva)
            params.Add(item.Quantite)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)
            MyBase.InsertItem(index, item)
            Total = Total + (item.Prix * item.Quantite)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        Dim params As New ArrayList

        Try
            params.Add(Me.HistoDate)
            params.Add(Me.Item(index).Code)
            MyBase.RemoveItem(index)
            connexion.ExecuteNonQuery(DELETE_QUERY, params)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Protected Overrides Sub ClearItems()
        Dim params As New ArrayList

        Try
            MyBase.ClearItems()
            params.Add(Me.HistoDate)
            connexion.ExecuteNonQuery(DELETE_ALL_QUERY, params)
        Catch ex As Exception
            Throw
        End Try
    End Sub

#Region "Proprietés"
    '''''''''''''''''''
    '' Properties    ''
    '''''''''''''''''''
    Private m_HistoDate As DateTime
    Public Property HistoDate() As DateTime
        Get
            Return m_HistoDate
        End Get
        Set(ByVal value As DateTime)
            m_HistoDate = value
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

    Private m_Connexion As Base
    Public Property Connexion() As Base
        Get
            Return m_Connexion
        End Get
        Set(ByVal value As Base)
            m_Connexion = value
        End Set
    End Property

    Private m_Total As Single
    Public Property Total() As Single
        Get
            Return m_Total
        End Get
        Set(ByVal value As Single)
            m_Total = value
        End Set
    End Property

#End Region
End Class
