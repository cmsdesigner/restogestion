<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.hlpCustomer = New System.Windows.Forms.HelpProvider
        Me.lblLastName = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.lblZipCode = New System.Windows.Forms.Label
        Me.txtTown = New System.Windows.Forms.TextBox
        Me.lblTown = New System.Windows.Forms.Label
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.lblPhoneNumber = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.lblComment = New System.Windows.Forms.Label
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdModify = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.ClientNomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientPrenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientAdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientVilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientTelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientRemarqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.flxCustomer = New System.Windows.Forms.DataGridView
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colZipCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTown = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colComment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.flxCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLastName
        '
        Me.lblLastName.AutoEllipsis = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 9)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(94, 20)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(112, 9)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(144, 20)
        Me.txtLastName.TabIndex = 0
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(503, 9)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(166, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoEllipsis = True
        Me.lblFirstName.Location = New System.Drawing.Point(262, 9)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(235, 20)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(112, 35)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(325, 20)
        Me.txtAddress.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoEllipsis = True
        Me.lblAddress.Location = New System.Drawing.Point(12, 35)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(94, 20)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(579, 35)
        Me.txtZipCode.MaxLength = 50
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(91, 20)
        Me.txtZipCode.TabIndex = 3
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoEllipsis = True
        Me.lblZipCode.Location = New System.Drawing.Point(443, 35)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(130, 20)
        Me.lblZipCode.TabIndex = 6
        Me.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(112, 61)
        Me.txtTown.MaxLength = 50
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(199, 20)
        Me.txtTown.TabIndex = 4
        '
        'lblTown
        '
        Me.lblTown.AutoEllipsis = True
        Me.lblTown.Location = New System.Drawing.Point(12, 61)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(94, 20)
        Me.lblTown.TabIndex = 8
        Me.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(543, 61)
        Me.txtPhoneNumber.MaxLength = 50
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(127, 20)
        Me.txtPhoneNumber.TabIndex = 5
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoEllipsis = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(317, 61)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(220, 20)
        Me.lblPhoneNumber.TabIndex = 10
        Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(112, 87)
        Me.txtComment.MaxLength = 100
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(558, 20)
        Me.txtComment.TabIndex = 6
        '
        'lblComment
        '
        Me.lblComment.AutoEllipsis = True
        Me.lblComment.Location = New System.Drawing.Point(12, 87)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(94, 20)
        Me.lblComment.TabIndex = 12
        Me.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(122, 113)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdModify
        '
        Me.cmdModify.Location = New System.Drawing.Point(248, 113)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(75, 23)
        Me.cmdModify.TabIndex = 8
        Me.cmdModify.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(369, 113)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(501, 113)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(595, 362)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'ClientNomDataGridViewTextBoxColumn
        '
        Me.ClientNomDataGridViewTextBoxColumn.DataPropertyName = "ClientNom"
        Me.ClientNomDataGridViewTextBoxColumn.HeaderText = "ClientNom"
        Me.ClientNomDataGridViewTextBoxColumn.Name = "ClientNomDataGridViewTextBoxColumn"
        '
        'ClientPrenomDataGridViewTextBoxColumn
        '
        Me.ClientPrenomDataGridViewTextBoxColumn.DataPropertyName = "ClientPrenom"
        Me.ClientPrenomDataGridViewTextBoxColumn.HeaderText = "ClientPrenom"
        Me.ClientPrenomDataGridViewTextBoxColumn.Name = "ClientPrenomDataGridViewTextBoxColumn"
        '
        'ClientAdresseDataGridViewTextBoxColumn
        '
        Me.ClientAdresseDataGridViewTextBoxColumn.DataPropertyName = "ClientAdresse"
        Me.ClientAdresseDataGridViewTextBoxColumn.HeaderText = "ClientAdresse"
        Me.ClientAdresseDataGridViewTextBoxColumn.Name = "ClientAdresseDataGridViewTextBoxColumn"
        '
        'ClientCPDataGridViewTextBoxColumn
        '
        Me.ClientCPDataGridViewTextBoxColumn.DataPropertyName = "ClientCP"
        Me.ClientCPDataGridViewTextBoxColumn.HeaderText = "ClientCP"
        Me.ClientCPDataGridViewTextBoxColumn.Name = "ClientCPDataGridViewTextBoxColumn"
        '
        'ClientVilleDataGridViewTextBoxColumn
        '
        Me.ClientVilleDataGridViewTextBoxColumn.DataPropertyName = "ClientVille"
        Me.ClientVilleDataGridViewTextBoxColumn.HeaderText = "ClientVille"
        Me.ClientVilleDataGridViewTextBoxColumn.Name = "ClientVilleDataGridViewTextBoxColumn"
        '
        'ClientTelephoneDataGridViewTextBoxColumn
        '
        Me.ClientTelephoneDataGridViewTextBoxColumn.DataPropertyName = "ClientTelephone"
        Me.ClientTelephoneDataGridViewTextBoxColumn.HeaderText = "ClientTelephone"
        Me.ClientTelephoneDataGridViewTextBoxColumn.Name = "ClientTelephoneDataGridViewTextBoxColumn"
        '
        'ClientRemarqueDataGridViewTextBoxColumn
        '
        Me.ClientRemarqueDataGridViewTextBoxColumn.DataPropertyName = "ClientRemarque"
        Me.ClientRemarqueDataGridViewTextBoxColumn.HeaderText = "ClientRemarque"
        Me.ClientRemarqueDataGridViewTextBoxColumn.Name = "ClientRemarqueDataGridViewTextBoxColumn"
        '
        'flxCustomer
        '
        Me.flxCustomer.AllowUserToAddRows = False
        Me.flxCustomer.AllowUserToDeleteRows = False
        Me.flxCustomer.AllowUserToResizeColumns = False
        Me.flxCustomer.AllowUserToResizeRows = False
        Me.flxCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.flxCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLastName, Me.colFirstName, Me.colAddress, Me.colZipCode, Me.colTown, Me.colPhone, Me.colComment, Me.colId})
        Me.flxCustomer.Location = New System.Drawing.Point(12, 142)
        Me.flxCustomer.MultiSelect = False
        Me.flxCustomer.Name = "flxCustomer"
        Me.flxCustomer.ReadOnly = True
        Me.flxCustomer.RowHeadersVisible = False
        Me.flxCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.flxCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.flxCustomer.Size = New System.Drawing.Size(658, 208)
        Me.flxCustomer.TabIndex = 13
        '
        'colLastName
        '
        Me.colLastName.HeaderText = ""
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        Me.colLastName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colLastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colFirstName
        '
        Me.colFirstName.HeaderText = ""
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.ReadOnly = True
        Me.colFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colAddress
        '
        Me.colAddress.HeaderText = ""
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colZipCode
        '
        Me.colZipCode.HeaderText = ""
        Me.colZipCode.Name = "colZipCode"
        Me.colZipCode.ReadOnly = True
        Me.colZipCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colZipCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTown
        '
        Me.colTown.HeaderText = ""
        Me.colTown.Name = "colTown"
        Me.colTown.ReadOnly = True
        Me.colTown.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTown.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPhone
        '
        Me.colPhone.HeaderText = ""
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        Me.colPhone.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colComment
        '
        Me.colComment.HeaderText = ""
        Me.colComment.Name = "colComment"
        Me.colComment.ReadOnly = True
        Me.colComment.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colId
        '
        Me.colId.HeaderText = ""
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colId.Visible = False
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 405)
        Me.Controls.Add(Me.flxCustomer)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdModify)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.txtTown)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.hlpCustomer.SetHelpKeyword(Me, "6")
        Me.hlpCustomer.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomer"
        Me.hlpCustomer.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.flxCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hlpCustomer As System.Windows.Forms.HelpProvider
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdModify As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ClientNomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientPrenomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientAdresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientCPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientVilleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientTelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientRemarqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents flxCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents colLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colZipCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTown As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colComment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
