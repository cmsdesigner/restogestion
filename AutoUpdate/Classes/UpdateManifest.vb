Option Strict On
Option Explicit On
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

Imports System.Xml.Serialization
Imports System.Collections.ObjectModel

'''<remarks/>
<XmlTypeAttribute("update"), _
 XmlRootAttribute()> _
Partial Public Class UpdateManifest
    Inherits KeyedCollection(Of String, Names)

    Protected Overrides Function GetKeyForItem(ByVal item As Names) As String
        Return item.file
    End Function
End Class

'''<remarks/>
<XmlTypeAttribute("name")> _
Partial Public Class Names

    Private m_file As String
    Private m_filename As String
    Private m_directory As String
    Private m_version As String
    Private m_date As Date
    Private m_hash As String

    'Public Sub New()
    '    textField = New KeyedTexts
    'End Sub
    '''<remarks/>
    <XmlAttributeAttribute("file")> _
    Public Property File() As String
        Get
            Return Me.m_file
        End Get
        Set(ByVal value As String)
            Me.m_file = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute("filename")> _
    Public Property Filename() As String
        Get
            Return Me.m_filename
        End Get
        Set(ByVal value As String)
            Me.m_filename = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute("directory")> _
    Public Property Directory() As String
        Get
            Return Me.m_directory
        End Get
        Set(ByVal value As String)
            Me.m_directory = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute("fileversion")> _
    Public Property Version() As String
        Get
            Return Me.m_version
        End Get
        Set(ByVal value As String)
            Me.m_version = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute("filelastmodified")> _
    Public Property [Date]() As Date
        Get
            Return Me.m_date
        End Get
        Set(ByVal value As Date)
            Me.m_date = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute("filehash")> _
    Public Property Hash() As String
        Get
            Return Me.m_hash
        End Get
        Set(ByVal value As String)
            Me.m_hash = value
        End Set
    End Property

    Public ReadOnly Property Extension() As String
        Get
            Dim tab As String()
            tab = (Me.m_file.Split(New [Char]() {"."c}))
            Return tab(tab.GetUpperBound(0))
        End Get
    End Property
End Class


