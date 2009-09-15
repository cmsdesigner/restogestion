<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableHistory))
        Me.hlpSell = New System.Windows.Forms.HelpProvider
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblTable = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.flxMenu = New System.Windows.Forms.DataGridView
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesignation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblSet = New System.Windows.Forms.Label
        Me.txtSet = New System.Windows.Forms.TextBox
        CType(Me.flxMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(197, 279)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 18)
        Me.cmdPrint.TabIndex = 10
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(278, 279)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 18)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(253, 226)
        Me.txtDiscount.MaxLength = 8
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 9
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(253, 253)
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
        'lblDiscount
        '
        Me.lblDiscount.AutoEllipsis = True
        Me.lblDiscount.Location = New System.Drawing.Point(12, 226)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(235, 15)
        Me.lblDiscount.TabIndex = 23
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmount
        '
        Me.lblAmount.AutoEllipsis = True
        Me.lblAmount.Location = New System.Drawing.Point(12, 252)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(235, 15)
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
        Me.flxMenu.Location = New System.Drawing.Point(12, 35)
        Me.flxMenu.MultiSelect = False
        Me.flxMenu.Name = "flxMenu"
        Me.flxMenu.ReadOnly = True
        Me.flxMenu.RowHeadersVisible = False
        Me.flxMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.flxMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.flxMenu.Size = New System.Drawing.Size(340, 185)
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
        'lblSet
        '
        Me.lblSet.AutoEllipsis = True
        Me.lblSet.Location = New System.Drawing.Point(166, 9)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(125, 20)
        Me.lblSet.TabIndex = 27
        Me.lblSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSet
        '
        Me.txtSet.Location = New System.Drawing.Point(297, 9)
        Me.txtSet.MaxLength = 10
        Me.txtSet.Name = "txtSet"
        Me.txtSet.ReadOnly = True
        Me.txtSet.Size = New System.Drawing.Size(56, 20)
        Me.txtSet.TabIndex = 26
        '
        'frmTableHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 307)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.txtSet)
        Me.Controls.Add(Me.flxMenu)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.hlpSell.SetHelpKeyword(Me, "8")
        Me.hlpSell.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTableHistory"
        Me.hlpSell.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        CType(Me.flxMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hlpSell As System.Windows.Forms.HelpProvider
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents flxMenu As System.Windows.Forms.DataGridView
    Friend WithEvents lblSet As System.Windows.Forms.Label
    Friend WithEvents txtSet As System.Windows.Forms.TextBox
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesignation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
