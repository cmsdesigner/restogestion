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
Imports System.Drawing
Imports Microsoft.VisualBasic

Public Class frmOption
    Private bill As PrintFile
    Dim f As New FontConverter

    Private Sub frmOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sFiles() As String
        Dim dt As New Date()

        bill = New PrintFile(PRINTFILEPATH)

        'recupération des libellés suivant la langue
        Me.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.NAME).Value
        'Libellés du premier onglet
        lblPassword.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.PASSWORD_FORM).Value
        fraPassword.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.PASSWORD_FORM).Value
        chkPassword.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.USEPASSWORD).Value
        lblLanguage.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LANGUAGE).Value
        lblVat.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TVA).Value
        cmdApply.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.APPLY_ACTION).Value
        cmdCancel.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CANCEL_ACTION).Value
        cmdBrowse.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.BROWSE).Value
        tabOptGeneral.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABOPTGENERAL).Value
        tabOptPrint.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABOPTPRINT).Value
        lblPasswordErase.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.PASSWORDERASE).Value
        fraPasswordErase.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.PASSWORDERASE).Value
        chkPasswordErase.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.USEPASSWORDERASE).Value

        'Libellés du deuxième onglet 
        lblPrintWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblPrintHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        fraPrint.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.PAGE).Value
        ''Libellés de l'entête
        tabHeader.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABHEADER).Value
        lblHeaderPanelLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblHeaderPanelTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblHeaderPanelWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblHeaderPanelHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkHeaderPanel.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        fraHeaderPanel.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABHEADER).Value

        lblHeaderLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblHeaderTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblHeaderWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblHeaderHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkHeader.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdHeaderFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        lblHeader.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEADER).Value
        fraHeader.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TEXTHEADER).Value

        lblLogoLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblLogoTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblLogoWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblLogoHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkLogo.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        lblPicture.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LOGO).Value
        fraLogo.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LOGO).Value

        lblDateLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblDateTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblDateWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblDateHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkDate.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdDateFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraDate.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.DATE).Value

        lblTableLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblTableTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblTableWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblTableHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkTable.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdTableFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraTable.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABLE).Value

        lblSetLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblSetTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblSetWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblSetHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkSet.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdSetFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraSet.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.SET).Value

        ''Libellés du corps
        tabBody.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABBODY).Value
        lblBodyPanelLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblBodyPanelTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblBodyPanelWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblBodyPanelHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkBodyPanel.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        fraBodyPanel.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABBODY).Value

        lblQuantityTitleLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblQuantityTitleTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblQuantityTitleWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblQuantityTitleHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkQuantityTitle.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdQuantityTitleFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraQuantityTitle.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.QUANTITYTITLE).Value

        lblQuantityLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblQuantityTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblQuantityWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblQuantityHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkQuantity.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdQuantityFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraQuantity.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.QUANTITY).Value

        lblDesignationTitleLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblDesignationTitleTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblDesignationTitleWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblDesignationTitleHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkDesignationTitle.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdDesignationTitleFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraDesignationTitle.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.DESIGNATIONTITLE).Value

        lblDesignationLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblDesignationTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblDesignationWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblDesignationHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkDesignation.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdDesignationFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraDesignation.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.DESIGNATION).Value

        lblTotalTitleLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblTotalTitleTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblTotalTitleWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblTotalTitleHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkTotalTitle.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdTotalTitleFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraTotalTitle.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOTALTITLE).Value

        lblTotalLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblTotalTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblTotalWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblTotalHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkTotal.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdTotalFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraTotal.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOTAL).Value

        ''Libellés du pied de page
        tabFooter.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABFOOTER).Value
        lblFooterPanelLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblFooterPanelTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblFooterPanelWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblFooterPanelHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkFooterPanel.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        fraFooterPanel.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TABFOOTER).Value

        lblSubAmountTextLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblSubAmountTextTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblSubAmountTextWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblSubAmountTextHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkSubAmountText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdSubAmountTextFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraSubAmountText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.SUBAMOUNTTEXT).Value

        lblSubAmountLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblSubAmountTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblSubAmountWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblSubAmountHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkSubAmount.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdSubAmountFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraSubAmount.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.SUBAMOUNT).Value

        lblDiscountTextLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblDiscountTextTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblDiscountTextWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblDiscountTextHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkDiscountText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdDiscountTextFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraDiscountText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.DISCOUNTTEXT).Value

        lblDiscountLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblDiscountTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblDiscountWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblDiscountHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkDiscount.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdDiscountFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraDiscount.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.DISCOUNT).Value

        lblAmountTextLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblAmountTextTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblAmountTextWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblAmountTextHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkAmountText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdAmountTextFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraAmountText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.AMOUNTTEXT).Value

        lblAmountLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblAmountTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblAmountWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblAmountHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkAmount.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdAmountFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraAmount.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.AMOUNT).Value

        lblTvaTextLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblTvaTextTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblTvaTextWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblTvaTextHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkTvaText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdTvaTextFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraTvaText.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VATTEXT).Value

        lblTvaLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblTvaTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblTvaWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblTvaHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkTva.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdTvaFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraTva.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VAT).Value

        lblFooterLeft.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.LEFT).Value
        lblFooterTop.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TOP).Value
        lblFooterWidth.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.WIDTH).Value
        lblFooterHeight.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.HEIGHT).Value
        chkFooter.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.VISIBLE).Value
        cmdFooterFont.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.FONT).Value
        fraFooter.Text = label(LanguageFile.OPTION_FORM).Label(LanguageFile.TEXTFOOTER).Value

        AddHandler cboLanguage.KeyPress, AddressOf NextTab
        AddHandler txtPassword.KeyPress, AddressOf NextTab
        AddHandler txtVat.KeyPress, AddressOf NextTab
        hlpOption.HelpNamespace = HELPPATH + "options.htm"

        Try
            'Récupération de la liste des langues a partir des fichiers présents dans ".\Langues\"
            sFiles = Directory.GetFiles(LANGUAGEFILEPATH, "*.lng", SearchOption.TopDirectoryOnly)
            For Each s As String In sFiles
                cboLanguage.Items.Add(s.Replace(LANGUAGEFILEPATH, ""))
            Next
            'on remplit les champs principaux
            txtVat.Text = config.Tva.ToString
            txtPassword.Text = config.Password
            txtPasswordErase.Text = config.PasswordErase
            'on vérifie si une image est définie
            If config.LogoPath <> "" Then
                'et si elle existe
                If File.Exists(config.LogoPath) Then
                    'puis on l'applique
                    pctLogo.ImageLocation = config.LogoPath
                End If
            End If
            chkPassword.Checked = config.HasPassword
            txtPassword.Enabled = config.HasPassword
            chkPasswordErase.Checked = config.HasPasswordErase
            txtPasswordErase.Enabled = config.HasPasswordErase
            cboLanguage.Text = config.LanguageFile

            cboDateFormat.Items.Add("dd/MM/yyyy")
            cboDateFormat.Items.Add("dd/MM/yyyy HH:mm")
            cboDateFormat.Items.Add("dd/MM/yy")
            cboDateFormat.Items.Add("dd/MM/yy HH:mm")
            cboDateFormat.Items.Add("ddd dd MMM yyyy")
            cboDateFormat.Items.Add("ddd dd MMM yyyy HH:mm")
            cboDateFormat.Items.Add("dddd dd MMM yyyy")
            cboDateFormat.Items.Add("dddd dd MMM yyyy HH:mm")
            cboDateFormat.Items.Add("ddd dd MMMM yyyy")
            cboDateFormat.Items.Add("ddd dd MMMM yyyy HH:mm")
            cboDateFormat.Items.Add("dddd dd MMMM yyyy")
            cboDateFormat.Items.Add("dddd dd MMMM yyyy HH:mm")

            'On remplit les champs des options d'impressions
            txtPrintWidth.Text = bill.Width
            txtPrintHeight.Text = bill.Height
            ''Entête
            txtHeaderPanelTop.Text = bill.Header(PrintFile.PANEL).Top
            txtHeaderPanelLeft.Text = bill.Header(PrintFile.PANEL).Left
            txtHeaderPanelWidth.Text = bill.Header(PrintFile.PANEL).Width
            txtHeaderPanelHeight.Text = bill.Header(PrintFile.PANEL).Height
            chkHeaderPanel.Checked = CBool(bill.Header(PrintFile.PANEL).Visible)

            txtHeaderTop.Text = bill.Header(PrintFile.HEADERTEXT).Top
            txtHeaderLeft.Text = bill.Header(PrintFile.HEADERTEXT).Left
            txtHeaderWidth.Text = bill.Header(PrintFile.HEADERTEXT).Width
            txtHeaderHeight.Text = bill.Header(PrintFile.HEADERTEXT).Height
            chkHeader.Checked = CBool(bill.Header(PrintFile.HEADERTEXT).Visible)
            txtHeader.Text = config.PrintHeader
            txtHeader.ForeColor = Color.FromArgb(bill.Header(PrintFile.HEADERTEXT).Color)
            txtHeader.BackColor = txtHeader.BackColor
            txtHeader.Font = CType(f.ConvertFromString(bill.Header(PrintFile.HEADERTEXT).Font), Font)

            txtLogoTop.Text = bill.Header(PrintFile.LOGO).Top
            txtLogoLeft.Text = bill.Header(PrintFile.LOGO).Left
            txtLogoWidth.Text = bill.Header(PrintFile.LOGO).Width
            txtLogoHeight.Text = bill.Header(PrintFile.LOGO).Height
            chkLogo.Checked = CBool(bill.Header(PrintFile.LOGO).Visible)

            txtDateTop.Text = bill.Header(PrintFile.DATE).Top
            txtDateLeft.Text = bill.Header(PrintFile.DATE).Left
            txtDateWidth.Text = bill.Header(PrintFile.DATE).Width
            txtDateHeight.Text = bill.Header(PrintFile.DATE).Height
            chkDate.Checked = CBool(bill.Header(PrintFile.DATE).Visible)
            txtDate.Text = Date.Now.ToString(bill.Header(PrintFile.DATE).Format)
            txtDate.ForeColor = Color.FromArgb(bill.Header(PrintFile.DATE).Color)
            txtDate.BackColor = txtDate.BackColor
            txtDate.Font = CType(f.ConvertFromString(bill.Header(PrintFile.DATE).Font), Font)
            cboDateFormat.Text = bill.Header(PrintFile.DATE).Format

            txtTableTop.Text = bill.Header(PrintFile.TABLE).Top
            txtTableLeft.Text = bill.Header(PrintFile.TABLE).Left
            txtTableWidth.Text = bill.Header(PrintFile.TABLE).Width
            txtTableHeight.Text = bill.Header(PrintFile.TABLE).Height
            chkTable.Checked = CBool(bill.Header(PrintFile.TABLE).Visible)
            txtTable.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.TABLE_DEFAULT_NAME).Value
            txtTable.ForeColor = Color.FromArgb(bill.Header(PrintFile.TABLE).Color)
            txtTable.BackColor = txtTable.BackColor
            txtTable.Font = CType(f.ConvertFromString(bill.Header(PrintFile.TABLE).Font), Font)

            txtSetTop.Text = bill.Header(PrintFile.SET).Top
            txtSetLeft.Text = bill.Header(PrintFile.SET).Left
            txtSetWidth.Text = bill.Header(PrintFile.SET).Width
            txtSetHeight.Text = bill.Header(PrintFile.SET).Height
            chkSet.Checked = CBool(bill.Header(PrintFile.SET).Visible)
            txtSet.Text = "1 " + label(LanguageFile.PRINT_LABELS).Label(LanguageFile.SET).Value
            txtSet.ForeColor = Color.FromArgb(bill.Header(PrintFile.SET).Color)
            txtSet.BackColor = txtSet.BackColor
            txtSet.Font = CType(f.ConvertFromString(bill.Header(PrintFile.SET).Font), Font)

            ''Corps
            txtBodyPanelTop.Text = bill.Body(PrintFile.PANEL).Top
            txtBodyPanelLeft.Text = bill.Body(PrintFile.PANEL).Left
            txtBodyPanelWidth.Text = bill.Body(PrintFile.PANEL).Width
            txtBodyPanelHeight.Text = bill.Body(PrintFile.PANEL).Height
            chkBodyPanel.Checked = CBool(bill.Body(PrintFile.PANEL).Visible)

            txtQuantityTitleTop.Text = bill.Body(PrintFile.QUANTITYTITLE).Top
            txtQuantityTitleLeft.Text = bill.Body(PrintFile.QUANTITYTITLE).Left
            txtQuantityTitleWidth.Text = bill.Body(PrintFile.QUANTITYTITLE).Width
            txtQuantityTitleHeight.Text = bill.Body(PrintFile.QUANTITYTITLE).Height
            chkQuantityTitle.Checked = CBool(bill.Body(PrintFile.QUANTITYTITLE).Visible)
            txtQuantityTitle.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.QUANTITY).Value
            txtQuantityTitle.ForeColor = Color.FromArgb(bill.Body(PrintFile.QUANTITYTITLE).Color)
            txtQuantityTitle.BackColor = txtQuantityTitle.BackColor
            txtQuantityTitle.Font = CType(f.ConvertFromString(bill.Body(PrintFile.QUANTITYTITLE).Font), Font)

            txtQuantityTop.Text = bill.Body(PrintFile.QUANTITY).Top
            txtQuantityLeft.Text = bill.Body(PrintFile.QUANTITY).Left
            txtQuantityWidth.Text = bill.Body(PrintFile.QUANTITY).Width
            txtQuantityHeight.Text = bill.Body(PrintFile.QUANTITY).Height
            chkQuantity.Checked = CBool(bill.Body(PrintFile.QUANTITY).Visible)
            txtQuantity.Text = "1"
            txtQuantity.ForeColor = Color.FromArgb(bill.Body(PrintFile.QUANTITY).Color)
            txtQuantity.BackColor = txtQuantity.BackColor
            txtQuantity.Font = CType(f.ConvertFromString(bill.Body(PrintFile.QUANTITY).Font), Font)

            txtDesignationTitleTop.Text = bill.Body(PrintFile.DESIGNATIONTITLE).Top
            txtDesignationTitleLeft.Text = bill.Body(PrintFile.DESIGNATIONTITLE).Left
            txtDesignationTitleWidth.Text = bill.Body(PrintFile.DESIGNATIONTITLE).Width
            txtDesignationTitleHeight.Text = bill.Body(PrintFile.DESIGNATIONTITLE).Height
            chkDesignationTitle.Checked = CBool(bill.Body(PrintFile.DESIGNATIONTITLE).Visible)
            txtDesignationTitle.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.MEAL_FORM).Value
            txtDesignationTitle.ForeColor = Color.FromArgb(bill.Body(PrintFile.DESIGNATIONTITLE).Color)
            txtDesignationTitle.BackColor = txtDesignationTitle.BackColor
            txtDesignationTitle.Font = CType(f.ConvertFromString(bill.Body(PrintFile.DESIGNATIONTITLE).Font), Font)

            txtDesignationTop.Text = bill.Body(PrintFile.DESIGNATION).Top
            txtDesignationLeft.Text = bill.Body(PrintFile.DESIGNATION).Left
            txtDesignationWidth.Text = bill.Body(PrintFile.DESIGNATION).Width
            txtDesignationHeight.Text = bill.Body(PrintFile.DESIGNATION).Height
            chkDesignation.Checked = CBool(bill.Body(PrintFile.DESIGNATION).Visible)
            txtDesignation.Text = "Designation"
            txtDesignation.ForeColor = Color.FromArgb(bill.Body(PrintFile.DESIGNATION).Color)
            txtDesignation.BackColor = txtDesignation.BackColor
            txtDesignation.Font = CType(f.ConvertFromString(bill.Body(PrintFile.DESIGNATION).Font), Font)

            txtTotalTitleTop.Text = bill.Body(PrintFile.TOTALTITLE).Top
            txtTotalTitleLeft.Text = bill.Body(PrintFile.TOTALTITLE).Left
            txtTotalTitleWidth.Text = bill.Body(PrintFile.TOTALTITLE).Width
            txtTotalTitleHeight.Text = bill.Body(PrintFile.TOTALTITLE).Height
            chkTotalTitle.Checked = CBool(bill.Body(PrintFile.TOTALTITLE).Visible)
            txtTotalTitle.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.TOTAL).Value
            txtTotalTitle.ForeColor = Color.FromArgb(bill.Body(PrintFile.TOTALTITLE).Color)
            txtTotalTitle.BackColor = txtTotalTitle.BackColor
            txtTotalTitle.Font = CType(f.ConvertFromString(bill.Body(PrintFile.TOTALTITLE).Font), Font)

            txtTotalTop.Text = bill.Body(PrintFile.TOTAL).Top
            txtTotalLeft.Text = bill.Body(PrintFile.TOTAL).Left
            txtTotalWidth.Text = bill.Body(PrintFile.TOTAL).Width
            txtTotalHeight.Text = bill.Body(PrintFile.TOTAL).Height
            chkTotal.Checked = CBool(bill.Body(PrintFile.TOTAL).Visible)
            txtTotal.Text = "0.0"
            txtTotal.ForeColor = Color.FromArgb(bill.Body(PrintFile.TOTAL).Color)
            txtTotal.BackColor = txtTotal.BackColor
            txtTotal.Font = CType(f.ConvertFromString(bill.Body(PrintFile.TOTAL).Font), Font)

            ''Pied de page
            txtFooterPanelTop.Text = bill.Footer(PrintFile.PANEL).Top
            txtFooterPanelLeft.Text = bill.Footer(PrintFile.PANEL).Left
            txtFooterPanelWidth.Text = bill.Footer(PrintFile.PANEL).Width
            txtFooterPanelHeight.Text = bill.Footer(PrintFile.PANEL).Height
            chkFooterPanel.Checked = CBool(bill.Footer(PrintFile.PANEL).Visible)

            txtSubAmountTextTop.Text = bill.Footer(PrintFile.SUBAMOUNTTEXT).Top
            txtSubAmountTextLeft.Text = bill.Footer(PrintFile.SUBAMOUNTTEXT).Left
            txtSubAmountTextWidth.Text = bill.Footer(PrintFile.SUBAMOUNTTEXT).Width
            txtSubAmountTextHeight.Text = bill.Footer(PrintFile.SUBAMOUNTTEXT).Height
            chkSubAmountText.Checked = CBool(bill.Footer(PrintFile.SUBAMOUNTTEXT).Visible)
            txtSubAmountText.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.SUBAMOUNT).Value
            txtSubAmountText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.SUBAMOUNTTEXT).Color)
            txtSubAmountText.BackColor = txtSubAmountText.BackColor
            txtSubAmountText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.SUBAMOUNTTEXT).Font), Font)

            txtSubAmountTop.Text = bill.Footer(PrintFile.SUBAMOUNT).Top
            txtSubAmountLeft.Text = bill.Footer(PrintFile.SUBAMOUNT).Left
            txtSubAmountWidth.Text = bill.Footer(PrintFile.SUBAMOUNT).Width
            txtSubAmountHeight.Text = bill.Footer(PrintFile.SUBAMOUNT).Height
            chkSubAmount.Checked = CBool(bill.Footer(PrintFile.SUBAMOUNT).Visible)
            txtSubAmount.Text = "0.0"
            txtSubAmount.ForeColor = Color.FromArgb(bill.Footer(PrintFile.SUBAMOUNT).Color)
            txtSubAmount.BackColor = txtSubAmount.BackColor
            txtSubAmount.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.SUBAMOUNT).Font), Font)

            txtDiscountTextTop.Text = bill.Footer(PrintFile.DISCOUNTTEXT).Top
            txtDiscountTextLeft.Text = bill.Footer(PrintFile.DISCOUNTTEXT).Left
            txtDiscountTextWidth.Text = bill.Footer(PrintFile.DISCOUNTTEXT).Width
            txtDiscountTextHeight.Text = bill.Footer(PrintFile.DISCOUNTTEXT).Height
            chkDiscountText.Checked = CBool(bill.Footer(PrintFile.DISCOUNTTEXT).Visible)
            txtDiscountText.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.DISCOUNT).Value
            txtDiscountText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.DISCOUNTTEXT).Color)
            txtDiscountText.BackColor = txtDiscountText.BackColor
            txtDiscountText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.DISCOUNTTEXT).Font), Font)

            txtDiscountTop.Text = bill.Footer(PrintFile.DISCOUNT).Top
            txtDiscountLeft.Text = bill.Footer(PrintFile.DISCOUNT).Left
            txtDiscountWidth.Text = bill.Footer(PrintFile.DISCOUNT).Width
            txtDiscountHeight.Text = bill.Footer(PrintFile.DISCOUNT).Height
            chkDiscount.Checked = CBool(bill.Footer(PrintFile.DISCOUNT).Visible)
            txtDiscount.Text = "0.0"
            txtDiscount.ForeColor = Color.FromArgb(bill.Footer(PrintFile.DISCOUNT).Color)
            txtDiscount.BackColor = txtDiscount.BackColor
            txtDiscount.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.DISCOUNT).Font), Font)

            txtAmountTextTop.Text = bill.Footer(PrintFile.AMOUNTTEXT).Top
            txtAmountTextLeft.Text = bill.Footer(PrintFile.AMOUNTTEXT).Left
            txtAmountTextWidth.Text = bill.Footer(PrintFile.AMOUNTTEXT).Width
            txtAmountTextHeight.Text = bill.Footer(PrintFile.AMOUNTTEXT).Height
            chkAmountText.Checked = CBool(bill.Footer(PrintFile.AMOUNTTEXT).Visible)
            txtAmountText.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.AMOUNT).Value
            txtAmountText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.AMOUNTTEXT).Color)
            txtAmountText.BackColor = txtAmountText.BackColor
            txtAmountText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.AMOUNTTEXT).Font), Font)

            txtAmountTop.Text = bill.Footer(PrintFile.AMOUNT).Top
            txtAmountLeft.Text = bill.Footer(PrintFile.AMOUNT).Left
            txtAmountWidth.Text = bill.Footer(PrintFile.AMOUNT).Width
            txtAmountHeight.Text = bill.Footer(PrintFile.AMOUNT).Height
            chkAmount.Checked = CBool(bill.Footer(PrintFile.AMOUNT).Visible)
            txtAmount.Text = "0.0"
            txtAmount.ForeColor = Color.FromArgb(bill.Footer(PrintFile.AMOUNT).Color)
            txtAmount.BackColor = txtAmount.BackColor
            txtAmount.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.AMOUNT).Font), Font)

            txtTvaTextTop.Text = bill.Footer(PrintFile.TVATEXT).Top
            txtTvaTextLeft.Text = bill.Footer(PrintFile.TVATEXT).Left
            txtTvaTextWidth.Text = bill.Footer(PrintFile.TVATEXT).Width
            txtTvaTextHeight.Text = bill.Footer(PrintFile.TVATEXT).Height
            chkTvaText.Checked = CBool(bill.Footer(PrintFile.TVATEXT).Visible)
            txtTvaText.Text = label(LanguageFile.PRINT_LABELS).Label(LanguageFile.TVA).Value
            txtTvaText.ForeColor = Color.FromArgb(bill.Footer(PrintFile.TVATEXT).Color)
            txtTvaText.BackColor = txtTvaText.BackColor
            txtTvaText.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.TVATEXT).Font), Font)

            txtTvaTop.Text = bill.Footer(PrintFile.TVA).Top
            txtTvaLeft.Text = bill.Footer(PrintFile.TVA).Left
            txtTvaWidth.Text = bill.Footer(PrintFile.TVA).Width
            txtTvaHeight.Text = bill.Footer(PrintFile.TVA).Height
            chkTva.Checked = CBool(bill.Footer(PrintFile.TVA).Visible)
            txtTva.Text = "0.0"
            txtTva.ForeColor = Color.FromArgb(bill.Footer(PrintFile.TVA).Color)
            txtTva.BackColor = txtTva.BackColor
            txtTva.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.TVA).Font), Font)

            txtFooterTop.Text = bill.Footer(PrintFile.FOOTERTEXT).Top
            txtFooterLeft.Text = bill.Footer(PrintFile.FOOTERTEXT).Left
            txtFooterWidth.Text = bill.Footer(PrintFile.FOOTERTEXT).Width
            txtFooterHeight.Text = bill.Footer(PrintFile.FOOTERTEXT).Height
            chkFooter.Checked = CBool(bill.Footer(PrintFile.FOOTERTEXT).Visible)
            txtFooter.Text = config.PrintFooter
            txtFooter.ForeColor = Color.FromArgb(bill.Footer(PrintFile.FOOTERTEXT).Color)
            txtFooter.BackColor = txtFooter.BackColor
            txtFooter.Font = CType(f.ConvertFromString(bill.Footer(PrintFile.FOOTERTEXT).Font), Font)

        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'on ferme la fenêtre (fait trop froid ..)
        Me.Close()
    End Sub

    Private Sub chkPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPassword.CheckedChanged
        'on active ou désactive le champs password
        txtPassword.Enabled = chkPassword.Checked
        txtPassword.Focus()
    End Sub

    Private Sub chkPasswordErase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPasswordErase.CheckedChanged
        'on active ou désactive le champs password
        txtPasswordErase.Enabled = chkPasswordErase.Checked
        txtPasswordErase.Focus()
    End Sub

    Private Sub txtVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVat.KeyPress
        'limitation des caractères au numérique et suppression
        If e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Enter)) Or e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Execute)) Then
            chkPassword.Focus()
        End If
        If Not e.KeyChar Like "[0123456789.,]" And Not e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Back)) Then e.KeyChar = Convert.ToChar(0)
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click

        Try
            'Préparation de la requete de mise a jour de la table
            If chkPassword.Checked And txtPassword.Text = "" Then
                'La case est cochée mais y a pas de password
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOPASSWORD).Value)
                txtPassword.Focus()
                Exit Sub
            End If
            If chkPasswordErase.Checked And txtPasswordErase.Text = "" Then
                'La case est cochée mais y a pas de password
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOPASSWORD).Value)
                txtPasswordErase.Focus()
                Exit Sub
            End If

            config.LanguageFile = cboLanguage.Text
            config.Tva = CSng(txtVat.Text.Replace(".", ","))
            config.HasPassword = chkPassword.Checked
            config.Password = txtPassword.Text
            config.HasPasswordErase = chkPasswordErase.Checked
            config.PasswordErase = txtPasswordErase.Text
            config.PrintHeader = txtHeader.Text
            config.LogoPath = pctLogo.ImageLocation + ""
            config.PrintFooter = txtFooter.Text
            config.SaveConfig()

            'On prépare le fichier d'impression pour sauvegarde
            bill.Width = txtPrintWidth.Text
            bill.Height = txtPrintHeight.Text
            ''Entête
            bill.Header(PrintFile.PANEL).Top = txtHeaderPanelTop.Text
            bill.Header(PrintFile.PANEL).Left = txtHeaderPanelLeft.Text
            bill.Header(PrintFile.PANEL).Width = txtHeaderPanelWidth.Text
            bill.Header(PrintFile.PANEL).Height = txtHeaderPanelHeight.Text
            bill.Header(PrintFile.PANEL).Visible = chkHeaderPanel.Checked.ToString

            bill.Header(PrintFile.HEADERTEXT).Top = txtHeaderTop.Text
            bill.Header(PrintFile.HEADERTEXT).Left = txtHeaderLeft.Text
            bill.Header(PrintFile.HEADERTEXT).Width = txtHeaderWidth.Text
            bill.Header(PrintFile.HEADERTEXT).Height = txtHeaderHeight.Text
            bill.Header(PrintFile.HEADERTEXT).Visible = chkHeader.Checked.ToString
            bill.Header(PrintFile.HEADERTEXT).Font = f.ConvertToString(txtHeader.Font)
            bill.Header(PrintFile.HEADERTEXT).Color = txtHeader.ForeColor.ToArgb

            bill.Header(PrintFile.LOGO).Top = txtLogoTop.Text
            bill.Header(PrintFile.LOGO).Left = txtLogoLeft.Text
            bill.Header(PrintFile.LOGO).Width = txtLogoWidth.Text
            bill.Header(PrintFile.LOGO).Height = txtLogoHeight.Text
            bill.Header(PrintFile.LOGO).Visible = chkLogo.Checked.ToString

            bill.Header(PrintFile.DATE).Top = txtDateTop.Text
            bill.Header(PrintFile.DATE).Left = txtDateLeft.Text
            bill.Header(PrintFile.DATE).Width = txtDateWidth.Text
            bill.Header(PrintFile.DATE).Height = txtDateHeight.Text
            bill.Header(PrintFile.DATE).Visible = chkDate.Checked.ToString
            bill.Header(PrintFile.DATE).Font = f.ConvertToString(txtDate.Font)
            bill.Header(PrintFile.DATE).Color = txtDate.ForeColor.ToArgb
            bill.Header(PrintFile.DATE).Format = cboDateFormat.Text

            bill.Header(PrintFile.TABLE).Top = txtTableTop.Text
            bill.Header(PrintFile.TABLE).Left = txtTableLeft.Text
            bill.Header(PrintFile.TABLE).Width = txtTableWidth.Text
            bill.Header(PrintFile.TABLE).Height = txtTableHeight.Text
            bill.Header(PrintFile.TABLE).Visible = chkTable.Checked.ToString
            bill.Header(PrintFile.TABLE).Font = f.ConvertToString(txtTable.Font)
            bill.Header(PrintFile.TABLE).Color = txtTable.ForeColor.ToArgb

            bill.Header(PrintFile.SET).Top = txtSetTop.Text
            bill.Header(PrintFile.SET).Left = txtSetLeft.Text
            bill.Header(PrintFile.SET).Width = txtSetWidth.Text
            bill.Header(PrintFile.SET).Height = txtSetHeight.Text
            bill.Header(PrintFile.SET).Visible = chkSet.Checked.ToString
            bill.Header(PrintFile.SET).Font = f.ConvertToString(txtSet.Font)
            bill.Header(PrintFile.SET).Color = txtSet.ForeColor.ToArgb

            ''Corps
            bill.Body(PrintFile.PANEL).Top = txtBodyPanelTop.Text
            bill.Body(PrintFile.PANEL).Left = txtBodyPanelLeft.Text
            bill.Body(PrintFile.PANEL).Width = txtBodyPanelWidth.Text
            bill.Body(PrintFile.PANEL).Height = txtBodyPanelHeight.Text
            bill.Body(PrintFile.PANEL).Visible = chkBodyPanel.Checked.ToString

            bill.Body(PrintFile.QUANTITYTITLE).Top = txtQuantityTitleTop.Text
            bill.Body(PrintFile.QUANTITYTITLE).Left = txtQuantityTitleLeft.Text
            bill.Body(PrintFile.QUANTITYTITLE).Width = txtQuantityTitleWidth.Text
            bill.Body(PrintFile.QUANTITYTITLE).Height = txtQuantityTitleHeight.Text
            bill.Body(PrintFile.QUANTITYTITLE).Visible = chkQuantityTitle.Checked.ToString
            bill.Body(PrintFile.QUANTITYTITLE).Font = f.ConvertToString(txtQuantityTitle.Font)
            bill.Body(PrintFile.QUANTITYTITLE).Color = txtQuantityTitle.ForeColor.ToArgb

            bill.Body(PrintFile.QUANTITY).Top = txtQuantityTop.Text
            bill.Body(PrintFile.QUANTITY).Left = txtQuantityLeft.Text
            bill.Body(PrintFile.QUANTITY).Width = txtQuantityWidth.Text
            bill.Body(PrintFile.QUANTITY).Height = txtQuantityHeight.Text
            bill.Body(PrintFile.QUANTITY).Visible = chkQuantity.Checked.ToString
            bill.Body(PrintFile.QUANTITY).Font = f.ConvertToString(txtQuantity.Font)
            bill.Body(PrintFile.QUANTITY).Color = txtQuantity.ForeColor.ToArgb

            bill.Body(PrintFile.DESIGNATIONTITLE).Top = txtDesignationTitleTop.Text
            bill.Body(PrintFile.DESIGNATIONTITLE).Left = txtDesignationTitleLeft.Text
            bill.Body(PrintFile.DESIGNATIONTITLE).Width = txtDesignationTitleWidth.Text
            bill.Body(PrintFile.DESIGNATIONTITLE).Height = txtDesignationTitleHeight.Text
            bill.Body(PrintFile.DESIGNATIONTITLE).Visible = chkDesignationTitle.Checked.ToString
            bill.Body(PrintFile.DESIGNATIONTITLE).Font = f.ConvertToString(txtDesignationTitle.Font)
            bill.Body(PrintFile.DESIGNATIONTITLE).Color = txtDesignationTitle.ForeColor.ToArgb

            bill.Body(PrintFile.DESIGNATION).Top = txtDesignationTop.Text
            bill.Body(PrintFile.DESIGNATION).Left = txtDesignationLeft.Text
            bill.Body(PrintFile.DESIGNATION).Width = txtDesignationWidth.Text
            bill.Body(PrintFile.DESIGNATION).Height = txtDesignationHeight.Text
            bill.Body(PrintFile.DESIGNATION).Visible = chkDesignation.Checked.ToString
            bill.Body(PrintFile.DESIGNATION).Font = f.ConvertToString(txtDesignation.Font)
            bill.Body(PrintFile.DESIGNATION).Color = txtDesignation.ForeColor.ToArgb

            bill.Body(PrintFile.TOTALTITLE).Top = txtTotalTitleTop.Text
            bill.Body(PrintFile.TOTALTITLE).Left = txtTotalTitleLeft.Text
            bill.Body(PrintFile.TOTALTITLE).Width = txtTotalTitleWidth.Text
            bill.Body(PrintFile.TOTALTITLE).Height = txtTotalTitleHeight.Text
            bill.Body(PrintFile.TOTALTITLE).Visible = chkTotalTitle.Checked.ToString
            bill.Body(PrintFile.TOTALTITLE).Font = f.ConvertToString(txtTotalTitle.Font)
            bill.Body(PrintFile.TOTALTITLE).Color = txtTotalTitle.ForeColor.ToArgb

            bill.Body(PrintFile.TOTAL).Top = txtTotalTop.Text
            bill.Body(PrintFile.TOTAL).Left = txtTotalLeft.Text
            bill.Body(PrintFile.TOTAL).Width = txtTotalWidth.Text
            bill.Body(PrintFile.TOTAL).Height = txtTotalHeight.Text
            bill.Body(PrintFile.TOTAL).Visible = chkTotal.Checked.ToString
            bill.Body(PrintFile.TOTAL).Font = f.ConvertToString(txtTotal.Font)
            bill.Body(PrintFile.TOTAL).Color = txtTotal.ForeColor.ToArgb

            ''Pied de page
            bill.Footer(PrintFile.PANEL).Top = txtFooterPanelTop.Text
            bill.Footer(PrintFile.PANEL).Left = txtFooterPanelLeft.Text
            bill.Footer(PrintFile.PANEL).Width = txtFooterPanelWidth.Text
            bill.Footer(PrintFile.PANEL).Height = txtFooterPanelHeight.Text
            bill.Footer(PrintFile.PANEL).Visible = chkFooterPanel.Checked.ToString

            bill.Footer(PrintFile.SUBAMOUNTTEXT).Top = txtSubAmountTextTop.Text
            bill.Footer(PrintFile.SUBAMOUNTTEXT).Left = txtSubAmountTextLeft.Text
            bill.Footer(PrintFile.SUBAMOUNTTEXT).Width = txtSubAmountTextWidth.Text
            bill.Footer(PrintFile.SUBAMOUNTTEXT).Height = txtSubAmountTextHeight.Text
            bill.Footer(PrintFile.SUBAMOUNTTEXT).Visible = chkSubAmountText.Checked.ToString
            bill.Footer(PrintFile.SUBAMOUNTTEXT).Font = f.ConvertToString(txtSubAmountText.Font)
            bill.Footer(PrintFile.SUBAMOUNTTEXT).Color = txtSubAmountText.ForeColor.ToArgb

            bill.Footer(PrintFile.SUBAMOUNT).Top = txtSubAmountTop.Text
            bill.Footer(PrintFile.SUBAMOUNT).Left = txtSubAmountLeft.Text
            bill.Footer(PrintFile.SUBAMOUNT).Width = txtSubAmountWidth.Text
            bill.Footer(PrintFile.SUBAMOUNT).Height = txtSubAmountHeight.Text
            bill.Footer(PrintFile.SUBAMOUNT).Visible = chkSubAmount.Checked.ToString
            bill.Footer(PrintFile.SUBAMOUNT).Font = f.ConvertToString(txtSubAmount.Font)
            bill.Footer(PrintFile.SUBAMOUNT).Color = txtSubAmount.ForeColor.ToArgb

            bill.Footer(PrintFile.DISCOUNTTEXT).Top = txtDiscountTextTop.Text
            bill.Footer(PrintFile.DISCOUNTTEXT).Left = txtDiscountTextLeft.Text
            bill.Footer(PrintFile.DISCOUNTTEXT).Width = txtDiscountTextWidth.Text
            bill.Footer(PrintFile.DISCOUNTTEXT).Height = txtDiscountTextHeight.Text
            bill.Footer(PrintFile.DISCOUNTTEXT).Visible = chkDiscountText.Checked.ToString
            bill.Footer(PrintFile.DISCOUNTTEXT).Font = f.ConvertToString(txtDiscountText.Font)
            bill.Footer(PrintFile.DISCOUNTTEXT).Color = txtDiscountText.ForeColor.ToArgb

            bill.Footer(PrintFile.DISCOUNT).Top = txtDiscountTop.Text
            bill.Footer(PrintFile.DISCOUNT).Left = txtDiscountLeft.Text
            bill.Footer(PrintFile.DISCOUNT).Width = txtDiscountWidth.Text
            bill.Footer(PrintFile.DISCOUNT).Height = txtDiscountHeight.Text
            bill.Footer(PrintFile.DISCOUNT).Visible = chkDiscount.Checked.ToString
            bill.Footer(PrintFile.DISCOUNT).Font = f.ConvertToString(txtDiscount.Font)
            bill.Footer(PrintFile.DISCOUNT).Color = txtDiscount.ForeColor.ToArgb

            bill.Footer(PrintFile.AMOUNTTEXT).Top = txtAmountTextTop.Text
            bill.Footer(PrintFile.AMOUNTTEXT).Left = txtAmountTextLeft.Text
            bill.Footer(PrintFile.AMOUNTTEXT).Width = txtAmountTextWidth.Text
            bill.Footer(PrintFile.AMOUNTTEXT).Height = txtAmountTextHeight.Text
            bill.Footer(PrintFile.AMOUNTTEXT).Visible = chkAmountText.Checked.ToString
            bill.Footer(PrintFile.AMOUNTTEXT).Font = f.ConvertToString(txtAmountText.Font)
            bill.Footer(PrintFile.AMOUNTTEXT).Color = txtAmountText.ForeColor.ToArgb

            bill.Footer(PrintFile.AMOUNT).Top = txtAmountTop.Text
            bill.Footer(PrintFile.AMOUNT).Left = txtAmountLeft.Text
            bill.Footer(PrintFile.AMOUNT).Width = txtAmountWidth.Text
            bill.Footer(PrintFile.AMOUNT).Height = txtAmountHeight.Text
            bill.Footer(PrintFile.AMOUNT).Visible = chkAmount.Checked.ToString
            bill.Footer(PrintFile.AMOUNT).Font = f.ConvertToString(txtAmount.Font)
            bill.Footer(PrintFile.AMOUNT).Color = txtAmount.ForeColor.ToArgb

            bill.Footer(PrintFile.TVATEXT).Top = txtTvaTextTop.Text
            bill.Footer(PrintFile.TVATEXT).Left = txtTvaTextLeft.Text
            bill.Footer(PrintFile.TVATEXT).Width = txtTvaTextWidth.Text
            bill.Footer(PrintFile.TVATEXT).Height = txtTvaTextHeight.Text
            bill.Footer(PrintFile.TVATEXT).Visible = chkTvaText.Checked.ToString
            bill.Footer(PrintFile.TVATEXT).Font = f.ConvertToString(txtTvaText.Font)
            bill.Footer(PrintFile.TVATEXT).Color = txtTvaText.ForeColor.ToArgb

            bill.Footer(PrintFile.TVA).Top = txtTvaTop.Text
            bill.Footer(PrintFile.TVA).Left = txtTvaLeft.Text
            bill.Footer(PrintFile.TVA).Width = txtTvaWidth.Text
            bill.Footer(PrintFile.TVA).Height = txtTvaHeight.Text
            bill.Footer(PrintFile.TVA).Visible = chkTva.Checked.ToString
            bill.Footer(PrintFile.TVA).Font = f.ConvertToString(txtTva.Font)
            bill.Footer(PrintFile.TVA).Color = txtTva.ForeColor.ToArgb

            bill.Footer(PrintFile.FOOTERTEXT).Top = txtFooterTop.Text
            bill.Footer(PrintFile.FOOTERTEXT).Left = txtFooterLeft.Text
            bill.Footer(PrintFile.FOOTERTEXT).Width = txtFooterWidth.Text
            bill.Footer(PrintFile.FOOTERTEXT).Height = txtFooterHeight.Text
            bill.Footer(PrintFile.FOOTERTEXT).Visible = chkFooter.Checked.ToString
            bill.Footer(PrintFile.FOOTERTEXT).Font = f.ConvertToString(txtFooter.Font)
            bill.Footer(PrintFile.FOOTERTEXT).Color = txtFooter.ForeColor.ToArgb

            bill.WriteFile(PRINTFILEPATH)
            MessageBox.Show(label(LanguageFile.OPTION_FORM).Label(LanguageFile.CAUTION).Value(), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            TraceError(ex)
        End Try
        Me.Close()
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        'boite de dialogue "Ouvrir" pour l'image
        dlgPicture.Title = label(LanguageFile.OPTION_FORM).Label(LanguageFile.PICTURE).Value
        dlgPicture.Filter = "Images|*.jpg;*.jpeg;*.bmp;*.gif;*.png" 'format supportés
        dlgPicture.ShowDialog(Me)
        pctLogo.ImageLocation = dlgPicture.FileName + ""
    End Sub

    Private Sub frmOption_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Try
            config.Load()
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHeader.CheckedChanged, chkDate.CheckedChanged, chkLogo.CheckedChanged, chkSet.CheckedChanged, chkTable.CheckedChanged, _
    chkQuantityTitle.CheckedChanged, chkQuantity.CheckedChanged, chkDesignationTitle.CheckedChanged, chkDesignation.CheckedChanged, chkTotalTitle.CheckedChanged, chkTotal.CheckedChanged

        Dim ClickedCheckbox As CheckBox
        Dim it As IEnumerator

        ClickedCheckbox = CType(sender, CheckBox)
        it = ClickedCheckbox.Parent.Controls.GetEnumerator
        While it.MoveNext
            CType(it.Current, Control).Enabled = ClickedCheckbox.Checked
        End While
        ClickedCheckbox.Enabled = True
        ClickedCheckbox.Parent.Focus()
    End Sub

    Private Sub CheckPanel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHeaderPanel.CheckedChanged, chkBodyPanel.CheckedChanged, chkFooterPanel.CheckedChanged
        Dim ClickedCheckbox As CheckBox
        Dim it As IEnumerator

        ClickedCheckbox = CType(sender, CheckBox)
        it = ClickedCheckbox.Parent.Parent.Controls.GetEnumerator
        While it.MoveNext
            CType(it.Current, Control).Enabled = ClickedCheckbox.Checked
        End While
        ClickedCheckbox.Parent.Enabled = True
        Check_CheckedChanged(sender, e)
    End Sub

    Private Sub cmdFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHeaderFont.Click, cmdDateFont.Click, cmdTableFont.Click, cmdSetFont.Click, _
    cmdQuantityTitleFont.Click, cmdQuantityFont.Click, cmdDesignationTitleFont.Click, cmdDesignationFont.Click, cmdTotalTitleFont.Click, cmdTotalFont.Click, _
    cmdSubAmountTextFont.Click, cmdSubAmountFont.Click, cmdDiscountTextFont.Click, cmdDiscountFont.Click, cmdAmountTextFont.Click, cmdAmountFont.Click, cmdTvaTextFont.Click, cmdTvaFont.Click, cmdFooterFont.Click
        Dim SelectedButton As Button
        Dim SelectedTextbox As TextBox

        SelectedButton = CType(sender, Button)
        SelectedTextbox = CType(SelectedButton.Tag, TextBox)

        frmFont.Font = SelectedTextbox.Font
        frmFont.Color = SelectedTextbox.ForeColor
        frmFont.ShowEffects = True
        frmFont.ShowColor = True
        frmFont.ShowDialog()
        SelectedTextbox.Font = frmFont.Font
        SelectedTextbox.ForeColor = frmFont.Color
        SelectedTextbox.BackColor = SelectedTextbox.BackColor
    End Sub

    Private Sub cboDateFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDateFormat.SelectedIndexChanged
        txtDate.Text = Date.Now.ToString(cboDateFormat.Text)
    End Sub

    Private Sub cboDateFormat_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDateFormat.Validated
        Try
            txtDate.Text = Date.Now.ToString(cboDateFormat.Text)
        Catch ex As Exception
            txtDate.Text = Date.Now.ToString
        End Try
    End Sub
End Class