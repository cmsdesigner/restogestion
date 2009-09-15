Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Public Class frmUpdate

    Private Sub frmUpdate_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim sProgram As String = Microsoft.VisualBasic.Command()
        Dim wbcUpdate As New WebClient
        Dim bIsUpdate As Boolean = False
        Dim xmlUpdate As New XMLFile

        pbUpdate.Value = 0
        pbUpdate.Maximum = 1
        If sProgram = Nothing Then
            If Not Directory.Exists(Application.StartupPath + "\update") Then
                Directory.CreateDirectory(Application.StartupPath + "\update")
            End If
            Try
                lblStatus.Text = "Téléchargement du fichier ServerManifest.xml..."
                Application.DoEvents()
                wbcUpdate.DownloadFile("http://511.free.fr/update/ServerManifest.xml", Application.StartupPath + "\update\ServerManifest.xml")
                lblStatus.Text = "Téléchargement du fichier ServerManifest.xml terminé"
                Application.DoEvents()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur")
            End Try
            If File.Exists(Application.StartupPath + "\ServerManifest.xml") Then
                bIsUpdate = verifyMd5Hash(getMd5Hash(Application.StartupPath + "\update\ServerManifest.xml"), getMd5Hash(Application.StartupPath + "\ServerManifest.xml"))
            End If
            If bIsUpdate Then
                MsgBox("Pas de mise à jour disponible", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mise à jour")
            End If
        Else
            KillAppExe(sProgram.Replace(".exe", ""))
        End If
        If Not bIsUpdate Then
            xmlUpdate.OpenFile(Application.StartupPath + "\update\ServerManifest.xml")
            pbUpdate.Maximum += xmlUpdate.GetCountElements("update", "name")
            Application.DoEvents()
            'TODO for Each xmlUpdate.
            xmlUpdate.CloseFile()
            File.Copy(Application.StartupPath + "\update\ServerManifest.xml", Application.StartupPath + "\ServerManifest.xml")
        End If
        Directory.Delete(Application.StartupPath + "\update", True)
        IncrementProgress()
        Me.Close()
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
    Function verifyMd5Hash(ByVal sHash1 As String, ByVal sHash2 As String) As Boolean

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
        Dim local As Process() = Process.GetProcesses
        Dim i As Integer

        ' Search MainApp process in windows process
        For i = 0 To local.Length - 1
            ' If MainApp process found then close or kill MainApp
            If Strings.UCase(local(i).ProcessName) = Strings.UCase(sProgram) Then
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
End Class
