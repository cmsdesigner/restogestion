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

Imports System.IO
Imports System.Collections.ObjectModel

Public Class frmPrint

    Dim memoryImage As Bitmap
    Dim bill As PrintFile
    Dim f As New FontConverter
    Dim dMnt As Single

    Public Sub New()

        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Designation = New Collection(Of String)
        Quantity = New Collection(Of Integer)
        Total = New Collection(Of Single)
        Tva = New Collection(Of Single)
    End Sub

    Private Sub frmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bill = New PrintFile(Consts.PRINTFILEPATH)

            Me.Width = CInt(bill.Width)
            Me.Height = CInt(bill.Height)

            InitHeader()
            InitBody()
            InitFooter()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InitHeader()
        fraHeader.Top = CInt(bill.Header(PrintFile.PANEL).Top)
        fraHeader.Left = CInt(bill.Header(PrintFile.PANEL).Left)
        fraHeader.Width = CInt(bill.Header(PrintFile.PANEL).Width)
        fraHeader.Height = CInt(bill.Header(PrintFile.PANEL).Height)
        fraHeader.Visible = CBool(bill.Header(PrintFile.PANEL).Visible)

        pctLogo.Top = CInt(bill.Header(PrintFile.LOGO).Top)
        pctLogo.Left = CInt(bill.Header(PrintFile.LOGO).Left)
        pctLogo.Height = CInt(bill.Header(PrintFile.LOGO).Height)
        pctLogo.Width = CInt(bill.Header(PrintFile.LOGO).Width)
        pctLogo.Visible = CBool(bill.Header(PrintFile.LOGO).Visible)
        If config.LogoPath <> "" Then
            If File.Exists(config.LogoPath) Then
                pctLogo.Image = Drawing.Image.FromFile(config.LogoPath)
            End If
        End If

        lblHeader.Top = CInt(bill.Header(PrintFile.HEADERTEXT).Top)
        lblHeader.Left = CInt(bill.Header(PrintFile.HEADERTEXT).Left)
        lblHeader.Height = CInt(bill.Header(PrintFile.HEADERTEXT).Height)
        lblHeader.Width = CInt(bill.Header(PrintFile.HEADERTEXT).Width)
        lblHeader.Visible = CBool(bill.Header(PrintFile.HEADERTEXT).Visible)
        lblHeader.Text = config.PrintHeader
        lblHeader.ForeColor = Color.FromArgb(bill.Header(PrintFile.HEADERTEXT).Color)
        lblHeader.Font = CType(f.ConvertFromString(bill.Header(PrintFile.HEADERTEXT).Font), Font)

        lblDate.Top = CInt(bill.Header(PrintFile.DATE).Top)
        lblDate.Left = CInt(bill.Header(PrintFile.DATE).Left)
        lblDate.Width = CInt(bill.Header(PrintFile.DATE).Width)
        lblDate.Height = CInt(bill.Header(PrintFile.DATE).Height)
        lblDate.Visible = CBool(bill.Header(PrintFile.DATE).Visible)
        lblDate.Text = Me.Date.ToString(bill.Header(PrintFile.DATE).Format)
        lblDate.ForeColor = Color.FromArgb(bill.Header(PrintFile.DATE).Color)
        lblDate.Font = CType(f.ConvertFromString(bill.Header(PrintFile.DATE).Font), Font)

        lblTable.Top = CInt(bill.Header(PrintFile.TABLE).Top)
        lblTable.Left = CInt(bill.Header(PrintFile.TABLE).Left)
        lblTable.Width = CInt(bill.Header(PrintFile.TABLE).Width)
        lblTable.Height = CInt(bill.Header(PrintFile.TABLE).Height)
        lblTable.Visible = CBool(bill.Header(PrintFile.TABLE).Visible)
        lblTable.Text = TableName
        lblTable.ForeColor = Color.FromArgb(bill.Header(PrintFile.TABLE).Color)
        lblTable.Font = CType(f.ConvertFromString(bill.Header(PrintFile.TABLE).Font), Font)

        lblSet.Top = CInt(bill.Header(PrintFile.SET).Top)
        lblSet.Left = CInt(bill.Header(PrintFile.SET).Left)
        lblSet.Width = CInt(bill.Header(PrintFile.SET).Width)
        lblSet.Height = CInt(bill.Header(PrintFile.SET).Height)
        lblSet.Visible = CBool(bill.Header(PrintFile.SET).Visible)
        lblSet.Text = NbSet.ToString + " " + label(LanguageFile.PRINT_LABELS).Label(LanguageFile.SET).Value
        lblSet.ForeColor = Color.FromArgb(bill.Header(PrintFile.SET).Color)
        lblSet.Font = CType(f.ConvertFromString(bill.Header(PrintFile.SET).Font), Font)

    End Sub

    Private Sub InitBody()
        Dim i As Integer
        Dim lblTemp As Label

        fraBody.Top = CInt(bill.Body(PrintFile.PANEL).Top)
        fraBody.Left = CInt(bill.Body(PrintFile.PANEL).Left)
        fraBody.Width = CInt(bill.Body(PrintFile.PANEL).Width)
        fraBody.Height = CInt(bill.Body(PrintFile.PANEL).Height)
        fraBody.Visible = CBool(bill.Body(PrintFile.PANEL).Visible)

        lblQuantityTitle.Top = CInt(bill.Body(PrintFile.QUANTITYTITLE).Top)
        lblQuantityTitle.Left = CInt(bill.Body(PrintFile.QUANTITYTITLE).Left)
        lblQuantityTitle.Width = CInt(bill.Body(PrintFile.QUANTITYTITLE).Width)
        lblQuantityTitle.Height = CInt(bill.Body(PrintFile.QUANTITYTITLE).Height)
        lblQuantityTitle.Visible = CBool(bill.Body(PrintFile.QUANTITYTITLE).Visible)
        lblQuantityTitle.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.QUANTITY).Value
        lblQuantityTitle.ForeColor = Color.FromArgb(bill.Body(PrintFile.QUANTITYTITLE).Color)
        lblQuantityTitle.Font = CType(f.ConvertFromString(bill.Body(PrintFile.QUANTITYTITLE).Font), Font)

        lblDesignationTitle.Top = CInt(bill.Body(PrintFile.DESIGNATIONTITLE).Top)
        lblDesignationTitle.Left = CInt(bill.Body(PrintFile.DESIGNATIONTITLE).Left)
        lblDesignationTitle.Width = CInt(bill.Body(PrintFile.DESIGNATIONTITLE).Width)
        lblDesignationTitle.Height = CInt(bill.Body(PrintFile.DESIGNATIONTITLE).Height)
        lblDesignationTitle.Visible = CBool(bill.Body(PrintFile.DESIGNATIONTITLE).Visible)
        lblDesignationTitle.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.MEAL_FORM).Value
        lblDesignationTitle.ForeColor = Color.FromArgb(bill.Body(PrintFile.DESIGNATIONTITLE).Color)
        lblDesignationTitle.Font = CType(f.ConvertFromString(bill.Body(PrintFile.DESIGNATIONTITLE).Font), Font)

        lblTotalTitle.Top = CInt(bill.Body(PrintFile.TOTALTITLE).Top)
        lblTotalTitle.Left = CInt(bill.Body(PrintFile.TOTALTITLE).Left)
        lblTotalTitle.Width = CInt(bill.Body(PrintFile.TOTALTITLE).Width)
        lblTotalTitle.Height = CInt(bill.Body(PrintFile.TOTALTITLE).Height)
        lblTotalTitle.Visible = CBool(bill.Body(PrintFile.TOTALTITLE).Visible)
        lblTotalTitle.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.TOTAL).Value
        lblTotalTitle.ForeColor = Color.FromArgb(bill.Body(PrintFile.TOTALTITLE).Color)
        lblTotalTitle.Font = CType(f.ConvertFromString(bill.Body(PrintFile.TOTALTITLE).Font), Font)

        For i = 0 To Quantity.Count - 1
            lblTemp = New Label
            lblTemp.Top = CInt(bill.Body(PrintFile.QUANTITY).Top) + (i * CInt(bill.Body(PrintFile.QUANTITY).Height))
            lblTemp.Left = CInt(bill.Body(PrintFile.QUANTITY).Left)
            lblTemp.Height = CInt(bill.Body(PrintFile.QUANTITY).Height)
            lblTemp.Width = CInt(bill.Body(PrintFile.QUANTITY).Width)
            lblTemp.Visible = CBool(bill.Body(PrintFile.QUANTITY).Visible)
            lblTemp.ForeColor = Color.FromArgb(bill.Body(PrintFile.QUANTITY).Color)
            lblTemp.Font = CType(f.ConvertFromString(bill.Body(PrintFile.QUANTITY).Font), Font)
            lblTemp.Name = "Quantity" + i.ToString
            lblTemp.Text = Quantity(i).ToString
            fraBody.Controls.Add(lblTemp)
            lblTemp = Nothing

            lblTemp = New Label
            lblTemp.Top = CInt(bill.Body(PrintFile.DESIGNATION).Top) + (i * CInt(bill.Body(PrintFile.DESIGNATION).Height))
            lblTemp.Left = CInt(bill.Body(PrintFile.DESIGNATION).Left)
            lblTemp.Width = CInt(bill.Body(PrintFile.DESIGNATION).Width)
            lblTemp.Height = CInt(bill.Body(PrintFile.DESIGNATION).Height)
            lblTemp.Visible = CBool(bill.Body(PrintFile.DESIGNATION).Visible)
            lblTemp.ForeColor = Color.FromArgb(bill.Body(PrintFile.DESIGNATION).Color)
            lblTemp.Font = CType(f.ConvertFromString(bill.Body(PrintFile.DESIGNATION).Font), Font)
            lblTemp.Name = "Designation" + i.ToString
            lblTemp.Text = Designation(i)
            fraBody.Controls.Add(lblTemp)
            lblTemp = Nothing

            lblTemp = New Label
            lblTemp.Top = CInt(bill.Body(PrintFile.TOTAL).Top) + (i * CInt(bill.Body(PrintFile.TOTAL).Height))
            lblTemp.Left = CInt(bill.Body(PrintFile.TOTAL).Left)
            lblTemp.Width = CInt(bill.Body(PrintFile.TOTAL).Width)
            lblTemp.Height = CInt(bill.Body(PrintFile.TOTAL).Height)
            lblTemp.Visible = CBool(bill.Body(PrintFile.TOTAL).Visible)
            lblTemp.ForeColor = Color.FromArgb(bill.Body(PrintFile.TOTAL).Color)
            lblTemp.Font = CType(f.ConvertFromString(bill.Body(PrintFile.TOTAL).Font), Font)
            lblTemp.Name = "Total" + i.ToString
            lblTemp.Text = Total(i).ToString
            dMnt = dMnt + Total(i)
            fraBody.Controls.Add(lblTemp)
            lblTemp = Nothing

        Next
    End Sub

    Private Sub InitFooter()
        Dim mntTva, mntTvaTot As Single
        Dim hTva As Hashtable
        Dim it As IEnumerator
        Dim keys(0) As Single

        hTva = New Hashtable
        For i As Integer = 0 To Tva.Count - 1
            mntTva = 0
            If Not hTva(Tva(i)) Is Nothing Then
                mntTva = CSng(hTva(Tva(i)))
                hTva.Remove(Tva(i))
            End If
            mntTva = mntTva + (Total(i) - (Total(i) / (1 + (Tva(i) / 100))))
            hTva.Add(Tva(i), mntTva)
        Next

        lblVatText.Text = ""
        lblVat.Text = ""
        mntTvaTot = 0
        Array.Resize(keys, hTva.Count)
        hTva.Keys.CopyTo(keys, 0)
        Array.Sort(keys)
        it = keys.GetEnumerator()
        While it.MoveNext
            lblVatText.Text = lblVatText.Text + label(LanguageFile.PRINT_LABELS).Label(LanguageFile.TVA).Value + " (" + it.Current.ToString + "%)" + Environment.NewLine
            lblVat.Text = lblVat.Text + Math.Round(CSng(hTva(it.Current)), 2).ToString + Environment.NewLine
            mntTvaTot = mntTvaTot + CSng(hTva(it.Current))
        End While

        fraFooter.Top = CInt(bill.Footer(PrintFile.PANEL).Top)
        fraFooter.Left = CInt(bill.Footer(PrintFile.PANEL).Left)
        fraFooter.Width = CInt(bill.Footer(PrintFile.PANEL).Width)
        fraFooter.Height = CInt(bill.Footer(PrintFile.PANEL).Height)
        fraFooter.Visible = CBool(bill.Footer(PrintFile.PANEL).Visible)

        lblSubAmountText.Top = CInt(bill.Footer(PrintFile.SUBAMOUNTTEXT).Top)
        lblSubAmountText.Left = CInt(bill.Footer(PrintFile.SUBAMOUNTTEXT).Left)
        lblSubAmountText.Width = CInt(bill.Footer(PrintFile.SUBAMOUNTTEXT).Width)
        lblSubAmountText.Height = CInt(bill.Footer(PrintFile.SUBAMOUNTTEXT).Height)
        lblSubAmountText.Visible = CBool(bill.Footer(PrintFile.SUBAMOUNTTEXT).Visible)
        lblSubAmountText.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.SUBAMOUNT).Value
        lblSubAmountText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.SUBAMOUNTTEXT).Color)
        lblSubAmountText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.SUBAMOUNTTEXT).Font), Font)

        lblSubAmount.Top = CInt(bill.Footer(PrintFile.SUBAMOUNT).Top)
        lblSubAmount.Left = CInt(bill.Footer(PrintFile.SUBAMOUNT).Left)
        lblSubAmount.Width = CInt(bill.Footer(PrintFile.SUBAMOUNT).Width)
        lblSubAmount.Height = CInt(bill.Footer(PrintFile.SUBAMOUNT).Height)
        lblSubAmount.Visible = CBool(bill.Footer(PrintFile.SUBAMOUNT).Visible)
        lblSubAmount.Text = Math.Round(dMnt - mntTvaTot, 2).ToString
        lblSubAmount.ForeColor = Color.FromArgb(bill.Footer(PrintFile.SUBAMOUNT).Color)
        lblSubAmount.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.SUBAMOUNT).Font), Font)


        lblVatText.Top = CInt(bill.Footer(PrintFile.TVATEXT).Top)
        lblVatText.Left = CInt(bill.Footer(PrintFile.TVATEXT).Left)
        lblVatText.Width = CInt(bill.Footer(PrintFile.TVATEXT).Width)
        lblVatText.Height = CInt(bill.Footer(PrintFile.TVATEXT).Height)
        lblVatText.Visible = CBool(bill.Footer(PrintFile.TVATEXT).Visible)
        lblVatText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.TVATEXT).Color)
        lblVatText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.TVATEXT).Font), Font)

        lblVat.Top = CInt(bill.Footer(PrintFile.TVA).Top)
        lblVat.Left = CInt(bill.Footer(PrintFile.TVA).Left)
        lblVat.Width = CInt(bill.Footer(PrintFile.TVA).Width)
        lblVat.Height = CInt(bill.Footer(PrintFile.TVA).Height)
        lblVat.Visible = CBool(bill.Footer(PrintFile.TVA).Visible)
        lblVat.ForeColor = Color.FromArgb(bill.Footer(PrintFile.TVA).Color)
        lblVat.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.TVA).Font), Font)



        lblDiscountText.Top = CInt(bill.Footer(PrintFile.DISCOUNTTEXT).Top)
        lblDiscountText.Left = CInt(bill.Footer(PrintFile.DISCOUNTTEXT).Left)
        lblDiscountText.Width = CInt(bill.Footer(PrintFile.DISCOUNTTEXT).Width)
        lblDiscountText.Height = CInt(bill.Footer(PrintFile.DISCOUNTTEXT).Height)
        lblDiscountText.Visible = CBool(bill.Footer(PrintFile.DISCOUNTTEXT).Visible)
        lblDiscountText.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.DISCOUNT).Value + " (" + Discount.ToString + "%)"
        lblDiscountText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.DISCOUNTTEXT).Color)
        lblDiscountText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.DISCOUNTTEXT).Font), Font)

        lblDiscount.Top = CInt(bill.Footer(PrintFile.DISCOUNT).Top)
        lblDiscount.Left = CInt(bill.Footer(PrintFile.DISCOUNT).Left)
        lblDiscount.Width = CInt(bill.Footer(PrintFile.DISCOUNT).Width)
        lblDiscount.Height = CInt(bill.Footer(PrintFile.DISCOUNT).Height)
        lblDiscount.Visible = CBool(bill.Footer(PrintFile.DISCOUNT).Visible)
        lblDiscount.Text = Math.Round(dMnt * Discount / 100, 2).ToString
        lblDiscount.ForeColor = Color.FromArgb(bill.Footer(PrintFile.DISCOUNT).Color)
        lblDiscount.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.DISCOUNT).Font), Font)

        lblAmountText.Top = CInt(bill.Footer(PrintFile.AMOUNTTEXT).Top)
        lblAmountText.Left = CInt(bill.Footer(PrintFile.AMOUNTTEXT).Left)
        lblAmountText.Width = CInt(bill.Footer(PrintFile.AMOUNTTEXT).Width)
        lblAmountText.Height = CInt(bill.Footer(PrintFile.AMOUNTTEXT).Height)
        lblAmountText.Visible = CBool(bill.Footer(PrintFile.AMOUNTTEXT).Visible)
        lblAmountText.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.AMOUNT).Value
        lblAmountText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.AMOUNTTEXT).Color)
        lblAmountText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.AMOUNTTEXT).Font), Font)

        lblAmount.Top = CInt(bill.Footer(PrintFile.AMOUNT).Top)
        lblAmount.Left = CInt(bill.Footer(PrintFile.AMOUNT).Left)
        lblAmount.Width = CInt(bill.Footer(PrintFile.AMOUNT).Width)
        lblAmount.Height = CInt(bill.Footer(PrintFile.AMOUNT).Height)
        lblAmount.Visible = CBool(bill.Footer(PrintFile.AMOUNT).Visible)
        lblAmount.Text = Math.Round(dMnt + CSng(lblDiscount.Text), 2).ToString
        lblAmount.ForeColor = Color.FromArgb(bill.Footer(PrintFile.AMOUNT).Color)
        lblAmount.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.AMOUNT).Font), Font)

        lblFooter.Top = CInt(bill.Footer(PrintFile.FOOTERTEXT).Top)
        lblFooter.Left = CInt(bill.Footer(PrintFile.FOOTERTEXT).Left)
        lblFooter.Width = CInt(bill.Footer(PrintFile.FOOTERTEXT).Width)
        lblFooter.Height = CInt(bill.Footer(PrintFile.FOOTERTEXT).Height)
        lblFooter.Visible = CBool(bill.Footer(PrintFile.FOOTERTEXT).Visible)
        lblFooter.Text = config.PrintFooter
        lblFooter.ForeColor = Color.FromArgb(bill.Footer(PrintFile.FOOTERTEXT).Color)
        lblFooter.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.FOOTERTEXT).Font), Font)

    End Sub

    Private Sub prtDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prtDoc.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub

    Private Sub CaptureScreen()
        Dim mygraphics As Graphics = Me.CreateGraphics()
        Dim s As Size = Me.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Me.DrawToBitmap(memoryImage, Me.ClientRectangle)
    End Sub

    Private Sub frmPrint_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim oResult As DialogResult
        CaptureScreen()
        Me.Hide()
        prtSetup.Document = prtDoc
        oResult = prtSetup.ShowDialog()
        If oResult = Windows.Forms.DialogResult.OK Then
            prtDoc.Print()
        End If
        Me.Close()
    End Sub

    Private m_Date As Date
    Public Property [Date]() As Date
        Get
            Return m_Date
        End Get
        Set(ByVal value As Date)
            m_Date = value
        End Set
    End Property

    Private m_Designation As Collection(Of String)
    Public Property Designation() As Collection(Of String)
        Get
            Return m_Designation
        End Get
        Set(ByVal value As Collection(Of String))
            m_Designation = value
        End Set
    End Property

    Private m_Quantity As Collection(Of Integer)
    Public Property Quantity() As Collection(Of Integer)
        Get
            Return m_Quantity
        End Get
        Set(ByVal value As Collection(Of Integer))
            m_Quantity = value
        End Set
    End Property

    Private m_Total As Collection(Of Single)
    Public Property Total() As Collection(Of Single)
        Get
            Return m_Total
        End Get
        Set(ByVal value As Collection(Of Single))
            m_Total = value
        End Set
    End Property

    Private m_Discount As Single
    Public Property Discount() As Single
        Get
            Return m_Discount
        End Get
        Set(ByVal value As Single)
            m_Discount = value
        End Set
    End Property

    Private m_Amount As Single
    Public Property Amount() As Single
        Get
            Return m_Amount
        End Get
        Set(ByVal value As Single)
            m_Amount = value
        End Set
    End Property

    Private m_Tva As Collection(Of Single)
    Public Property Tva() As Collection(Of Single)
        Get
            Return m_Tva
        End Get
        Set(ByVal value As Collection(Of Single))
            m_Tva = value
        End Set
    End Property

    Private m_Set As String
    Public Property NbSet() As String
        Get
            Return m_Set
        End Get
        Set(ByVal value As String)
            m_Set = value
        End Set
    End Property

    Private m_TableName As String
    Public Property TableName() As String
        Get
            Return m_TableName
        End Get
        Set(ByVal value As String)
            m_TableName = value
        End Set
    End Property

End Class