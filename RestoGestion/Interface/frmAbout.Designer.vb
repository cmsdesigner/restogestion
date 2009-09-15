<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblVersion = New System.Windows.Forms.Label
        Me.txtCopyLeft = New System.Windows.Forms.TextBox
        Me.cmdCredit = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.hlpAbout = New System.Windows.Forms.HelpProvider
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.hlpAbout.SetHelpKeyword(Me.PictureBox1, "APropos")
        Me.hlpAbout.SetHelpNavigator(Me.PictureBox1, System.Windows.Forms.HelpNavigator.TopicId)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.hlpAbout.SetShowHelp(Me.PictureBox1, False)
        Me.PictureBox1.Size = New System.Drawing.Size(400, 60)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoEllipsis = True
        Me.hlpAbout.SetHelpKeyword(Me.lblVersion, "APropos")
        Me.hlpAbout.SetHelpNavigator(Me.lblVersion, System.Windows.Forms.HelpNavigator.TopicId)
        Me.lblVersion.Location = New System.Drawing.Point(12, 63)
        Me.lblVersion.Name = "lblVersion"
        Me.hlpAbout.SetShowHelp(Me.lblVersion, False)
        Me.lblVersion.Size = New System.Drawing.Size(375, 17)
        Me.lblVersion.TabIndex = 1
        '
        'txtCopyLeft
        '
        Me.hlpAbout.SetHelpKeyword(Me.txtCopyLeft, "APropos")
        Me.hlpAbout.SetHelpNavigator(Me.txtCopyLeft, System.Windows.Forms.HelpNavigator.TopicId)
        Me.txtCopyLeft.Location = New System.Drawing.Point(12, 83)
        Me.txtCopyLeft.Multiline = True
        Me.txtCopyLeft.Name = "txtCopyLeft"
        Me.hlpAbout.SetShowHelp(Me.txtCopyLeft, False)
        Me.txtCopyLeft.Size = New System.Drawing.Size(375, 193)
        Me.txtCopyLeft.TabIndex = 2
        '
        'cmdCredit
        '
        Me.hlpAbout.SetHelpKeyword(Me.cmdCredit, "APropos")
        Me.hlpAbout.SetHelpNavigator(Me.cmdCredit, System.Windows.Forms.HelpNavigator.TopicId)
        Me.cmdCredit.Location = New System.Drawing.Point(12, 282)
        Me.cmdCredit.Name = "cmdCredit"
        Me.hlpAbout.SetShowHelp(Me.cmdCredit, False)
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 3
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.hlpAbout.SetHelpKeyword(Me.cmdOk, "")
        Me.cmdOk.Location = New System.Drawing.Point(312, 282)
        Me.cmdOk.Name = "cmdOk"
        Me.hlpAbout.SetShowHelp(Me.cmdOk, False)
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'hlpAbout
        '
        Me.hlpAbout.HelpNamespace = ""
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 314)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.txtCopyLeft)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.hlpAbout.SetHelpKeyword(Me, "12")
        Me.hlpAbout.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.hlpAbout.SetHelpString(Me, "")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.hlpAbout.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents txtCopyLeft As System.Windows.Forms.TextBox
    Friend WithEvents cmdCredit As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents hlpAbout As System.Windows.Forms.HelpProvider
End Class
