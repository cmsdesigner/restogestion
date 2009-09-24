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
Imports System.Xml.Serialization
Imports System.IO
Public Class LanguageFile
    Inherits Labels

    Public Sub New(ByVal FilePath As String)
        FileLoad(FilePath)
    End Sub

    Public Sub FileLoad(ByVal FilePath As String)
        Try
            Dim items As New Labels
            Dim it As IEnumerator(Of Types)

            MyBase.Clear()

            Dim reader As StreamReader = New StreamReader(FilePath, System.Text.Encoding.Unicode)
            Dim serialize As XmlSerializer = New XmlSerializer(GetType(Labels))
            items = CType(serialize.Deserialize(reader), Labels)
            it = items.GetEnumerator
            While it.MoveNext
                MyBase.Add(it.Current)
            End While

            reader.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub
#Region "Constantes"
    '''''''''''''''''''''
    '' CONSTANTES
    '''''''''''''''''''''
#Region "Types"
    Public Const COMMON_LABELS As String = "Common"
    Public Const TABLE_FORM As String = "Table"
    Public Const MODIFY_FORM As String = "Modify"
    Public Const MEAL_FORM As String = "Meal"
    Public Const SELL_FORM As String = "Sell"
    Public Const CUSTOMER_FORM As String = "Customer"
    Public Const PASSWORD_FORM As String = "Password"
    Public Const OPTION_FORM As String = "Option"
    Public Const HISTORY_FORM As String = "History"
    Public Const ABOUT_FORM As String = "About"
    Public Const PRINT_LABELS As String = "Print"
    Public Const UPDATE_LABELS As String = "Update"
    Public Const ERRORS_LABELS As String = "Error"
#End Region
#Region "Labels"
    Public Const NAME As String = "Name"

#Region "Common"
    Public Const APPLY_ACTION As String = "Apply"
    Public Const CANCEL_ACTION As String = "Cancel"
    Public Const DELETE_ACTION As String = "Delete"
    Public Const CLOSE_ACTION As String = "Close"
    Public Const ADD_ACTION As String = "Add"
    Public Const MODIFY_ACTION As String = "Modify"
#End Region
#Region "Table"
    Public Const MEAL_MENU As String = "Meal"
    Public Const CUSTOMER_MENU As String = "Customer"
    Public Const ADD_MENU As String = "Add"
    Public Const OPTION_MENU As String = "Option"
    Public Const MODIFY_MENU As String = "Modify"
    Public Const TABLE_DEFAULT_NAME As String = "Table"
    Public Const ABOUT_MENU As String = "About"
    Public Const HELP_MENU As String = "Help"
    Public Const EDIT_MENU As String = "Edit"
    Public Const HISTORY_MENU As String = "History"
    Public Const HELP_SUB_MENU As String = "HelpMenu"
    Public Const UPDATE_MENU As String = "UpdateMenu"
#End Region
#Region "Modify"
    Public Const ENABLE As String = "Enable"
    Public Const LEFT As String = "Left"
    Public Const TOP As String = "Top"
    Public Const WIDTH As String = "Width"
    Public Const HEIGHT As String = "Height"
    Public Const TEXT As String = "Text"
    Public Const MOVE As String = "Move"
    Public Const RESIZE As String = "Resize"
#End Region
#Region "Sell"
    Public Const ERASE_ACTION As String = "Erase"
    Public Const PRINT_ACTION As String = "Print"
    Public Const CODE As String = "Code"
    Public Const DESIGNATION As String = "Designation"
    Public Const QUANTITY As String = "Quantity"
    Public Const PRICE As String = "Price"
    Public Const [SET] As String = "Set"
    Public Const AMOUNT As String = "Amount"
    Public Const TOTAL As String = "Total"
    Public Const DISCOUNT As String = "Discount"
    Public Const ERASEQUESTION As String = "EraseQuestion"
    Public Const ERASETITLE As String = "EraseTitle"
#End Region
#Region "Meal"
    'Ces codes sont identiques aux précédents écrans
    'Public Const CODE As String = "Code"
    'Public Const DESIGNATION As String = "Designation"
    'Public Const PRICE As String = "Price"
    Public Const DELETEQUESTION As String = "DeleteQuestion"
    Public Const DELETETITLE As String = "DeleteTitle"
    Public Const MODIFYQUESTION As String = "ModifyQuestion"
    Public Const MODIFYTITLE As String = "ModifyTitle"
    'Public Const TVA As String = "Vat"
#End Region
#Region "Customer"
    Public Const LASTNAME As String = "LastName"
    Public Const FIRSTNAME As String = "FirstName"
    Public Const ADDRESS As String = "Address"
    Public Const ZIPCODE As String = "ZipCode"
    Public Const CITY As String = "City"
    Public Const PHONENUMBER As String = "PhoneNumber"
    Public Const COMMENT As String = "Comment"
    'Ces codes sont identiques aux écrans précédents
    'Public Const DELETEQUESTION As String = "DeleteQuestion"
    'Public Const DELETETITLE As String = "DeleteTitle"
    'Public Const MODIFYQUESTION As String = "ModifyQuestion"
    'Public Const MODIFYTITLE As String = "ModifyTitle"
#End Region
#Region "Password"
    Public Const APP_TITLE As String = "Title"
    Public Const PASSWORD As String = "Password"
    Public Const ERROR_TEXT As String = "Error"
#End Region
#Region "Option"
    Public Const USEPASSWORD As String = "UsePassword"
    'Public Const PASSWORD As String = "Password"
    Public Const LANGUAGE As String = "Language"
    Public Const TVA As String = "Vat"
    Public Const HEADER As String = "Header"
    Public Const CAUTION As String = "Caution"
    Public Const BROWSE As String = "Browse"
    Public Const PICTURE As String = "Picture"
    Public Const LOGO As String = "Logo"
    Public Const TABOPTGENERAL As String = "TabOptGeneral"
    Public Const TABOPTPRINT As String = "TabOptPrint"
    Public Const TABHEADER As String = "TabHeader"
    Public Const TABBODY As String = "TabBody"
    Public Const TABFOOTER As String = "TabFooter"
    Public Const USEPASSWORDERASE As String = "UsePasswordErase"
    Public Const PASSWORDERASE As String = "PasswordErase"
    'Public Const LEFT As String = "Left"
    'Public Const TOP As String = "Top"
    'Public Const WIDTH As String = "Width"
    'Public Const HEIGHT As String = "Height"
    Public Const VISIBLE As String = "Visible"
    Public Const FONT As String = "Font"
    'Public Const LOGO As String = "Logo"
    Public Const PAGE As String = "Page"
    Public Const TEXTHEADER As String = "TextHeader"
    Public Const [DATE] As String = "Date"
    Public Const TABLE As String = "Table"
    'Public Const [SET] As String = "Set"
    Public Const QUANTITYTITLE As String = "QuantityTitle"
    'Public Const QUANTITY As String = "Quantity"
    Public Const DESIGNATIONTITLE As String = "DesignationTitle"
    'Public Const DESIGNATION As String = "Designation"
    Public Const TOTALTITLE As String = "TotalTitle"
    'Public Const TOTAL As String = "Total"
    Public Const SUBAMOUNTTEXT As String = "SubAmountText"
    Public Const SUBAMOUNT As String = "SubAmount"
    Public Const DISCOUNTTEXT As String = "DiscountText"
    'Public Const DISCOUNT As String = "Discount"
    Public Const AMOUNTTEXT As String = "AmountText"
    'Public Const AMOUNT As String = "Amount"
    Public Const VATTEXT As String = "VatText"
    Public Const VAT As String = "Vat"
    Public Const TEXTFOOTER As String = "TextFooter"

#End Region
#Region "History"
    'Public Const [DATE] As String = "Date"
    'Public Const TOTAL As String = "Total"
    'Public Const TABLE As String = "Table"
    'Public Const HEADER As String = "Header"
    Public Const FILTER As String = "Filter"
    Public Const FROM_DATE As String = "FromDate"
    Public Const TO_DATE As String = "ToDate"
#End Region
#Region "Print"
    Public Const OK As String = "Ok"
    Public Const CREDITS As String = "Credits"
    'Public Const SET As String = "Set"
    Public Const THANKS As String = "Thanks"
    Public Const SERVICE As String = "Service"
    'Public Const AMOUNT As String = "Amount"
    'Public Const TOTAL As String = "Total"
    'Public Const DISCOUNT As String = "Discount"
    'Public Const VAT As String = "Vat"
    'Public Const MEAL As String = "Meal"
    'Public Const QUANTITY As String = "Quantity"
    'Public Const SUBAMOUNT As String = "SubAmount"
#End Region
#Region "Update"
    Public Const DOWNLOADING As String = "Downloading"
    Public Const DOWNLOADED As String = "Downloaded"
    Public Const NOUPDATE As String = "NoUpdate"
    Public Const ENDUPDATE As String = "EndUpdate"
    Public Const TITLE As String = "Title"
    Public Const BACKUP As String = "Backup"
    Public Const UPDATEQUESTION As String = "UpdateQuestion"
#End Region
#Region "Error"
    Public Const CODEINVALID As String = "CodeInvalid"
    Public Const NOMEALSELECT As String = "NoMealSelect"
    Public Const NOMEAL As String = "NoMeal"
    Public Const NOQUANTITY As String = "NoQuantity"
    Public Const ROWSELECT As String = "RowSelect"
    Public Const NOFIRSTNAME As String = "NoFirstName"
    Public Const NOLASTNAME As String = "NoLastName"
    Public Const NOPRICE As String = "NoPrice"
    Public Const NOCODE As String = "NoCode"
    Public Const CODEEXIST As String = "CodeExist"
    Public Const NOPASSWORD As String = "NoPassword"
    Public Const DISCOUNTINVALID As String = "DiscountInvalid"
    Public Const QUANTITYINVALID As String = "QuantityInvalid"
#End Region
#End Region
#End Region
End Class


