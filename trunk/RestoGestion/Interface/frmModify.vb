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
Public Class frmModify
    Private CurrentTable As Button

    Public Sub New(ByVal button As Button)
        InitializeComponent()
        CurrentTable = button
    End Sub

    Private Sub rdbMove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMove.CheckedChanged
        'modifie les champs modifiable suivant le bouton radio coché
        updTop.Enabled = rdbMove.Checked
        updLeft.Enabled = rdbMove.Checked
        updWidth.Enabled = Not rdbMove.Checked
        updHeight.Enabled = Not rdbMove.Checked
    End Sub

    Private Sub frmModify_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Dim table As Table
        Dim index As Integer

        Try
            'si la table n'est pas déjà supprimée
            If Not CurrentTable Is Nothing Then

                'on remet la table telle qu'elle est enregistrée dans la base
                index = CInt(CurrentTable.Tag)
                table = resto.Item(index)
                CurrentTable.Height = table.Height
                CurrentTable.Width = table.Width
                CurrentTable.Left = table.Left
                CurrentTable.Top = table.Top
                CurrentTable.Text = table.Name
                'on laisse par contre Enable a True pour pouvoir cliqué dessus en édition
                CurrentTable.Enabled = True

            End If
        Catch ex As Exception
            TraceError(ex)
        End Try

    End Sub

    Private Sub frmModify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lTop, lLeft, lWidth, lHeight As Long

        'Recupération des libellés suivant les langues
        cmdApply.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.APPLY_ACTION).Value
        cmdCancel.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.CANCEL_ACTION).Value
        cmdDelete.Text = label(LanguageFile.COMMON_LABELS).Label(LanguageFile.DELETE_ACTION).Value
        chkEnable.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.ENABLE).Value
        Me.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.NAME).Value
        lblLeft.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.LEFT).Value
        lblTop.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.TOP).Value
        lblName.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.TEXT).Value
        lblWidth.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.WIDTH).Value
        lblHeight.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.HEIGHT).Value
        rdbMove.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.MOVE).Value
        rdbSize.Text = label(LanguageFile.MODIFY_FORM).Label(LanguageFile.RESIZE).Value
        'Affectation de l'action keypress a la fonction NextTab
        AddHandler txtName.KeyPress, AddressOf NextTab
        AddHandler updHeight.KeyPress, AddressOf NextTab
        AddHandler updLeft.KeyPress, AddressOf NextTab
        AddHandler updTop.KeyPress, AddressOf NextTab
        AddHandler updWidth.KeyPress, AddressOf NextTab
        hlpModify.HelpNamespace = Consts.HELPPATH + "modification.htm"

        Try
            'on remplit les champs avec les infos de la table
            lTop = CurrentTable.Top
            lLeft = CurrentTable.Left
            lWidth = CurrentTable.Width
            lHeight = CurrentTable.Height
            'on définit les valeurs maximum et minimum de la table
            updTop.Minimum = frmMain.fraSalle.Padding.Top
            updTop.Maximum = frmMain.fraSalle.DisplayRectangle.Height - lHeight
            updTop.Value = lTop

            updLeft.Minimum = frmMain.fraSalle.Padding.Left
            updLeft.Maximum = frmMain.fraSalle.DisplayRectangle.Width - lWidth
            updLeft.Value = lLeft

            updWidth.Minimum = 1
            updWidth.Maximum = frmMain.fraSalle.DisplayRectangle.Width - lLeft
            updWidth.Value = lWidth

            updHeight.Minimum = 1
            updHeight.Maximum = frmMain.fraSalle.DisplayRectangle.Height - lTop
            updHeight.Value = lHeight

            txtName.Text = CurrentTable.Text
            chkEnable.Checked = CurrentTable.Enabled
            'on empeche la suppression si des commandes sont en cours
            If resto.Item(CInt(CurrentTable.Tag)).HasOrder Then
                cmdDelete.Enabled = False
            End If
            rdbMove.Checked = True
        Catch ex As Exception
            TraceError(ex)
        End Try
    End Sub

    Private Sub updTop_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updTop.ValueChanged
        'Si la valeur du champ change, on recalcule le maximum possible
        updTop.Maximum = frmMain.fraSalle.DisplayRectangle.Height - CurrentTable.Height
        CurrentTable.Top = CInt(updTop.Value)
        updHeight.Maximum = frmMain.fraSalle.DisplayRectangle.Height - CurrentTable.Top
    End Sub

    Private Sub updLeft_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updLeft.ValueChanged
        'Si la valeur du champ change, on recalcule le maximum possible
        updLeft.Maximum = frmMain.fraSalle.DisplayRectangle.Width - CurrentTable.Width
        CurrentTable.Left = CInt(updLeft.Value)
        updWidth.Maximum = frmMain.fraSalle.DisplayRectangle.Width - CurrentTable.Left
    End Sub

    Private Sub updWidth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updWidth.ValueChanged
        'Si la valeur du champ change, on recalcule le maximum possible
        updWidth.Maximum = frmMain.fraSalle.DisplayRectangle.Width - CurrentTable.Left
        CurrentTable.Width = CInt(updWidth.Value)
        updLeft.Maximum = frmMain.fraSalle.DisplayRectangle.Width - CurrentTable.Width
    End Sub

    Private Sub updHeight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updHeight.ValueChanged
        'Si la valeur du champ change, on recalcule le maximum possible
        updTop.Maximum = frmMain.fraSalle.DisplayRectangle.Height - CurrentTable.Height
        CurrentTable.Height = CInt(updHeight.Value)
        updHeight.Maximum = frmMain.fraSalle.DisplayRectangle.Height - CurrentTable.Top
    End Sub

    Private Sub chkEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnable.CheckedChanged
        'On active ou désactive le bouton suivant la valeur de la cas
        CurrentTable.Enabled = chkEnable.Checked
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        'On change le texte du bouton a la volée
        CurrentTable.Text = txtName.Text
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        Dim table As Table
        Dim index As Integer

        Try
            'mise à jour de la table
            index = CInt(CurrentTable.Tag)
            table = resto.Item(index)
            table.Height = CurrentTable.Height
            table.Width = CurrentTable.Width
            table.Left = CurrentTable.Left
            table.Top = CurrentTable.Top
            table.Name = CurrentTable.Text
            table.Enable = CurrentTable.Enabled
            table.Id = CInt(CurrentTable.Tag)
            resto.UpdateItem(index, table)
        Catch ex As Exception
            TraceError(ex)
        End Try

        'on ferme la fenêtre
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'on ferme la fenêtre
        Me.Close()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim key As Integer

        Try
            'suppression de la table
            key = CInt(CurrentTable.Tag)
            resto.Remove(key)
            CurrentTable.Dispose()
        Catch ex As Exception
            TraceError(ex)
        Finally
            CurrentTable = Nothing
        End Try
        Me.Close()
    End Sub
End Class