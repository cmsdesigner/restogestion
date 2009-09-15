<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.fraHeader = New System.Windows.Forms.Panel
        Me.lblSet = New System.Windows.Forms.Label
        Me.lblTable = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label
        Me.pctLogo = New System.Windows.Forms.PictureBox
        Me.fraBody = New System.Windows.Forms.Panel
        Me.lblTotalTitle = New System.Windows.Forms.Label
        Me.lblDesignationTitle = New System.Windows.Forms.Label
        Me.lblQuantityTitle = New System.Windows.Forms.Label
        Me.fraFooter = New System.Windows.Forms.Panel
        Me.lblFooter = New System.Windows.Forms.Label
        Me.lblVat = New System.Windows.Forms.Label
        Me.lblVatText = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.lblAmountText = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblDiscountText = New System.Windows.Forms.Label
        Me.lblSubAmount = New System.Windows.Forms.Label
        Me.lblSubAmountText = New System.Windows.Forms.Label
        Me.prtDoc = New System.Drawing.Printing.PrintDocument
        Me.prtSetup = New System.Windows.Forms.PageSetupDialog
        Me.fraHeader.SuspendLayout()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraBody.SuspendLayout()
        Me.fraFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraHeader
        '
        Me.fraHeader.Controls.Add(Me.lblSet)
        Me.fraHeader.Controls.Add(Me.lblTable)
        Me.fraHeader.Controls.Add(Me.lblDate)
        Me.fraHeader.Controls.Add(Me.lblHeader)
        Me.fraHeader.Controls.Add(Me.pctLogo)
        Me.fraHeader.Location = New System.Drawing.Point(0, 0)
        Me.fraHeader.Name = "fraHeader"
        Me.fraHeader.Size = New System.Drawing.Size(112, 75)
        Me.fraHeader.TabIndex = 0
        '
        'lblSet
        '
        Me.lblSet.AutoEllipsis = True
        Me.lblSet.Location = New System.Drawing.Point(43, 27)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(10, 23)
        Me.lblSet.TabIndex = 4
        '
        'lblTable
        '
        Me.lblTable.AutoEllipsis = True
        Me.lblTable.Location = New System.Drawing.Point(27, 27)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(10, 23)
        Me.lblTable.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoEllipsis = True
        Me.lblDate.Location = New System.Drawing.Point(11, 27)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(10, 23)
        Me.lblDate.TabIndex = 2
        '
        'lblHeader
        '
        Me.lblHeader.AutoEllipsis = True
        Me.lblHeader.Location = New System.Drawing.Point(91, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(10, 23)
        Me.lblHeader.TabIndex = 1
        '
        'pctLogo
        '
        Me.pctLogo.Location = New System.Drawing.Point(12, 12)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(14, 13)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogo.TabIndex = 0
        Me.pctLogo.TabStop = False
        '
        'fraBody
        '
        Me.fraBody.Controls.Add(Me.lblTotalTitle)
        Me.fraBody.Controls.Add(Me.lblDesignationTitle)
        Me.fraBody.Controls.Add(Me.lblQuantityTitle)
        Me.fraBody.Location = New System.Drawing.Point(118, 0)
        Me.fraBody.Name = "fraBody"
        Me.fraBody.Size = New System.Drawing.Size(112, 75)
        Me.fraBody.TabIndex = 1
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoEllipsis = True
        Me.lblTotalTitle.Location = New System.Drawing.Point(3, 42)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(42, 23)
        Me.lblTotalTitle.TabIndex = 2
        '
        'lblDesignationTitle
        '
        Me.lblDesignationTitle.AutoEllipsis = True
        Me.lblDesignationTitle.Location = New System.Drawing.Point(51, 42)
        Me.lblDesignationTitle.Name = "lblDesignationTitle"
        Me.lblDesignationTitle.Size = New System.Drawing.Size(32, 23)
        Me.lblDesignationTitle.TabIndex = 1
        '
        'lblQuantityTitle
        '
        Me.lblQuantityTitle.AutoEllipsis = True
        Me.lblQuantityTitle.Location = New System.Drawing.Point(15, 9)
        Me.lblQuantityTitle.Name = "lblQuantityTitle"
        Me.lblQuantityTitle.Size = New System.Drawing.Size(41, 23)
        Me.lblQuantityTitle.TabIndex = 0
        '
        'fraFooter
        '
        Me.fraFooter.Controls.Add(Me.lblFooter)
        Me.fraFooter.Controls.Add(Me.lblVat)
        Me.fraFooter.Controls.Add(Me.lblVatText)
        Me.fraFooter.Controls.Add(Me.lblAmount)
        Me.fraFooter.Controls.Add(Me.lblAmountText)
        Me.fraFooter.Controls.Add(Me.lblDiscount)
        Me.fraFooter.Controls.Add(Me.lblDiscountText)
        Me.fraFooter.Controls.Add(Me.lblSubAmount)
        Me.fraFooter.Controls.Add(Me.lblSubAmountText)
        Me.fraFooter.Location = New System.Drawing.Point(236, 0)
        Me.fraFooter.Name = "fraFooter"
        Me.fraFooter.Size = New System.Drawing.Size(120, 75)
        Me.fraFooter.TabIndex = 2
        '
        'lblFooter
        '
        Me.lblFooter.AutoEllipsis = True
        Me.lblFooter.Location = New System.Drawing.Point(0, 0)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(34, 10)
        Me.lblFooter.TabIndex = 8
        '
        'lblVat
        '
        Me.lblVat.AutoEllipsis = True
        Me.lblVat.Location = New System.Drawing.Point(56, 56)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(34, 10)
        Me.lblVat.TabIndex = 7
        '
        'lblVatText
        '
        Me.lblVatText.AutoEllipsis = True
        Me.lblVatText.Location = New System.Drawing.Point(48, 48)
        Me.lblVatText.Name = "lblVatText"
        Me.lblVatText.Size = New System.Drawing.Size(31, 17)
        Me.lblVatText.TabIndex = 6
        Me.lblVatText.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblAmount
        '
        Me.lblAmount.AutoEllipsis = True
        Me.lblAmount.Location = New System.Drawing.Point(40, 40)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(31, 17)
        Me.lblAmount.TabIndex = 5
        Me.lblAmount.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblAmountText
        '
        Me.lblAmountText.AutoEllipsis = True
        Me.lblAmountText.Location = New System.Drawing.Point(32, 32)
        Me.lblAmountText.Name = "lblAmountText"
        Me.lblAmountText.Size = New System.Drawing.Size(31, 17)
        Me.lblAmountText.TabIndex = 4
        Me.lblAmountText.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoEllipsis = True
        Me.lblDiscount.Location = New System.Drawing.Point(24, 24)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(31, 17)
        Me.lblDiscount.TabIndex = 3
        Me.lblDiscount.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDiscountText
        '
        Me.lblDiscountText.AutoEllipsis = True
        Me.lblDiscountText.Location = New System.Drawing.Point(16, 16)
        Me.lblDiscountText.Name = "lblDiscountText"
        Me.lblDiscountText.Size = New System.Drawing.Size(31, 17)
        Me.lblDiscountText.TabIndex = 2
        Me.lblDiscountText.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSubAmount
        '
        Me.lblSubAmount.AutoEllipsis = True
        Me.lblSubAmount.Location = New System.Drawing.Point(8, 8)
        Me.lblSubAmount.Name = "lblSubAmount"
        Me.lblSubAmount.Size = New System.Drawing.Size(31, 17)
        Me.lblSubAmount.TabIndex = 1
        Me.lblSubAmount.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSubAmountText
        '
        Me.lblSubAmountText.AutoEllipsis = True
        Me.lblSubAmountText.Location = New System.Drawing.Point(0, 0)
        Me.lblSubAmountText.Name = "lblSubAmountText"
        Me.lblSubAmountText.Size = New System.Drawing.Size(31, 17)
        Me.lblSubAmountText.TabIndex = 0
        Me.lblSubAmountText.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'prtDoc
        '
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 78)
        Me.Controls.Add(Me.fraFooter)
        Me.Controls.Add(Me.fraBody)
        Me.Controls.Add(Me.fraHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrint"
        Me.fraHeader.ResumeLayout(False)
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraBody.ResumeLayout(False)
        Me.fraFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fraHeader As System.Windows.Forms.Panel
    Friend WithEvents fraBody As System.Windows.Forms.Panel
    Friend WithEvents pctLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblSet As System.Windows.Forms.Label
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblDesignationTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuantityTitle As System.Windows.Forms.Label
    Friend WithEvents fraFooter As System.Windows.Forms.Panel
    Friend WithEvents lblFooter As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblVatText As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblAmountText As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscountText As System.Windows.Forms.Label
    Friend WithEvents lblSubAmount As System.Windows.Forms.Label
    Friend WithEvents lblSubAmountText As System.Windows.Forms.Label
    Friend WithEvents prtDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents prtSetup As System.Windows.Forms.PageSetupDialog
End Class
