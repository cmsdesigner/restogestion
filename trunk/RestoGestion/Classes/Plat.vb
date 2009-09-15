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
Public Class Plat

    Private m_Code As String
    Public Property Code() As String
        Get
            Return m_Code
        End Get
        Set(ByVal value As String)
            m_Code = value
        End Set
    End Property

    Private m_Designation As String
    Public Property Designation() As String
        Get
            Return m_Designation
        End Get
        Set(ByVal value As String)
            m_Designation = value
        End Set
    End Property

    Private m_Prix As Single
    Public Property Prix() As Single
        Get
            Return m_Prix
        End Get
        Set(ByVal value As Single)
            m_Prix = value
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

End Class
