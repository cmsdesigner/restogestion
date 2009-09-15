<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOption
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.hlpOption = New System.Windows.Forms.HelpProvider
        Me.lblLanguage = New System.Windows.Forms.Label
        Me.lblVat = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtVat = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.cboLanguage = New System.Windows.Forms.ComboBox
        Me.chkPassword = New System.Windows.Forms.CheckBox
        Me.fraPassword = New System.Windows.Forms.GroupBox
        Me.cmdApply = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.dlgPicture = New System.Windows.Forms.OpenFileDialog
        Me.tabOption = New System.Windows.Forms.TabControl
        Me.tabOptGeneral = New System.Windows.Forms.TabPage
        Me.fraPasswordErase = New System.Windows.Forms.GroupBox
        Me.txtPasswordErase = New System.Windows.Forms.TextBox
        Me.lblPasswordErase = New System.Windows.Forms.Label
        Me.chkPasswordErase = New System.Windows.Forms.CheckBox
        Me.tabOptPrint = New System.Windows.Forms.TabPage
        Me.tabPrint = New System.Windows.Forms.TabControl
        Me.tabHeader = New System.Windows.Forms.TabPage
        Me.fraLogo = New System.Windows.Forms.GroupBox
        Me.lblPicture = New System.Windows.Forms.Label
        Me.txtLogoLeft = New System.Windows.Forms.TextBox
        Me.lblLogoLeft = New System.Windows.Forms.Label
        Me.txtLogoWidth = New System.Windows.Forms.TextBox
        Me.pctLogo = New System.Windows.Forms.PictureBox
        Me.lblLogoWidth = New System.Windows.Forms.Label
        Me.txtLogoHeight = New System.Windows.Forms.TextBox
        Me.lblLogoHeight = New System.Windows.Forms.Label
        Me.txtLogoTop = New System.Windows.Forms.TextBox
        Me.lblLogoTop = New System.Windows.Forms.Label
        Me.chkLogo = New System.Windows.Forms.CheckBox
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.fraHeaderPanel = New System.Windows.Forms.GroupBox
        Me.txtHeaderPanelLeft = New System.Windows.Forms.TextBox
        Me.lblHeaderPanelLeft = New System.Windows.Forms.Label
        Me.txtHeaderPanelWidth = New System.Windows.Forms.TextBox
        Me.lblHeaderPanelWidth = New System.Windows.Forms.Label
        Me.txtHeaderPanelHeight = New System.Windows.Forms.TextBox
        Me.lblHeaderPanelHeight = New System.Windows.Forms.Label
        Me.txtHeaderPanelTop = New System.Windows.Forms.TextBox
        Me.lblHeaderPanelTop = New System.Windows.Forms.Label
        Me.chkHeaderPanel = New System.Windows.Forms.CheckBox
        Me.fraHeader = New System.Windows.Forms.GroupBox
        Me.cmdHeaderFont = New System.Windows.Forms.Button
        Me.txtHeader = New System.Windows.Forms.TextBox
        Me.txtHeaderLeft = New System.Windows.Forms.TextBox
        Me.lblHeaderLeft = New System.Windows.Forms.Label
        Me.txtHeaderWidth = New System.Windows.Forms.TextBox
        Me.lblHeaderWidth = New System.Windows.Forms.Label
        Me.txtHeaderHeight = New System.Windows.Forms.TextBox
        Me.lblHeaderHeight = New System.Windows.Forms.Label
        Me.txtHeaderTop = New System.Windows.Forms.TextBox
        Me.lblHeaderTop = New System.Windows.Forms.Label
        Me.chkHeader = New System.Windows.Forms.CheckBox
        Me.lblHeader = New System.Windows.Forms.Label
        Me.fraDate = New System.Windows.Forms.GroupBox
        Me.cboDateFormat = New System.Windows.Forms.ComboBox
        Me.cmdDateFont = New System.Windows.Forms.Button
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.txtDateLeft = New System.Windows.Forms.TextBox
        Me.lblDateLeft = New System.Windows.Forms.Label
        Me.txtDateWidth = New System.Windows.Forms.TextBox
        Me.lblDateWidth = New System.Windows.Forms.Label
        Me.txtDateHeight = New System.Windows.Forms.TextBox
        Me.lblDateHeight = New System.Windows.Forms.Label
        Me.txtDateTop = New System.Windows.Forms.TextBox
        Me.lblDateTop = New System.Windows.Forms.Label
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.fraTable = New System.Windows.Forms.GroupBox
        Me.cmdTableFont = New System.Windows.Forms.Button
        Me.txtTable = New System.Windows.Forms.TextBox
        Me.txtTableLeft = New System.Windows.Forms.TextBox
        Me.lblTableLeft = New System.Windows.Forms.Label
        Me.txtTableWidth = New System.Windows.Forms.TextBox
        Me.lblTableWidth = New System.Windows.Forms.Label
        Me.txtTableHeight = New System.Windows.Forms.TextBox
        Me.lblTableHeight = New System.Windows.Forms.Label
        Me.txtTableTop = New System.Windows.Forms.TextBox
        Me.lblTableTop = New System.Windows.Forms.Label
        Me.chkTable = New System.Windows.Forms.CheckBox
        Me.fraSet = New System.Windows.Forms.GroupBox
        Me.cmdSetFont = New System.Windows.Forms.Button
        Me.txtSet = New System.Windows.Forms.TextBox
        Me.txtSetLeft = New System.Windows.Forms.TextBox
        Me.lblSetLeft = New System.Windows.Forms.Label
        Me.txtSetWidth = New System.Windows.Forms.TextBox
        Me.lblSetWidth = New System.Windows.Forms.Label
        Me.txtSetHeight = New System.Windows.Forms.TextBox
        Me.lblSetHeight = New System.Windows.Forms.Label
        Me.txtSetTop = New System.Windows.Forms.TextBox
        Me.lblSetTop = New System.Windows.Forms.Label
        Me.chkSet = New System.Windows.Forms.CheckBox
        Me.tabBody = New System.Windows.Forms.TabPage
        Me.fraBodyPanel = New System.Windows.Forms.GroupBox
        Me.txtBodyPanelLeft = New System.Windows.Forms.TextBox
        Me.lblBodyPanelLeft = New System.Windows.Forms.Label
        Me.txtBodyPanelWidth = New System.Windows.Forms.TextBox
        Me.lblBodyPanelWidth = New System.Windows.Forms.Label
        Me.txtBodyPanelHeight = New System.Windows.Forms.TextBox
        Me.lblBodyPanelHeight = New System.Windows.Forms.Label
        Me.txtBodyPanelTop = New System.Windows.Forms.TextBox
        Me.lblBodyPanelTop = New System.Windows.Forms.Label
        Me.chkBodyPanel = New System.Windows.Forms.CheckBox
        Me.fraQuantityTitle = New System.Windows.Forms.GroupBox
        Me.cmdQuantityTitleFont = New System.Windows.Forms.Button
        Me.txtQuantityTitle = New System.Windows.Forms.TextBox
        Me.txtQuantityTitleLeft = New System.Windows.Forms.TextBox
        Me.lblQuantityTitleLeft = New System.Windows.Forms.Label
        Me.txtQuantityTitleWidth = New System.Windows.Forms.TextBox
        Me.lblQuantityTitleWidth = New System.Windows.Forms.Label
        Me.txtQuantityTitleHeight = New System.Windows.Forms.TextBox
        Me.lblQuantityTitleHeight = New System.Windows.Forms.Label
        Me.txtQuantityTitleTop = New System.Windows.Forms.TextBox
        Me.lblQuantityTitleTop = New System.Windows.Forms.Label
        Me.chkQuantityTitle = New System.Windows.Forms.CheckBox
        Me.fraQuantity = New System.Windows.Forms.GroupBox
        Me.cmdQuantityFont = New System.Windows.Forms.Button
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.txtQuantityLeft = New System.Windows.Forms.TextBox
        Me.lblQuantityLeft = New System.Windows.Forms.Label
        Me.txtQuantityWidth = New System.Windows.Forms.TextBox
        Me.lblQuantityWidth = New System.Windows.Forms.Label
        Me.txtQuantityHeight = New System.Windows.Forms.TextBox
        Me.lblQuantityHeight = New System.Windows.Forms.Label
        Me.txtQuantityTop = New System.Windows.Forms.TextBox
        Me.lblQuantityTop = New System.Windows.Forms.Label
        Me.chkQuantity = New System.Windows.Forms.CheckBox
        Me.fraDesignationTitle = New System.Windows.Forms.GroupBox
        Me.cmdDesignationTitleFont = New System.Windows.Forms.Button
        Me.txtDesignationTitle = New System.Windows.Forms.TextBox
        Me.txtDesignationTitleLeft = New System.Windows.Forms.TextBox
        Me.lblDesignationTitleLeft = New System.Windows.Forms.Label
        Me.txtDesignationTitleWidth = New System.Windows.Forms.TextBox
        Me.lblDesignationTitleWidth = New System.Windows.Forms.Label
        Me.txtDesignationTitleHeight = New System.Windows.Forms.TextBox
        Me.lblDesignationTitleHeight = New System.Windows.Forms.Label
        Me.txtDesignationTitleTop = New System.Windows.Forms.TextBox
        Me.lblDesignationTitleTop = New System.Windows.Forms.Label
        Me.chkDesignationTitle = New System.Windows.Forms.CheckBox
        Me.fraDesignation = New System.Windows.Forms.GroupBox
        Me.cmdDesignationFont = New System.Windows.Forms.Button
        Me.txtDesignation = New System.Windows.Forms.TextBox
        Me.txtDesignationLeft = New System.Windows.Forms.TextBox
        Me.lblDesignationLeft = New System.Windows.Forms.Label
        Me.txtDesignationWidth = New System.Windows.Forms.TextBox
        Me.lblDesignationWidth = New System.Windows.Forms.Label
        Me.txtDesignationHeight = New System.Windows.Forms.TextBox
        Me.lblDesignationHeight = New System.Windows.Forms.Label
        Me.txtDesignationTop = New System.Windows.Forms.TextBox
        Me.lblDesignationTop = New System.Windows.Forms.Label
        Me.chkDesignation = New System.Windows.Forms.CheckBox
        Me.fraTotalTitle = New System.Windows.Forms.GroupBox
        Me.cmdTotalTitleFont = New System.Windows.Forms.Button
        Me.txtTotalTitle = New System.Windows.Forms.TextBox
        Me.txtTotalTitleLeft = New System.Windows.Forms.TextBox
        Me.lblTotalTitleLeft = New System.Windows.Forms.Label
        Me.txtTotalTitleWidth = New System.Windows.Forms.TextBox
        Me.lblTotalTitleWidth = New System.Windows.Forms.Label
        Me.txtTotalTitleHeight = New System.Windows.Forms.TextBox
        Me.lblTotalTitleHeight = New System.Windows.Forms.Label
        Me.txtTotalTitleTop = New System.Windows.Forms.TextBox
        Me.lblTotalTitleTop = New System.Windows.Forms.Label
        Me.chkTotalTitle = New System.Windows.Forms.CheckBox
        Me.fraTotal = New System.Windows.Forms.GroupBox
        Me.cmdTotalFont = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtTotalLeft = New System.Windows.Forms.TextBox
        Me.lblTotalLeft = New System.Windows.Forms.Label
        Me.txtTotalWidth = New System.Windows.Forms.TextBox
        Me.lblTotalWidth = New System.Windows.Forms.Label
        Me.txtTotalHeight = New System.Windows.Forms.TextBox
        Me.lblTotalHeight = New System.Windows.Forms.Label
        Me.txtTotalTop = New System.Windows.Forms.TextBox
        Me.lblTotalTop = New System.Windows.Forms.Label
        Me.chkTotal = New System.Windows.Forms.CheckBox
        Me.tabFooter = New System.Windows.Forms.TabPage
        Me.fraFooterPanel = New System.Windows.Forms.GroupBox
        Me.txtFooterPanelLeft = New System.Windows.Forms.TextBox
        Me.lblFooterPanelLeft = New System.Windows.Forms.Label
        Me.txtFooterPanelWidth = New System.Windows.Forms.TextBox
        Me.lblFooterPanelWidth = New System.Windows.Forms.Label
        Me.txtFooterPanelHeight = New System.Windows.Forms.TextBox
        Me.lblFooterPanelHeight = New System.Windows.Forms.Label
        Me.txtFooterPanelTop = New System.Windows.Forms.TextBox
        Me.lblFooterPanelTop = New System.Windows.Forms.Label
        Me.chkFooterPanel = New System.Windows.Forms.CheckBox
        Me.fraSubAmountText = New System.Windows.Forms.GroupBox
        Me.cmdSubAmountTextFont = New System.Windows.Forms.Button
        Me.txtSubAmountText = New System.Windows.Forms.TextBox
        Me.txtSubAmountTextLeft = New System.Windows.Forms.TextBox
        Me.lblSubAmountTextLeft = New System.Windows.Forms.Label
        Me.txtSubAmountTextWidth = New System.Windows.Forms.TextBox
        Me.lblSubAmountTextWidth = New System.Windows.Forms.Label
        Me.txtSubAmountTextHeight = New System.Windows.Forms.TextBox
        Me.lblSubAmountTextHeight = New System.Windows.Forms.Label
        Me.txtSubAmountTextTop = New System.Windows.Forms.TextBox
        Me.lblSubAmountTextTop = New System.Windows.Forms.Label
        Me.chkSubAmountText = New System.Windows.Forms.CheckBox
        Me.fraSubAmount = New System.Windows.Forms.GroupBox
        Me.cmdSubAmountFont = New System.Windows.Forms.Button
        Me.txtSubAmount = New System.Windows.Forms.TextBox
        Me.txtSubAmountLeft = New System.Windows.Forms.TextBox
        Me.lblSubAmountLeft = New System.Windows.Forms.Label
        Me.txtSubAmountWidth = New System.Windows.Forms.TextBox
        Me.lblSubAmountWidth = New System.Windows.Forms.Label
        Me.txtSubAmountHeight = New System.Windows.Forms.TextBox
        Me.lblSubAmountHeight = New System.Windows.Forms.Label
        Me.txtSubAmountTop = New System.Windows.Forms.TextBox
        Me.lblSubAmountTop = New System.Windows.Forms.Label
        Me.chkSubAmount = New System.Windows.Forms.CheckBox
        Me.fraDiscountText = New System.Windows.Forms.GroupBox
        Me.cmdDiscountTextFont = New System.Windows.Forms.Button
        Me.txtDiscountText = New System.Windows.Forms.TextBox
        Me.txtDiscountTextLeft = New System.Windows.Forms.TextBox
        Me.lblDiscountTextLeft = New System.Windows.Forms.Label
        Me.txtDiscountTextWidth = New System.Windows.Forms.TextBox
        Me.lblDiscountTextWidth = New System.Windows.Forms.Label
        Me.txtDiscountTextHeight = New System.Windows.Forms.TextBox
        Me.lblDiscountTextHeight = New System.Windows.Forms.Label
        Me.txtDiscountTextTop = New System.Windows.Forms.TextBox
        Me.lblDiscountTextTop = New System.Windows.Forms.Label
        Me.chkDiscountText = New System.Windows.Forms.CheckBox
        Me.fraDiscount = New System.Windows.Forms.GroupBox
        Me.cmdDiscountFont = New System.Windows.Forms.Button
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtDiscountLeft = New System.Windows.Forms.TextBox
        Me.lblDiscountLeft = New System.Windows.Forms.Label
        Me.txtDiscountWidth = New System.Windows.Forms.TextBox
        Me.lblDiscountWidth = New System.Windows.Forms.Label
        Me.txtDiscountHeight = New System.Windows.Forms.TextBox
        Me.lblDiscountHeight = New System.Windows.Forms.Label
        Me.txtDiscountTop = New System.Windows.Forms.TextBox
        Me.lblDiscountTop = New System.Windows.Forms.Label
        Me.chkDiscount = New System.Windows.Forms.CheckBox
        Me.fraAmountText = New System.Windows.Forms.GroupBox
        Me.cmdAmountTextFont = New System.Windows.Forms.Button
        Me.txtAmountText = New System.Windows.Forms.TextBox
        Me.txtAmountTextLeft = New System.Windows.Forms.TextBox
        Me.lblAmountTextLeft = New System.Windows.Forms.Label
        Me.txtAmountTextWidth = New System.Windows.Forms.TextBox
        Me.lblAmountTextWidth = New System.Windows.Forms.Label
        Me.txtAmountTextHeight = New System.Windows.Forms.TextBox
        Me.lblAmountTextHeight = New System.Windows.Forms.Label
        Me.txtAmountTextTop = New System.Windows.Forms.TextBox
        Me.lblAmountTextTop = New System.Windows.Forms.Label
        Me.chkAmountText = New System.Windows.Forms.CheckBox
        Me.fraAmount = New System.Windows.Forms.GroupBox
        Me.cmdAmountFont = New System.Windows.Forms.Button
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtAmountLeft = New System.Windows.Forms.TextBox
        Me.lblAmountLeft = New System.Windows.Forms.Label
        Me.txtAmountWidth = New System.Windows.Forms.TextBox
        Me.lblAmountWidth = New System.Windows.Forms.Label
        Me.txtAmountHeight = New System.Windows.Forms.TextBox
        Me.lblAmountHeight = New System.Windows.Forms.Label
        Me.txtAmountTop = New System.Windows.Forms.TextBox
        Me.lblAmountTop = New System.Windows.Forms.Label
        Me.chkAmount = New System.Windows.Forms.CheckBox
        Me.fraTvaText = New System.Windows.Forms.GroupBox
        Me.cmdTvaTextFont = New System.Windows.Forms.Button
        Me.txtTvaText = New System.Windows.Forms.TextBox
        Me.txtTvaTextLeft = New System.Windows.Forms.TextBox
        Me.lblTvaTextLeft = New System.Windows.Forms.Label
        Me.txtTvaTextWidth = New System.Windows.Forms.TextBox
        Me.lblTvaTextWidth = New System.Windows.Forms.Label
        Me.txtTvaTextHeight = New System.Windows.Forms.TextBox
        Me.lblTvaTextHeight = New System.Windows.Forms.Label
        Me.txtTvaTextTop = New System.Windows.Forms.TextBox
        Me.lblTvaTextTop = New System.Windows.Forms.Label
        Me.chkTvaText = New System.Windows.Forms.CheckBox
        Me.fraTva = New System.Windows.Forms.GroupBox
        Me.cmdTvaFont = New System.Windows.Forms.Button
        Me.txtTva = New System.Windows.Forms.TextBox
        Me.txtTvaLeft = New System.Windows.Forms.TextBox
        Me.lblTvaLeft = New System.Windows.Forms.Label
        Me.txtTvaWidth = New System.Windows.Forms.TextBox
        Me.lblTvaWidth = New System.Windows.Forms.Label
        Me.txtTvaHeight = New System.Windows.Forms.TextBox
        Me.lblTvaHeight = New System.Windows.Forms.Label
        Me.txtTvaTop = New System.Windows.Forms.TextBox
        Me.lblTvaTop = New System.Windows.Forms.Label
        Me.chkTva = New System.Windows.Forms.CheckBox
        Me.fraFooter = New System.Windows.Forms.GroupBox
        Me.cmdFooterFont = New System.Windows.Forms.Button
        Me.txtFooter = New System.Windows.Forms.TextBox
        Me.txtFooterLeft = New System.Windows.Forms.TextBox
        Me.lblFooterLeft = New System.Windows.Forms.Label
        Me.txtFooterWidth = New System.Windows.Forms.TextBox
        Me.lblFooterWidth = New System.Windows.Forms.Label
        Me.txtFooterHeight = New System.Windows.Forms.TextBox
        Me.lblFooterHeight = New System.Windows.Forms.Label
        Me.txtFooterTop = New System.Windows.Forms.TextBox
        Me.lblFooterTop = New System.Windows.Forms.Label
        Me.chkFooter = New System.Windows.Forms.CheckBox
        Me.frmFont = New System.Windows.Forms.FontDialog
        Me.fraPrint = New System.Windows.Forms.GroupBox
        Me.txtPrintWidth = New System.Windows.Forms.TextBox
        Me.lblPrintWidth = New System.Windows.Forms.Label
        Me.txtPrintHeight = New System.Windows.Forms.TextBox
        Me.lblPrintHeight = New System.Windows.Forms.Label
        Me.fraPassword.SuspendLayout()
        Me.tabOption.SuspendLayout()
        Me.tabOptGeneral.SuspendLayout()
        Me.fraPasswordErase.SuspendLayout()
        Me.tabOptPrint.SuspendLayout()
        Me.tabPrint.SuspendLayout()
        Me.tabHeader.SuspendLayout()
        Me.fraLogo.SuspendLayout()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraHeaderPanel.SuspendLayout()
        Me.fraHeader.SuspendLayout()
        Me.fraDate.SuspendLayout()
        Me.fraTable.SuspendLayout()
        Me.fraSet.SuspendLayout()
        Me.tabBody.SuspendLayout()
        Me.fraBodyPanel.SuspendLayout()
        Me.fraQuantityTitle.SuspendLayout()
        Me.fraQuantity.SuspendLayout()
        Me.fraDesignationTitle.SuspendLayout()
        Me.fraDesignation.SuspendLayout()
        Me.fraTotalTitle.SuspendLayout()
        Me.fraTotal.SuspendLayout()
        Me.tabFooter.SuspendLayout()
        Me.fraFooterPanel.SuspendLayout()
        Me.fraSubAmountText.SuspendLayout()
        Me.fraSubAmount.SuspendLayout()
        Me.fraDiscountText.SuspendLayout()
        Me.fraDiscount.SuspendLayout()
        Me.fraAmountText.SuspendLayout()
        Me.fraAmount.SuspendLayout()
        Me.fraTvaText.SuspendLayout()
        Me.fraTva.SuspendLayout()
        Me.fraFooter.SuspendLayout()
        Me.fraPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoEllipsis = True
        Me.lblLanguage.Location = New System.Drawing.Point(146, 20)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(144, 21)
        Me.lblLanguage.TabIndex = 1
        Me.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVat
        '
        Me.lblVat.AutoEllipsis = True
        Me.lblVat.Location = New System.Drawing.Point(149, 79)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(156, 20)
        Me.lblVat.TabIndex = 4
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPassword
        '
        Me.lblPassword.AutoEllipsis = True
        Me.lblPassword.Location = New System.Drawing.Point(6, 40)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(150, 20)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(317, 79)
        Me.txtVat.MaxLength = 8
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(100, 20)
        Me.txtVat.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(162, 40)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'cboLanguage
        '
        Me.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(296, 20)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cboLanguage.TabIndex = 0
        '
        'chkPassword
        '
        Me.chkPassword.AutoEllipsis = True
        Me.chkPassword.Location = New System.Drawing.Point(6, 13)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(256, 20)
        Me.chkPassword.TabIndex = 5
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'fraPassword
        '
        Me.fraPassword.Controls.Add(Me.chkPassword)
        Me.fraPassword.Controls.Add(Me.txtPassword)
        Me.fraPassword.Controls.Add(Me.lblPassword)
        Me.fraPassword.Location = New System.Drawing.Point(149, 141)
        Me.fraPassword.Name = "fraPassword"
        Me.fraPassword.Size = New System.Drawing.Size(268, 73)
        Me.fraPassword.TabIndex = 12
        Me.fraPassword.TabStop = False
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(97, 490)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 6
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(282, 490)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'dlgPicture
        '
        Me.dlgPicture.SupportMultiDottedExtensions = True
        '
        'tabOption
        '
        Me.tabOption.Controls.Add(Me.tabOptGeneral)
        Me.tabOption.Controls.Add(Me.tabOptPrint)
        Me.tabOption.Location = New System.Drawing.Point(12, 8)
        Me.tabOption.Name = "tabOption"
        Me.tabOption.SelectedIndex = 0
        Me.tabOption.Size = New System.Drawing.Size(454, 476)
        Me.tabOption.TabIndex = 13
        '
        'tabOptGeneral
        '
        Me.tabOptGeneral.AutoScroll = True
        Me.tabOptGeneral.Controls.Add(Me.fraPasswordErase)
        Me.tabOptGeneral.Controls.Add(Me.fraPassword)
        Me.tabOptGeneral.Controls.Add(Me.lblVat)
        Me.tabOptGeneral.Controls.Add(Me.txtVat)
        Me.tabOptGeneral.Controls.Add(Me.lblLanguage)
        Me.tabOptGeneral.Controls.Add(Me.cboLanguage)
        Me.tabOptGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabOptGeneral.Name = "tabOptGeneral"
        Me.tabOptGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOptGeneral.Size = New System.Drawing.Size(446, 450)
        Me.tabOptGeneral.TabIndex = 0
        Me.tabOptGeneral.UseVisualStyleBackColor = True
        '
        'fraPasswordErase
        '
        Me.fraPasswordErase.Controls.Add(Me.txtPasswordErase)
        Me.fraPasswordErase.Controls.Add(Me.lblPasswordErase)
        Me.fraPasswordErase.Controls.Add(Me.chkPasswordErase)
        Me.fraPasswordErase.Location = New System.Drawing.Point(149, 247)
        Me.fraPasswordErase.Name = "fraPasswordErase"
        Me.fraPasswordErase.Size = New System.Drawing.Size(268, 77)
        Me.fraPasswordErase.TabIndex = 13
        Me.fraPasswordErase.TabStop = False
        '
        'txtPasswordErase
        '
        Me.txtPasswordErase.Location = New System.Drawing.Point(162, 42)
        Me.txtPasswordErase.MaxLength = 50
        Me.txtPasswordErase.Name = "txtPasswordErase"
        Me.txtPasswordErase.Size = New System.Drawing.Size(100, 20)
        Me.txtPasswordErase.TabIndex = 8
        Me.txtPasswordErase.UseSystemPasswordChar = True
        '
        'lblPasswordErase
        '
        Me.lblPasswordErase.AutoEllipsis = True
        Me.lblPasswordErase.Location = New System.Drawing.Point(6, 42)
        Me.lblPasswordErase.Name = "lblPasswordErase"
        Me.lblPasswordErase.Size = New System.Drawing.Size(150, 20)
        Me.lblPasswordErase.TabIndex = 7
        Me.lblPasswordErase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkPasswordErase
        '
        Me.chkPasswordErase.AutoEllipsis = True
        Me.chkPasswordErase.Location = New System.Drawing.Point(6, 13)
        Me.chkPasswordErase.Name = "chkPasswordErase"
        Me.chkPasswordErase.Size = New System.Drawing.Size(256, 20)
        Me.chkPasswordErase.TabIndex = 6
        Me.chkPasswordErase.UseVisualStyleBackColor = True
        '
        'tabOptPrint
        '
        Me.tabOptPrint.AutoScroll = True
        Me.tabOptPrint.Controls.Add(Me.fraPrint)
        Me.tabOptPrint.Controls.Add(Me.tabPrint)
        Me.tabOptPrint.Location = New System.Drawing.Point(4, 22)
        Me.tabOptPrint.Name = "tabOptPrint"
        Me.tabOptPrint.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOptPrint.Size = New System.Drawing.Size(446, 450)
        Me.tabOptPrint.TabIndex = 1
        Me.tabOptPrint.UseVisualStyleBackColor = True
        '
        'tabPrint
        '
        Me.tabPrint.Controls.Add(Me.tabHeader)
        Me.tabPrint.Controls.Add(Me.tabBody)
        Me.tabPrint.Controls.Add(Me.tabFooter)
        Me.tabPrint.Location = New System.Drawing.Point(3, 68)
        Me.tabPrint.Name = "tabPrint"
        Me.tabPrint.SelectedIndex = 0
        Me.tabPrint.Size = New System.Drawing.Size(440, 379)
        Me.tabPrint.TabIndex = 10
        '
        'tabHeader
        '
        Me.tabHeader.AutoScroll = True
        Me.tabHeader.Controls.Add(Me.fraLogo)
        Me.tabHeader.Controls.Add(Me.fraHeaderPanel)
        Me.tabHeader.Controls.Add(Me.fraHeader)
        Me.tabHeader.Controls.Add(Me.fraDate)
        Me.tabHeader.Controls.Add(Me.fraTable)
        Me.tabHeader.Controls.Add(Me.fraSet)
        Me.tabHeader.Location = New System.Drawing.Point(4, 22)
        Me.tabHeader.Name = "tabHeader"
        Me.tabHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHeader.Size = New System.Drawing.Size(432, 353)
        Me.tabHeader.TabIndex = 0
        Me.tabHeader.UseVisualStyleBackColor = True
        '
        'fraLogo
        '
        Me.fraLogo.Controls.Add(Me.lblPicture)
        Me.fraLogo.Controls.Add(Me.txtLogoLeft)
        Me.fraLogo.Controls.Add(Me.lblLogoLeft)
        Me.fraLogo.Controls.Add(Me.txtLogoWidth)
        Me.fraLogo.Controls.Add(Me.pctLogo)
        Me.fraLogo.Controls.Add(Me.lblLogoWidth)
        Me.fraLogo.Controls.Add(Me.txtLogoHeight)
        Me.fraLogo.Controls.Add(Me.lblLogoHeight)
        Me.fraLogo.Controls.Add(Me.txtLogoTop)
        Me.fraLogo.Controls.Add(Me.lblLogoTop)
        Me.fraLogo.Controls.Add(Me.chkLogo)
        Me.fraLogo.Controls.Add(Me.cmdBrowse)
        Me.fraLogo.Location = New System.Drawing.Point(3, 335)
        Me.fraLogo.Name = "fraLogo"
        Me.fraLogo.Size = New System.Drawing.Size(405, 176)
        Me.fraLogo.TabIndex = 15
        Me.fraLogo.TabStop = False
        '
        'lblPicture
        '
        Me.lblPicture.AutoEllipsis = True
        Me.lblPicture.Location = New System.Drawing.Point(156, 85)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(156, 54)
        Me.lblPicture.TabIndex = 13
        Me.lblPicture.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLogoLeft
        '
        Me.txtLogoLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtLogoLeft.Name = "txtLogoLeft"
        Me.txtLogoLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtLogoLeft.TabIndex = 20
        '
        'lblLogoLeft
        '
        Me.lblLogoLeft.AutoEllipsis = True
        Me.lblLogoLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblLogoLeft.Name = "lblLogoLeft"
        Me.lblLogoLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblLogoLeft.TabIndex = 19
        Me.lblLogoLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLogoWidth
        '
        Me.txtLogoWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtLogoWidth.Name = "txtLogoWidth"
        Me.txtLogoWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtLogoWidth.TabIndex = 18
        '
        'pctLogo
        '
        Me.pctLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctLogo.Location = New System.Drawing.Point(318, 85)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(80, 80)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogo.TabIndex = 14
        Me.pctLogo.TabStop = False
        '
        'lblLogoWidth
        '
        Me.lblLogoWidth.AutoEllipsis = True
        Me.lblLogoWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblLogoWidth.Name = "lblLogoWidth"
        Me.lblLogoWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblLogoWidth.TabIndex = 17
        Me.lblLogoWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLogoHeight
        '
        Me.txtLogoHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtLogoHeight.Name = "txtLogoHeight"
        Me.txtLogoHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtLogoHeight.TabIndex = 16
        '
        'lblLogoHeight
        '
        Me.lblLogoHeight.AutoEllipsis = True
        Me.lblLogoHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblLogoHeight.Name = "lblLogoHeight"
        Me.lblLogoHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblLogoHeight.TabIndex = 15
        Me.lblLogoHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLogoTop
        '
        Me.txtLogoTop.Location = New System.Drawing.Point(99, 33)
        Me.txtLogoTop.Name = "txtLogoTop"
        Me.txtLogoTop.Size = New System.Drawing.Size(100, 20)
        Me.txtLogoTop.TabIndex = 14
        '
        'lblLogoTop
        '
        Me.lblLogoTop.AutoEllipsis = True
        Me.lblLogoTop.Location = New System.Drawing.Point(6, 36)
        Me.lblLogoTop.Name = "lblLogoTop"
        Me.lblLogoTop.Size = New System.Drawing.Size(87, 20)
        Me.lblLogoTop.TabIndex = 13
        Me.lblLogoTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkLogo
        '
        Me.chkLogo.AutoSize = True
        Me.chkLogo.Checked = True
        Me.chkLogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLogo.Location = New System.Drawing.Point(6, 16)
        Me.chkLogo.Name = "chkLogo"
        Me.chkLogo.Size = New System.Drawing.Size(15, 14)
        Me.chkLogo.TabIndex = 12
        Me.chkLogo.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(237, 142)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 12
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'fraHeaderPanel
        '
        Me.fraHeaderPanel.Controls.Add(Me.txtHeaderPanelLeft)
        Me.fraHeaderPanel.Controls.Add(Me.lblHeaderPanelLeft)
        Me.fraHeaderPanel.Controls.Add(Me.txtHeaderPanelWidth)
        Me.fraHeaderPanel.Controls.Add(Me.lblHeaderPanelWidth)
        Me.fraHeaderPanel.Controls.Add(Me.txtHeaderPanelHeight)
        Me.fraHeaderPanel.Controls.Add(Me.lblHeaderPanelHeight)
        Me.fraHeaderPanel.Controls.Add(Me.txtHeaderPanelTop)
        Me.fraHeaderPanel.Controls.Add(Me.lblHeaderPanelTop)
        Me.fraHeaderPanel.Controls.Add(Me.chkHeaderPanel)
        Me.fraHeaderPanel.Location = New System.Drawing.Point(6, 6)
        Me.fraHeaderPanel.Name = "fraHeaderPanel"
        Me.fraHeaderPanel.Size = New System.Drawing.Size(402, 97)
        Me.fraHeaderPanel.TabIndex = 15
        Me.fraHeaderPanel.TabStop = False
        '
        'txtHeaderPanelLeft
        '
        Me.txtHeaderPanelLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtHeaderPanelLeft.Name = "txtHeaderPanelLeft"
        Me.txtHeaderPanelLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderPanelLeft.TabIndex = 20
        '
        'lblHeaderPanelLeft
        '
        Me.lblHeaderPanelLeft.AutoEllipsis = True
        Me.lblHeaderPanelLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblHeaderPanelLeft.Name = "lblHeaderPanelLeft"
        Me.lblHeaderPanelLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderPanelLeft.TabIndex = 19
        Me.lblHeaderPanelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaderPanelWidth
        '
        Me.txtHeaderPanelWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtHeaderPanelWidth.Name = "txtHeaderPanelWidth"
        Me.txtHeaderPanelWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderPanelWidth.TabIndex = 18
        '
        'lblHeaderPanelWidth
        '
        Me.lblHeaderPanelWidth.AutoEllipsis = True
        Me.lblHeaderPanelWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblHeaderPanelWidth.Name = "lblHeaderPanelWidth"
        Me.lblHeaderPanelWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderPanelWidth.TabIndex = 17
        Me.lblHeaderPanelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaderPanelHeight
        '
        Me.txtHeaderPanelHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtHeaderPanelHeight.Name = "txtHeaderPanelHeight"
        Me.txtHeaderPanelHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderPanelHeight.TabIndex = 16
        '
        'lblHeaderPanelHeight
        '
        Me.lblHeaderPanelHeight.AutoEllipsis = True
        Me.lblHeaderPanelHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblHeaderPanelHeight.Name = "lblHeaderPanelHeight"
        Me.lblHeaderPanelHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderPanelHeight.TabIndex = 15
        Me.lblHeaderPanelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaderPanelTop
        '
        Me.txtHeaderPanelTop.Location = New System.Drawing.Point(99, 33)
        Me.txtHeaderPanelTop.Name = "txtHeaderPanelTop"
        Me.txtHeaderPanelTop.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderPanelTop.TabIndex = 14
        '
        'lblHeaderPanelTop
        '
        Me.lblHeaderPanelTop.AutoEllipsis = True
        Me.lblHeaderPanelTop.Location = New System.Drawing.Point(6, 36)
        Me.lblHeaderPanelTop.Name = "lblHeaderPanelTop"
        Me.lblHeaderPanelTop.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderPanelTop.TabIndex = 13
        Me.lblHeaderPanelTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkHeaderPanel
        '
        Me.chkHeaderPanel.AutoSize = True
        Me.chkHeaderPanel.Checked = True
        Me.chkHeaderPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHeaderPanel.Location = New System.Drawing.Point(6, 16)
        Me.chkHeaderPanel.Name = "chkHeaderPanel"
        Me.chkHeaderPanel.Size = New System.Drawing.Size(15, 14)
        Me.chkHeaderPanel.TabIndex = 12
        Me.chkHeaderPanel.UseVisualStyleBackColor = True
        '
        'fraHeader
        '
        Me.fraHeader.Controls.Add(Me.cmdHeaderFont)
        Me.fraHeader.Controls.Add(Me.txtHeaderLeft)
        Me.fraHeader.Controls.Add(Me.lblHeaderLeft)
        Me.fraHeader.Controls.Add(Me.txtHeaderWidth)
        Me.fraHeader.Controls.Add(Me.lblHeaderWidth)
        Me.fraHeader.Controls.Add(Me.txtHeaderHeight)
        Me.fraHeader.Controls.Add(Me.lblHeaderHeight)
        Me.fraHeader.Controls.Add(Me.txtHeaderTop)
        Me.fraHeader.Controls.Add(Me.lblHeaderTop)
        Me.fraHeader.Controls.Add(Me.chkHeader)
        Me.fraHeader.Controls.Add(Me.txtHeader)
        Me.fraHeader.Controls.Add(Me.lblHeader)
        Me.fraHeader.Location = New System.Drawing.Point(6, 109)
        Me.fraHeader.Name = "fraHeader"
        Me.fraHeader.Size = New System.Drawing.Size(402, 220)
        Me.fraHeader.TabIndex = 15
        Me.fraHeader.TabStop = False
        '
        'cmdHeaderFont
        '
        Me.cmdHeaderFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdHeaderFont.Name = "cmdHeaderFont"
        Me.cmdHeaderFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdHeaderFont.TabIndex = 21
        Me.cmdHeaderFont.Tag = Me.txtHeader
        Me.cmdHeaderFont.UseVisualStyleBackColor = True
        '
        'txtHeader
        '
        Me.txtHeader.AcceptsReturn = True
        Me.txtHeader.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHeader.Location = New System.Drawing.Point(9, 124)
        Me.txtHeader.Multiline = True
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(389, 90)
        Me.txtHeader.TabIndex = 10
        '
        'txtHeaderLeft
        '
        Me.txtHeaderLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtHeaderLeft.Name = "txtHeaderLeft"
        Me.txtHeaderLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderLeft.TabIndex = 20
        '
        'lblHeaderLeft
        '
        Me.lblHeaderLeft.AutoEllipsis = True
        Me.lblHeaderLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblHeaderLeft.Name = "lblHeaderLeft"
        Me.lblHeaderLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderLeft.TabIndex = 19
        Me.lblHeaderLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaderWidth
        '
        Me.txtHeaderWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtHeaderWidth.Name = "txtHeaderWidth"
        Me.txtHeaderWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderWidth.TabIndex = 18
        '
        'lblHeaderWidth
        '
        Me.lblHeaderWidth.AutoEllipsis = True
        Me.lblHeaderWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblHeaderWidth.Name = "lblHeaderWidth"
        Me.lblHeaderWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderWidth.TabIndex = 17
        Me.lblHeaderWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaderHeight
        '
        Me.txtHeaderHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtHeaderHeight.Name = "txtHeaderHeight"
        Me.txtHeaderHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderHeight.TabIndex = 16
        '
        'lblHeaderHeight
        '
        Me.lblHeaderHeight.AutoEllipsis = True
        Me.lblHeaderHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblHeaderHeight.Name = "lblHeaderHeight"
        Me.lblHeaderHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderHeight.TabIndex = 15
        Me.lblHeaderHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHeaderTop
        '
        Me.txtHeaderTop.Location = New System.Drawing.Point(99, 33)
        Me.txtHeaderTop.Name = "txtHeaderTop"
        Me.txtHeaderTop.Size = New System.Drawing.Size(100, 20)
        Me.txtHeaderTop.TabIndex = 14
        '
        'lblHeaderTop
        '
        Me.lblHeaderTop.AutoEllipsis = True
        Me.lblHeaderTop.Location = New System.Drawing.Point(6, 36)
        Me.lblHeaderTop.Name = "lblHeaderTop"
        Me.lblHeaderTop.Size = New System.Drawing.Size(87, 20)
        Me.lblHeaderTop.TabIndex = 13
        Me.lblHeaderTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkHeader
        '
        Me.chkHeader.AutoSize = True
        Me.chkHeader.Checked = True
        Me.chkHeader.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHeader.Location = New System.Drawing.Point(6, 16)
        Me.chkHeader.Name = "chkHeader"
        Me.chkHeader.Size = New System.Drawing.Size(15, 14)
        Me.chkHeader.TabIndex = 12
        Me.chkHeader.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoEllipsis = True
        Me.lblHeader.Location = New System.Drawing.Point(6, 85)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(285, 36)
        Me.lblHeader.TabIndex = 11
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fraDate
        '
        Me.fraDate.Controls.Add(Me.cboDateFormat)
        Me.fraDate.Controls.Add(Me.cmdDateFont)
        Me.fraDate.Controls.Add(Me.txtDateLeft)
        Me.fraDate.Controls.Add(Me.lblDateLeft)
        Me.fraDate.Controls.Add(Me.txtDateWidth)
        Me.fraDate.Controls.Add(Me.lblDateWidth)
        Me.fraDate.Controls.Add(Me.txtDateHeight)
        Me.fraDate.Controls.Add(Me.lblDateHeight)
        Me.fraDate.Controls.Add(Me.txtDateTop)
        Me.fraDate.Controls.Add(Me.lblDateTop)
        Me.fraDate.Controls.Add(Me.chkDate)
        Me.fraDate.Controls.Add(Me.txtDate)
        Me.fraDate.Location = New System.Drawing.Point(6, 517)
        Me.fraDate.Name = "fraDate"
        Me.fraDate.Size = New System.Drawing.Size(402, 132)
        Me.fraDate.TabIndex = 15
        Me.fraDate.TabStop = False
        '
        'cboDateFormat
        '
        Me.cboDateFormat.FormattingEnabled = True
        Me.cboDateFormat.Location = New System.Drawing.Point(6, 98)
        Me.cboDateFormat.Name = "cboDateFormat"
        Me.cboDateFormat.Size = New System.Drawing.Size(151, 21)
        Me.cboDateFormat.TabIndex = 22
        '
        'cmdDateFont
        '
        Me.cmdDateFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdDateFont.Name = "cmdDateFont"
        Me.cmdDateFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdDateFont.TabIndex = 21
        Me.cmdDateFont.Tag = Me.txtDate
        Me.cmdDateFont.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.AcceptsReturn = True
        Me.txtDate.Location = New System.Drawing.Point(163, 98)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(129, 20)
        Me.txtDate.TabIndex = 10
        '
        'txtDateLeft
        '
        Me.txtDateLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtDateLeft.Name = "txtDateLeft"
        Me.txtDateLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtDateLeft.TabIndex = 20
        '
        'lblDateLeft
        '
        Me.lblDateLeft.AutoEllipsis = True
        Me.lblDateLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblDateLeft.Name = "lblDateLeft"
        Me.lblDateLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblDateLeft.TabIndex = 19
        Me.lblDateLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDateWidth
        '
        Me.txtDateWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtDateWidth.Name = "txtDateWidth"
        Me.txtDateWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtDateWidth.TabIndex = 18
        '
        'lblDateWidth
        '
        Me.lblDateWidth.AutoEllipsis = True
        Me.lblDateWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblDateWidth.Name = "lblDateWidth"
        Me.lblDateWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblDateWidth.TabIndex = 17
        Me.lblDateWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDateHeight
        '
        Me.txtDateHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtDateHeight.Name = "txtDateHeight"
        Me.txtDateHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtDateHeight.TabIndex = 16
        '
        'lblDateHeight
        '
        Me.lblDateHeight.AutoEllipsis = True
        Me.lblDateHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblDateHeight.Name = "lblDateHeight"
        Me.lblDateHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblDateHeight.TabIndex = 15
        Me.lblDateHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDateTop
        '
        Me.txtDateTop.Location = New System.Drawing.Point(99, 33)
        Me.txtDateTop.Name = "txtDateTop"
        Me.txtDateTop.Size = New System.Drawing.Size(100, 20)
        Me.txtDateTop.TabIndex = 14
        '
        'lblDateTop
        '
        Me.lblDateTop.AutoEllipsis = True
        Me.lblDateTop.Location = New System.Drawing.Point(6, 36)
        Me.lblDateTop.Name = "lblDateTop"
        Me.lblDateTop.Size = New System.Drawing.Size(87, 20)
        Me.lblDateTop.TabIndex = 13
        Me.lblDateTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Checked = True
        Me.chkDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDate.Location = New System.Drawing.Point(6, 16)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(15, 14)
        Me.chkDate.TabIndex = 12
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'fraTable
        '
        Me.fraTable.Controls.Add(Me.cmdTableFont)
        Me.fraTable.Controls.Add(Me.txtTableLeft)
        Me.fraTable.Controls.Add(Me.lblTableLeft)
        Me.fraTable.Controls.Add(Me.txtTableWidth)
        Me.fraTable.Controls.Add(Me.lblTableWidth)
        Me.fraTable.Controls.Add(Me.txtTableHeight)
        Me.fraTable.Controls.Add(Me.lblTableHeight)
        Me.fraTable.Controls.Add(Me.txtTableTop)
        Me.fraTable.Controls.Add(Me.lblTableTop)
        Me.fraTable.Controls.Add(Me.chkTable)
        Me.fraTable.Controls.Add(Me.txtTable)
        Me.fraTable.Location = New System.Drawing.Point(6, 655)
        Me.fraTable.Name = "fraTable"
        Me.fraTable.Size = New System.Drawing.Size(402, 132)
        Me.fraTable.TabIndex = 15
        Me.fraTable.TabStop = False
        '
        'cmdTableFont
        '
        Me.cmdTableFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdTableFont.Name = "cmdTableFont"
        Me.cmdTableFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdTableFont.TabIndex = 21
        Me.cmdTableFont.Tag = Me.txtTable
        Me.cmdTableFont.UseVisualStyleBackColor = True
        '
        'txtTable
        '
        Me.txtTable.AcceptsReturn = True
        Me.txtTable.Location = New System.Drawing.Point(208, 98)
        Me.txtTable.Multiline = True
        Me.txtTable.Name = "txtTable"
        Me.txtTable.ReadOnly = True
        Me.txtTable.Size = New System.Drawing.Size(84, 20)
        Me.txtTable.TabIndex = 10
        '
        'txtTableLeft
        '
        Me.txtTableLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtTableLeft.Name = "txtTableLeft"
        Me.txtTableLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtTableLeft.TabIndex = 20
        '
        'lblTableLeft
        '
        Me.lblTableLeft.AutoEllipsis = True
        Me.lblTableLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblTableLeft.Name = "lblTableLeft"
        Me.lblTableLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblTableLeft.TabIndex = 19
        Me.lblTableLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTableWidth
        '
        Me.txtTableWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtTableWidth.Name = "txtTableWidth"
        Me.txtTableWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtTableWidth.TabIndex = 18
        '
        'lblTableWidth
        '
        Me.lblTableWidth.AutoEllipsis = True
        Me.lblTableWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblTableWidth.Name = "lblTableWidth"
        Me.lblTableWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblTableWidth.TabIndex = 17
        Me.lblTableWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTableHeight
        '
        Me.txtTableHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtTableHeight.Name = "txtTableHeight"
        Me.txtTableHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtTableHeight.TabIndex = 16
        '
        'lblTableHeight
        '
        Me.lblTableHeight.AutoEllipsis = True
        Me.lblTableHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblTableHeight.Name = "lblTableHeight"
        Me.lblTableHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblTableHeight.TabIndex = 15
        Me.lblTableHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTableTop
        '
        Me.txtTableTop.Location = New System.Drawing.Point(99, 33)
        Me.txtTableTop.Name = "txtTableTop"
        Me.txtTableTop.Size = New System.Drawing.Size(100, 20)
        Me.txtTableTop.TabIndex = 14
        '
        'lblTableTop
        '
        Me.lblTableTop.AutoEllipsis = True
        Me.lblTableTop.Location = New System.Drawing.Point(6, 36)
        Me.lblTableTop.Name = "lblTableTop"
        Me.lblTableTop.Size = New System.Drawing.Size(87, 20)
        Me.lblTableTop.TabIndex = 13
        Me.lblTableTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTable
        '
        Me.chkTable.AutoSize = True
        Me.chkTable.Checked = True
        Me.chkTable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTable.Location = New System.Drawing.Point(6, 16)
        Me.chkTable.Name = "chkTable"
        Me.chkTable.Size = New System.Drawing.Size(15, 14)
        Me.chkTable.TabIndex = 12
        Me.chkTable.UseVisualStyleBackColor = True
        '
        'fraSet
        '
        Me.fraSet.Controls.Add(Me.cmdSetFont)
        Me.fraSet.Controls.Add(Me.txtSetLeft)
        Me.fraSet.Controls.Add(Me.lblSetLeft)
        Me.fraSet.Controls.Add(Me.txtSetWidth)
        Me.fraSet.Controls.Add(Me.lblSetWidth)
        Me.fraSet.Controls.Add(Me.txtSetHeight)
        Me.fraSet.Controls.Add(Me.lblSetHeight)
        Me.fraSet.Controls.Add(Me.txtSetTop)
        Me.fraSet.Controls.Add(Me.lblSetTop)
        Me.fraSet.Controls.Add(Me.chkSet)
        Me.fraSet.Controls.Add(Me.txtSet)
        Me.fraSet.Location = New System.Drawing.Point(6, 793)
        Me.fraSet.Name = "fraSet"
        Me.fraSet.Size = New System.Drawing.Size(402, 132)
        Me.fraSet.TabIndex = 15
        Me.fraSet.TabStop = False
        '
        'cmdSetFont
        '
        Me.cmdSetFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdSetFont.Name = "cmdSetFont"
        Me.cmdSetFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetFont.TabIndex = 21
        Me.cmdSetFont.Tag = Me.txtSet
        Me.cmdSetFont.UseVisualStyleBackColor = True
        '
        'txtSet
        '
        Me.txtSet.AcceptsReturn = True
        Me.txtSet.Location = New System.Drawing.Point(208, 98)
        Me.txtSet.Multiline = True
        Me.txtSet.Name = "txtSet"
        Me.txtSet.ReadOnly = True
        Me.txtSet.Size = New System.Drawing.Size(84, 20)
        Me.txtSet.TabIndex = 10
        '
        'txtSetLeft
        '
        Me.txtSetLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtSetLeft.Name = "txtSetLeft"
        Me.txtSetLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtSetLeft.TabIndex = 20
        '
        'lblSetLeft
        '
        Me.lblSetLeft.AutoEllipsis = True
        Me.lblSetLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblSetLeft.Name = "lblSetLeft"
        Me.lblSetLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblSetLeft.TabIndex = 19
        Me.lblSetLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSetWidth
        '
        Me.txtSetWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtSetWidth.Name = "txtSetWidth"
        Me.txtSetWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtSetWidth.TabIndex = 18
        '
        'lblSetWidth
        '
        Me.lblSetWidth.AutoEllipsis = True
        Me.lblSetWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblSetWidth.Name = "lblSetWidth"
        Me.lblSetWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblSetWidth.TabIndex = 17
        Me.lblSetWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSetHeight
        '
        Me.txtSetHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtSetHeight.Name = "txtSetHeight"
        Me.txtSetHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtSetHeight.TabIndex = 16
        '
        'lblSetHeight
        '
        Me.lblSetHeight.AutoEllipsis = True
        Me.lblSetHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblSetHeight.Name = "lblSetHeight"
        Me.lblSetHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblSetHeight.TabIndex = 15
        Me.lblSetHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSetTop
        '
        Me.txtSetTop.Location = New System.Drawing.Point(99, 33)
        Me.txtSetTop.Name = "txtSetTop"
        Me.txtSetTop.Size = New System.Drawing.Size(100, 20)
        Me.txtSetTop.TabIndex = 14
        '
        'lblSetTop
        '
        Me.lblSetTop.AutoEllipsis = True
        Me.lblSetTop.Location = New System.Drawing.Point(6, 36)
        Me.lblSetTop.Name = "lblSetTop"
        Me.lblSetTop.Size = New System.Drawing.Size(87, 20)
        Me.lblSetTop.TabIndex = 13
        Me.lblSetTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSet
        '
        Me.chkSet.AutoSize = True
        Me.chkSet.Checked = True
        Me.chkSet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSet.Location = New System.Drawing.Point(6, 16)
        Me.chkSet.Name = "chkSet"
        Me.chkSet.Size = New System.Drawing.Size(15, 14)
        Me.chkSet.TabIndex = 12
        Me.chkSet.UseVisualStyleBackColor = True
        '
        'tabBody
        '
        Me.tabBody.AutoScroll = True
        Me.tabBody.Controls.Add(Me.fraBodyPanel)
        Me.tabBody.Controls.Add(Me.fraQuantityTitle)
        Me.tabBody.Controls.Add(Me.fraQuantity)
        Me.tabBody.Controls.Add(Me.fraDesignationTitle)
        Me.tabBody.Controls.Add(Me.fraDesignation)
        Me.tabBody.Controls.Add(Me.fraTotalTitle)
        Me.tabBody.Controls.Add(Me.fraTotal)
        Me.tabBody.Location = New System.Drawing.Point(4, 22)
        Me.tabBody.Name = "tabBody"
        Me.tabBody.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBody.Size = New System.Drawing.Size(432, 418)
        Me.tabBody.TabIndex = 1
        Me.tabBody.UseVisualStyleBackColor = True
        '
        'fraBodyPanel
        '
        Me.fraBodyPanel.Controls.Add(Me.txtBodyPanelLeft)
        Me.fraBodyPanel.Controls.Add(Me.lblBodyPanelLeft)
        Me.fraBodyPanel.Controls.Add(Me.txtBodyPanelWidth)
        Me.fraBodyPanel.Controls.Add(Me.lblBodyPanelWidth)
        Me.fraBodyPanel.Controls.Add(Me.txtBodyPanelHeight)
        Me.fraBodyPanel.Controls.Add(Me.lblBodyPanelHeight)
        Me.fraBodyPanel.Controls.Add(Me.txtBodyPanelTop)
        Me.fraBodyPanel.Controls.Add(Me.lblBodyPanelTop)
        Me.fraBodyPanel.Controls.Add(Me.chkBodyPanel)
        Me.fraBodyPanel.Location = New System.Drawing.Point(6, 6)
        Me.fraBodyPanel.Name = "fraBodyPanel"
        Me.fraBodyPanel.Size = New System.Drawing.Size(402, 97)
        Me.fraBodyPanel.TabIndex = 16
        Me.fraBodyPanel.TabStop = False
        '
        'txtBodyPanelLeft
        '
        Me.txtBodyPanelLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtBodyPanelLeft.Name = "txtBodyPanelLeft"
        Me.txtBodyPanelLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtBodyPanelLeft.TabIndex = 20
        '
        'lblBodyPanelLeft
        '
        Me.lblBodyPanelLeft.AutoEllipsis = True
        Me.lblBodyPanelLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblBodyPanelLeft.Name = "lblBodyPanelLeft"
        Me.lblBodyPanelLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblBodyPanelLeft.TabIndex = 19
        Me.lblBodyPanelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBodyPanelWidth
        '
        Me.txtBodyPanelWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtBodyPanelWidth.Name = "txtBodyPanelWidth"
        Me.txtBodyPanelWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtBodyPanelWidth.TabIndex = 18
        '
        'lblBodyPanelWidth
        '
        Me.lblBodyPanelWidth.AutoEllipsis = True
        Me.lblBodyPanelWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblBodyPanelWidth.Name = "lblBodyPanelWidth"
        Me.lblBodyPanelWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblBodyPanelWidth.TabIndex = 17
        Me.lblBodyPanelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBodyPanelHeight
        '
        Me.txtBodyPanelHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtBodyPanelHeight.Name = "txtBodyPanelHeight"
        Me.txtBodyPanelHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtBodyPanelHeight.TabIndex = 16
        '
        'lblBodyPanelHeight
        '
        Me.lblBodyPanelHeight.AutoEllipsis = True
        Me.lblBodyPanelHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblBodyPanelHeight.Name = "lblBodyPanelHeight"
        Me.lblBodyPanelHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblBodyPanelHeight.TabIndex = 15
        Me.lblBodyPanelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBodyPanelTop
        '
        Me.txtBodyPanelTop.Location = New System.Drawing.Point(99, 33)
        Me.txtBodyPanelTop.Name = "txtBodyPanelTop"
        Me.txtBodyPanelTop.Size = New System.Drawing.Size(100, 20)
        Me.txtBodyPanelTop.TabIndex = 14
        '
        'lblBodyPanelTop
        '
        Me.lblBodyPanelTop.AutoEllipsis = True
        Me.lblBodyPanelTop.Location = New System.Drawing.Point(6, 36)
        Me.lblBodyPanelTop.Name = "lblBodyPanelTop"
        Me.lblBodyPanelTop.Size = New System.Drawing.Size(87, 20)
        Me.lblBodyPanelTop.TabIndex = 13
        Me.lblBodyPanelTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkBodyPanel
        '
        Me.chkBodyPanel.AutoSize = True
        Me.chkBodyPanel.Checked = True
        Me.chkBodyPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBodyPanel.Location = New System.Drawing.Point(6, 16)
        Me.chkBodyPanel.Name = "chkBodyPanel"
        Me.chkBodyPanel.Size = New System.Drawing.Size(15, 14)
        Me.chkBodyPanel.TabIndex = 12
        Me.chkBodyPanel.UseVisualStyleBackColor = True
        '
        'fraQuantityTitle
        '
        Me.fraQuantityTitle.Controls.Add(Me.cmdQuantityTitleFont)
        Me.fraQuantityTitle.Controls.Add(Me.txtQuantityTitleLeft)
        Me.fraQuantityTitle.Controls.Add(Me.lblQuantityTitleLeft)
        Me.fraQuantityTitle.Controls.Add(Me.txtQuantityTitleWidth)
        Me.fraQuantityTitle.Controls.Add(Me.lblQuantityTitleWidth)
        Me.fraQuantityTitle.Controls.Add(Me.txtQuantityTitleHeight)
        Me.fraQuantityTitle.Controls.Add(Me.lblQuantityTitleHeight)
        Me.fraQuantityTitle.Controls.Add(Me.txtQuantityTitleTop)
        Me.fraQuantityTitle.Controls.Add(Me.lblQuantityTitleTop)
        Me.fraQuantityTitle.Controls.Add(Me.chkQuantityTitle)
        Me.fraQuantityTitle.Controls.Add(Me.txtQuantityTitle)
        Me.fraQuantityTitle.Location = New System.Drawing.Point(6, 109)
        Me.fraQuantityTitle.Name = "fraQuantityTitle"
        Me.fraQuantityTitle.Size = New System.Drawing.Size(402, 132)
        Me.fraQuantityTitle.TabIndex = 15
        Me.fraQuantityTitle.TabStop = False
        '
        'cmdQuantityTitleFont
        '
        Me.cmdQuantityTitleFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdQuantityTitleFont.Name = "cmdQuantityTitleFont"
        Me.cmdQuantityTitleFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuantityTitleFont.TabIndex = 21
        Me.cmdQuantityTitleFont.Tag = Me.txtQuantityTitle
        Me.cmdQuantityTitleFont.UseVisualStyleBackColor = True
        '
        'txtQuantityTitle
        '
        Me.txtQuantityTitle.AcceptsReturn = True
        Me.txtQuantityTitle.Location = New System.Drawing.Point(208, 98)
        Me.txtQuantityTitle.Multiline = True
        Me.txtQuantityTitle.Name = "txtQuantityTitle"
        Me.txtQuantityTitle.ReadOnly = True
        Me.txtQuantityTitle.Size = New System.Drawing.Size(84, 20)
        Me.txtQuantityTitle.TabIndex = 10
        '
        'txtQuantityTitleLeft
        '
        Me.txtQuantityTitleLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtQuantityTitleLeft.Name = "txtQuantityTitleLeft"
        Me.txtQuantityTitleLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityTitleLeft.TabIndex = 20
        '
        'lblQuantityTitleLeft
        '
        Me.lblQuantityTitleLeft.AutoEllipsis = True
        Me.lblQuantityTitleLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblQuantityTitleLeft.Name = "lblQuantityTitleLeft"
        Me.lblQuantityTitleLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityTitleLeft.TabIndex = 19
        Me.lblQuantityTitleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantityTitleWidth
        '
        Me.txtQuantityTitleWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtQuantityTitleWidth.Name = "txtQuantityTitleWidth"
        Me.txtQuantityTitleWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityTitleWidth.TabIndex = 18
        '
        'lblQuantityTitleWidth
        '
        Me.lblQuantityTitleWidth.AutoEllipsis = True
        Me.lblQuantityTitleWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblQuantityTitleWidth.Name = "lblQuantityTitleWidth"
        Me.lblQuantityTitleWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityTitleWidth.TabIndex = 17
        Me.lblQuantityTitleWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantityTitleHeight
        '
        Me.txtQuantityTitleHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtQuantityTitleHeight.Name = "txtQuantityTitleHeight"
        Me.txtQuantityTitleHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityTitleHeight.TabIndex = 16
        '
        'lblQuantityTitleHeight
        '
        Me.lblQuantityTitleHeight.AutoEllipsis = True
        Me.lblQuantityTitleHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblQuantityTitleHeight.Name = "lblQuantityTitleHeight"
        Me.lblQuantityTitleHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityTitleHeight.TabIndex = 15
        Me.lblQuantityTitleHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantityTitleTop
        '
        Me.txtQuantityTitleTop.Location = New System.Drawing.Point(99, 33)
        Me.txtQuantityTitleTop.Name = "txtQuantityTitleTop"
        Me.txtQuantityTitleTop.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityTitleTop.TabIndex = 14
        '
        'lblQuantityTitleTop
        '
        Me.lblQuantityTitleTop.AutoEllipsis = True
        Me.lblQuantityTitleTop.Location = New System.Drawing.Point(6, 36)
        Me.lblQuantityTitleTop.Name = "lblQuantityTitleTop"
        Me.lblQuantityTitleTop.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityTitleTop.TabIndex = 13
        Me.lblQuantityTitleTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkQuantityTitle
        '
        Me.chkQuantityTitle.AutoSize = True
        Me.chkQuantityTitle.Checked = True
        Me.chkQuantityTitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuantityTitle.Location = New System.Drawing.Point(6, 16)
        Me.chkQuantityTitle.Name = "chkQuantityTitle"
        Me.chkQuantityTitle.Size = New System.Drawing.Size(15, 14)
        Me.chkQuantityTitle.TabIndex = 12
        Me.chkQuantityTitle.UseVisualStyleBackColor = True
        '
        'fraQuantity
        '
        Me.fraQuantity.Controls.Add(Me.cmdQuantityFont)
        Me.fraQuantity.Controls.Add(Me.txtQuantityLeft)
        Me.fraQuantity.Controls.Add(Me.lblQuantityLeft)
        Me.fraQuantity.Controls.Add(Me.txtQuantityWidth)
        Me.fraQuantity.Controls.Add(Me.lblQuantityWidth)
        Me.fraQuantity.Controls.Add(Me.txtQuantityHeight)
        Me.fraQuantity.Controls.Add(Me.lblQuantityHeight)
        Me.fraQuantity.Controls.Add(Me.txtQuantityTop)
        Me.fraQuantity.Controls.Add(Me.lblQuantityTop)
        Me.fraQuantity.Controls.Add(Me.chkQuantity)
        Me.fraQuantity.Controls.Add(Me.txtQuantity)
        Me.fraQuantity.Location = New System.Drawing.Point(6, 247)
        Me.fraQuantity.Name = "fraQuantity"
        Me.fraQuantity.Size = New System.Drawing.Size(402, 132)
        Me.fraQuantity.TabIndex = 15
        Me.fraQuantity.TabStop = False
        '
        'cmdQuantityFont
        '
        Me.cmdQuantityFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdQuantityFont.Name = "cmdQuantityFont"
        Me.cmdQuantityFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuantityFont.TabIndex = 21
        Me.cmdQuantityFont.Tag = Me.txtQuantity
        Me.cmdQuantityFont.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.AcceptsReturn = True
        Me.txtQuantity.Location = New System.Drawing.Point(208, 98)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(84, 20)
        Me.txtQuantity.TabIndex = 10
        '
        'txtQuantityLeft
        '
        Me.txtQuantityLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtQuantityLeft.Name = "txtQuantityLeft"
        Me.txtQuantityLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityLeft.TabIndex = 20
        '
        'lblQuantityLeft
        '
        Me.lblQuantityLeft.AutoEllipsis = True
        Me.lblQuantityLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblQuantityLeft.Name = "lblQuantityLeft"
        Me.lblQuantityLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityLeft.TabIndex = 19
        Me.lblQuantityLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantityWidth
        '
        Me.txtQuantityWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtQuantityWidth.Name = "txtQuantityWidth"
        Me.txtQuantityWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityWidth.TabIndex = 18
        '
        'lblQuantityWidth
        '
        Me.lblQuantityWidth.AutoEllipsis = True
        Me.lblQuantityWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblQuantityWidth.Name = "lblQuantityWidth"
        Me.lblQuantityWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityWidth.TabIndex = 17
        Me.lblQuantityWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantityHeight
        '
        Me.txtQuantityHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtQuantityHeight.Name = "txtQuantityHeight"
        Me.txtQuantityHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityHeight.TabIndex = 16
        '
        'lblQuantityHeight
        '
        Me.lblQuantityHeight.AutoEllipsis = True
        Me.lblQuantityHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblQuantityHeight.Name = "lblQuantityHeight"
        Me.lblQuantityHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityHeight.TabIndex = 15
        Me.lblQuantityHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantityTop
        '
        Me.txtQuantityTop.Location = New System.Drawing.Point(99, 33)
        Me.txtQuantityTop.Name = "txtQuantityTop"
        Me.txtQuantityTop.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityTop.TabIndex = 14
        '
        'lblQuantityTop
        '
        Me.lblQuantityTop.AutoEllipsis = True
        Me.lblQuantityTop.Location = New System.Drawing.Point(6, 36)
        Me.lblQuantityTop.Name = "lblQuantityTop"
        Me.lblQuantityTop.Size = New System.Drawing.Size(87, 20)
        Me.lblQuantityTop.TabIndex = 13
        Me.lblQuantityTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkQuantity
        '
        Me.chkQuantity.AutoSize = True
        Me.chkQuantity.Checked = True
        Me.chkQuantity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuantity.Location = New System.Drawing.Point(6, 16)
        Me.chkQuantity.Name = "chkQuantity"
        Me.chkQuantity.Size = New System.Drawing.Size(15, 14)
        Me.chkQuantity.TabIndex = 12
        Me.chkQuantity.UseVisualStyleBackColor = True
        '
        'fraDesignationTitle
        '
        Me.fraDesignationTitle.Controls.Add(Me.cmdDesignationTitleFont)
        Me.fraDesignationTitle.Controls.Add(Me.txtDesignationTitleLeft)
        Me.fraDesignationTitle.Controls.Add(Me.lblDesignationTitleLeft)
        Me.fraDesignationTitle.Controls.Add(Me.txtDesignationTitleWidth)
        Me.fraDesignationTitle.Controls.Add(Me.lblDesignationTitleWidth)
        Me.fraDesignationTitle.Controls.Add(Me.txtDesignationTitleHeight)
        Me.fraDesignationTitle.Controls.Add(Me.lblDesignationTitleHeight)
        Me.fraDesignationTitle.Controls.Add(Me.txtDesignationTitleTop)
        Me.fraDesignationTitle.Controls.Add(Me.lblDesignationTitleTop)
        Me.fraDesignationTitle.Controls.Add(Me.chkDesignationTitle)
        Me.fraDesignationTitle.Controls.Add(Me.txtDesignationTitle)
        Me.fraDesignationTitle.Location = New System.Drawing.Point(6, 385)
        Me.fraDesignationTitle.Name = "fraDesignationTitle"
        Me.fraDesignationTitle.Size = New System.Drawing.Size(402, 132)
        Me.fraDesignationTitle.TabIndex = 15
        Me.fraDesignationTitle.TabStop = False
        '
        'cmdDesignationTitleFont
        '
        Me.cmdDesignationTitleFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdDesignationTitleFont.Name = "cmdDesignationTitleFont"
        Me.cmdDesignationTitleFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdDesignationTitleFont.TabIndex = 21
        Me.cmdDesignationTitleFont.Tag = Me.txtDesignationTitle
        Me.cmdDesignationTitleFont.UseVisualStyleBackColor = True
        '
        'txtDesignationTitle
        '
        Me.txtDesignationTitle.AcceptsReturn = True
        Me.txtDesignationTitle.Location = New System.Drawing.Point(208, 98)
        Me.txtDesignationTitle.Multiline = True
        Me.txtDesignationTitle.Name = "txtDesignationTitle"
        Me.txtDesignationTitle.ReadOnly = True
        Me.txtDesignationTitle.Size = New System.Drawing.Size(84, 20)
        Me.txtDesignationTitle.TabIndex = 10
        '
        'txtDesignationTitleLeft
        '
        Me.txtDesignationTitleLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtDesignationTitleLeft.Name = "txtDesignationTitleLeft"
        Me.txtDesignationTitleLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationTitleLeft.TabIndex = 20
        '
        'lblDesignationTitleLeft
        '
        Me.lblDesignationTitleLeft.AutoEllipsis = True
        Me.lblDesignationTitleLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblDesignationTitleLeft.Name = "lblDesignationTitleLeft"
        Me.lblDesignationTitleLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationTitleLeft.TabIndex = 19
        Me.lblDesignationTitleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesignationTitleWidth
        '
        Me.txtDesignationTitleWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtDesignationTitleWidth.Name = "txtDesignationTitleWidth"
        Me.txtDesignationTitleWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationTitleWidth.TabIndex = 18
        '
        'lblDesignationTitleWidth
        '
        Me.lblDesignationTitleWidth.AutoEllipsis = True
        Me.lblDesignationTitleWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblDesignationTitleWidth.Name = "lblDesignationTitleWidth"
        Me.lblDesignationTitleWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationTitleWidth.TabIndex = 17
        Me.lblDesignationTitleWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesignationTitleHeight
        '
        Me.txtDesignationTitleHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtDesignationTitleHeight.Name = "txtDesignationTitleHeight"
        Me.txtDesignationTitleHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationTitleHeight.TabIndex = 16
        '
        'lblDesignationTitleHeight
        '
        Me.lblDesignationTitleHeight.AutoEllipsis = True
        Me.lblDesignationTitleHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblDesignationTitleHeight.Name = "lblDesignationTitleHeight"
        Me.lblDesignationTitleHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationTitleHeight.TabIndex = 15
        Me.lblDesignationTitleHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesignationTitleTop
        '
        Me.txtDesignationTitleTop.Location = New System.Drawing.Point(99, 33)
        Me.txtDesignationTitleTop.Name = "txtDesignationTitleTop"
        Me.txtDesignationTitleTop.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationTitleTop.TabIndex = 14
        '
        'lblDesignationTitleTop
        '
        Me.lblDesignationTitleTop.AutoEllipsis = True
        Me.lblDesignationTitleTop.Location = New System.Drawing.Point(6, 36)
        Me.lblDesignationTitleTop.Name = "lblDesignationTitleTop"
        Me.lblDesignationTitleTop.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationTitleTop.TabIndex = 13
        Me.lblDesignationTitleTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDesignationTitle
        '
        Me.chkDesignationTitle.AutoSize = True
        Me.chkDesignationTitle.Checked = True
        Me.chkDesignationTitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDesignationTitle.Location = New System.Drawing.Point(6, 16)
        Me.chkDesignationTitle.Name = "chkDesignationTitle"
        Me.chkDesignationTitle.Size = New System.Drawing.Size(15, 14)
        Me.chkDesignationTitle.TabIndex = 12
        Me.chkDesignationTitle.UseVisualStyleBackColor = True
        '
        'fraDesignation
        '
        Me.fraDesignation.Controls.Add(Me.cmdDesignationFont)
        Me.fraDesignation.Controls.Add(Me.txtDesignationLeft)
        Me.fraDesignation.Controls.Add(Me.lblDesignationLeft)
        Me.fraDesignation.Controls.Add(Me.txtDesignationWidth)
        Me.fraDesignation.Controls.Add(Me.lblDesignationWidth)
        Me.fraDesignation.Controls.Add(Me.txtDesignationHeight)
        Me.fraDesignation.Controls.Add(Me.lblDesignationHeight)
        Me.fraDesignation.Controls.Add(Me.txtDesignationTop)
        Me.fraDesignation.Controls.Add(Me.lblDesignationTop)
        Me.fraDesignation.Controls.Add(Me.chkDesignation)
        Me.fraDesignation.Controls.Add(Me.txtDesignation)
        Me.fraDesignation.Location = New System.Drawing.Point(6, 523)
        Me.fraDesignation.Name = "fraDesignation"
        Me.fraDesignation.Size = New System.Drawing.Size(402, 132)
        Me.fraDesignation.TabIndex = 15
        Me.fraDesignation.TabStop = False
        '
        'cmdDesignationFont
        '
        Me.cmdDesignationFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdDesignationFont.Name = "cmdDesignationFont"
        Me.cmdDesignationFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdDesignationFont.TabIndex = 21
        Me.cmdDesignationFont.Tag = Me.txtDesignation
        Me.cmdDesignationFont.UseVisualStyleBackColor = True
        '
        'txtDesignation
        '
        Me.txtDesignation.AcceptsReturn = True
        Me.txtDesignation.Location = New System.Drawing.Point(208, 98)
        Me.txtDesignation.Multiline = True
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(84, 20)
        Me.txtDesignation.TabIndex = 10
        '
        'txtDesignationLeft
        '
        Me.txtDesignationLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtDesignationLeft.Name = "txtDesignationLeft"
        Me.txtDesignationLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationLeft.TabIndex = 20
        '
        'lblDesignationLeft
        '
        Me.lblDesignationLeft.AutoEllipsis = True
        Me.lblDesignationLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblDesignationLeft.Name = "lblDesignationLeft"
        Me.lblDesignationLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationLeft.TabIndex = 19
        Me.lblDesignationLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesignationWidth
        '
        Me.txtDesignationWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtDesignationWidth.Name = "txtDesignationWidth"
        Me.txtDesignationWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationWidth.TabIndex = 18
        '
        'lblDesignationWidth
        '
        Me.lblDesignationWidth.AutoEllipsis = True
        Me.lblDesignationWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblDesignationWidth.Name = "lblDesignationWidth"
        Me.lblDesignationWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationWidth.TabIndex = 17
        Me.lblDesignationWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesignationHeight
        '
        Me.txtDesignationHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtDesignationHeight.Name = "txtDesignationHeight"
        Me.txtDesignationHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationHeight.TabIndex = 16
        '
        'lblDesignationHeight
        '
        Me.lblDesignationHeight.AutoEllipsis = True
        Me.lblDesignationHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblDesignationHeight.Name = "lblDesignationHeight"
        Me.lblDesignationHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationHeight.TabIndex = 15
        Me.lblDesignationHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesignationTop
        '
        Me.txtDesignationTop.Location = New System.Drawing.Point(99, 33)
        Me.txtDesignationTop.Name = "txtDesignationTop"
        Me.txtDesignationTop.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignationTop.TabIndex = 14
        '
        'lblDesignationTop
        '
        Me.lblDesignationTop.AutoEllipsis = True
        Me.lblDesignationTop.Location = New System.Drawing.Point(6, 36)
        Me.lblDesignationTop.Name = "lblDesignationTop"
        Me.lblDesignationTop.Size = New System.Drawing.Size(87, 20)
        Me.lblDesignationTop.TabIndex = 13
        Me.lblDesignationTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDesignation
        '
        Me.chkDesignation.AutoSize = True
        Me.chkDesignation.Checked = True
        Me.chkDesignation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDesignation.Location = New System.Drawing.Point(6, 16)
        Me.chkDesignation.Name = "chkDesignation"
        Me.chkDesignation.Size = New System.Drawing.Size(15, 14)
        Me.chkDesignation.TabIndex = 12
        Me.chkDesignation.UseVisualStyleBackColor = True
        '
        'fraTotalTitle
        '
        Me.fraTotalTitle.Controls.Add(Me.cmdTotalTitleFont)
        Me.fraTotalTitle.Controls.Add(Me.txtTotalTitleLeft)
        Me.fraTotalTitle.Controls.Add(Me.lblTotalTitleLeft)
        Me.fraTotalTitle.Controls.Add(Me.txtTotalTitleWidth)
        Me.fraTotalTitle.Controls.Add(Me.lblTotalTitleWidth)
        Me.fraTotalTitle.Controls.Add(Me.txtTotalTitleHeight)
        Me.fraTotalTitle.Controls.Add(Me.lblTotalTitleHeight)
        Me.fraTotalTitle.Controls.Add(Me.txtTotalTitleTop)
        Me.fraTotalTitle.Controls.Add(Me.lblTotalTitleTop)
        Me.fraTotalTitle.Controls.Add(Me.chkTotalTitle)
        Me.fraTotalTitle.Controls.Add(Me.txtTotalTitle)
        Me.fraTotalTitle.Location = New System.Drawing.Point(6, 661)
        Me.fraTotalTitle.Name = "fraTotalTitle"
        Me.fraTotalTitle.Size = New System.Drawing.Size(402, 132)
        Me.fraTotalTitle.TabIndex = 15
        Me.fraTotalTitle.TabStop = False
        '
        'cmdTotalTitleFont
        '
        Me.cmdTotalTitleFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdTotalTitleFont.Name = "cmdTotalTitleFont"
        Me.cmdTotalTitleFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdTotalTitleFont.TabIndex = 21
        Me.cmdTotalTitleFont.Tag = Me.txtTotalTitle
        Me.cmdTotalTitleFont.UseVisualStyleBackColor = True
        '
        'txtTotalTitle
        '
        Me.txtTotalTitle.AcceptsReturn = True
        Me.txtTotalTitle.Location = New System.Drawing.Point(208, 98)
        Me.txtTotalTitle.Multiline = True
        Me.txtTotalTitle.Name = "txtTotalTitle"
        Me.txtTotalTitle.ReadOnly = True
        Me.txtTotalTitle.Size = New System.Drawing.Size(84, 20)
        Me.txtTotalTitle.TabIndex = 10
        '
        'txtTotalTitleLeft
        '
        Me.txtTotalTitleLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtTotalTitleLeft.Name = "txtTotalTitleLeft"
        Me.txtTotalTitleLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTitleLeft.TabIndex = 20
        '
        'lblTotalTitleLeft
        '
        Me.lblTotalTitleLeft.AutoEllipsis = True
        Me.lblTotalTitleLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblTotalTitleLeft.Name = "lblTotalTitleLeft"
        Me.lblTotalTitleLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalTitleLeft.TabIndex = 19
        Me.lblTotalTitleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalTitleWidth
        '
        Me.txtTotalTitleWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtTotalTitleWidth.Name = "txtTotalTitleWidth"
        Me.txtTotalTitleWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTitleWidth.TabIndex = 18
        '
        'lblTotalTitleWidth
        '
        Me.lblTotalTitleWidth.AutoEllipsis = True
        Me.lblTotalTitleWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblTotalTitleWidth.Name = "lblTotalTitleWidth"
        Me.lblTotalTitleWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalTitleWidth.TabIndex = 17
        Me.lblTotalTitleWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalTitleHeight
        '
        Me.txtTotalTitleHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtTotalTitleHeight.Name = "txtTotalTitleHeight"
        Me.txtTotalTitleHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTitleHeight.TabIndex = 16
        '
        'lblTotalTitleHeight
        '
        Me.lblTotalTitleHeight.AutoEllipsis = True
        Me.lblTotalTitleHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblTotalTitleHeight.Name = "lblTotalTitleHeight"
        Me.lblTotalTitleHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalTitleHeight.TabIndex = 15
        Me.lblTotalTitleHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalTitleTop
        '
        Me.txtTotalTitleTop.Location = New System.Drawing.Point(99, 33)
        Me.txtTotalTitleTop.Name = "txtTotalTitleTop"
        Me.txtTotalTitleTop.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTitleTop.TabIndex = 14
        '
        'lblTotalTitleTop
        '
        Me.lblTotalTitleTop.AutoEllipsis = True
        Me.lblTotalTitleTop.Location = New System.Drawing.Point(6, 36)
        Me.lblTotalTitleTop.Name = "lblTotalTitleTop"
        Me.lblTotalTitleTop.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalTitleTop.TabIndex = 13
        Me.lblTotalTitleTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTotalTitle
        '
        Me.chkTotalTitle.AutoSize = True
        Me.chkTotalTitle.Checked = True
        Me.chkTotalTitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTotalTitle.Location = New System.Drawing.Point(6, 16)
        Me.chkTotalTitle.Name = "chkTotalTitle"
        Me.chkTotalTitle.Size = New System.Drawing.Size(15, 14)
        Me.chkTotalTitle.TabIndex = 12
        Me.chkTotalTitle.UseVisualStyleBackColor = True
        '
        'fraTotal
        '
        Me.fraTotal.Controls.Add(Me.cmdTotalFont)
        Me.fraTotal.Controls.Add(Me.txtTotalLeft)
        Me.fraTotal.Controls.Add(Me.lblTotalLeft)
        Me.fraTotal.Controls.Add(Me.txtTotalWidth)
        Me.fraTotal.Controls.Add(Me.lblTotalWidth)
        Me.fraTotal.Controls.Add(Me.txtTotalHeight)
        Me.fraTotal.Controls.Add(Me.lblTotalHeight)
        Me.fraTotal.Controls.Add(Me.txtTotalTop)
        Me.fraTotal.Controls.Add(Me.lblTotalTop)
        Me.fraTotal.Controls.Add(Me.chkTotal)
        Me.fraTotal.Controls.Add(Me.txtTotal)
        Me.fraTotal.Location = New System.Drawing.Point(6, 799)
        Me.fraTotal.Name = "fraTotal"
        Me.fraTotal.Size = New System.Drawing.Size(402, 132)
        Me.fraTotal.TabIndex = 15
        Me.fraTotal.TabStop = False
        '
        'cmdTotalFont
        '
        Me.cmdTotalFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdTotalFont.Name = "cmdTotalFont"
        Me.cmdTotalFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdTotalFont.TabIndex = 21
        Me.cmdTotalFont.Tag = Me.txtTotal
        Me.cmdTotalFont.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.AcceptsReturn = True
        Me.txtTotal.Location = New System.Drawing.Point(208, 98)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(84, 20)
        Me.txtTotal.TabIndex = 10
        '
        'txtTotalLeft
        '
        Me.txtTotalLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtTotalLeft.Name = "txtTotalLeft"
        Me.txtTotalLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalLeft.TabIndex = 20
        '
        'lblTotalLeft
        '
        Me.lblTotalLeft.AutoEllipsis = True
        Me.lblTotalLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblTotalLeft.Name = "lblTotalLeft"
        Me.lblTotalLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalLeft.TabIndex = 19
        Me.lblTotalLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalWidth
        '
        Me.txtTotalWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtTotalWidth.Name = "txtTotalWidth"
        Me.txtTotalWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalWidth.TabIndex = 18
        '
        'lblTotalWidth
        '
        Me.lblTotalWidth.AutoEllipsis = True
        Me.lblTotalWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblTotalWidth.Name = "lblTotalWidth"
        Me.lblTotalWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalWidth.TabIndex = 17
        Me.lblTotalWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalHeight
        '
        Me.txtTotalHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtTotalHeight.Name = "txtTotalHeight"
        Me.txtTotalHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalHeight.TabIndex = 16
        '
        'lblTotalHeight
        '
        Me.lblTotalHeight.AutoEllipsis = True
        Me.lblTotalHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblTotalHeight.Name = "lblTotalHeight"
        Me.lblTotalHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalHeight.TabIndex = 15
        Me.lblTotalHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalTop
        '
        Me.txtTotalTop.Location = New System.Drawing.Point(99, 33)
        Me.txtTotalTop.Name = "txtTotalTop"
        Me.txtTotalTop.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTop.TabIndex = 14
        '
        'lblTotalTop
        '
        Me.lblTotalTop.AutoEllipsis = True
        Me.lblTotalTop.Location = New System.Drawing.Point(6, 36)
        Me.lblTotalTop.Name = "lblTotalTop"
        Me.lblTotalTop.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalTop.TabIndex = 13
        Me.lblTotalTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTotal
        '
        Me.chkTotal.AutoSize = True
        Me.chkTotal.Checked = True
        Me.chkTotal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTotal.Location = New System.Drawing.Point(6, 16)
        Me.chkTotal.Name = "chkTotal"
        Me.chkTotal.Size = New System.Drawing.Size(15, 14)
        Me.chkTotal.TabIndex = 12
        Me.chkTotal.UseVisualStyleBackColor = True
        '
        'tabFooter
        '
        Me.tabFooter.AutoScroll = True
        Me.tabFooter.Controls.Add(Me.fraFooterPanel)
        Me.tabFooter.Controls.Add(Me.fraSubAmountText)
        Me.tabFooter.Controls.Add(Me.fraSubAmount)
        Me.tabFooter.Controls.Add(Me.fraDiscountText)
        Me.tabFooter.Controls.Add(Me.fraDiscount)
        Me.tabFooter.Controls.Add(Me.fraAmountText)
        Me.tabFooter.Controls.Add(Me.fraAmount)
        Me.tabFooter.Controls.Add(Me.fraTvaText)
        Me.tabFooter.Controls.Add(Me.fraTva)
        Me.tabFooter.Controls.Add(Me.fraFooter)
        Me.tabFooter.Location = New System.Drawing.Point(4, 22)
        Me.tabFooter.Name = "tabFooter"
        Me.tabFooter.Size = New System.Drawing.Size(432, 418)
        Me.tabFooter.TabIndex = 2
        Me.tabFooter.UseVisualStyleBackColor = True
        '
        'fraFooterPanel
        '
        Me.fraFooterPanel.Controls.Add(Me.txtFooterPanelLeft)
        Me.fraFooterPanel.Controls.Add(Me.lblFooterPanelLeft)
        Me.fraFooterPanel.Controls.Add(Me.txtFooterPanelWidth)
        Me.fraFooterPanel.Controls.Add(Me.lblFooterPanelWidth)
        Me.fraFooterPanel.Controls.Add(Me.txtFooterPanelHeight)
        Me.fraFooterPanel.Controls.Add(Me.lblFooterPanelHeight)
        Me.fraFooterPanel.Controls.Add(Me.txtFooterPanelTop)
        Me.fraFooterPanel.Controls.Add(Me.lblFooterPanelTop)
        Me.fraFooterPanel.Controls.Add(Me.chkFooterPanel)
        Me.fraFooterPanel.Location = New System.Drawing.Point(6, 6)
        Me.fraFooterPanel.Name = "fraFooterPanel"
        Me.fraFooterPanel.Size = New System.Drawing.Size(402, 97)
        Me.fraFooterPanel.TabIndex = 16
        Me.fraFooterPanel.TabStop = False
        '
        'txtFooterPanelLeft
        '
        Me.txtFooterPanelLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtFooterPanelLeft.Name = "txtFooterPanelLeft"
        Me.txtFooterPanelLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterPanelLeft.TabIndex = 20
        '
        'lblFooterPanelLeft
        '
        Me.lblFooterPanelLeft.AutoEllipsis = True
        Me.lblFooterPanelLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblFooterPanelLeft.Name = "lblFooterPanelLeft"
        Me.lblFooterPanelLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterPanelLeft.TabIndex = 19
        Me.lblFooterPanelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFooterPanelWidth
        '
        Me.txtFooterPanelWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtFooterPanelWidth.Name = "txtFooterPanelWidth"
        Me.txtFooterPanelWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterPanelWidth.TabIndex = 18
        '
        'lblFooterPanelWidth
        '
        Me.lblFooterPanelWidth.AutoEllipsis = True
        Me.lblFooterPanelWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblFooterPanelWidth.Name = "lblFooterPanelWidth"
        Me.lblFooterPanelWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterPanelWidth.TabIndex = 17
        Me.lblFooterPanelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFooterPanelHeight
        '
        Me.txtFooterPanelHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtFooterPanelHeight.Name = "txtFooterPanelHeight"
        Me.txtFooterPanelHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterPanelHeight.TabIndex = 16
        '
        'lblFooterPanelHeight
        '
        Me.lblFooterPanelHeight.AutoEllipsis = True
        Me.lblFooterPanelHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblFooterPanelHeight.Name = "lblFooterPanelHeight"
        Me.lblFooterPanelHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterPanelHeight.TabIndex = 15
        Me.lblFooterPanelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFooterPanelTop
        '
        Me.txtFooterPanelTop.Location = New System.Drawing.Point(99, 33)
        Me.txtFooterPanelTop.Name = "txtFooterPanelTop"
        Me.txtFooterPanelTop.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterPanelTop.TabIndex = 14
        '
        'lblFooterPanelTop
        '
        Me.lblFooterPanelTop.AutoEllipsis = True
        Me.lblFooterPanelTop.Location = New System.Drawing.Point(6, 36)
        Me.lblFooterPanelTop.Name = "lblFooterPanelTop"
        Me.lblFooterPanelTop.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterPanelTop.TabIndex = 13
        Me.lblFooterPanelTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkFooterPanel
        '
        Me.chkFooterPanel.AutoSize = True
        Me.chkFooterPanel.Checked = True
        Me.chkFooterPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFooterPanel.Location = New System.Drawing.Point(6, 16)
        Me.chkFooterPanel.Name = "chkFooterPanel"
        Me.chkFooterPanel.Size = New System.Drawing.Size(15, 14)
        Me.chkFooterPanel.TabIndex = 12
        Me.chkFooterPanel.UseVisualStyleBackColor = True
        '
        'fraSubAmountText
        '
        Me.fraSubAmountText.Controls.Add(Me.cmdSubAmountTextFont)
        Me.fraSubAmountText.Controls.Add(Me.txtSubAmountTextLeft)
        Me.fraSubAmountText.Controls.Add(Me.lblSubAmountTextLeft)
        Me.fraSubAmountText.Controls.Add(Me.txtSubAmountTextWidth)
        Me.fraSubAmountText.Controls.Add(Me.lblSubAmountTextWidth)
        Me.fraSubAmountText.Controls.Add(Me.txtSubAmountTextHeight)
        Me.fraSubAmountText.Controls.Add(Me.lblSubAmountTextHeight)
        Me.fraSubAmountText.Controls.Add(Me.txtSubAmountTextTop)
        Me.fraSubAmountText.Controls.Add(Me.lblSubAmountTextTop)
        Me.fraSubAmountText.Controls.Add(Me.chkSubAmountText)
        Me.fraSubAmountText.Controls.Add(Me.txtSubAmountText)
        Me.fraSubAmountText.Location = New System.Drawing.Point(6, 109)
        Me.fraSubAmountText.Name = "fraSubAmountText"
        Me.fraSubAmountText.Size = New System.Drawing.Size(402, 132)
        Me.fraSubAmountText.TabIndex = 15
        Me.fraSubAmountText.TabStop = False
        '
        'cmdSubAmountTextFont
        '
        Me.cmdSubAmountTextFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdSubAmountTextFont.Name = "cmdSubAmountTextFont"
        Me.cmdSubAmountTextFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubAmountTextFont.TabIndex = 21
        Me.cmdSubAmountTextFont.Tag = Me.txtSubAmountText
        Me.cmdSubAmountTextFont.UseVisualStyleBackColor = True
        '
        'txtSubAmountText
        '
        Me.txtSubAmountText.AcceptsReturn = True
        Me.txtSubAmountText.Location = New System.Drawing.Point(208, 98)
        Me.txtSubAmountText.Multiline = True
        Me.txtSubAmountText.Name = "txtSubAmountText"
        Me.txtSubAmountText.ReadOnly = True
        Me.txtSubAmountText.Size = New System.Drawing.Size(84, 20)
        Me.txtSubAmountText.TabIndex = 10
        '
        'txtSubAmountTextLeft
        '
        Me.txtSubAmountTextLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtSubAmountTextLeft.Name = "txtSubAmountTextLeft"
        Me.txtSubAmountTextLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountTextLeft.TabIndex = 20
        '
        'lblSubAmountTextLeft
        '
        Me.lblSubAmountTextLeft.AutoEllipsis = True
        Me.lblSubAmountTextLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblSubAmountTextLeft.Name = "lblSubAmountTextLeft"
        Me.lblSubAmountTextLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountTextLeft.TabIndex = 19
        Me.lblSubAmountTextLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubAmountTextWidth
        '
        Me.txtSubAmountTextWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtSubAmountTextWidth.Name = "txtSubAmountTextWidth"
        Me.txtSubAmountTextWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountTextWidth.TabIndex = 18
        '
        'lblSubAmountTextWidth
        '
        Me.lblSubAmountTextWidth.AutoEllipsis = True
        Me.lblSubAmountTextWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblSubAmountTextWidth.Name = "lblSubAmountTextWidth"
        Me.lblSubAmountTextWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountTextWidth.TabIndex = 17
        Me.lblSubAmountTextWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubAmountTextHeight
        '
        Me.txtSubAmountTextHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtSubAmountTextHeight.Name = "txtSubAmountTextHeight"
        Me.txtSubAmountTextHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountTextHeight.TabIndex = 16
        '
        'lblSubAmountTextHeight
        '
        Me.lblSubAmountTextHeight.AutoEllipsis = True
        Me.lblSubAmountTextHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblSubAmountTextHeight.Name = "lblSubAmountTextHeight"
        Me.lblSubAmountTextHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountTextHeight.TabIndex = 15
        Me.lblSubAmountTextHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubAmountTextTop
        '
        Me.txtSubAmountTextTop.Location = New System.Drawing.Point(99, 33)
        Me.txtSubAmountTextTop.Name = "txtSubAmountTextTop"
        Me.txtSubAmountTextTop.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountTextTop.TabIndex = 14
        '
        'lblSubAmountTextTop
        '
        Me.lblSubAmountTextTop.AutoEllipsis = True
        Me.lblSubAmountTextTop.Location = New System.Drawing.Point(6, 36)
        Me.lblSubAmountTextTop.Name = "lblSubAmountTextTop"
        Me.lblSubAmountTextTop.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountTextTop.TabIndex = 13
        Me.lblSubAmountTextTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSubAmountText
        '
        Me.chkSubAmountText.AutoSize = True
        Me.chkSubAmountText.Checked = True
        Me.chkSubAmountText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSubAmountText.Location = New System.Drawing.Point(6, 16)
        Me.chkSubAmountText.Name = "chkSubAmountText"
        Me.chkSubAmountText.Size = New System.Drawing.Size(15, 14)
        Me.chkSubAmountText.TabIndex = 12
        Me.chkSubAmountText.UseVisualStyleBackColor = True
        '
        'fraSubAmount
        '
        Me.fraSubAmount.Controls.Add(Me.cmdSubAmountFont)
        Me.fraSubAmount.Controls.Add(Me.txtSubAmountLeft)
        Me.fraSubAmount.Controls.Add(Me.lblSubAmountLeft)
        Me.fraSubAmount.Controls.Add(Me.txtSubAmountWidth)
        Me.fraSubAmount.Controls.Add(Me.lblSubAmountWidth)
        Me.fraSubAmount.Controls.Add(Me.txtSubAmountHeight)
        Me.fraSubAmount.Controls.Add(Me.lblSubAmountHeight)
        Me.fraSubAmount.Controls.Add(Me.txtSubAmountTop)
        Me.fraSubAmount.Controls.Add(Me.lblSubAmountTop)
        Me.fraSubAmount.Controls.Add(Me.chkSubAmount)
        Me.fraSubAmount.Controls.Add(Me.txtSubAmount)
        Me.fraSubAmount.Location = New System.Drawing.Point(6, 247)
        Me.fraSubAmount.Name = "fraSubAmount"
        Me.fraSubAmount.Size = New System.Drawing.Size(402, 132)
        Me.fraSubAmount.TabIndex = 15
        Me.fraSubAmount.TabStop = False
        '
        'cmdSubAmountFont
        '
        Me.cmdSubAmountFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdSubAmountFont.Name = "cmdSubAmountFont"
        Me.cmdSubAmountFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubAmountFont.TabIndex = 21
        Me.cmdSubAmountFont.Tag = Me.txtSubAmount
        Me.cmdSubAmountFont.UseVisualStyleBackColor = True
        '
        'txtSubAmount
        '
        Me.txtSubAmount.AcceptsReturn = True
        Me.txtSubAmount.Location = New System.Drawing.Point(208, 98)
        Me.txtSubAmount.Multiline = True
        Me.txtSubAmount.Name = "txtSubAmount"
        Me.txtSubAmount.ReadOnly = True
        Me.txtSubAmount.Size = New System.Drawing.Size(84, 20)
        Me.txtSubAmount.TabIndex = 10
        '
        'txtSubAmountLeft
        '
        Me.txtSubAmountLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtSubAmountLeft.Name = "txtSubAmountLeft"
        Me.txtSubAmountLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountLeft.TabIndex = 20
        '
        'lblSubAmountLeft
        '
        Me.lblSubAmountLeft.AutoEllipsis = True
        Me.lblSubAmountLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblSubAmountLeft.Name = "lblSubAmountLeft"
        Me.lblSubAmountLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountLeft.TabIndex = 19
        Me.lblSubAmountLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubAmountWidth
        '
        Me.txtSubAmountWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtSubAmountWidth.Name = "txtSubAmountWidth"
        Me.txtSubAmountWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountWidth.TabIndex = 18
        '
        'lblSubAmountWidth
        '
        Me.lblSubAmountWidth.AutoEllipsis = True
        Me.lblSubAmountWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblSubAmountWidth.Name = "lblSubAmountWidth"
        Me.lblSubAmountWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountWidth.TabIndex = 17
        Me.lblSubAmountWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubAmountHeight
        '
        Me.txtSubAmountHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtSubAmountHeight.Name = "txtSubAmountHeight"
        Me.txtSubAmountHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountHeight.TabIndex = 16
        '
        'lblSubAmountHeight
        '
        Me.lblSubAmountHeight.AutoEllipsis = True
        Me.lblSubAmountHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblSubAmountHeight.Name = "lblSubAmountHeight"
        Me.lblSubAmountHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountHeight.TabIndex = 15
        Me.lblSubAmountHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubAmountTop
        '
        Me.txtSubAmountTop.Location = New System.Drawing.Point(99, 33)
        Me.txtSubAmountTop.Name = "txtSubAmountTop"
        Me.txtSubAmountTop.Size = New System.Drawing.Size(100, 20)
        Me.txtSubAmountTop.TabIndex = 14
        '
        'lblSubAmountTop
        '
        Me.lblSubAmountTop.AutoEllipsis = True
        Me.lblSubAmountTop.Location = New System.Drawing.Point(6, 36)
        Me.lblSubAmountTop.Name = "lblSubAmountTop"
        Me.lblSubAmountTop.Size = New System.Drawing.Size(87, 20)
        Me.lblSubAmountTop.TabIndex = 13
        Me.lblSubAmountTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSubAmount
        '
        Me.chkSubAmount.AutoSize = True
        Me.chkSubAmount.Checked = True
        Me.chkSubAmount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSubAmount.Location = New System.Drawing.Point(6, 16)
        Me.chkSubAmount.Name = "chkSubAmount"
        Me.chkSubAmount.Size = New System.Drawing.Size(15, 14)
        Me.chkSubAmount.TabIndex = 12
        Me.chkSubAmount.UseVisualStyleBackColor = True
        '
        'fraDiscountText
        '
        Me.fraDiscountText.Controls.Add(Me.cmdDiscountTextFont)
        Me.fraDiscountText.Controls.Add(Me.txtDiscountTextLeft)
        Me.fraDiscountText.Controls.Add(Me.lblDiscountTextLeft)
        Me.fraDiscountText.Controls.Add(Me.txtDiscountTextWidth)
        Me.fraDiscountText.Controls.Add(Me.lblDiscountTextWidth)
        Me.fraDiscountText.Controls.Add(Me.txtDiscountTextHeight)
        Me.fraDiscountText.Controls.Add(Me.lblDiscountTextHeight)
        Me.fraDiscountText.Controls.Add(Me.txtDiscountTextTop)
        Me.fraDiscountText.Controls.Add(Me.lblDiscountTextTop)
        Me.fraDiscountText.Controls.Add(Me.chkDiscountText)
        Me.fraDiscountText.Controls.Add(Me.txtDiscountText)
        Me.fraDiscountText.Location = New System.Drawing.Point(6, 661)
        Me.fraDiscountText.Name = "fraDiscountText"
        Me.fraDiscountText.Size = New System.Drawing.Size(402, 132)
        Me.fraDiscountText.TabIndex = 15
        Me.fraDiscountText.TabStop = False
        '
        'cmdDiscountTextFont
        '
        Me.cmdDiscountTextFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdDiscountTextFont.Name = "cmdDiscountTextFont"
        Me.cmdDiscountTextFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdDiscountTextFont.TabIndex = 21
        Me.cmdDiscountTextFont.Tag = Me.txtDiscountText
        Me.cmdDiscountTextFont.UseVisualStyleBackColor = True
        '
        'txtDiscountText
        '
        Me.txtDiscountText.AcceptsReturn = True
        Me.txtDiscountText.Location = New System.Drawing.Point(208, 98)
        Me.txtDiscountText.Multiline = True
        Me.txtDiscountText.Name = "txtDiscountText"
        Me.txtDiscountText.ReadOnly = True
        Me.txtDiscountText.Size = New System.Drawing.Size(84, 20)
        Me.txtDiscountText.TabIndex = 10
        '
        'txtDiscountTextLeft
        '
        Me.txtDiscountTextLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtDiscountTextLeft.Name = "txtDiscountTextLeft"
        Me.txtDiscountTextLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountTextLeft.TabIndex = 20
        '
        'lblDiscountTextLeft
        '
        Me.lblDiscountTextLeft.AutoEllipsis = True
        Me.lblDiscountTextLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblDiscountTextLeft.Name = "lblDiscountTextLeft"
        Me.lblDiscountTextLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountTextLeft.TabIndex = 19
        Me.lblDiscountTextLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscountTextWidth
        '
        Me.txtDiscountTextWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtDiscountTextWidth.Name = "txtDiscountTextWidth"
        Me.txtDiscountTextWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountTextWidth.TabIndex = 18
        '
        'lblDiscountTextWidth
        '
        Me.lblDiscountTextWidth.AutoEllipsis = True
        Me.lblDiscountTextWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblDiscountTextWidth.Name = "lblDiscountTextWidth"
        Me.lblDiscountTextWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountTextWidth.TabIndex = 17
        Me.lblDiscountTextWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscountTextHeight
        '
        Me.txtDiscountTextHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtDiscountTextHeight.Name = "txtDiscountTextHeight"
        Me.txtDiscountTextHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountTextHeight.TabIndex = 16
        '
        'lblDiscountTextHeight
        '
        Me.lblDiscountTextHeight.AutoEllipsis = True
        Me.lblDiscountTextHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblDiscountTextHeight.Name = "lblDiscountTextHeight"
        Me.lblDiscountTextHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountTextHeight.TabIndex = 15
        Me.lblDiscountTextHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscountTextTop
        '
        Me.txtDiscountTextTop.Location = New System.Drawing.Point(99, 33)
        Me.txtDiscountTextTop.Name = "txtDiscountTextTop"
        Me.txtDiscountTextTop.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountTextTop.TabIndex = 14
        '
        'lblDiscountTextTop
        '
        Me.lblDiscountTextTop.AutoEllipsis = True
        Me.lblDiscountTextTop.Location = New System.Drawing.Point(6, 36)
        Me.lblDiscountTextTop.Name = "lblDiscountTextTop"
        Me.lblDiscountTextTop.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountTextTop.TabIndex = 13
        Me.lblDiscountTextTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDiscountText
        '
        Me.chkDiscountText.AutoSize = True
        Me.chkDiscountText.Checked = True
        Me.chkDiscountText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiscountText.Location = New System.Drawing.Point(6, 16)
        Me.chkDiscountText.Name = "chkDiscountText"
        Me.chkDiscountText.Size = New System.Drawing.Size(15, 14)
        Me.chkDiscountText.TabIndex = 12
        Me.chkDiscountText.UseVisualStyleBackColor = True
        '
        'fraDiscount
        '
        Me.fraDiscount.Controls.Add(Me.cmdDiscountFont)
        Me.fraDiscount.Controls.Add(Me.txtDiscountLeft)
        Me.fraDiscount.Controls.Add(Me.lblDiscountLeft)
        Me.fraDiscount.Controls.Add(Me.txtDiscountWidth)
        Me.fraDiscount.Controls.Add(Me.lblDiscountWidth)
        Me.fraDiscount.Controls.Add(Me.txtDiscountHeight)
        Me.fraDiscount.Controls.Add(Me.lblDiscountHeight)
        Me.fraDiscount.Controls.Add(Me.txtDiscountTop)
        Me.fraDiscount.Controls.Add(Me.lblDiscountTop)
        Me.fraDiscount.Controls.Add(Me.chkDiscount)
        Me.fraDiscount.Controls.Add(Me.txtDiscount)
        Me.fraDiscount.Location = New System.Drawing.Point(6, 799)
        Me.fraDiscount.Name = "fraDiscount"
        Me.fraDiscount.Size = New System.Drawing.Size(402, 132)
        Me.fraDiscount.TabIndex = 15
        Me.fraDiscount.TabStop = False
        '
        'cmdDiscountFont
        '
        Me.cmdDiscountFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdDiscountFont.Name = "cmdDiscountFont"
        Me.cmdDiscountFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdDiscountFont.TabIndex = 21
        Me.cmdDiscountFont.Tag = Me.txtDiscount
        Me.cmdDiscountFont.UseVisualStyleBackColor = True
        '
        'txtDiscount
        '
        Me.txtDiscount.AcceptsReturn = True
        Me.txtDiscount.Location = New System.Drawing.Point(208, 98)
        Me.txtDiscount.Multiline = True
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(84, 20)
        Me.txtDiscount.TabIndex = 10
        '
        'txtDiscountLeft
        '
        Me.txtDiscountLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtDiscountLeft.Name = "txtDiscountLeft"
        Me.txtDiscountLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountLeft.TabIndex = 20
        '
        'lblDiscountLeft
        '
        Me.lblDiscountLeft.AutoEllipsis = True
        Me.lblDiscountLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblDiscountLeft.Name = "lblDiscountLeft"
        Me.lblDiscountLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountLeft.TabIndex = 19
        Me.lblDiscountLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscountWidth
        '
        Me.txtDiscountWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtDiscountWidth.Name = "txtDiscountWidth"
        Me.txtDiscountWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountWidth.TabIndex = 18
        '
        'lblDiscountWidth
        '
        Me.lblDiscountWidth.AutoEllipsis = True
        Me.lblDiscountWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblDiscountWidth.Name = "lblDiscountWidth"
        Me.lblDiscountWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountWidth.TabIndex = 17
        Me.lblDiscountWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscountHeight
        '
        Me.txtDiscountHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtDiscountHeight.Name = "txtDiscountHeight"
        Me.txtDiscountHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountHeight.TabIndex = 16
        '
        'lblDiscountHeight
        '
        Me.lblDiscountHeight.AutoEllipsis = True
        Me.lblDiscountHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblDiscountHeight.Name = "lblDiscountHeight"
        Me.lblDiscountHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountHeight.TabIndex = 15
        Me.lblDiscountHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscountTop
        '
        Me.txtDiscountTop.Location = New System.Drawing.Point(99, 33)
        Me.txtDiscountTop.Name = "txtDiscountTop"
        Me.txtDiscountTop.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountTop.TabIndex = 14
        '
        'lblDiscountTop
        '
        Me.lblDiscountTop.AutoEllipsis = True
        Me.lblDiscountTop.Location = New System.Drawing.Point(6, 36)
        Me.lblDiscountTop.Name = "lblDiscountTop"
        Me.lblDiscountTop.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscountTop.TabIndex = 13
        Me.lblDiscountTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Checked = True
        Me.chkDiscount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiscount.Location = New System.Drawing.Point(6, 16)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(15, 14)
        Me.chkDiscount.TabIndex = 12
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'fraAmountText
        '
        Me.fraAmountText.Controls.Add(Me.cmdAmountTextFont)
        Me.fraAmountText.Controls.Add(Me.txtAmountTextLeft)
        Me.fraAmountText.Controls.Add(Me.lblAmountTextLeft)
        Me.fraAmountText.Controls.Add(Me.txtAmountTextWidth)
        Me.fraAmountText.Controls.Add(Me.lblAmountTextWidth)
        Me.fraAmountText.Controls.Add(Me.txtAmountTextHeight)
        Me.fraAmountText.Controls.Add(Me.lblAmountTextHeight)
        Me.fraAmountText.Controls.Add(Me.txtAmountTextTop)
        Me.fraAmountText.Controls.Add(Me.lblAmountTextTop)
        Me.fraAmountText.Controls.Add(Me.chkAmountText)
        Me.fraAmountText.Controls.Add(Me.txtAmountText)
        Me.fraAmountText.Location = New System.Drawing.Point(6, 937)
        Me.fraAmountText.Name = "fraAmountText"
        Me.fraAmountText.Size = New System.Drawing.Size(402, 132)
        Me.fraAmountText.TabIndex = 15
        Me.fraAmountText.TabStop = False
        '
        'cmdAmountTextFont
        '
        Me.cmdAmountTextFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdAmountTextFont.Name = "cmdAmountTextFont"
        Me.cmdAmountTextFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdAmountTextFont.TabIndex = 21
        Me.cmdAmountTextFont.Tag = Me.txtAmountText
        Me.cmdAmountTextFont.UseVisualStyleBackColor = True
        '
        'txtAmountText
        '
        Me.txtAmountText.AcceptsReturn = True
        Me.txtAmountText.Location = New System.Drawing.Point(208, 98)
        Me.txtAmountText.Multiline = True
        Me.txtAmountText.Name = "txtAmountText"
        Me.txtAmountText.ReadOnly = True
        Me.txtAmountText.Size = New System.Drawing.Size(84, 20)
        Me.txtAmountText.TabIndex = 10
        '
        'txtAmountTextLeft
        '
        Me.txtAmountTextLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtAmountTextLeft.Name = "txtAmountTextLeft"
        Me.txtAmountTextLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountTextLeft.TabIndex = 20
        '
        'lblAmountTextLeft
        '
        Me.lblAmountTextLeft.AutoEllipsis = True
        Me.lblAmountTextLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblAmountTextLeft.Name = "lblAmountTextLeft"
        Me.lblAmountTextLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountTextLeft.TabIndex = 19
        Me.lblAmountTextLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountTextWidth
        '
        Me.txtAmountTextWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtAmountTextWidth.Name = "txtAmountTextWidth"
        Me.txtAmountTextWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountTextWidth.TabIndex = 18
        '
        'lblAmountTextWidth
        '
        Me.lblAmountTextWidth.AutoEllipsis = True
        Me.lblAmountTextWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblAmountTextWidth.Name = "lblAmountTextWidth"
        Me.lblAmountTextWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountTextWidth.TabIndex = 17
        Me.lblAmountTextWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountTextHeight
        '
        Me.txtAmountTextHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtAmountTextHeight.Name = "txtAmountTextHeight"
        Me.txtAmountTextHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountTextHeight.TabIndex = 16
        '
        'lblAmountTextHeight
        '
        Me.lblAmountTextHeight.AutoEllipsis = True
        Me.lblAmountTextHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblAmountTextHeight.Name = "lblAmountTextHeight"
        Me.lblAmountTextHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountTextHeight.TabIndex = 15
        Me.lblAmountTextHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountTextTop
        '
        Me.txtAmountTextTop.Location = New System.Drawing.Point(99, 33)
        Me.txtAmountTextTop.Name = "txtAmountTextTop"
        Me.txtAmountTextTop.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountTextTop.TabIndex = 14
        '
        'lblAmountTextTop
        '
        Me.lblAmountTextTop.AutoEllipsis = True
        Me.lblAmountTextTop.Location = New System.Drawing.Point(6, 36)
        Me.lblAmountTextTop.Name = "lblAmountTextTop"
        Me.lblAmountTextTop.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountTextTop.TabIndex = 13
        Me.lblAmountTextTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAmountText
        '
        Me.chkAmountText.AutoSize = True
        Me.chkAmountText.Checked = True
        Me.chkAmountText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAmountText.Location = New System.Drawing.Point(6, 16)
        Me.chkAmountText.Name = "chkAmountText"
        Me.chkAmountText.Size = New System.Drawing.Size(15, 14)
        Me.chkAmountText.TabIndex = 12
        Me.chkAmountText.UseVisualStyleBackColor = True
        '
        'fraAmount
        '
        Me.fraAmount.Controls.Add(Me.cmdAmountFont)
        Me.fraAmount.Controls.Add(Me.txtAmountLeft)
        Me.fraAmount.Controls.Add(Me.lblAmountLeft)
        Me.fraAmount.Controls.Add(Me.txtAmountWidth)
        Me.fraAmount.Controls.Add(Me.lblAmountWidth)
        Me.fraAmount.Controls.Add(Me.txtAmountHeight)
        Me.fraAmount.Controls.Add(Me.lblAmountHeight)
        Me.fraAmount.Controls.Add(Me.txtAmountTop)
        Me.fraAmount.Controls.Add(Me.lblAmountTop)
        Me.fraAmount.Controls.Add(Me.chkAmount)
        Me.fraAmount.Controls.Add(Me.txtAmount)
        Me.fraAmount.Location = New System.Drawing.Point(6, 1075)
        Me.fraAmount.Name = "fraAmount"
        Me.fraAmount.Size = New System.Drawing.Size(402, 132)
        Me.fraAmount.TabIndex = 15
        Me.fraAmount.TabStop = False
        '
        'cmdAmountFont
        '
        Me.cmdAmountFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdAmountFont.Name = "cmdAmountFont"
        Me.cmdAmountFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdAmountFont.TabIndex = 21
        Me.cmdAmountFont.Tag = Me.txtAmount
        Me.cmdAmountFont.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.AcceptsReturn = True
        Me.txtAmount.Location = New System.Drawing.Point(208, 98)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(84, 20)
        Me.txtAmount.TabIndex = 10
        '
        'txtAmountLeft
        '
        Me.txtAmountLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtAmountLeft.Name = "txtAmountLeft"
        Me.txtAmountLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountLeft.TabIndex = 20
        '
        'lblAmountLeft
        '
        Me.lblAmountLeft.AutoEllipsis = True
        Me.lblAmountLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblAmountLeft.Name = "lblAmountLeft"
        Me.lblAmountLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountLeft.TabIndex = 19
        Me.lblAmountLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountWidth
        '
        Me.txtAmountWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtAmountWidth.Name = "txtAmountWidth"
        Me.txtAmountWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountWidth.TabIndex = 18
        '
        'lblAmountWidth
        '
        Me.lblAmountWidth.AutoEllipsis = True
        Me.lblAmountWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblAmountWidth.Name = "lblAmountWidth"
        Me.lblAmountWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountWidth.TabIndex = 17
        Me.lblAmountWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountHeight
        '
        Me.txtAmountHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtAmountHeight.Name = "txtAmountHeight"
        Me.txtAmountHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountHeight.TabIndex = 16
        '
        'lblAmountHeight
        '
        Me.lblAmountHeight.AutoEllipsis = True
        Me.lblAmountHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblAmountHeight.Name = "lblAmountHeight"
        Me.lblAmountHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountHeight.TabIndex = 15
        Me.lblAmountHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountTop
        '
        Me.txtAmountTop.Location = New System.Drawing.Point(99, 33)
        Me.txtAmountTop.Name = "txtAmountTop"
        Me.txtAmountTop.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountTop.TabIndex = 14
        '
        'lblAmountTop
        '
        Me.lblAmountTop.AutoEllipsis = True
        Me.lblAmountTop.Location = New System.Drawing.Point(6, 36)
        Me.lblAmountTop.Name = "lblAmountTop"
        Me.lblAmountTop.Size = New System.Drawing.Size(87, 20)
        Me.lblAmountTop.TabIndex = 13
        Me.lblAmountTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAmount
        '
        Me.chkAmount.AutoSize = True
        Me.chkAmount.Checked = True
        Me.chkAmount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAmount.Location = New System.Drawing.Point(6, 16)
        Me.chkAmount.Name = "chkAmount"
        Me.chkAmount.Size = New System.Drawing.Size(15, 14)
        Me.chkAmount.TabIndex = 12
        Me.chkAmount.UseVisualStyleBackColor = True
        '
        'fraTvaText
        '
        Me.fraTvaText.Controls.Add(Me.cmdTvaTextFont)
        Me.fraTvaText.Controls.Add(Me.txtTvaTextLeft)
        Me.fraTvaText.Controls.Add(Me.lblTvaTextLeft)
        Me.fraTvaText.Controls.Add(Me.txtTvaTextWidth)
        Me.fraTvaText.Controls.Add(Me.lblTvaTextWidth)
        Me.fraTvaText.Controls.Add(Me.txtTvaTextHeight)
        Me.fraTvaText.Controls.Add(Me.lblTvaTextHeight)
        Me.fraTvaText.Controls.Add(Me.txtTvaTextTop)
        Me.fraTvaText.Controls.Add(Me.lblTvaTextTop)
        Me.fraTvaText.Controls.Add(Me.chkTvaText)
        Me.fraTvaText.Controls.Add(Me.txtTvaText)
        Me.fraTvaText.Location = New System.Drawing.Point(6, 385)
        Me.fraTvaText.Name = "fraTvaText"
        Me.fraTvaText.Size = New System.Drawing.Size(402, 132)
        Me.fraTvaText.TabIndex = 15
        Me.fraTvaText.TabStop = False
        '
        'cmdTvaTextFont
        '
        Me.cmdTvaTextFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdTvaTextFont.Name = "cmdTvaTextFont"
        Me.cmdTvaTextFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdTvaTextFont.TabIndex = 21
        Me.cmdTvaTextFont.Tag = Me.txtTvaText
        Me.cmdTvaTextFont.UseVisualStyleBackColor = True
        '
        'txtTvaText
        '
        Me.txtTvaText.AcceptsReturn = True
        Me.txtTvaText.Location = New System.Drawing.Point(208, 98)
        Me.txtTvaText.Multiline = True
        Me.txtTvaText.Name = "txtTvaText"
        Me.txtTvaText.ReadOnly = True
        Me.txtTvaText.Size = New System.Drawing.Size(84, 20)
        Me.txtTvaText.TabIndex = 10
        '
        'txtTvaTextLeft
        '
        Me.txtTvaTextLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtTvaTextLeft.Name = "txtTvaTextLeft"
        Me.txtTvaTextLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaTextLeft.TabIndex = 20
        '
        'lblTvaTextLeft
        '
        Me.lblTvaTextLeft.AutoEllipsis = True
        Me.lblTvaTextLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblTvaTextLeft.Name = "lblTvaTextLeft"
        Me.lblTvaTextLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaTextLeft.TabIndex = 19
        Me.lblTvaTextLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTvaTextWidth
        '
        Me.txtTvaTextWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtTvaTextWidth.Name = "txtTvaTextWidth"
        Me.txtTvaTextWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaTextWidth.TabIndex = 18
        '
        'lblTvaTextWidth
        '
        Me.lblTvaTextWidth.AutoEllipsis = True
        Me.lblTvaTextWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblTvaTextWidth.Name = "lblTvaTextWidth"
        Me.lblTvaTextWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaTextWidth.TabIndex = 17
        Me.lblTvaTextWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTvaTextHeight
        '
        Me.txtTvaTextHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtTvaTextHeight.Name = "txtTvaTextHeight"
        Me.txtTvaTextHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaTextHeight.TabIndex = 16
        '
        'lblTvaTextHeight
        '
        Me.lblTvaTextHeight.AutoEllipsis = True
        Me.lblTvaTextHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblTvaTextHeight.Name = "lblTvaTextHeight"
        Me.lblTvaTextHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaTextHeight.TabIndex = 15
        Me.lblTvaTextHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTvaTextTop
        '
        Me.txtTvaTextTop.Location = New System.Drawing.Point(99, 33)
        Me.txtTvaTextTop.Name = "txtTvaTextTop"
        Me.txtTvaTextTop.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaTextTop.TabIndex = 14
        '
        'lblTvaTextTop
        '
        Me.lblTvaTextTop.AutoEllipsis = True
        Me.lblTvaTextTop.Location = New System.Drawing.Point(6, 36)
        Me.lblTvaTextTop.Name = "lblTvaTextTop"
        Me.lblTvaTextTop.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaTextTop.TabIndex = 13
        Me.lblTvaTextTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTvaText
        '
        Me.chkTvaText.AutoSize = True
        Me.chkTvaText.Checked = True
        Me.chkTvaText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTvaText.Location = New System.Drawing.Point(6, 16)
        Me.chkTvaText.Name = "chkTvaText"
        Me.chkTvaText.Size = New System.Drawing.Size(15, 14)
        Me.chkTvaText.TabIndex = 12
        Me.chkTvaText.UseVisualStyleBackColor = True
        '
        'fraTva
        '
        Me.fraTva.Controls.Add(Me.cmdTvaFont)
        Me.fraTva.Controls.Add(Me.txtTvaLeft)
        Me.fraTva.Controls.Add(Me.lblTvaLeft)
        Me.fraTva.Controls.Add(Me.txtTvaWidth)
        Me.fraTva.Controls.Add(Me.lblTvaWidth)
        Me.fraTva.Controls.Add(Me.txtTvaHeight)
        Me.fraTva.Controls.Add(Me.lblTvaHeight)
        Me.fraTva.Controls.Add(Me.txtTvaTop)
        Me.fraTva.Controls.Add(Me.lblTvaTop)
        Me.fraTva.Controls.Add(Me.chkTva)
        Me.fraTva.Controls.Add(Me.txtTva)
        Me.fraTva.Location = New System.Drawing.Point(6, 523)
        Me.fraTva.Name = "fraTva"
        Me.fraTva.Size = New System.Drawing.Size(402, 132)
        Me.fraTva.TabIndex = 15
        Me.fraTva.TabStop = False
        '
        'cmdTvaFont
        '
        Me.cmdTvaFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdTvaFont.Name = "cmdTvaFont"
        Me.cmdTvaFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdTvaFont.TabIndex = 21
        Me.cmdTvaFont.Tag = Me.txtTva
        Me.cmdTvaFont.UseVisualStyleBackColor = True
        '
        'txtTva
        '
        Me.txtTva.AcceptsReturn = True
        Me.txtTva.Location = New System.Drawing.Point(208, 98)
        Me.txtTva.Multiline = True
        Me.txtTva.Name = "txtTva"
        Me.txtTva.ReadOnly = True
        Me.txtTva.Size = New System.Drawing.Size(84, 20)
        Me.txtTva.TabIndex = 10
        '
        'txtTvaLeft
        '
        Me.txtTvaLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtTvaLeft.Name = "txtTvaLeft"
        Me.txtTvaLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaLeft.TabIndex = 20
        '
        'lblTvaLeft
        '
        Me.lblTvaLeft.AutoEllipsis = True
        Me.lblTvaLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblTvaLeft.Name = "lblTvaLeft"
        Me.lblTvaLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaLeft.TabIndex = 19
        Me.lblTvaLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTvaWidth
        '
        Me.txtTvaWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtTvaWidth.Name = "txtTvaWidth"
        Me.txtTvaWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaWidth.TabIndex = 18
        '
        'lblTvaWidth
        '
        Me.lblTvaWidth.AutoEllipsis = True
        Me.lblTvaWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblTvaWidth.Name = "lblTvaWidth"
        Me.lblTvaWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaWidth.TabIndex = 17
        Me.lblTvaWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTvaHeight
        '
        Me.txtTvaHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtTvaHeight.Name = "txtTvaHeight"
        Me.txtTvaHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaHeight.TabIndex = 16
        '
        'lblTvaHeight
        '
        Me.lblTvaHeight.AutoEllipsis = True
        Me.lblTvaHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblTvaHeight.Name = "lblTvaHeight"
        Me.lblTvaHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaHeight.TabIndex = 15
        Me.lblTvaHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTvaTop
        '
        Me.txtTvaTop.Location = New System.Drawing.Point(99, 33)
        Me.txtTvaTop.Name = "txtTvaTop"
        Me.txtTvaTop.Size = New System.Drawing.Size(100, 20)
        Me.txtTvaTop.TabIndex = 14
        '
        'lblTvaTop
        '
        Me.lblTvaTop.AutoEllipsis = True
        Me.lblTvaTop.Location = New System.Drawing.Point(6, 36)
        Me.lblTvaTop.Name = "lblTvaTop"
        Me.lblTvaTop.Size = New System.Drawing.Size(87, 20)
        Me.lblTvaTop.TabIndex = 13
        Me.lblTvaTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTva
        '
        Me.chkTva.AutoSize = True
        Me.chkTva.Checked = True
        Me.chkTva.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTva.Location = New System.Drawing.Point(6, 16)
        Me.chkTva.Name = "chkTva"
        Me.chkTva.Size = New System.Drawing.Size(15, 14)
        Me.chkTva.TabIndex = 12
        Me.chkTva.UseVisualStyleBackColor = True
        '
        'fraFooter
        '
        Me.fraFooter.Controls.Add(Me.cmdFooterFont)
        Me.fraFooter.Controls.Add(Me.txtFooterLeft)
        Me.fraFooter.Controls.Add(Me.lblFooterLeft)
        Me.fraFooter.Controls.Add(Me.txtFooterWidth)
        Me.fraFooter.Controls.Add(Me.lblFooterWidth)
        Me.fraFooter.Controls.Add(Me.txtFooterHeight)
        Me.fraFooter.Controls.Add(Me.lblFooterHeight)
        Me.fraFooter.Controls.Add(Me.txtFooterTop)
        Me.fraFooter.Controls.Add(Me.lblFooterTop)
        Me.fraFooter.Controls.Add(Me.chkFooter)
        Me.fraFooter.Controls.Add(Me.txtFooter)
        Me.fraFooter.Location = New System.Drawing.Point(6, 1213)
        Me.fraFooter.Name = "fraFooter"
        Me.fraFooter.Size = New System.Drawing.Size(402, 220)
        Me.fraFooter.TabIndex = 15
        Me.fraFooter.TabStop = False
        '
        'cmdFooterFont
        '
        Me.cmdFooterFont.Location = New System.Drawing.Point(307, 95)
        Me.cmdFooterFont.Name = "cmdFooterFont"
        Me.cmdFooterFont.Size = New System.Drawing.Size(75, 23)
        Me.cmdFooterFont.TabIndex = 21
        Me.cmdFooterFont.Tag = Me.txtFooter
        Me.cmdFooterFont.UseVisualStyleBackColor = True
        '
        'txtFooter
        '
        Me.txtFooter.AcceptsReturn = True
        Me.txtFooter.Location = New System.Drawing.Point(9, 124)
        Me.txtFooter.Multiline = True
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.Size = New System.Drawing.Size(389, 90)
        Me.txtFooter.TabIndex = 10
        '
        'txtFooterLeft
        '
        Me.txtFooterLeft.Location = New System.Drawing.Point(298, 33)
        Me.txtFooterLeft.Name = "txtFooterLeft"
        Me.txtFooterLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterLeft.TabIndex = 20
        '
        'lblFooterLeft
        '
        Me.lblFooterLeft.AutoEllipsis = True
        Me.lblFooterLeft.Location = New System.Drawing.Point(205, 33)
        Me.lblFooterLeft.Name = "lblFooterLeft"
        Me.lblFooterLeft.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterLeft.TabIndex = 19
        Me.lblFooterLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFooterWidth
        '
        Me.txtFooterWidth.Location = New System.Drawing.Point(99, 62)
        Me.txtFooterWidth.Name = "txtFooterWidth"
        Me.txtFooterWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterWidth.TabIndex = 18
        '
        'lblFooterWidth
        '
        Me.lblFooterWidth.AutoEllipsis = True
        Me.lblFooterWidth.Location = New System.Drawing.Point(6, 62)
        Me.lblFooterWidth.Name = "lblFooterWidth"
        Me.lblFooterWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterWidth.TabIndex = 17
        Me.lblFooterWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFooterHeight
        '
        Me.txtFooterHeight.Location = New System.Drawing.Point(298, 62)
        Me.txtFooterHeight.Name = "txtFooterHeight"
        Me.txtFooterHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterHeight.TabIndex = 16
        '
        'lblFooterHeight
        '
        Me.lblFooterHeight.AutoEllipsis = True
        Me.lblFooterHeight.Location = New System.Drawing.Point(205, 62)
        Me.lblFooterHeight.Name = "lblFooterHeight"
        Me.lblFooterHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterHeight.TabIndex = 15
        Me.lblFooterHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFooterTop
        '
        Me.txtFooterTop.Location = New System.Drawing.Point(99, 33)
        Me.txtFooterTop.Name = "txtFooterTop"
        Me.txtFooterTop.Size = New System.Drawing.Size(100, 20)
        Me.txtFooterTop.TabIndex = 14
        '
        'lblFooterTop
        '
        Me.lblFooterTop.AutoEllipsis = True
        Me.lblFooterTop.Location = New System.Drawing.Point(6, 36)
        Me.lblFooterTop.Name = "lblFooterTop"
        Me.lblFooterTop.Size = New System.Drawing.Size(87, 20)
        Me.lblFooterTop.TabIndex = 13
        Me.lblFooterTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkFooter
        '
        Me.chkFooter.AutoSize = True
        Me.chkFooter.Checked = True
        Me.chkFooter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFooter.Location = New System.Drawing.Point(6, 16)
        Me.chkFooter.Name = "chkFooter"
        Me.chkFooter.Size = New System.Drawing.Size(15, 14)
        Me.chkFooter.TabIndex = 12
        Me.chkFooter.UseVisualStyleBackColor = True
        '
        'fraPrint
        '
        Me.fraPrint.Controls.Add(Me.txtPrintWidth)
        Me.fraPrint.Controls.Add(Me.lblPrintWidth)
        Me.fraPrint.Controls.Add(Me.txtPrintHeight)
        Me.fraPrint.Controls.Add(Me.lblPrintHeight)
        Me.fraPrint.Location = New System.Drawing.Point(6, 6)
        Me.fraPrint.Name = "fraPrint"
        Me.fraPrint.Size = New System.Drawing.Size(433, 56)
        Me.fraPrint.TabIndex = 11
        Me.fraPrint.TabStop = False
        '
        'txtPrintWidth
        '
        Me.txtPrintWidth.Location = New System.Drawing.Point(106, 19)
        Me.txtPrintWidth.Name = "txtPrintWidth"
        Me.txtPrintWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtPrintWidth.TabIndex = 22
        '
        'lblPrintWidth
        '
        Me.lblPrintWidth.AutoEllipsis = True
        Me.lblPrintWidth.Location = New System.Drawing.Point(13, 19)
        Me.lblPrintWidth.Name = "lblPrintWidth"
        Me.lblPrintWidth.Size = New System.Drawing.Size(87, 20)
        Me.lblPrintWidth.TabIndex = 21
        Me.lblPrintWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrintHeight
        '
        Me.txtPrintHeight.Location = New System.Drawing.Point(305, 19)
        Me.txtPrintHeight.Name = "txtPrintHeight"
        Me.txtPrintHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtPrintHeight.TabIndex = 20
        '
        'lblPrintHeight
        '
        Me.lblPrintHeight.AutoEllipsis = True
        Me.lblPrintHeight.Location = New System.Drawing.Point(212, 19)
        Me.lblPrintHeight.Name = "lblPrintHeight"
        Me.lblPrintHeight.Size = New System.Drawing.Size(87, 20)
        Me.lblPrintHeight.TabIndex = 19
        Me.lblPrintHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 518)
        Me.Controls.Add(Me.tabOption)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.hlpOption.SetHelpKeyword(Me, "7")
        Me.hlpOption.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOption"
        Me.hlpOption.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.fraPassword.ResumeLayout(False)
        Me.fraPassword.PerformLayout()
        Me.tabOption.ResumeLayout(False)
        Me.tabOptGeneral.ResumeLayout(False)
        Me.tabOptGeneral.PerformLayout()
        Me.fraPasswordErase.ResumeLayout(False)
        Me.fraPasswordErase.PerformLayout()
        Me.tabOptPrint.ResumeLayout(False)
        Me.tabPrint.ResumeLayout(False)
        Me.tabHeader.ResumeLayout(False)
        Me.fraLogo.ResumeLayout(False)
        Me.fraLogo.PerformLayout()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraHeaderPanel.ResumeLayout(False)
        Me.fraHeaderPanel.PerformLayout()
        Me.fraHeader.ResumeLayout(False)
        Me.fraHeader.PerformLayout()
        Me.fraDate.ResumeLayout(False)
        Me.fraDate.PerformLayout()
        Me.fraTable.ResumeLayout(False)
        Me.fraTable.PerformLayout()
        Me.fraSet.ResumeLayout(False)
        Me.fraSet.PerformLayout()
        Me.tabBody.ResumeLayout(False)
        Me.fraBodyPanel.ResumeLayout(False)
        Me.fraBodyPanel.PerformLayout()
        Me.fraQuantityTitle.ResumeLayout(False)
        Me.fraQuantityTitle.PerformLayout()
        Me.fraQuantity.ResumeLayout(False)
        Me.fraQuantity.PerformLayout()
        Me.fraDesignationTitle.ResumeLayout(False)
        Me.fraDesignationTitle.PerformLayout()
        Me.fraDesignation.ResumeLayout(False)
        Me.fraDesignation.PerformLayout()
        Me.fraTotalTitle.ResumeLayout(False)
        Me.fraTotalTitle.PerformLayout()
        Me.fraTotal.ResumeLayout(False)
        Me.fraTotal.PerformLayout()
        Me.tabFooter.ResumeLayout(False)
        Me.fraFooterPanel.ResumeLayout(False)
        Me.fraFooterPanel.PerformLayout()
        Me.fraSubAmountText.ResumeLayout(False)
        Me.fraSubAmountText.PerformLayout()
        Me.fraSubAmount.ResumeLayout(False)
        Me.fraSubAmount.PerformLayout()
        Me.fraDiscountText.ResumeLayout(False)
        Me.fraDiscountText.PerformLayout()
        Me.fraDiscount.ResumeLayout(False)
        Me.fraDiscount.PerformLayout()
        Me.fraAmountText.ResumeLayout(False)
        Me.fraAmountText.PerformLayout()
        Me.fraAmount.ResumeLayout(False)
        Me.fraAmount.PerformLayout()
        Me.fraTvaText.ResumeLayout(False)
        Me.fraTvaText.PerformLayout()
        Me.fraTva.ResumeLayout(False)
        Me.fraTva.PerformLayout()
        Me.fraFooter.ResumeLayout(False)
        Me.fraFooter.PerformLayout()
        Me.fraPrint.ResumeLayout(False)
        Me.fraPrint.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hlpOption As System.Windows.Forms.HelpProvider
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cboLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents chkPassword As System.Windows.Forms.CheckBox
    Friend WithEvents fraPassword As System.Windows.Forms.GroupBox
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents dlgPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tabOption As System.Windows.Forms.TabControl
    Friend WithEvents tabOptGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabOptPrint As System.Windows.Forms.TabPage
    Friend WithEvents fraPasswordErase As System.Windows.Forms.GroupBox
    Friend WithEvents txtPasswordErase As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordErase As System.Windows.Forms.Label
    Friend WithEvents chkPasswordErase As System.Windows.Forms.CheckBox
    Friend WithEvents tabPrint As System.Windows.Forms.TabControl
    Friend WithEvents tabHeader As System.Windows.Forms.TabPage
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents txtHeader As System.Windows.Forms.TextBox
    Friend WithEvents pctLogo As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents lblPicture As System.Windows.Forms.Label
    Friend WithEvents tabBody As System.Windows.Forms.TabPage
    Friend WithEvents tabFooter As System.Windows.Forms.TabPage
    Friend WithEvents fraHeader As System.Windows.Forms.GroupBox
    Friend WithEvents txtHeaderTop As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderTop As System.Windows.Forms.Label
    Friend WithEvents chkHeader As System.Windows.Forms.CheckBox
    Friend WithEvents txtHeaderLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderLeft As System.Windows.Forms.Label
    Friend WithEvents txtHeaderWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderWidth As System.Windows.Forms.Label
    Friend WithEvents txtHeaderHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderHeight As System.Windows.Forms.Label
    Friend WithEvents cmdHeaderFont As System.Windows.Forms.Button
    Friend WithEvents fraHeaderPanel As System.Windows.Forms.GroupBox
    Friend WithEvents txtHeaderPanelTop As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderPanelTop As System.Windows.Forms.Label
    Friend WithEvents chkHeaderPanel As System.Windows.Forms.CheckBox
    Friend WithEvents txtHeaderPanelLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderPanelLeft As System.Windows.Forms.Label
    Friend WithEvents txtHeaderPanelWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderPanelWidth As System.Windows.Forms.Label
    Friend WithEvents txtHeaderPanelHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderPanelHeight As System.Windows.Forms.Label
    Friend WithEvents fraLogo As System.Windows.Forms.GroupBox
    Friend WithEvents txtLogoTop As System.Windows.Forms.TextBox
    Friend WithEvents lblLogoTop As System.Windows.Forms.Label
    Friend WithEvents chkLogo As System.Windows.Forms.CheckBox
    Friend WithEvents txtLogoLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblLogoLeft As System.Windows.Forms.Label
    Friend WithEvents txtLogoWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblLogoWidth As System.Windows.Forms.Label
    Friend WithEvents txtLogoHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblLogoHeight As System.Windows.Forms.Label
    Friend WithEvents fraDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateTop As System.Windows.Forms.TextBox
    Friend WithEvents lblDateTop As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents txtDateLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblDateLeft As System.Windows.Forms.Label
    Friend WithEvents txtDateWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblDateWidth As System.Windows.Forms.Label
    Friend WithEvents txtDateHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblDateHeight As System.Windows.Forms.Label
    Friend WithEvents cmdDateFont As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents fraTable As System.Windows.Forms.GroupBox
    Friend WithEvents txtTableTop As System.Windows.Forms.TextBox
    Friend WithEvents lblTableTop As System.Windows.Forms.Label
    Friend WithEvents chkTable As System.Windows.Forms.CheckBox
    Friend WithEvents txtTableLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblTableLeft As System.Windows.Forms.Label
    Friend WithEvents txtTableWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblTableWidth As System.Windows.Forms.Label
    Friend WithEvents txtTableHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTableHeight As System.Windows.Forms.Label
    Friend WithEvents cmdTableFont As System.Windows.Forms.Button
    Friend WithEvents txtTable As System.Windows.Forms.TextBox
    Friend WithEvents fraSet As System.Windows.Forms.GroupBox
    Friend WithEvents txtSetTop As System.Windows.Forms.TextBox
    Friend WithEvents lblSetTop As System.Windows.Forms.Label
    Friend WithEvents chkSet As System.Windows.Forms.CheckBox
    Friend WithEvents txtSetLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblSetLeft As System.Windows.Forms.Label
    Friend WithEvents txtSetWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblSetWidth As System.Windows.Forms.Label
    Friend WithEvents txtSetHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblSetHeight As System.Windows.Forms.Label
    Friend WithEvents cmdSetFont As System.Windows.Forms.Button
    Friend WithEvents txtSet As System.Windows.Forms.TextBox
    Friend WithEvents fraBodyPanel As System.Windows.Forms.GroupBox
    Friend WithEvents txtBodyPanelLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblBodyPanelLeft As System.Windows.Forms.Label
    Friend WithEvents txtBodyPanelWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblBodyPanelWidth As System.Windows.Forms.Label
    Friend WithEvents txtBodyPanelHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblBodyPanelHeight As System.Windows.Forms.Label
    Friend WithEvents txtBodyPanelTop As System.Windows.Forms.TextBox
    Friend WithEvents lblBodyPanelTop As System.Windows.Forms.Label
    Friend WithEvents chkBodyPanel As System.Windows.Forms.CheckBox
    Friend WithEvents fraFooterPanel As System.Windows.Forms.GroupBox
    Friend WithEvents txtFooterPanelLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterPanelLeft As System.Windows.Forms.Label
    Friend WithEvents txtFooterPanelWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterPanelWidth As System.Windows.Forms.Label
    Friend WithEvents txtFooterPanelHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterPanelHeight As System.Windows.Forms.Label
    Friend WithEvents txtFooterPanelTop As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterPanelTop As System.Windows.Forms.Label
    Friend WithEvents chkFooterPanel As System.Windows.Forms.CheckBox
    Friend WithEvents fraQuantityTitle As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuantityTitleTop As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityTitleTop As System.Windows.Forms.Label
    Friend WithEvents chkQuantityTitle As System.Windows.Forms.CheckBox
    Friend WithEvents txtQuantityTitleLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityTitleLeft As System.Windows.Forms.Label
    Friend WithEvents txtQuantityTitleWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityTitleWidth As System.Windows.Forms.Label
    Friend WithEvents txtQuantityTitleHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityTitleHeight As System.Windows.Forms.Label
    Friend WithEvents cmdQuantityTitleFont As System.Windows.Forms.Button
    Friend WithEvents txtQuantityTitle As System.Windows.Forms.TextBox
    Friend WithEvents fraQuantity As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuantityTop As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityTop As System.Windows.Forms.Label
    Friend WithEvents chkQuantity As System.Windows.Forms.CheckBox
    Friend WithEvents txtQuantityLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityLeft As System.Windows.Forms.Label
    Friend WithEvents txtQuantityWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityWidth As System.Windows.Forms.Label
    Friend WithEvents txtQuantityHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantityHeight As System.Windows.Forms.Label
    Friend WithEvents cmdQuantityFont As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents fraDesignationTitle As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesignationTitleTop As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationTitleTop As System.Windows.Forms.Label
    Friend WithEvents chkDesignationTitle As System.Windows.Forms.CheckBox
    Friend WithEvents txtDesignationTitleLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationTitleLeft As System.Windows.Forms.Label
    Friend WithEvents txtDesignationTitleWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationTitleWidth As System.Windows.Forms.Label
    Friend WithEvents txtDesignationTitleHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationTitleHeight As System.Windows.Forms.Label
    Friend WithEvents cmdDesignationTitleFont As System.Windows.Forms.Button
    Friend WithEvents txtDesignationTitle As System.Windows.Forms.TextBox
    Friend WithEvents fraDesignation As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesignationTop As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationTop As System.Windows.Forms.Label
    Friend WithEvents chkDesignation As System.Windows.Forms.CheckBox
    Friend WithEvents txtDesignationLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationLeft As System.Windows.Forms.Label
    Friend WithEvents txtDesignationWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationWidth As System.Windows.Forms.Label
    Friend WithEvents txtDesignationHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignationHeight As System.Windows.Forms.Label
    Friend WithEvents cmdDesignationFont As System.Windows.Forms.Button
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents fraTotalTitle As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalTitleTop As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTitleTop As System.Windows.Forms.Label
    Friend WithEvents chkTotalTitle As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotalTitleLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTitleLeft As System.Windows.Forms.Label
    Friend WithEvents txtTotalTitleWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTitleWidth As System.Windows.Forms.Label
    Friend WithEvents txtTotalTitleHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTitleHeight As System.Windows.Forms.Label
    Friend WithEvents cmdTotalTitleFont As System.Windows.Forms.Button
    Friend WithEvents txtTotalTitle As System.Windows.Forms.TextBox
    Friend WithEvents fraTotal As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalTop As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTop As System.Windows.Forms.Label
    Friend WithEvents chkTotal As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotalLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalLeft As System.Windows.Forms.Label
    Friend WithEvents txtTotalWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalWidth As System.Windows.Forms.Label
    Friend WithEvents txtTotalHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalHeight As System.Windows.Forms.Label
    Friend WithEvents cmdTotalFont As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents fraSubAmountText As System.Windows.Forms.GroupBox
    Friend WithEvents txtSubAmountTextTop As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountTextTop As System.Windows.Forms.Label
    Friend WithEvents chkSubAmountText As System.Windows.Forms.CheckBox
    Friend WithEvents txtSubAmountTextLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountTextLeft As System.Windows.Forms.Label
    Friend WithEvents txtSubAmountTextWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountTextWidth As System.Windows.Forms.Label
    Friend WithEvents txtSubAmountTextHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountTextHeight As System.Windows.Forms.Label
    Friend WithEvents cmdSubAmountTextFont As System.Windows.Forms.Button
    Friend WithEvents txtSubAmountText As System.Windows.Forms.TextBox
    Friend WithEvents fraSubAmount As System.Windows.Forms.GroupBox
    Friend WithEvents txtSubAmountTop As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountTop As System.Windows.Forms.Label
    Friend WithEvents chkSubAmount As System.Windows.Forms.CheckBox
    Friend WithEvents txtSubAmountLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountLeft As System.Windows.Forms.Label
    Friend WithEvents txtSubAmountWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountWidth As System.Windows.Forms.Label
    Friend WithEvents txtSubAmountHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblSubAmountHeight As System.Windows.Forms.Label
    Friend WithEvents cmdSubAmountFont As System.Windows.Forms.Button
    Friend WithEvents txtSubAmount As System.Windows.Forms.TextBox
    Friend WithEvents fraDiscountText As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiscountTextTop As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountTextTop As System.Windows.Forms.Label
    Friend WithEvents chkDiscountText As System.Windows.Forms.CheckBox
    Friend WithEvents txtDiscountTextLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountTextLeft As System.Windows.Forms.Label
    Friend WithEvents txtDiscountTextWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountTextWidth As System.Windows.Forms.Label
    Friend WithEvents txtDiscountTextHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountTextHeight As System.Windows.Forms.Label
    Friend WithEvents cmdDiscountTextFont As System.Windows.Forms.Button
    Friend WithEvents txtDiscountText As System.Windows.Forms.TextBox
    Friend WithEvents fraDiscount As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiscountTop As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountTop As System.Windows.Forms.Label
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents txtDiscountLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountLeft As System.Windows.Forms.Label
    Friend WithEvents txtDiscountWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountWidth As System.Windows.Forms.Label
    Friend WithEvents txtDiscountHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountHeight As System.Windows.Forms.Label
    Friend WithEvents cmdDiscountFont As System.Windows.Forms.Button
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents fraAmountText As System.Windows.Forms.GroupBox
    Friend WithEvents txtAmountTextTop As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountTextTop As System.Windows.Forms.Label
    Friend WithEvents chkAmountText As System.Windows.Forms.CheckBox
    Friend WithEvents txtAmountTextLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountTextLeft As System.Windows.Forms.Label
    Friend WithEvents txtAmountTextWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountTextWidth As System.Windows.Forms.Label
    Friend WithEvents txtAmountTextHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountTextHeight As System.Windows.Forms.Label
    Friend WithEvents cmdAmountTextFont As System.Windows.Forms.Button
    Friend WithEvents txtAmountText As System.Windows.Forms.TextBox
    Friend WithEvents fraAmount As System.Windows.Forms.GroupBox
    Friend WithEvents txtAmountTop As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountTop As System.Windows.Forms.Label
    Friend WithEvents chkAmount As System.Windows.Forms.CheckBox
    Friend WithEvents txtAmountLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountLeft As System.Windows.Forms.Label
    Friend WithEvents txtAmountWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountWidth As System.Windows.Forms.Label
    Friend WithEvents txtAmountHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountHeight As System.Windows.Forms.Label
    Friend WithEvents cmdAmountFont As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents fraTvaText As System.Windows.Forms.GroupBox
    Friend WithEvents txtTvaTextTop As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaTextTop As System.Windows.Forms.Label
    Friend WithEvents chkTvaText As System.Windows.Forms.CheckBox
    Friend WithEvents txtTvaTextLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaTextLeft As System.Windows.Forms.Label
    Friend WithEvents txtTvaTextWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaTextWidth As System.Windows.Forms.Label
    Friend WithEvents txtTvaTextHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaTextHeight As System.Windows.Forms.Label
    Friend WithEvents cmdTvaTextFont As System.Windows.Forms.Button
    Friend WithEvents txtTvaText As System.Windows.Forms.TextBox
    Friend WithEvents fraTva As System.Windows.Forms.GroupBox
    Friend WithEvents txtTvaTop As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaTop As System.Windows.Forms.Label
    Friend WithEvents chkTva As System.Windows.Forms.CheckBox
    Friend WithEvents txtTvaLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaLeft As System.Windows.Forms.Label
    Friend WithEvents txtTvaWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaWidth As System.Windows.Forms.Label
    Friend WithEvents txtTvaHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTvaHeight As System.Windows.Forms.Label
    Friend WithEvents cmdTvaFont As System.Windows.Forms.Button
    Friend WithEvents txtTva As System.Windows.Forms.TextBox
    Friend WithEvents fraFooter As System.Windows.Forms.GroupBox
    Friend WithEvents txtFooterTop As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterTop As System.Windows.Forms.Label
    Friend WithEvents chkFooter As System.Windows.Forms.CheckBox
    Friend WithEvents txtFooterLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterLeft As System.Windows.Forms.Label
    Friend WithEvents txtFooterWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterWidth As System.Windows.Forms.Label
    Friend WithEvents txtFooterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblFooterHeight As System.Windows.Forms.Label
    Friend WithEvents cmdFooterFont As System.Windows.Forms.Button
    Friend WithEvents txtFooter As System.Windows.Forms.TextBox
    Friend WithEvents frmFont As System.Windows.Forms.FontDialog
    Friend WithEvents cboDateFormat As System.Windows.Forms.ComboBox
    Friend WithEvents fraPrint As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrintWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblPrintWidth As System.Windows.Forms.Label
    Friend WithEvents txtPrintHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblPrintHeight As System.Windows.Forms.Label

End Class
