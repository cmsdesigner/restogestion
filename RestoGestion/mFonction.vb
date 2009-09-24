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
Imports System.Xml
Imports System.Net
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Xml.Serialization

Module mFonction

    Public Sub Main()
        Dim frmPass As frmPassword
        Dim passwordOk As Boolean

        Application.EnableVisualStyles()
        trace = New Log(Consts.LOGFILE)
        Try
            bdd = New Base(Consts.BASEPATH)
            config = New Configuration(bdd)
            config.Load()
            If Not File.Exists(Consts.LANGUAGEFILEPATH + config.LanguageFile) Then
                config.LanguageFile = Directory.GetFiles(Consts.LANGUAGEFILEPATH, "*.lng")(0).Replace(Consts.LANGUAGEFILEPATH, "")
            End If
            label = New LanguageFile(Consts.LANGUAGEFILEPATH + config.LanguageFile)
            passwordOk = True
            If config.HasPassword Then
                frmPass = New frmPassword
                frmPass.PasswordErase = False
                frmPass.ShowDialog()
                passwordOk = frmPass.passwordOk
                frmPass = Nothing
            End If
            If passwordOk Then
                resto = New Salle(bdd)
                carte = New Menu(bdd)
                clients = New Carnet(bdd)
                histo = New HistoSalle(bdd)

                resto.Load()
                carte.Load()
                clients.Load()
                histo.Load()

                frmMain = New frmTable
                frmMain.ShowDialog()
                frmMain = Nothing
            End If
        Catch ex As Exception
            TraceError(ex)
        Finally
            label = Nothing
            config.SaveConfig()
            bdd.Close()
            trace.Close()
        End Try
    End Sub

    Public Sub MessError(ByVal message As String)
        MessageBox.Show(message, label(LanguageFile.ERRORS_LABELS).Label(LanguageFile.NAME).Value, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Public Sub RAZText(ByVal frmRaz As Form)
        Dim oControl As Control
        For Each oControl In frmRaz.Controls
            If TypeOf oControl Is TextBox Then
                oControl.Text = ""
            End If
        Next
    End Sub
    Public Sub NextTab(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim selectedControl As Control = CType(sender, Control)
        If e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Enter)) Or e.KeyChar.Equals(Convert.ToChar(System.Windows.Forms.Keys.Execute)) Then
            selectedControl.Parent.SelectNextControl(selectedControl, True, False, False, False)
        End If
    End Sub

    Public Sub VerifyUpdate()
        Dim p As New Process
        Dim pi As New ProcessStartInfo(Application.StartupPath + "\AutoUpdate.exe")
        pi.Arguments = "RestoGestion.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    'Hash an input string and return the hash as
    ' a 32 character hexadecimal string.
    Function getMd5Hash(ByVal sSource As String) As String
        ' Create a new instance of the MD5 object.
        Dim md5Hasher As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim oFile As FileStream = File.OpenRead(sSource)
        Dim data As Byte() = md5Hasher.ComputeHash(oFile)
        oFile.Close()
        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function


    ' Verify a hash against a string.
    Private Function verifyMd5Hash(ByVal sHash1 As String, ByVal sHash2 As String) As Boolean

        ' Create a StringComparer an comare the hashes.
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(sHash1, sHash2) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub TraceError(ByVal ex As Exception)
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        trace.WriteLog(ex.Message + Environment.NewLine + ex.StackTrace)
    End Sub
End Module
