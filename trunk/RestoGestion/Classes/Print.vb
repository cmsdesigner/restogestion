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
Imports System.Drawing

'''<remarks/>
<XmlTypeAttribute(), _
 XmlRootAttribute()> _
Partial Public Class Print
    Private heightField As String

    Private widthField As String

    Private headerField As Elements

    Private bodyField As Elements

    Private footerField As Elements

    '''<remarks/>
    <XmlElementAttribute()> _
    Public Property Height() As String
        Get
            Return Me.heightField
        End Get
        Set(ByVal value As String)
            Me.heightField = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute()> _
    Public Property Width() As String
        Get
            Return Me.widthField
        End Get
        Set(ByVal value As String)
            Me.widthField = value
        End Set
    End Property

    '''<remarks/>
    <XmlArrayAttribute()> _
    Public Property Header() As Elements
        Get
            Return Me.headerField
        End Get
        Set(ByVal value As Elements)
            Me.headerField = value
        End Set
    End Property

    '''<remarks/>
    <XmlArrayAttribute()> _
    Public Property Body() As Elements
        Get
            Return Me.bodyField
        End Get
        Set(ByVal value As Elements)
            Me.bodyField = value
        End Set
    End Property

    '''<remarks/>
    <XmlArrayAttribute()> _
    Public Property Footer() As Elements
        Get
            Return Me.footerField
        End Get
        Set(ByVal value As Elements)
            Me.footerField = value
        End Set
    End Property
End Class

Public Class Elements
    Inherits KeyedCollection(Of String, Element)

    Protected Overrides Function GetKeyForItem(ByVal item As Element) As String
        Return item.name
    End Function

End Class

'''<remarks/>
<XmlTypeAttribute()> _
Partial Public Class Element

    Private topField As String

    Private leftField As String

    Private heightField As String

    Private widthField As String

    Private visibleField As String

    Private formatField As String

    Private nameField As String

    Private fontField As String

    Private colorField As Integer

    '''<remarks/>
    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Top() As String
        Get
            Return Me.topField
        End Get
        Set(ByVal value As String)
            Me.topField = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Left() As String
        Get
            Return Me.leftField
        End Get
        Set(ByVal value As String)
            Me.leftField = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Height() As String
        Get
            Return Me.heightField
        End Get
        Set(ByVal value As String)
            Me.heightField = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Width() As String
        Get
            Return Me.widthField
        End Get
        Set(ByVal value As String)
            Me.widthField = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Visible() As String
        Get
            Return Me.visibleField
        End Get
        Set(ByVal value As String)
            Me.visibleField = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Format() As String
        Get
            Return Me.formatField
        End Get
        Set(ByVal value As String)
            Me.formatField = value
        End Set
    End Property

    '''<remarks/>
    <XmlAttributeAttribute()> _
    Public Property name() As String
        Get
            Return Me.nameField
        End Get
        Set(ByVal value As String)
            Me.nameField = value
        End Set
    End Property

    '''<remarks/>
    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Font() As String
        Get
            Return fontField
        End Get
        Set(ByVal value As String)
            fontField = value
        End Set
    End Property

    <XmlElementAttribute(IsNullable:=False)> _
    Public Property Color() As Integer
        Get
            Return colorField
        End Get
        Set(ByVal value As Integer)
            colorField = value
        End Set
    End Property
End Class