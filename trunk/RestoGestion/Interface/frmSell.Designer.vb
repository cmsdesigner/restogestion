<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSell))
        Me.hlpSell = New System.Windows.Forms.HelpProvider
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdModify = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdErase = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cboDesignation = New System.Windows.Forms.ComboBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.txtSet = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblTable = New System.Windows.Forms.Label
        Me.lblSet = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblDesignation = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.lblQuantity = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.flxMenu = New System.Windows.Forms.DataGridView
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesignation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.flxMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(17, 140)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdModify
        '
        Me.cmdModify.Location = New System.Drawing.Point(98, 140)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(75, 23)
        Me.cmdModify.TabIndex = 5
        Me.cmdModify.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(179, 140)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 6
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdCancel.Location = New System.Drawing.Point(260, 140)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(116, 387)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 29)
        Me.cmdPrint.TabIndex = 10
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdErase
        '
        Me.cmdErase.Location = New System.Drawing.Point(197, 387)
        Me.cmdErase.Name = "cmdErase"
        Me.cmdErase.Size = New System.Drawing.Size(75, 29)
        Me.cmdErase.TabIndex = 11
        Me.cmdErase.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(278, 387)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 29)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cboDesignation
        '
        Me.cboDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesignation.FormattingEnabled = True
        Me.cboDesignation.Location = New System.Drawing.Point(143, 61)
        Me.cboDesignation.Name = "cboDesignation"
        Me.cboDesignation.Size = New System.Drawing.Size(192, 21)
        Me.cboDesignation.Sorted = True
        Me.cboDesignation.TabIndex = 1
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(143, 35)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(143, 88)
        Me.txtPrice.MaxLength = 8
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(143, 114)
        Me.txtQuantity.MaxLength = 6
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 3
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSet
        '
        Me.txtSet.Location = New System.Drawing.Point(299, 12)
        Me.txtSet.MaxLength = 10
        Me.txtSet.Name = "txtSet"
        Me.txtSet.Size = New System.Drawing.Size(56, 20)
        Me.txtSet.TabIndex = 0
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(253, 334)
        Me.txtDiscount.MaxLength = 8
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 9
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(253, 361)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 15
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTable
        '
        Me.lblTable.AutoEllipsis = True
        Me.lblTable.Location = New System.Drawing.Point(12, 12)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(78, 20)
        Me.lblTable.TabIndex = 16
        '
        'lblSet
        '
        Me.lblSet.AutoEllipsis = True
        Me.lblSet.Location = New System.Drawing.Point(168, 12)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(125, 20)
        Me.lblSet.TabIndex = 17
        Me.lblSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCode
        '
        Me.lblCode.AutoEllipsis = True
        Me.lblCode.Location = New System.Drawing.Point(12, 38)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(125, 20)
        Me.lblCode.TabIndex = 18
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoEllipsis = True
        Me.lblDesignation.Location = New System.Drawing.Point(12, 64)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(125, 21)
        Me.lblDesignation.TabIndex = 19
        Me.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.AutoEllipsis = True
        Me.lblPrice.Location = New System.Drawing.Point(12, 91)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(125, 20)
        Me.lblPrice.TabIndex = 20
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoEllipsis = True
        Me.lblQuantity.Location = New System.Drawing.Point(12, 117)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(125, 20)
        Me.lblQuantity.TabIndex = 21
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoEllipsis = True
        Me.lblDiscount.Location = New System.Drawing.Point(12, 334)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(235, 26)
        Me.lblDiscount.TabIndex = 23
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmount
        '
        Me.lblAmount.AutoEllipsis = True
        Me.lblAmount.Location = New System.Drawing.Point(12, 360)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(235, 26)
        Me.lblAmount.TabIndex = 24
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flxMenu
        '
        Me.flxMenu.AllowUserToAddRows = False
        Me.flxMenu.AllowUserToDeleteRows = False
        Me.flxMenu.AllowUserToResizeColumns = False
        Me.flxMenu.AllowUserToResizeRows = False
        Me.flxMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.flxMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCode, Me.colDesignation, Me.colQte, Me.colPrice, Me.colTotal})
        Me.flxMenu.Location = New System.Drawing.Point(15, 169)
        Me.flxMenu.MultiSelect = False
        Me.flxMenu.Name = "flxMenu"
        Me.flxMenu.ReadOnly = True
        Me.flxMenu.RowHeadersVisible = False
        Me.flxMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.flxMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.flxMenu.Size = New System.Drawing.Size(340, 162)
        Me.flxMenu.TabIndex = 25
        '
        'colCode
        '
        Me.colCode.HeaderText = ""
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        Me.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDesignation
        '
        Me.colDesignation.HeaderText = ""
        Me.colDesignation.Name = "colDesignation"
        Me.colDesignation.ReadOnly = True
        Me.colDesignation.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colQte
        '
        Me.colQte.HeaderText = ""
        Me.colQte.Name = "colQte"
        Me.colQte.ReadOnly = True
        Me.colQte.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colQte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPrice
        '
        Me.colPrice.HeaderText = ""
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTotal
        '
        Me.colTotal.HeaderText = ""
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmSell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 422)
        Me.Controls.Add(Me.flxMenu)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDesignation)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtSet)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.cboDesignation)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdErase)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdModify)
        Me.Controls.Add(Me.cmdAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.hlpSell.SetHelpKeyword(Me, "8")
        Me.hlpSell.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSell"
        Me.hlpSell.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        CType(Me.flxMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hlpSell As System.Windows.Forms.HelpProvider
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdModify As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdErase As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cboDesignation As System.Windows.Forms.ComboBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtSet As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents lblSet As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents flxMenu As System.Windows.Forms.DataGridView
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesignation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
