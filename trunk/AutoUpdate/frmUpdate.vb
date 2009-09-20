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
Imports Microsoft.VisualBasic


Public Class frmUpdate
    Private Const SERVERURL As String = "http://localhost/web/update"
    'Private Const SERVERURL As String = "http://511.free.fr/update"

    Private Sub frmUpdate_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim wbcUpdate As New WebClient
        Dim bIsUpdate As Boolean = False
        Dim xmlUpdate As UpdateFile
        Dim it As IEnumerator(Of Names)
        Dim SQLFiles As New ArrayList

        pbUpdate.Value = 0
        pbUpdate.Maximum = 1

        Try
            'on crée le répertoire d'acceuil des mises à jour.
            If Not Directory.Exists(Application.StartupPath + "\update") Then
                Directory.CreateDirectory(Application.StartupPath + "\update")
            End If

            'on recupère le fichier XML contenant les infos de MAJ
            lblStatus.Text = "Téléchargement du fichier ServerManifest.xml..."
            Application.DoEvents()
            wbcUpdate.DownloadFile(SERVERURL + "/ServerManifest.xml", Application.StartupPath + "\update\ServerManifest.xml")
            lblStatus.Text = "Téléchargement du fichier ServerManifest.xml terminé"
            Application.DoEvents()

            'on vérifie qu'il n'est pas identique au dernier télécharger
            If File.Exists(Application.StartupPath + "\ServerManifest.xml") Then
                bIsUpdate = verifyHash(getHash(Application.StartupPath + "\update\ServerManifest.xml"), getHash(Application.StartupPath + "\ServerManifest.xml"))
            End If

            'identique, alors on ne fait rien
            If bIsUpdate Then
                MessageBox.Show("Pas de mise à jour disponible", "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'on commence la mise à jour
                'Si on execute depuis l'application principale, on termine l'application
                If My.Application.CommandLineArgs.Count > 0 Then
                    KillAppExe(My.Application.CommandLineArgs(0).Replace(".exe", ""))
                End If
                'on ouvre le fichier XML
                xmlUpdate = New UpdateFile(Application.StartupPath + "\update\ServerManifest.xml")
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
                        If it.Current.Extension.Equals("sql") Then
                            wbcUpdate.DownloadFile(SERVERURL + CurrentFile.Replace("\", "/"), Application.StartupPath + "\update" + CurrentFile)
                            SQLFiles.Add(Application.StartupPath + "\update" + CurrentFile)
                        Else
                            wbcUpdate.DownloadFile(SERVERURL + CurrentFile.Replace("\", "/"), Application.StartupPath + CurrentFile)
                        End If
                    End If
                End While
                UpdateDatabase(SQLFiles)
                xmlUpdate = Nothing
                File.Copy(Application.StartupPath + "\update\ServerManifest.xml", Application.StartupPath + "\ServerManifest.xml", True)
            End If

            'suppression du répertoire temporaire
            Directory.Delete(Application.StartupPath + "\update", True)

            IncrementProgress()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        lblStatus.Text = "Copie de l'ancien fichier " + FilePath
        Try
            File.Copy(FilePath, FilePath + ".bak", True)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdateDatabase(ByVal SqlFiles As ArrayList)
        Dim db As New Base(Application.StartupPath + "\RestoGestion.db")
        Dim it As IEnumerator

        it = SqlFiles.GetEnumerator
        While it.MoveNext
            Dim oRead As New StreamReader(it.Current.ToString)
            db.ExecuteNonQuery(oRead.ReadToEnd)
        End While

        db.Close()
    End Sub
End Class
