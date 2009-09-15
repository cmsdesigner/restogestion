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

Imports System.ComponentModel
Imports System.Collections.ObjectModel


Public Class Configuration
    Dim connexion As Base

    Const INSERT_QUERY As String = "INSERT INTO Configuration (Parameter,Value) VALUES (?,?);"
    Const DELETE_ALL_QUERY As String = "DELETE FROM Configuration;"
    Const SELECT_ALL_QUERY As String = "SELECT Parameter,Value FROM Configuration"

    Public Sub New(ByVal Base As Base)
        connexion = Base
        init()
    End Sub

    Private Sub init()
        LanguageFile = ""
        HasPassword = False
        Password = ""
        HasPasswordErase = False
        PasswordErase = ""
        PrintHeader = ""
        LogoPath = ""
        Tva = 0
        PrintFooter = ""
    End Sub

    Public Sub Load()
        Dim result As ArrayList
        Dim it As IEnumerator
        Dim row As Hashtable
        Try
            result = connexion.ExecuteQuery(SELECT_ALL_QUERY)
            it = result.GetEnumerator
            While it.MoveNext
                row = CType(it.Current, Hashtable)
                Select Case row("Parameter").ToString
                    Case "Logo"
                        LogoPath = row("Value").ToString
                    Case "LanguageFile"
                        LanguageFile = row("Value").ToString
                    Case "UsePasswordErase"
                        HasPasswordErase = CBool(row("Value"))
                    Case "PasswordErase"
                        PasswordErase = row("Value").ToString
                    Case "UsePassword"
                        HasPassword = CBool(row("Value"))
                    Case "Password"
                        Password = row("Value").ToString
                    Case "Header"
                        PrintHeader = row("Value").ToString
                    Case "Vat"
                        Tva = CSng(row("Value").ToString.Replace(".", ","))
                    Case ("Footer")
                        PrintFooter = row("Value").ToString
                End Select
            End While
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub SaveConfig()
        Try
            connexion.ExecuteNonQuery(DELETE_ALL_QUERY)

            Dim params As New ArrayList
            params.Add("Logo")
            params.Add(LogoPath)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("LanguageFile")
            params.Add(LanguageFile)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("UsePasswordErase")
            params.Add(HasPasswordErase)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("PasswordErase")
            params.Add(PasswordErase)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("UsePassword")
            params.Add(HasPassword)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("Password")
            params.Add(Password)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("Header")
            params.Add(PrintHeader)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("Vat")
            params.Add(Tva)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

            params.Clear()
            params.Add("Footer")
            params.Add(PrintFooter)
            connexion.ExecuteNonQuery(INSERT_QUERY, params)

        Catch ex As Exception
            Throw
        End Try

    End Sub

#Region "Propriétés"
    '''''''''''''''''''
    '' Properties    ''
    '''''''''''''''''''
    Private m_LogoPath As String
    Public Property LogoPath() As String
        Get
            Return m_LogoPath
        End Get
        Set(ByVal value As String)
            m_LogoPath = value
        End Set
    End Property

    Private m_LanguageFile As String
    Public Property LanguageFile() As String
        Get
            Return m_LanguageFile
        End Get
        Set(ByVal value As String)
            m_LanguageFile = value
        End Set
    End Property

    Private m_HasPasswordErase As Boolean
    Public Property HasPasswordErase() As Boolean
        Get
            Return m_HasPasswordErase
        End Get
        Set(ByVal value As Boolean)
            m_HasPasswordErase = value
        End Set
    End Property

    Private m_PasswordErase As String
    Public Property PasswordErase() As String
        Get
            Return m_PasswordErase
        End Get
        Set(ByVal value As String)
            m_PasswordErase = value
        End Set
    End Property

    Private m_HasPassword As Boolean
    Public Property HasPassword() As Boolean
        Get
            Return m_HasPassword
        End Get
        Set(ByVal value As Boolean)
            m_HasPassword = value
        End Set
    End Property

    Private m_Password As String
    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(ByVal value As String)
            m_Password = value
        End Set
    End Property

    Private m_Header As String
    Public Property PrintHeader() As String
        Get
            Return m_Header
        End Get
        Set(ByVal value As String)
            m_Header = value
        End Set
    End Property

    Private m_Tva As Single
    Public Property Tva() As Single
        Get
            Return m_Tva
        End Get
        Set(ByVal value As Single)
            m_Tva = value
        End Set
    End Property

    Private m_Footer As String
    Public Property PrintFooter() As String
        Get
            Return m_Footer
        End Get
        Set(ByVal value As String)
            m_Footer = value
        End Set
    End Property

#End Region
End Class
