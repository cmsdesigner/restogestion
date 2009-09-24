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

Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports RestoGestion


Public Class frmUpdate
    Private Const SERVERURL As String = "http://localhost/web/update"
    'Private Const SERVERURL As String = "http://511.free.fr/update"
    Private Const UPDATEFILE As String = "ServerManifest.xml"
    Private db As Base
    Private label As LanguageFile
    Private config As Configuration
    Private trace As Log

    Private Sub frmUpdate_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim wbcUpdate As New WebClient
        Dim bIsUpdate As Boolean = False
        Dim bUpdate As Boolean = True
        Dim xmlUpdate As UpdateFile
        Dim it As IEnumerator(Of Names)
        Dim SQLFiles As New ArrayList

        pbUpdate.Value = 0
        pbUpdate.Maximum = 1

        trace = New Log(Application.StartupPath + "\AutoUpdate.log")
        Try
            db = New Base(Consts.BASEPATH)
            config = New Configuration(db)
            config.Load()
            If Not File.Exists(Consts.LANGUAGEFILEPATH + config.LanguageFile) Then
                config.LanguageFile = Directory.GetFiles(Consts.LANGUAGEFILEPATH, "*.lng")(0).Replace(Consts.LANGUAGEFILEPATH, "")
            End If
            label = New LanguageFile(Consts.LANGUAGEFILEPATH + config.LanguageFile)

            'on crée le répertoire d'acceuil des mises à jour.
            If Not Directory.Exists(Application.StartupPath + "\update") Then
                Directory.CreateDirectory(Application.StartupPath + "\update")
            End If

            'on recupère le fichier XML contenant les infos de MAJ
            lblStatus.Text = label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.DOWNLOADING).Value.Replace("%s", UPDATEFILE)
            Application.DoEvents()
            wbcUpdate.DownloadFile(SERVERURL + "/" + UPDATEFILE, Application.StartupPath + "\update\" + UPDATEFILE)
            lblStatus.Text = label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.DOWNLOADED).Value.Replace("%s", UPDATEFILE)
            Application.DoEvents()

            'on vérifie qu'il n'est pas identique au dernier télécharger
            If File.Exists(Application.StartupPath + "\" + UPDATEFILE) Then
                bIsUpdate = verifyHash(getHash(Application.StartupPath + "\update\" + UPDATEFILE), getHash(Application.StartupPath + "\" + UPDATEFILE))
            End If

            'identique, alors on ne fait rien
            If bIsUpdate Then
                lblStatus.Text = label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.NOUPDATE).Value
                MessageBox.Show(label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.NOUPDATE).Value, label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.TITLE).Value, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                'on commence la mise à jour
                'Si on execute depuis l'application principale, on termine l'application
                If My.Application.CommandLineArgs.Count > 0 Then
                    If MessageBox.Show(label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.UPDATEQUESTION).Value, label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.TITLE).Value, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        KillAppExe(My.Application.CommandLineArgs(0).Replace(".exe", ""))
                    Else
                        bUpdate = False
                    End If
                End If
                If bUpdate Then
                    'on ouvre le fichier XML
                    xmlUpdate = New UpdateFile(Application.StartupPath + "\update\" + UPDATEFILE)
                    pbUpdate.Maximum += xmlUpdate.Count
                    Application.DoEvents()
                    it = xmlUpdate.GetEnumerator
                    While it.MoveNext
                        Dim CurrentFile As String = "\" + it.Current.Directory + "\" + it.Current.Filename
                        If Not Directory.Exists(Application.StartupPath + "\" + it.Current.Directory) Then
                            Directory.CreateDirectory(Application.StartupPath + "\" + it.Current.Directory)
                        End If
                        If Not verifyHash(it.Current.Hash, getHash(Application.StartupPath + CurrentFile)) Then
                            If it.Current.Extension.Equals("db") Or it.Current.Extension.Equals("lng") Or it.Current.Extension.Equals("xml") Then
                                BackupFile(Application.StartupPath + CurrentFile)
                            End If
                            lblStatus.Text = label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.DOWNLOADING).Value.Replace("%s", it.Current.Filename)
                            Application.DoEvents()
                            If it.Current.Extension.Equals("sql") Then
                                wbcUpdate.DownloadFile(SERVERURL + CurrentFile.Replace("\", "/"), Application.StartupPath + "\update" + CurrentFile)
                                SQLFiles.Add(Application.StartupPath + "\update" + CurrentFile)
                            Else
                                wbcUpdate.DownloadFile(SERVERURL + CurrentFile.Replace("\", "/"), Application.StartupPath + CurrentFile)
                            End If
                            lblStatus.Text = label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.DOWNLOADED).Value.Replace("%s", it.Current.Filename)
                            Application.DoEvents()
                        End If
                    End While
                    UpdateDatabase(SQLFiles)
                    xmlUpdate = Nothing
                    File.Copy(Application.StartupPath + "\update\" + UPDATEFILE, Application.StartupPath + "\" + UPDATEFILE, True)
                End If
                lblStatus.Text = label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.ENDUPDATE).Value
                MessageBox.Show(label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.ENDUPDATE).Value, label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.TITLE).Value, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

                'suppression du répertoire temporaire
                Directory.Delete(Application.StartupPath + "\update", True)

                IncrementProgress()
        Catch ex As Exception
            TraceError(ex)
        End Try
        Me.Close()
    End Sub

    'Hash an input string and return the hash as
    ' a 32 character hexadecimal string.
    Function getHash(ByVal sSource As String) As String
        Try
            ' Create a new instance of the MD5 object.
            Dim hasher As SHA256 = SHA256.Create

            ' Convert the input string to a byte array and compute the hash.
            Dim oFile As FileStream = File.OpenRead(sSource)
            Dim data As Byte() = hasher.ComputeHash(oFile)
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
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    ' Verify a hash against a string.
    Function verifyHash(ByVal sHash1 As String, ByVal sHash2 As String) As Boolean

        ' Create a StringComparer an comare the hashes.
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(sHash1, sHash2) Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub KillAppExe(ByVal sProgram As String)
        ' Get MainApp exe name without extension
        Dim local As Process() = Process.GetProcessesByName(sProgram)
        Dim i As Integer

        ' Search MainApp process in windows process
        For i = 0 To local.Length - 1
            ' If MainApp process found then close or kill MainApp
            If local(i).ProcessName.ToUpper = sProgram.ToUpper Then
                local(i).CloseMainWindow()
            End If
        Next
    End Sub
    Private Sub IncrementProgress()
        With pbUpdate
            If .Value < .Maximum Then .Value = .Value + 1
            Application.DoEvents()
        End With
    End Sub

    Private Sub BackupFile(ByVal FilePath As String)
        lblStatus.Text = label(LanguageFile.UPDATE_LABELS).Label(LanguageFile.DOWNLOADED).Value.Replace("%s", FilePath)
        Try
            File.Copy(FilePath, FilePath + ".bak", True)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdateDatabase(ByVal SqlFiles As ArrayList)

        Dim it As IEnumerator

        it = SqlFiles.GetEnumerator
        While it.MoveNext
            Dim oRead As New StreamReader(it.Current.ToString)
            db.ExecuteNonQuery(oRead.ReadToEnd)
        End While

        db.Close()
    End Sub

    Public Sub TraceError(ByVal ex As Exception)
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        trace.WriteLog(ex.Message + Environment.NewLine + ex.StackTrace)
    End Sub
End Class
