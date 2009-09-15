<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModify))
        Me.rdbMove = New System.Windows.Forms.RadioButton
        Me.rdbSize = New System.Windows.Forms.RadioButton
        Me.updLeft = New System.Windows.Forms.NumericUpDown
        Me.updTop = New System.Windows.Forms.NumericUpDown
        Me.updHeight = New System.Windows.Forms.NumericUpDown
        Me.updWidth = New System.Windows.Forms.NumericUpDown
        Me.lblTop = New System.Windows.Forms.Label
        Me.lblWidth = New System.Windows.Forms.Label
        Me.lblLeft = New System.Windows.Forms.Label
        Me.lblHeight = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.chkEnable = New System.Windows.Forms.CheckBox
        Me.cmdApply = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.hlpModify = New System.Windows.Forms.HelpProvider
        CType(Me.updLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbMove
        '
        Me.rdbMove.AutoEllipsis = True
        Me.rdbMove.Location = New System.Drawing.Point(12, 67)
        Me.rdbMove.Name = "rdbMove"
        Me.rdbMove.Size = New System.Drawing.Size(205, 17)
        Me.rdbMove.TabIndex = 1
        Me.rdbMove.TabStop = True
        Me.rdbMove.UseVisualStyleBackColor = True
        '
        'rdbSize
        '
        Me.rdbSize.AutoEllipsis = True
        Me.rdbSize.Location = New System.Drawing.Point(12, 151)
        Me.rdbSize.Name = "rdbSize"
        Me.rdbSize.Size = New System.Drawing.Size(205, 17)
        Me.rdbSize.TabIndex = 2
        Me.rdbSize.TabStop = True
        Me.rdbSize.UseVisualStyleBackColor = True
        '
        'updLeft
        '
        Me.updLeft.Location = New System.Drawing.Point(113, 116)
        Me.updLeft.Name = "updLeft"
        Me.updLeft.Size = New System.Drawing.Size(104, 20)
        Me.updLeft.TabIndex = 4
        '
        'updTop
        '
        Me.updTop.Location = New System.Drawing.Point(113, 90)
        Me.updTop.Name = "updTop"
        Me.updTop.Size = New System.Drawing.Size(104, 20)
        Me.updTop.TabIndex = 3
        '
        'updHeight
        '
        Me.updHeight.Location = New System.Drawing.Point(113, 200)
        Me.updHeight.Name = "updHeight"
        Me.updHeight.Size = New System.Drawing.Size(104, 20)
        Me.updHeight.TabIndex = 6
        '
        'updWidth
        '
        Me.updWidth.Location = New System.Drawing.Point(113, 174)
        Me.updWidth.Name = "updWidth"
        Me.updWidth.Size = New System.Drawing.Size(104, 20)
        Me.updWidth.TabIndex = 5
        '
        'lblTop
        '
        Me.lblTop.AutoEllipsis = True
        Me.lblTop.Location = New System.Drawing.Point(12, 90)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(95, 20)
        Me.lblTop.TabIndex = 10
        Me.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWidth
        '
        Me.lblWidth.AutoEllipsis = True
        Me.lblWidth.Location = New System.Drawing.Point(12, 174)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(95, 20)
        Me.lblWidth.TabIndex = 11
        Me.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLeft
        '
        Me.lblLeft.AutoEllipsis = True
        Me.lblLeft.Location = New System.Drawing.Point(12, 116)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(95, 20)
        Me.lblLeft.TabIndex = 12
        Me.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeight
        '
        Me.lblHeight.AutoEllipsis = True
        Me.lblHeight.Location = New System.Drawing.Point(12, 200)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(95, 20)
        Me.lblHeight.TabIndex = 13
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(113, 30)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(104, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.Location = New System.Drawing.Point(12, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 20)
        Me.lblName.TabIndex = 15
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEnable
        '
        Me.chkEnable.AutoEllipsis = True
        Me.chkEnable.Location = New System.Drawing.Point(15, 238)
        Me.chkEnable.Name = "chkEnable"
        Me.chkEnable.Size = New System.Drawing.Size(121, 23)
        Me.chkEnable.TabIndex = 7
        Me.chkEnable.UseVisualStyleBackColor = True
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(15, 300)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 9
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(142, 300)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(142, 238)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'frmModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(229, 335)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.chkEnable)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.updWidth)
        Me.Controls.Add(Me.updHeight)
        Me.Controls.Add(Me.updTop)
        Me.Controls.Add(Me.updLeft)
        Me.Controls.Add(Me.rdbSize)
        Me.Controls.Add(Me.rdbMove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.hlpModify.SetHelpKeyword(Me, "9")
        Me.hlpModify.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModify"
        Me.hlpModify.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        CType(Me.updLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbMove As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSize As System.Windows.Forms.RadioButton
    Friend WithEvents updLeft As System.Windows.Forms.NumericUpDown
    Friend WithEvents updTop As System.Windows.Forms.NumericUpDown
    Friend WithEvents updHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents updWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTop As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents chkEnable As System.Windows.Forms.CheckBox
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents hlpModify As System.Windows.Forms.HelpProvider
End Class
