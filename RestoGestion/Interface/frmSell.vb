Option Explicit On
Option Strict On

'***********************************************************
'*                                                         *
'* Copyright (C) 2006 by Sylvain Bodin                     *
'*                                                         *
'* This file is part of Resto Gestion                      *
'*                                                         *
'* Resto Gestion is free software; you can redistribute it *
'* and/or modify it under the terms of the GNU General     *
'* Public License as published by the Free Software        *
'* Foundation; either version 2 of the License, or any     *
'* later version.                                          *
'*                                                         *
'* This program is distributed in the hope that it will be *
'* useful, but WITHOUT ANY WARRANTY; without even the      *
'* implied warranty of MERCHANTABILITY or FITNESS FOR A    *
'* PARTICULAR PURPOSE.  See the GNU General Public License *
'* for more details.                                       *
'*                                                         *
'* You should have received a copy of the GNU General      *
'* Public License along with this program; if not, write   *
'* to the Free Software Foundation, Inc. at:               *
'*                                                         *
'*           Free Software Foundation, Inc.                *
'*           59 Temple Place - Suite 330                   *
'*           Boston, MA  02111-1307, USA.                  *
'*                                                         *
'***********************************************************
Public Class frmSell
    Private dMnt As Single 'Total

    Private Sub frmSell_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            CurrentTable.NbSet = txtSet.Text
            CurrentTable.TxDiscount = CSng(txtDiscount.Text)
            resto.UpdateItem(CurrentTable.Id, CurrentTable)
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub frmSell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'recupération des libellés suivant la langue
        cmdCancel.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CANCEL_ACTION).Value
        cmdClose.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CLOSE_ACTION).Value
        cmdAdd.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.ADD_ACTION).Value
        cmdModify.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.MODIFY_FORM).Value
        cmdDelete.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.DELETE_ACTION).Value
        cmdErase.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.ERASE_ACTION).Value
        cmdPrint.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.PRINT_LABELS).Value
        Me.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.NAME).Value
        lblCode.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.CODE).Value
        lblDesignation.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.DESIGNATION).Value
        lblPrice.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.PRICE).Value
        lblQuantity.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.QUANTITY).Value
        lblSet.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.SET).Value
        lblAmount.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.AMOUNT).Value
        lblDiscount.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.DISCOUNT).Value
        AddHandler txtSet.KeyPress, AddressOf NextTab
        AddHandler txtCode.KeyPress, AddressOf NextTab
        AddHandler cboDesignation.KeyPress, AddressOf NextTab
        hlpSell.HelpNamespace = Consts.HELPPATH + "commandes.htm"

        Try
            'on remplit les champs
            txtSet.Text = CurrentTable.NbSet
            lblTable.Text = CurrentTable.Name
            txtDiscount.Text = CurrentTable.TxDiscount.ToString
            'recupération des plats
            cboDesignation.DataSource = carte
            cboDesignation.DisplayMember = "Designation"
            cboDesignation.ValueMember = "Code"
            cboDesignation.SelectedItem = Nothing
        Catch ex As Exception
            TraceError(ex)
        End Try
        'on formatte la grille et on la remplit si besoin
        AfficheGrille()
    End Sub

    Private Sub AfficheGrille()
        Dim it As IEnumerator
        Dim order As Commande
        Dim plat As Plat

        'formattage de la grille
        dMnt = 0
        flxMenu.Rows.Clear()
        flxMenu.Columns("colCode").HeaderText = lblCode.Text
        flxMenu.Columns("colDesignation").HeaderText = lblDesignation.Text
        flxMenu.Columns("colQte").HeaderText = lblQuantity.Text
        flxMenu.Columns("colPrice").HeaderText = lblPrice.Text
        flxMenu.Columns("colTotal").HeaderText = label(LanguageFile.SELL_FORM).Label(LanguageFile.TOTAL).Value

        flxMenu.Columns("colCode").Width = 80
        flxMenu.Columns("colDesignation").Width = 107
        flxMenu.Columns("colQte").Width = 50
        flxMenu.Columns("colPrice").Width = 50
        flxMenu.Columns("colTotal").Width = 50

        Try
            it = CurrentTable.GetEnumerator
            While it.MoveNext
                order = CType(it.Current, Commande)
                plat = carte(order.PlatCode)
                'Ajout dans la grille
                Dim tRow() As Object = {order.PlatCode, plat.Designation, order.Quantite, plat.Prix, order.Quantite * plat.Prix}
                flxMenu.Rows.Add(tRow)
                dMnt = dMnt + (order.Quantite * plat.Prix)
            End While
        Catch ex As Exception
            TraceError(ex)
        End Try
        txtAmount.Text = System.Math.Round(dMnt - (dMnt * CSng(txtDiscount.Text.Replace(".", ",")) / 100), 2).ToString
    End Sub

    Private Sub cboDesignation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDesignation.SelectedIndexChanged

        Try
            If Not cboDesignation.SelectedItem Is Nothing Then
                txtCode.Text = CType(cboDesignation.SelectedItem, Plat).Code
                txtPrice.Text = CType(cboDesignation.SelectedItem, Plat).Prix.ToString
                txtQuantity.Focus()
            Else
                txtCode.Clear()
                txtPrice.Clear()
                txtCode.Focus()
            End If
            txtQuantity.Text = "1"
        Catch ex As Exception
            TraceError(ex)
        End Try

    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Dim plat As Plat

        If txtCode.Text <> "" Then
            Try
                plat = carte(txtCode.Text)
                txtPrice.Text = plat.Prix.ToString
                cboDesignation.SelectedItem = plat
                txtQuantity.Focus()
            Catch ex As KeyNotFoundException
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.CODEINVALID).Value)
                cboDesignation.SelectedItem = Nothing
            Catch ex As Exception
                TraceError(ex)
            End Try
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        NextTab(sender, e)
        If Not e.KeyChar Like "[0123456789,.]" And Not e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Back)) Then e.KeyChar = Convert.ToChar(0)
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If txtDiscount.Text <> "" Then
            If CSng(txtDiscount.Text.Replace(".", ",")) > 100 Then
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.DISCOUNTINVALID).Value)
                txtDiscount.Clear()
                txtDiscount.Focus()
            Else
                txtAmount.Text = System.Math.Round(dMnt - (dMnt * CSng(txtDiscount.Text.Replace(".", ",")) / 100), 2).ToString
            End If
        Else
            txtDiscount.Text = "0"
            txtAmount.Text = System.Math.Round(dMnt - (dMnt * CSng(txtDiscount.Text.Replace(".", ",")) / 100), 2).ToString
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        NextTab(sender, e)
        If Not e.KeyChar Like "[0123456789-]" And Not e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Back)) Then e.KeyChar = Convert.ToChar(0)
    End Sub

    Private Sub txtVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NextTab(sender, e)
        If Not e.KeyChar Like "[0123456789,.]" And Not e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Back)) Then e.KeyChar = Convert.ToChar(0)
    End Sub

    Private Sub flxMenu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flxMenu.CellClick, flxMenu.Enter
        If flxMenu.SelectedRows.Count > 0 Then
            txtCode.Text = flxMenu.SelectedRows(0).Cells("colCode").Value.ToString
            cboDesignation.Text = flxMenu.SelectedRows(0).Cells("colDesignation").Value.ToString
            txtPrice.Text = flxMenu.SelectedRows(0).Cells("colPrice").Value.ToString
            txtQuantity.Text = flxMenu.SelectedRows(0).Cells("colQte").Value.ToString
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim frmFormPrint As New frmPrint
        Dim oRow As System.Windows.Forms.DataGridViewRow

        For Each oRow In flxMenu.Rows
            Dim plat As New Plat
            plat = carte(oRow.Cells("colCode").Value.ToString)
            frmFormPrint.Quantity.Add(CInt(oRow.Cells("colQte").Value))
            frmFormPrint.Designation.Add(oRow.Cells("colDesignation").Value.ToString)
            frmFormPrint.Total.Add(CSng(oRow.Cells("colTotal").Value))
            frmFormPrint.Tva.Add(plat.Tva)
        Next
        frmFormPrint.NbSet = txtSet.Text
        frmFormPrint.TableName = lblTable.Text
        frmFormPrint.Discount = CSng(txtDiscount.Text.Replace(".", ","))
        frmFormPrint.Amount = CSng(txtAmount.Text.Replace(".", ","))
        frmFormPrint.Date = Date.Now
        frmFormPrint.ShowDialog()
        frmFormPrint.Dispose()
        cmdErase.Focus()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim order As Commande

        If Not cboDesignation.SelectedItem Is Nothing Then
            If txtQuantity.Text <> "" Then
                If CInt(txtQuantity.Text) > 0 Then
                    Try
                        'Ajout en base
                        order = CurrentTable.Item(txtCode.Text)
                        order.Quantite = CInt(txtQuantity.Text)
                        CurrentTable.UpdateItem(txtCode.Text, order)
                        AfficheGrille()
                        cboDesignation.SelectedIndex = Nothing
                    Catch ex As Exception
                        TraceError(ex)
                    End Try
                Else
                    MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.QUANTITYINVALID).Value)
                    txtQuantity.Focus()
                End If
            Else
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOQUANTITY).Value)
                txtQuantity.Focus()
            End If
        Else
            MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOMEALSELECT).Value)
            cboDesignation.Focus()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If flxMenu.SelectedRows.Count > 0 Then
            Try
                CurrentTable.Remove(flxMenu.SelectedRows(0).Cells("colCode").Value.ToString)
                AfficheGrille()
                cboDesignation.SelectedItem = Nothing
            Catch ex As Exception
                TraceError(ex)
            End Try
        Else
            MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.ROWSELECT).Value)
        End If
    End Sub

    Private Sub cmdErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdErase.Click
        Dim mRep As DialogResult
        Dim frmPass As frmPassword
        Dim oRow As DataGridViewRow
        Dim passwordOk As Boolean
        Dim hisTable As HistoTable

        passwordOk = True
        If config.HasPasswordErase Then
            frmPass = New frmPassword
            frmPass.PasswordErase = True
            frmPass.ShowDialog()
            passwordOk = frmPass.passwordOk
            frmPass = Nothing
        End If
        If passwordOk Then

            mRep = MessageBox.Show(label(LanguageFile.SELL_FORM).Label(LanguageFile.ERASEQUESTION).Value, label(LanguageFile.SELL_FORM).Label(LanguageFile.ERASETITLE).Value, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mRep.Equals(DialogResult.Yes) Then
                Try
                    hisTable = New HistoTable
                    hisTable.HistoDate = DateTime.Now
                    hisTable.Name = lblTable.Text
                    hisTable.NbSet = txtSet.Text
                    hisTable.TxDiscount = CSng(txtDiscount.Text.Replace(".", ","))
                    histo.Add(hisTable)
                    For Each oRow In flxMenu.Rows
                        Dim hisCmd As New HistoCommande
                        Dim plat As New Plat

                        plat = carte(oRow.Cells("colCode").Value.ToString)

                        hisCmd.Code = plat.Code
                        hisCmd.Designation = plat.Designation
                        hisCmd.Prix = plat.Prix
                        hisCmd.Quantite = CInt(oRow.Cells("colQte").Value)
                        hisCmd.Tva = plat.Tva
                        hisTable.Add(hisCmd)
                        hisCmd = Nothing
                    Next
                    hisTable = Nothing

                    'Supprime de la base
                    CurrentTable.Clear()
                    CurrentTable.NbSet = ""
                    resto.UpdateItem(CurrentTable.Id, CurrentTable)

                    'Efface la grille
                    AfficheGrille()
                    RAZText(Me)
                    cmdClose.Focus()
                Catch ex As Exception
                    TraceError(ex)
                End Try
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cboDesignation.SelectedItem = Nothing
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        If txtQuantity.Text = "" Then
            txtQuantity.Text = "1"
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim order As Commande

        If cboDesignation.SelectedIndex <> -1 Then
            If txtQuantity.Text <> "" Then
                Try
                    'Ajout en base
                    order = New Commande
                    order.PlatCode = txtCode.Text
                    order.Quantite = CInt(txtQuantity.Text)
                    CurrentTable.Add(order)
                    AfficheGrille()
                    cboDesignation.SelectedItem = Nothing
                Catch ex As ApplicationException
                    MessError(ex.Message)
                Catch ex As Exception
                    TraceError(ex)
                End Try
            Else
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOQUANTITY).Value)
                txtQuantity.Focus()
            End If
        Else
            MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOMEALSELECT).Value)
            cboDesignation.Focus()
        End If
    End Sub

    Private m_CurrentTable As Table
    Public Property CurrentTable() As Table
        Get
            Return m_CurrentTable
        End Get
        Set(ByVal value As Table)
            m_CurrentTable = value
        End Set
    End Property
End Class