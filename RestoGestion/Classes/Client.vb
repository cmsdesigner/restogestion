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
Public Class Client

    Private m_Id As Integer
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(ByVal value As Integer)
            m_Id = value
        End Set
    End Property

    Private m_Nom As String
    Public Property Nom() As String
        Get
            Return m_Nom
        End Get
        Set(ByVal value As String)
            m_Nom = value
        End Set
    End Property

    Private m_Prenom As String
    Public Property Prenom() As String
        Get
            Return m_Prenom
        End Get
        Set(ByVal value As String)
            m_Prenom = value
        End Set
    End Property

    Private m_Adresse As String
    Public Property Adresse() As String
        Get
            Return m_Adresse
        End Get
        Set(ByVal value As String)
            m_Adresse = value
        End Set
    End Property

    Private m_CodePostal As String
    Public Property CodePostal() As String
        Get
            Return m_CodePostal
        End Get
        Set(ByVal value As String)
            m_CodePostal = value
        End Set
    End Property

    Private m_Ville As String
    Public Property Ville() As String
        Get
            Return m_Ville
        End Get
        Set(ByVal value As String)
            m_Ville = value
        End Set
    End Property

    Private m_Telephone As String
    Public Property Telephone() As String
        Get
            Return m_Telephone
        End Get
        Set(ByVal value As String)
            m_Telephone = value
        End Set
    End Property

    Private m_Commentaire As String
    Public Property Commentaire() As String
        Get
            Return m_Commentaire
        End Get
        Set(ByVal value As String)
            m_Commentaire = value
        End Set
    End Property

End Class
