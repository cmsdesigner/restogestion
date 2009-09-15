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
Public Class frmCustomer

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Recupération des libellés dans le fichier XML
        cmdCancel.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CANCEL_ACTION).Value
        cmdClose.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CLOSE_ACTION).Value
        cmdAdd.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.ADD_ACTION).Value
        cmdModify.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.MODIFY_FORM).Value
        cmdDelete.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.DELETE_ACTION).Value
        Me.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.NAME).Value
        lblLastName.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.LASTNAME).Value
        lblFirstName.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.FIRSTNAME).Value
        lblAddress.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.ADDRESS).Value
        lblZipCode.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.ZIPCODE).Value
        lblTown.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.CITY).Value
        lblPhoneNumber.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.PHONENUMBER).Value
        lblComment.Text = label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.COMMENT).Value
        'Affectation du fichier d'aide
        hlpCustomer.HelpNamespace = HELPPATH + "clients.htm"
        'On affecte l'action de KeyPress à la fonction NextTab chargée d'emuler
        'la touche Tab lorque que l'on appuie sur Entree
        AddHandler txtAddress.KeyPress, AddressOf NextTab
        AddHandler txtComment.KeyPress, AddressOf NextTab
        AddHandler txtFirstName.KeyPress, AddressOf NextTab
        AddHandler txtLastName.KeyPress, AddressOf NextTab
        AddHandler txtPhoneNumber.KeyPress, AddressOf NextTab
        AddHandler txtTown.KeyPress, AddressOf NextTab
        AddHandler txtZipCode.KeyPress, AddressOf NextTab
        'On formatte la grille et on la remplit si besoin
        AfficheGrille()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        'Fermeture de la fenêtre
        Me.Close()
    End Sub
    Private Sub AfficheGrille()
        Dim it As IEnumerator
        Dim client As Client

        Try
            'Formattage de la grille
            'On vide la grille
            flxCustomer.Rows.Clear()
            'On remet les libellés des colonnes
            flxCustomer.Columns("colLastName").HeaderText = lblLastName.Text
            flxCustomer.Columns("colFirstName").HeaderText = lblFirstName.Text
            flxCustomer.Columns("colAddress").HeaderText = lblAddress.Text
            flxCustomer.Columns("colZipCode").HeaderText = lblZipCode.Text
            flxCustomer.Columns("colTown").HeaderText = lblTown.Text
            flxCustomer.Columns("colPhone").HeaderText = lblPhoneNumber.Text
            flxCustomer.Columns("colComment").HeaderText = lblComment.Text
            'On redimensionne les colonnes
            flxCustomer.Columns("colLastName").Width = 80
            flxCustomer.Columns("colFirstName").Width = 80
            flxCustomer.Columns("colAddress").Width = 170
            flxCustomer.Columns("colZipCode").Width = 65
            flxCustomer.Columns("colTown").Width = 100
            flxCustomer.Columns("colPhone").Width = 85
            flxCustomer.Columns("colComment").Width = 75
            If clients.Count > 0 Then
                it = clients.GetEnumerator
                While it.MoveNext
                    client = CType(it.Current, Client)
                    'On met les données dans un tableau
                    Dim tRow As Object() = {client.Nom, client.Prenom, client.Adresse, client.CodePostal, client.Ville, client.Telephone, client.Commentaire, client.Id}
                    'Ajout dans la grille
                    flxCustomer.Rows.Add(tRow)
                End While
            End If
            'On elève les sélections
            flxCustomer.ClearSelection()
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'Mise a blanc des zone de texte
        RAZText(Me)
        txtLastName.Focus()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim mRep As DialogResult

        Try
            'Si une ligne est sélectionnée
            If flxCustomer.SelectedRows.Count > 0 Then
                'Petite MessageBox de validation de l'action
                mRep = MessageBox.Show(label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.DELETEQUESTION).Value, label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.DELETETITLE).Value, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'On a valider on peut y aller
                If mRep.Equals(DialogResult.Yes) Then
                    'Requete de suppression du client
                    clients.Remove(CInt(flxCustomer.SelectedRows(0).Cells("colId").Value))
                    'On réaffiche la grille
                    AfficheGrille()
                    'Remise a Zero des champs
                    cmdCancel_Click(sender, e)
                End If
            Else
                'Affichage du message d'erreur correspondant
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.ROWSELECT).Value)
            End If
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim mRep As DialogResult
        Dim client As Client

        Try
            'Une ligne est sélectionnée
            If flxCustomer.SelectedRows.Count > 0 Then
                'Champ Nom non vide
                If txtLastName.Text <> "" Then
                    'Champ prénom remplit
                    If txtFirstName.Text <> "" Then
                        'Message Box pour la validation de l'action
                        mRep = MessageBox.Show(label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.MODIFYQUESTION).Value, label(LanguageFile.CUSTOMER_FORM).Label(LanguageFile.MODIFYTITLE).Value, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        'Action validée
                        If mRep.Equals(DialogResult.Yes) Then
                            'Mise à jour du client
                            client = New Client
                            client.Nom = txtLastName.Text
                            client.Prenom = txtFirstName.Text
                            client.Adresse = txtAddress.Text
                            client.CodePostal = txtZipCode.Text
                            client.Ville = txtTown.Text
                            client.Telephone = txtPhoneNumber.Text
                            client.Commentaire = txtComment.Text
                            clients.UpdateItem(CInt(flxCustomer.SelectedRows(0).Cells("colId").Value), client)

                            'Raffraichissement de la grille
                            AfficheGrille()
                            'Remise a Zero des champs
                            cmdCancel_Click(sender, e)
                        End If
                    Else
                        'Affichage du message d'erreur correspondant
                        MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOFIRSTNAME).Value)
                        txtFirstName.Focus()
                    End If
                Else
                    'Affichage du message d'erreur correspondant
                    MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOLASTNAME).Value)
                    txtLastName.Focus()
                End If
            Else
                'Affchage du message d'erreur correspondant
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.ROWSELECT).Value)
            End If
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim client As Client

        Try
            'Le champ nom est il vide ?
            If txtLastName.Text <> "" Then
                'Vérification du champ Prénom
                If txtFirstName.Text <> "" Then
                    'Requete d'insertion dans la table
                    client = New Client
                    client.Nom = txtLastName.Text
                    client.Prenom = txtFirstName.Text
                    client.Adresse = txtAddress.Text
                    client.CodePostal = txtZipCode.Text
                    client.Ville = txtTown.Text
                    client.Telephone = txtPhoneNumber.Text
                    client.Commentaire = txtComment.Text
                    client.Id = -1 'on force pour générer un nouvel Id automatiquement
                    clients.Add(client)
                    'Rafraichissement de la grille
                    AfficheGrille()
                    'Remise a Zero des champs
                    cmdCancel_Click(sender, e)
                Else
                    'Message d'erreur correspondant
                    MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOFIRSTNAME).Value)
                    txtFirstName.Focus()
                End If
            Else
                'Message d'erreur correspondant
                MessError(label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NOLASTNAME).Value)
                txtLastName.Focus()
            End If
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub flxCustomer_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles flxCustomer.CellMouseClick
        'Une ligne est sélectionnée
        If flxCustomer.SelectedRows.Count > 0 Then
            'On remplit les champs avec les données de la grille
            txtLastName.Text = flxCustomer.SelectedRows(0).Cells("colLastName").Value.ToString
            txtFirstName.Text = flxCustomer.SelectedRows(0).Cells("colFirstName").Value.ToString
            txtAddress.Text = flxCustomer.SelectedRows(0).Cells("colAddress").Value.ToString
            txtZipCode.Text = flxCustomer.SelectedRows(0).Cells("colZipCode").Value.ToString
            txtTown.Text = flxCustomer.SelectedRows(0).Cells("colTown").Value.ToString
            txtPhoneNumber.Text = flxCustomer.SelectedRows(0).Cells("colPhone").Value.ToString
            txtComment.Text = flxCustomer.SelectedRows(0).Cells("colComment").Value.ToString
        End If
    End Sub
End Class