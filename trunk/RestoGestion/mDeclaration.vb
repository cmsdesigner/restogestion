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

Module Declaration
    '---Les varibales---

    Public bdd As Base
    Public config As Configuration
    Public label As LanguageFile
    Public resto As Salle
    Public carte As Menu
    Public clients As Carnet
    Public trace As Log
    Public histo As HistoSalle

    'Formulaire
    Public frmMain As frmTable

    '---Les types---
    Public Structure RECT
        Dim Left As Long
        Dim Top As Long
        Dim Right As Long
        Dim Bottom As Long
    End Structure

End Module

Public Class Consts
    '---Les constantes---
    Public Const MAX_ENTRY As Integer = 327
    Public Shared ReadOnly HELPPATH As String = Application.StartupPath + "\Aide\"
    Public Shared ReadOnly BASEPATH As String = Application.StartupPath + "\RestoGestion.db"
    Public Shared ReadOnly LANGUAGEFILEPATH As String = Application.StartupPath + "\Langues\"
    Public Shared ReadOnly LOGFILE As String = Application.StartupPath + "\RestoGestion.log"
    Public Shared ReadOnly PRINTFILEPATH As String = Application.StartupPath + "\Print.xml"
End Class
