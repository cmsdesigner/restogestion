Option Strict On
Option Explicit On
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
Public Class frmHistory

    Private Sub frmHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'recupération des libellés suivant la langue
        Me.Text = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.NAME).Value
        lblHeader.Text = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.HEADER).Value
        lblSelect.Text = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.FROM_DATE).Value
        lblAnd.Text = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.TO_DATE).Value
        cmdFilter.Text = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.FILTER).Value
        dtpDateInf.Value = Date.Now
        dtpDateSup.Value = Date.Now.AddDays(1)
        AfficheGrille()
    End Sub

    Private Sub AfficheGrille()
        Dim it As IEnumerator

        'formattage de la grille
        flxHistory.Rows.Clear()
        flxHistory.Columns("colDate").HeaderText = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.DATE).Value
        flxHistory.Columns("colTotal").HeaderText = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.TOTAL).Value
        flxHistory.Columns("colTable").HeaderText = label(LanguageFile.HISTORY_FORM).Label(LanguageFile.TABLE).Value
        flxHistory.Columns("colDate").Width = 120
        flxHistory.Columns("colTotal").Width = 57
        flxHistory.Columns("colTable").Width = 130
        Try
            'on rempli la grille
            it = histo.GetEnumerator
            While it.MoveNext
                Dim SelectedTable As HistoTable
                SelectedTable = CType(it.Current, HistoTable)
                If SelectedTable.HistoDate > dtpDateInf.Value.Date And SelectedTable.HistoDate < dtpDateSup.Value.Date Then
                    'Ajout dans la grille
                    Dim tRow As Object() = {SelectedTable.HistoDate, SelectedTable.Name, SelectedTable.Total}
                    flxHistory.Rows.Add(tRow)
                End If
            End While
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        AfficheGrille()
    End Sub

    Private Sub flxHistory_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles flxHistory.CellClick
        Dim frmTableHistoryForm As New frmTableHistory
        If flxHistory.SelectedRows.Count > 0 Then
            frmTableHistoryForm.SelectedTable = histo(CDate(flxHistory.SelectedRows(0).Cells("colDate").Value))
            frmTableHistoryForm.ShowDialog()
            frmTableHistoryForm = Nothing
        End If
    End Sub
End Class