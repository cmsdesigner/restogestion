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
Imports System.Math

Public Class frmPassword

    Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'on récupères les libellés dans le fichier XML
        Me.Text = label(LanguageFile.PASSWORD_FORM).Label(LanguageFile.NAME).Value
        lblPassword.Text = label(LanguageFile.PASSWORD_FORM).Label(LanguageFile.TEXT).Value
        If PasswordErase Then
            lblTitle.Hide()
        Else
            lblTitle.Text = label(LanguageFile.PASSWORD_FORM).Label(LanguageFile.APP_TITLE).Value
        End If
        hlpPassword.HelpNamespace = HELPPATH + "index.htm"
        passwordOk = False
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Dim password As String
        Dim rnd As New Random

        'initialisation du random
        If PasswordErase Then
            password = config.PasswordErase
        Else
            password = config.Password
        End If
        'si on valide en appuyant sur entrer
        If e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Enter)) Or e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Execute)) Then
            'le password est ok
            If txtPassword.Text = password Then
                passwordOk = True
                'on ferme la fenêtre pour ouvrir la suite
                Me.Close()
            Else
                'on efface le champ
                txtPassword.Text = ""
                'on affiche un texte de couleur aléatoire
                lblError.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))
                lblError.Text = label(LanguageFile.PASSWORD_FORM).Label(LanguageFile.ERRORS_LABELS).Value
            End If
        End If
    End Sub

    Private m_PasswordOk As Boolean
    Public Property passwordOk() As Boolean
        Get
            Return m_PasswordOk
        End Get
        Set(ByVal value As Boolean)
            m_PasswordOk = value
        End Set
    End Property

    Private m_PasswordErase As Boolean
    Public Property PasswordErase() As Boolean
        Get
            Return m_PasswordErase
        End Get
        Set(ByVal value As Boolean)
            m_PasswordErase = value
        End Set
    End Property

End Class