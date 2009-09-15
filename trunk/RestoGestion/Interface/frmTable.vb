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
Public Class frmTable
    Private frmMod As frmModify
    Private CurrentTable As Button
    Private x, y As Integer

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim cmdPrec As New Button
        Dim oTable As New Table
        Dim i As Integer

        Try
            'on ajoute un bouton "table" sur la fenêtre
            i = fraSalle.Controls.Count
            oTable.Id = -1 'on force pour générer un nouvel Id automatiquement
            oTable.Name = label(LanguageFile.TABLE_FORM).Label(LanguageFile.TABLE_DEFAULT_NAME).Value + i.ToString
            oTable.NbSet = ""
            oTable.Width = 100
            oTable.Height = 50
            oTable.Top = fraSalle.Padding.Top
            oTable.Left = fraSalle.Padding.Left
            If i > 0 Then
                If TypeOf (fraSalle.Controls(i - 1)) Is Button Then
                    cmdPrec = CType(fraSalle.Controls(i - 1), Button)
                    oTable.Height = cmdPrec.Height
                    oTable.Width = cmdPrec.Width
                    oTable.Top = cmdPrec.Top
                    oTable.Left = cmdPrec.Left + cmdPrec.Width

                    If (oTable.Left + oTable.Width) > (fraSalle.Width - fraSalle.Padding.Right) Then
                        oTable.Left = fraSalle.Padding.Left
                        oTable.Top = cmdPrec.Top + cmdPrec.Height
                    End If
                End If
            End If
            oTable.Enable = True

            resto.Add(oTable)
            fraSalle.Controls.Add(TableToButton(oTable))
        Catch ex As Exception
            TraceError(ex)
        Finally
            cmdPrec = Nothing
            oTable = Nothing
        End Try
    End Sub

    Private Sub mnuModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModify.Click
        Dim it As IEnumerator

        Try
            mnuMeal.Enabled = Not mnuModify.Checked
            mnuCustomer.Enabled = Not mnuModify.Checked
            mnuHelpMenu.Enabled = Not mnuModify.Checked
            mnuOption.Enabled = Not mnuModify.Checked
            mnuHistory.Enabled = Not mnuModify.Checked
            it = fraSalle.Controls.GetEnumerator
            While it.MoveNext
                If mnuModify.Checked Then
                    CType(it.Current, Control).Enabled = True
                Else
                    Dim index As Integer

                    index = CInt(CType(it.Current, Control).Tag)
                    CType(it.Current, Control).Enabled = resto(index).Enable
                End If
            End While
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SelectedButton As Button

        SelectedButton = CType(sender, Button)
        If frmMod Is Nothing Then
            If mnuModify.Checked Then
                frmMod = New frmModify(SelectedButton)
                CurrentTable = SelectedButton
                frmMod.Show()
                frmMod.Select()
            Else
                Dim frmSellForm As New frmSell

                frmSellForm.CurrentTable = resto(CInt(SelectedButton.Tag))
                frmSellForm.ShowDialog()
                frmSellForm = Nothing
            End If
        End If
    End Sub

    Private Sub cmdTable_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim SelectedButton As Button

        Try
            SelectedButton = CType(sender, Button)
            If Not frmMod Is Nothing Then
                If SelectedButton.Equals(CurrentTable) Then
                    If e.Button = Windows.Forms.MouseButtons.Left Then
                        If frmMod.rdbMove.Checked Then
                            SelectedButton.Left = (SelectedButton.Left + e.X) - x
                            SelectedButton.Top = (SelectedButton.Top + e.Y) - y
                            SelectedButton.Refresh()
                            If SelectedButton.Left > frmMod.updLeft.Maximum Then
                                SelectedButton.Left = CInt(frmMod.updLeft.Maximum)
                            ElseIf SelectedButton.Left < frmMod.updLeft.Minimum Then
                                SelectedButton.Left = CInt(frmMod.updLeft.Minimum)
                            End If
                            frmMod.updLeft.Value = SelectedButton.Left
                            If SelectedButton.Top > frmMod.updTop.Maximum Then
                                SelectedButton.Top = CInt(frmMod.updTop.Maximum)
                            ElseIf SelectedButton.Top < frmMod.updTop.Minimum Then
                                SelectedButton.Top = CInt(frmMod.updTop.Minimum)
                            End If
                            frmMod.updTop.Value = SelectedButton.Top
                        Else
                            SelectedButton.Width = (SelectedButton.Width + e.X) - x
                            SelectedButton.Height = (SelectedButton.Height + e.Y) - y
                            x = e.X
                            y = e.Y
                            SelectedButton.Refresh()
                            If SelectedButton.Width > frmMod.updWidth.Maximum Then
                                SelectedButton.Width = CInt(frmMod.updWidth.Maximum)
                            ElseIf SelectedButton.Width < frmMod.updWidth.Minimum Then
                                SelectedButton.Width = CInt(frmMod.updWidth.Minimum)
                            End If
                            If SelectedButton.Height > frmMod.updHeight.Maximum Then
                                SelectedButton.Height = CInt(frmMod.updHeight.Maximum)
                            ElseIf SelectedButton.Height < frmMod.updHeight.Minimum Then
                                SelectedButton.Height = CInt(frmMod.updHeight.Minimum)
                            End If
                            frmMod.updHeight.Value = SelectedButton.Height
                            frmMod.updWidth.Value = SelectedButton.Width
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdTable_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        x = e.X
        y = e.Y
    End Sub

    Private Sub frmTable_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim it As IEnumerator

        If Not frmMod Is Nothing Then
            If frmMod.Disposing Then
                frmMod = Nothing
            End If
        End If

        it = fraSalle.Controls.GetEnumerator
        While it.MoveNext
            Dim SelectButton As Button

            SelectButton = CType(it.Current, Button)
            If resto(CInt(SelectButton.Tag)).HasOrder Then
                SelectButton.BackColor = Color.CornflowerBlue
            Else
                SelectButton.BackColor = Color.Transparent
            End If
        End While
    End Sub

    Private Sub frmTable_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not frmMod Is Nothing Then
            frmMod.Dispose()
        End If
    End Sub

    Private Sub frmTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim it As IEnumerator

        mnuMeal.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.MEAL_MENU).Value
        mnuCustomer.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.CUSTOMER_MENU).Value
        mnuAdd.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.ADD_MENU).Value
        mnuOption.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.OPTION_MENU).Value
        mnuAbout.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.ABOUT_MENU).Value
        mnuHelp.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.HELP_MENU).Value
        mnuModify.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.MODIFY_MENU).Value
        mnuEdit.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.EDIT_MENU).Value
        mnuHelpMenu.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.HELP_SUB_MENU).Value
        mnuHistory.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.HISTORY_MENU).Value
        Me.Text = label(LanguageFile.TABLE_FORM).Label(LanguageFile.NAME).Value
        hlpTable.HelpNamespace = HELPPATH + "index.htm"

        Try
            it = resto.GetEnumerator
            While it.MoveNext
                fraSalle.Controls.Add(TableToButton(CType(it.Current, Table)))
            End While
        Catch ex As Exception
            TraceError(ex)
        End Try
        'TODO VerifyUpdate()
    End Sub

    Private Sub mnuMeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMeal.Click
        Dim frmMeal As New frmMeal
        frmMeal.ShowDialog()
        frmMeal = Nothing
    End Sub

    Private Sub mnuCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomer.Click
        Dim frmCustomForm As New frmCustomer
        frmCustomForm.ShowDialog()
        frmCustomForm = Nothing
    End Sub

    Private Sub mnuOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOption.Click
        Dim frmOptionForm As New frmOption
        frmOptionForm.ShowDialog()
        frmOptionForm = Nothing
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Dim frmAboutForm As New frmAbout
        frmAboutForm.ShowDialog()
        frmAboutForm = Nothing
    End Sub

    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, HELPPATH + "index.htm")
    End Sub

    Private Sub mnuHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHistory.Click
        Dim frmHistoryForm As New frmHistory
        frmHistoryForm.ShowDialog()
        frmHistoryForm = Nothing
    End Sub

    Private Function TableToButton(ByVal Table As Table) As Button
        Dim result As Button

        result = New Button
        result.Visible = True
        result.Height = Table.Height
        result.Width = Table.Width
        result.Left = Table.Left
        result.Top = Table.Top
        result.Text = Table.Name
        result.Enabled = Table.Enable
        result.Tag = Table.Id
        result.Name = "Table" + Table.Id.ToString
        AddHandler result.Click, AddressOf cmdTable_Click
        AddHandler result.MouseMove, AddressOf cmdTable_MouseMove
        AddHandler result.MouseDown, AddressOf cmdTable_MouseDown

        Return result
    End Function
End Class
