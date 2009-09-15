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
<XmlTypeAttribute("Labels"), _
 XmlRootAttribute()> _
Partial Public Class Labels
    Inherits KeyedCollection(Of String, Types)

    Protected Overrides Function GetKeyForItem(ByVal item As Types) As String
        Return item.key
    End Function
End Class

'''<remarks/>
<XmlTypeAttribute("Type")> _
Partial Public Class Types

    Private textField As KeyedTexts

    Private valueField As String
    Public Sub New()
        textField = New KeyedTexts
    End Sub

    '''<remarks/>
    <XmlElementAttribute("Label")> _
    Public Property Label() As KeyedTexts
        Get
            Return Me.textField
        End Get
        Set(ByVal value As KeyedTexts)
            Me.textField = value
        End Set
    End Property

    '''<remarks/>
    <XmlAttributeAttribute()> _
    Public Property key() As String
        Get
            Return Me.valueField
        End Get
        Set(ByVal value As String)
            Me.valueField = value
        End Set
    End Property

    'Protected Overrides Function GetKeyForItem(ByVal item As TextsTypeText) As String
    '    Return item.key
    'End Function
End Class

'''<remarks/>
<XmlTypeAttribute("Label")> _
Partial Public Class Texts

    Private keyField As String

    Private valueField As String

    '''<remarks/>
    <XmlAttributeAttribute()> _
    Public Property key() As String
        Get
            Return Me.keyField
        End Get
        Set(ByVal value As String)
            Me.keyField = value
        End Set
    End Property

    '''<remarks/>
    <XmlTextAttribute()> _
    Public Property Value() As String
        Get
            Return Me.valueField
        End Get
        Set(ByVal value As String)
            Me.valueField = value
        End Set
    End Property
End Class

Public Class KeyedTexts
    Inherits KeyedCollection(Of String, Texts)

    Protected Overrides Function GetKeyForItem(ByVal item As Texts) As String
        Return item.key
    End Function
End Class

