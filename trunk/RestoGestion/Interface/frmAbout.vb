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
Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Recupération des libellés dans le fichier XML
        cmdOk.Text = label(LanguageFile.ABOUT_FORM).Label(LanguageFile.OK).Value
        cmdCredit.Text = label(LanguageFile.ABOUT_FORM).Label(LanguageFile.CREDITS).Value
        Me.Text = label(LanguageFile.ABOUT_FORM).Label(LanguageFile.NAME).Value + " " + My.Application.Info.Title
        'Afficher la version 
        lblVersion.Text = "v " + My.Application.Info.Version.ToString + " " + My.Application.Info.Copyright
        'Texte de license
        txtCopyLeft.Text = "This program is free software; you can redistribute it and/or modify " _
                            + " it under the terms of the GNU General Public License as published by " _
                            + "the Free Software Foundation; either version 2 of the License, or (at your option) " _
                            + "any later version." + Environment.NewLine + Environment.NewLine _
                            + "This program is distributed in the hope that it will be useful, but WITHOUT ANY " _
                            + "WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A " _
                            + "PARTICULAR PURPOSE.  See the GNU General Public License for more details." + Environment.NewLine + Environment.NewLine _
                            + "You should have received a copy of the GNU General Public License along with " _
                            + "this program; if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA"
        'Affectation du fichier d'aide
        hlpAbout.HelpNamespace = HELPPATH + "about.htm"
        'Selection du bouton OK
        cmdOk.Focus()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        'On ferme la fenêtre
        Me.Close()
    End Sub

    Private Sub cmdCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCredit.Click
        'On affiche l'aide à la page correpondante
        Help.ShowHelp(Me, HELPPATH + "credits.htm")
    End Sub
End Class