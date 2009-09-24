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
Public Class frmTableHistory

    Private Sub frmSell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'recupération des libellés suivant la langue
        cmdClose.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CLOSE_ACTION).Value
        cmdPrint.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.PRINT_LABELS).Value
        Me.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.NAME).Value
        lblAmount.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.AMOUNT).Value
        lblDiscount.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.DISCOUNT).Value
        lblSet.Text = label(LanguageFile.SELL_FORM).Label(LanguageFile.SET).Value
        hlpSell.HelpNamespace = Consts.HELPPATH + "historique.htm"
        Try
            'Recupération de la liste des plats
            lblTable.Text = SelectedTable.Name
            txtDiscount.Text = SelectedTable.TxDiscount.ToString
            txtAmount.Text = SelectedTable.Total.ToString
            txtSet.Text = SelectedTable.NbSet
        Catch ex As Exception
            TraceError(ex)
        End Try
        'on formatte la grille et on la remplit si besoin
        AfficheGrille()
    End Sub

    Private Sub AfficheGrille()
        Dim it As IEnumerator(Of HistoCommande)

        'formattage de la grille
        flxMenu.Rows.Clear()
        flxMenu.Columns("colCode").HeaderText = label(LanguageFile.SELL_FORM).Label(LanguageFile.CODE).Value
        flxMenu.Columns("colDesignation").HeaderText = label(LanguageFile.SELL_FORM).Label(LanguageFile.DESIGNATION).Value
        flxMenu.Columns("colQte").HeaderText = label(LanguageFile.SELL_FORM).Label(LanguageFile.QUANTITY).Value
        flxMenu.Columns("colPrice").HeaderText = label(LanguageFile.SELL_FORM).Label(LanguageFile.PRICE).Value
        flxMenu.Columns("colTotal").HeaderText = label(LanguageFile.SELL_FORM).Label(LanguageFile.TOTAL).Value
        flxMenu.Columns("colCode").Width = 80
        flxMenu.Columns("colDesignation").Width = 107
        flxMenu.Columns("colQte").Width = 50
        flxMenu.Columns("colPrice").Width = 50
        flxMenu.Columns("colTotal").Width = 50
        Try
            it = SelectedTable.GetEnumerator
            While it.MoveNext
                'Ajout dans la grille
                Dim tRow As Object() = {it.Current.Code, it.Current.Designation, it.Current.Quantite, it.Current.Prix, it.Current.Prix * it.Current.Quantite}
                flxMenu.Rows.Add(tRow)
            End While
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim frmFormPrint As New frmPrint
        Dim it As IEnumerator(Of HistoCommande)

        it = SelectedTable.GetEnumerator
        While it.MoveNext
            frmFormPrint.Quantity.Add(it.Current.Quantite)
            frmFormPrint.Designation.Add(it.Current.Designation)
            frmFormPrint.Total.Add(it.Current.Quantite * it.Current.Prix)
            frmFormPrint.Tva.Add(it.Current.Tva)
        End While
        frmFormPrint.NbSet = SelectedTable.NbSet
        frmFormPrint.TableName = SelectedTable.Name
        frmFormPrint.Discount = SelectedTable.TxDiscount
        frmFormPrint.Date = SelectedTable.HistoDate
        frmFormPrint.Amount = SelectedTable.Total
        frmFormPrint.ShowDialog()
        frmFormPrint = Nothing
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private m_SelectedTable As HistoTable
    Public Property SelectedTable() As HistoTable
        Get
            Return m_SelectedTable
        End Get
        Set(ByVal value As HistoTable)
            m_SelectedTable = value
        End Set
    End Property

End Class