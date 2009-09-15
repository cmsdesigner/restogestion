<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.flxHistory = New System.Windows.Forms.DataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtpDateInf = New System.Windows.Forms.DateTimePicker
        Me.dtpDateSup = New System.Windows.Forms.DateTimePicker
        Me.cmdFilter = New System.Windows.Forms.Button
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblSelect = New System.Windows.Forms.Label
        Me.lblAnd = New System.Windows.Forms.Label
        CType(Me.flxHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flxHistory
        '
        Me.flxHistory.AllowUserToAddRows = False
        Me.flxHistory.AllowUserToDeleteRows = False
        Me.flxHistory.AllowUserToResizeColumns = False
        Me.flxHistory.AllowUserToResizeRows = False
        Me.flxHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.flxHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTable, Me.colTotal})
        Me.flxHistory.Location = New System.Drawing.Point(12, 33)
        Me.flxHistory.MultiSelect = False
        Me.flxHistory.Name = "flxHistory"
        Me.flxHistory.ReadOnly = True
        Me.flxHistory.RowHeadersVisible = False
        Me.flxHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.flxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.flxHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.flxHistory.Size = New System.Drawing.Size(311, 220)
        Me.flxHistory.TabIndex = 0
        '
        'colDate
        '
        Me.colDate.HeaderText = ""
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTable
        '
        Me.colTable.HeaderText = ""
        Me.colTable.Name = "colTable"
        Me.colTable.ReadOnly = True
        Me.colTable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTotal
        '
        Me.colTotal.HeaderText = ""
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtpDateInf
        '
        Me.dtpDateInf.Location = New System.Drawing.Point(12, 282)
        Me.dtpDateInf.Name = "dtpDateInf"
        Me.dtpDateInf.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateInf.TabIndex = 1
        '
        'dtpDateSup
        '
        Me.dtpDateSup.Location = New System.Drawing.Point(12, 335)
        Me.dtpDateSup.Name = "dtpDateSup"
        Me.dtpDateSup.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateSup.TabIndex = 2
        '
        'cmdFilter
        '
        Me.cmdFilter.Location = New System.Drawing.Point(126, 384)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdFilter.TabIndex = 3
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoEllipsis = True
        Me.lblHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(311, 21)
        Me.lblHeader.TabIndex = 4
        '
        'lblSelect
        '
        Me.lblSelect.AutoEllipsis = True
        Me.lblSelect.Location = New System.Drawing.Point(12, 256)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(308, 23)
        Me.lblSelect.TabIndex = 5
        Me.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnd
        '
        Me.lblAnd.AutoEllipsis = True
        Me.lblAnd.Location = New System.Drawing.Point(12, 309)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(311, 23)
        Me.lblAnd.TabIndex = 6
        Me.lblAnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 419)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.cmdFilter)
        Me.Controls.Add(Me.dtpDateSup)
        Me.Controls.Add(Me.dtpDateInf)
        Me.Controls.Add(Me.flxHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistory"
        Me.ShowInTaskbar = False
        CType(Me.flxHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flxHistory As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDateInf As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateSup As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents lblAnd As System.Windows.Forms.Label
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
