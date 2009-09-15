<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTable))
        Me.mnuMenu = New System.Windows.Forms.MenuStrip
        Me.mnuMeal = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHistory = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuModify = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOption = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.hlpTable = New System.Windows.Forms.HelpProvider
        Me.fraSalle = New System.Windows.Forms.Panel
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMeal, Me.mnuCustomer, Me.mnuHistory, Me.mnuEdit, Me.mnuOption, Me.mnuHelpMenu})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(607, 24)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "Menu"
        '
        'mnuMeal
        '
        Me.mnuMeal.Name = "mnuMeal"
        Me.mnuMeal.Size = New System.Drawing.Size(12, 20)
        '
        'mnuCustomer
        '
        Me.mnuCustomer.Name = "mnuCustomer"
        Me.mnuCustomer.Size = New System.Drawing.Size(12, 20)
        '
        'mnuHistory
        '
        Me.mnuHistory.Name = "mnuHistory"
        Me.mnuHistory.Size = New System.Drawing.Size(12, 20)
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuModify})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(12, 20)
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAdd.Size = New System.Drawing.Size(108, 22)
        '
        'mnuModify
        '
        Me.mnuModify.CheckOnClick = True
        Me.mnuModify.Name = "mnuModify"
        Me.mnuModify.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuModify.Size = New System.Drawing.Size(108, 22)
        '
        'mnuOption
        '
        Me.mnuOption.Name = "mnuOption"
        Me.mnuOption.Size = New System.Drawing.Size(12, 20)
        '
        'mnuHelpMenu
        '
        Me.mnuHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp, Me.mnuAbout})
        Me.mnuHelpMenu.Name = "mnuHelpMenu"
        Me.mnuHelpMenu.Size = New System.Drawing.Size(12, 20)
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelp.Size = New System.Drawing.Size(86, 22)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(86, 22)
        '
        'fraSalle
        '
        Me.fraSalle.AutoSize = True
        Me.fraSalle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.fraSalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraSalle.Location = New System.Drawing.Point(0, 24)
        Me.fraSalle.Name = "fraSalle"
        Me.fraSalle.Padding = New System.Windows.Forms.Padding(3)
        Me.fraSalle.Size = New System.Drawing.Size(607, 450)
        Me.fraSalle.TabIndex = 1
        '
        'frmTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 474)
        Me.Controls.Add(Me.fraSalle)
        Me.Controls.Add(Me.mnuMenu)
        Me.hlpTable.SetHelpKeyword(Me, "4")
        Me.hlpTable.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmTable"
        Me.hlpTable.SetShowHelp(Me, True)
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMeal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hlpTable As System.Windows.Forms.HelpProvider
    Friend WithEvents mnuHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fraSalle As System.Windows.Forms.Panel

End Class
