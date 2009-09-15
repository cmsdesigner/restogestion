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
Imports System.IO

Public Class PrintFile
    Inherits Print

    Public Sub New(ByVal FilePath As String)
        FileLoad(FilePath)
    End Sub

    Public Sub FileLoad(ByVal FilePath As String)
        Try
            Dim item As New Print

            Dim reader As StreamReader = New StreamReader(FilePath, System.Text.Encoding.Unicode)
            Dim serialize As XmlSerializer = New XmlSerializer(GetType(Print))
            item = CType(serialize.Deserialize(reader), Print)

            MyBase.Height = item.Height
            MyBase.Width = item.Width
            MyBase.Header = item.Header
            MyBase.Body = item.Body
            MyBase.Footer = item.Footer

            reader.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub WriteFile(ByVal FilePath As String)
        Try
            Dim item As New Print

            item.Height = MyBase.Height
            item.Width = MyBase.Width
            item.Header = MyBase.Header
            item.Body = MyBase.Body
            item.Footer = MyBase.Footer

            Dim writer As StreamWriter = New StreamWriter(FilePath, False, System.Text.Encoding.Unicode)
            Dim serialize As XmlSerializer = New XmlSerializer(GetType(Print))
            serialize.Serialize(writer, item)

            writer.Flush()
            writer.Close()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub CloseFile()
        Try
            label = Nothing
        Catch ex As Exception
            Throw
        End Try

    End Sub
#Region "Constantes"
    '''''''''''''''''''''
    '' CONSTANTES
    '''''''''''''''''''''
    Public Const PANEL As String = "Panel"
    Public Const LOGO As String = "Logo"
    Public Const HEADERTEXT As String = "Text"
    Public Const [DATE] As String = "Date"
    Public Const TABLE As String = "Table"
    Public Const [SET] As String = "Set"
    Public Const QUANTITYTITLE As String = "QuantityTitle"
    Public Const DESIGNATIONTITLE As String = "DesignationTitle"
    Public Const TOTALTITLE As String = "TotalTitle"
    Public Const QUANTITY As String = "Quantity"
    Public Const DESIGNATION As String = "Designation"
    Public Const TOTAL As String = "Total"
    Public Const SUBAMOUNTTEXT As String = "SubAmountText"
    Public Const SUBAMOUNT As String = "SubAmount"
    Public Const DISCOUNTTEXT As String = "DiscountText"
    Public Const DISCOUNT As String = "Discount"
    Public Const AMOUNTTEXT As String = "AmountText"
    Public Const AMOUNT As String = "Amount"
    Public Const TVATEXT As String = "VatText"
    Public Const TVA As String = "Vat"
    Public Const FOOTERTEXT As String = "Text"
#End Region
End Class
