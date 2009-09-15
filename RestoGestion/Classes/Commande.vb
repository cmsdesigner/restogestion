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
Public Class Commande

    Private m_TableId As Integer
    Public Property TableId() As Integer
        Get
            Return m_TableId
        End Get
        Set(ByVal value As Integer)
            m_TableId = value
        End Set
    End Property

    Private m_PlatCode As String
    Public Property PlatCode() As String
        Get
            Return m_PlatCode
        End Get
        Set(ByVal value As String)
            m_PlatCode = value
        End Set
    End Property

    Private m_Quantite As Integer
    Public Property Quantite() As Integer
        Get
            Return m_Quantite
        End Get
        Set(ByVal value As Integer)
            m_Quantite = value
        End Set
    End Property

End Class
