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
Public Class frmMeal

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        'Fermeture de la fenêtre
        Me.Close()
    End Sub

    Private Sub frmMeal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Recupération des libellés dans le fichier XML
        cmdCancel.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CANCEL_ACTION).Value
        cmdClose.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CLOSE_ACTION).Value
        cmdAdd.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.ADD_ACTION).Value
        cmdModify.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.MODIFY_FORM).Value
        cmdDelete.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.DELETE_ACTION).Value
        Me.Text = label(LanguageFile.MEAL_FORM).Label(LanguageFile.NAME).Value
        lblCode.Text = label(LanguageFile.MEAL_FORM).Label(LanguageFile.CODE).Value
        lblDesignation.Text = label(LanguageFile.MEAL_FORM).Label(LanguageFile.DESIGNATION).Value
        lblPrice.Text = label(LanguageFile.MEAL_FORM).Label(LanguageFile.PRICE).Value
        lblTva.Text = label(LanguageFile.MEAL_FORM).Label(LanguageFile.TVA).Value
        txtTva.Text = config.Tva.ToString
        'Assignation de la commande KeyPress a la fonction NextTab
        'pour emuler la touche tab lors de la validation du champs par la touche entrée
        AddHandler txtCode.KeyPress, AddressOf NextTab
        AddHandler txtDesignation.KeyPress, AddressOf NextTab
        'on formatte la grille et on la remplit si besoin
        AfficheGrille()
    End Sub

    Private Sub AfficheGrille()
        Dim it As IEnumerator
        Dim plat As Plat

        Try
            'formattage de la grille
            'Vidage de la grille
            flxMeal.Rows.Clear()
            'On remet les entêtes de colonnes
            flxMeal.Columns("colCode").HeaderText = lblCode.Text
            flxMeal.Columns("colDesignation").HeaderText = lblDesignation.Text
            flxMeal.Columns("colPrice").HeaderText = lblPrice.Text
            flxMeal.Columns("colTva").HeaderText = lblTva.Text
            'Et on les redimensionnent
            flxMeal.Columns("colCode").Width = 80
            flxMeal.Columns("colDesignation").Width = 287
            flxMeal.Columns("colPrice").Width = 50
            flxMeal.Columns("colTva").Width = 50
            it = carte.GetEnumerator
            While it.MoveNext
                plat = CType(it.Current, Plat)
                'On met les données dans un tableau
                Dim tRow As Object() = {plat.Code, plat.Designation, plat.Prix, plat.Tva}
                'Ajout dans la grille
                flxMeal.Rows.Add(tRow)
            End While
            'On trie l'affichage par ordre alphabetique des codes
            flxMeal.Sort(colCode, System.ComponentModel.ListSortDirection.Ascending)
            'On effeace les selections de la grille
            flxMeal.ClearSelection()

        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'Mise a blanc des champs
        RAZText(Me)
        txtCode.Focus()
    End Sub

    Private Sub flxMeal_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles flxMeal.CellMouseClick
        'Une ligne de la grille est sélectionnée
        If flxMeal.SelectedRows.Count > 0 Then
            'On remplit les champs avec les données de la grille
            txtCode.Text = flxMeal.SelectedRows(0).Cells("colCode").Value.ToString
            txtDesignation.Text = flxMeal.SelectedRows(0).Cells("colDesignation").Value.ToString
            txtPrice.Text = flxMeal.SelectedRows(0).Cells("colPrice").Value.ToString
            txtTva.Text = flxMeal.SelectedRows(0).Cells("colTva").Value.ToString
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress, txtTva.KeyPress
        'On execute la fonction NextTab (passage au champs suivant si on presse entrée
        NextTab(sender, e)
        'On vérifie que les touches en entrée sont numérique ou la touche d'effacement
        If Not e.KeyChar Like "[0123456789.,]" And Not e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Back)) Then e.KeyChar = Convert.ToChar(0)
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim plat As Plat

        Try
            'Si le champ code est remplit 
            If txtCode.Text <> "" Then
                'Si le champs Designation est remplit
                If txtDesignation.Text <> "" Then
                    'Si le prix est remplit
                    If txtPrice.Text <> "" Then
                        'insertion des données dans la table
                        plat = New Plat
                        plat.Code = txtCode.Text
                        plat.Designation = txtDesignation.Text
                        plat.Prix = CSng(txtPrice.Text.Replace(".", ","))
                        plat.Tva = CSng(txtTva.Text.Replace(".", ","))
                        carte.Add(plat)
                        'On met a jour la grille
                        AfficheGrille()
                        'Remise a Zero des champs
                        cmdCancel_Click(sender, e)
                    Else
                        'Affichage de l'erreur correspondante
                        MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOPRICE).Value)
                        txtPrice.Focus()
                    End If
                Else
                    'Affichage de l'erreur correspondante
                    MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOMEAL).Value)
                    txtDesignation.Focus()
                End If
            Else
                'Affichage de l'erreur correspondante
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOCODE).Value)
                txtCode.Focus()
            End If
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim mRep As DialogResult

        Try
            'Une ligne est selectionnée
            If flxMeal.SelectedRows.Count > 0 Then
                'Affichage de la messageBox pour validation
                mRep = MessageBox.Show(label(LanguageFile.MEAL_FORM).Label(LanguageFile.DELETEQUESTION).Value, label(LanguageFile.MEAL_FORM).Label(LanguageFile.DELETETITLE).Value, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'Validation a Oui
                If mRep.Equals(DialogResult.Yes) Then
                    'Suppression dans la table Plats
                    carte.Remove(flxMeal.SelectedRows(0).Cells("colCode").Value.ToString)
                    'Mise a Jour de la grille
                    AfficheGrille()
                    'Remise a Zero des champs
                    cmdCancel_Click(sender, e)
                End If
            Else
                'Message d'erreur correspondant
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.ROWSELECT).Value)
            End If
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim mRep As DialogResult
        Dim plat As Plat

        Try
            'On a sélectionner une ligne
            If flxMeal.SelectedRows.Count > 0 Then
                'Le champ Code est renseigné
                If txtCode.Text <> "" Then
                    'Idem pour le champ Désignation
                    If txtDesignation.Text <> "" Then
                        'Et pour le prix
                        If txtPrice.Text <> "" Then
                            'MessageBox pour valider
                            mRep = MessageBox.Show(label(LanguageFile.MEAL_FORM).Label(LanguageFile.MODIFYQUESTION).Value, label(LanguageFile.MEAL_FORM).Label(LanguageFile.MODIFYTITLE).Value, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            'Réponse positive
                            If mRep.Equals(DialogResult.Yes) Then
                                'Mise a jour du plat
                                plat = New Plat
                                plat.Code = txtCode.Text
                                plat.Designation = txtDesignation.Text
                                plat.Prix = CSng(txtPrice.Text.Replace(".", ","))
                                plat.Tva = CSng(txtTva.Text.Replace(".", ","))
                                carte.UpdateItem(flxMeal.SelectedRows(0).Cells("colCode").Value.ToString, plat)
                                'On rafraichit le grille
                                AfficheGrille()
                                'Remise a Zero des champs
                                cmdCancel_Click(sender, e)
                            End If
                        Else
                            'Pas de prix entré
                            MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOPRICE).Value)
                            txtPrice.Focus()
                        End If
                    Else
                        'Pas de plats
                        MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOMEAL).Value)
                        txtDesignation.Focus()
                    End If
                Else
                    'pas de code
                    MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOCODE).Value)
                    txtCode.Focus()
                End If
            Else
                'Aucune ligne sélectionnée
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.ROWSELECT).Value)
            End If
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub txtTva_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTva.TextChanged
        If txtTva.Text = "" Then txtTva.Text = config.Tva.ToString
    End Sub
End Class