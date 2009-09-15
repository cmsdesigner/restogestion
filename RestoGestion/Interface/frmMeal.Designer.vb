<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMeal))
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdModify = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtDesignation = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.lblDesignation = New System.Windows.Forms.Label
        Me.flxMeal = New System.Windows.Forms.DataGridView
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesignation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblTva = New System.Windows.Forms.Label
        Me.txtTva = New System.Windows.Forms.TextBox
        CType(Me.flxMeal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(407, 373)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(12, 90)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdModify
        '
        Me.cmdModify.Location = New System.Drawing.Point(137, 90)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(75, 23)
        Me.cmdModify.TabIndex = 5
        Me.cmdModify.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(271, 90)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 6
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(407, 90)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(112, 12)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(112, 64)
        Me.txtDesignation.MaxLength = 100
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(370, 20)
        Me.txtDesignation.TabIndex = 3
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(382, 12)
        Me.txtPrice.MaxLength = 8
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 1
        '
        'lblCode
        '
        Me.lblCode.AutoEllipsis = True
        Me.lblCode.Location = New System.Drawing.Point(12, 12)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(94, 20)
        Me.lblCode.TabIndex = 9
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.AutoEllipsis = True
        Me.lblPrice.Location = New System.Drawing.Point(218, 12)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(158, 20)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoEllipsis = True
        Me.lblDesignation.Location = New System.Drawing.Point(12, 64)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(94, 20)
        Me.lblDesignation.TabIndex = 11
        Me.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flxMeal
        '
        Me.flxMeal.AllowUserToAddRows = False
        Me.flxMeal.AllowUserToDeleteRows = False
        Me.flxMeal.AllowUserToResizeColumns = False
        Me.flxMeal.AllowUserToResizeRows = False
        Me.flxMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.flxMeal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCode, Me.colDesignation, Me.colPrice, Me.colTva})
        Me.flxMeal.Location = New System.Drawing.Point(12, 119)
        Me.flxMeal.MultiSelect = False
        Me.flxMeal.Name = "flxMeal"
        Me.flxMeal.ReadOnly = True
        Me.flxMeal.RowHeadersVisible = False
        Me.flxMeal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.flxMeal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.flxMeal.Size = New System.Drawing.Size(470, 248)
        Me.flxMeal.TabIndex = 12
        '
        'colCode
        '
        Me.colCode.Frozen = True
        Me.colCode.HeaderText = ""
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        Me.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDesignation
        '
        Me.colDesignation.Frozen = True
        Me.colDesignation.HeaderText = ""
        Me.colDesignation.Name = "colDesignation"
        Me.colDesignation.ReadOnly = True
        Me.colDesignation.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPrice
        '
        Me.colPrice.Frozen = True
        Me.colPrice.HeaderText = ""
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTva
        '
        Me.colTva.Frozen = True
        Me.colTva.HeaderText = ""
        Me.colTva.Name = "colTva"
        Me.colTva.ReadOnly = True
        Me.colTva.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblTva
        '
        Me.lblTva.AutoEllipsis = True
        Me.lblTva.Location = New System.Drawing.Point(218, 38)
        Me.lblTva.Name = "lblTva"
        Me.lblTva.Size = New System.Drawing.Size(158, 20)
        Me.lblTva.TabIndex = 14
        Me.lblTva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTva
        '
        Me.txtTva.Location = New System.Drawing.Point(382, 38)
        Me.txtTva.MaxLength = 8
        Me.txtTva.Name = "txtTva"
        Me.txtTva.Size = New System.Drawing.Size(100, 20)
        Me.txtTva.TabIndex = 2
        '
        'frmMeal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(494, 404)
        Me.Controls.Add(Me.lblTva)
        Me.Controls.Add(Me.txtTva)
        Me.Controls.Add(Me.flxMeal)
        Me.Controls.Add(Me.lblDesignation)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdModify)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMeal"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMeal"
        CType(Me.flxMeal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdModify As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents flxMeal As System.Windows.Forms.DataGridView
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesignation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTva As System.Windows.Forms.Label
    Friend WithEvents txtTva As System.Windows.Forms.TextBox
End Class
