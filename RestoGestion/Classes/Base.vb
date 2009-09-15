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

Imports System.Data.SQLite

'//Classe pour la gestion de la base //
Public Class Base
	 
    Private Connexion As SQLiteConnection

    Public Sub New(ByVal BasePath As String)
        Dim ConnexionString As String
        ConnexionString = "data source=" + BasePath
        Connexion = New SQLiteConnection(ConnexionString)

        Try
            Connexion.Open()
        Catch ex As Exception
            Connexion = Nothing
            Throw
        End Try
    End Sub

    Public Sub Close()
        Try
            Connexion.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ExecuteQuery(ByVal Query As String) As ArrayList
        Dim Command As New SQLiteCommand(Connexion)
        Dim result As ArrayList
        Dim reader As SQLiteDataReader
        Dim row As Hashtable

        result = New ArrayList

        Command.CommandText = Query
        Try
            reader = Command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    row = New Hashtable(reader.FieldCount)
                    For i As Integer = 0 To reader.FieldCount - 1
                        row.Add(reader.GetName(i), reader.GetValue(i))
                    Next
                    result.Add(row)
                    row = Nothing
                End While
            End If
            reader.Close()
        Catch ex As Exception
            Throw
        Finally
            Command.Dispose()
        End Try

        Return result
    End Function

    Public Function ExecuteQuery(ByVal Query As String, ByVal params As ArrayList) As ArrayList
        Dim Command As New SQLiteCommand(Connexion)
        Dim result As ArrayList
        Dim reader As SQLiteDataReader
        Dim row As Hashtable

        result = New ArrayList

        Command = PrepareQuery(Query, params)
        Try
            reader = Command.ExecuteReader
            If reader.HasRows Then
                While reader.Read()
                    row = New Hashtable(reader.FieldCount)
                    For i As Integer = 0 To reader.FieldCount - 1
                        row.Add(reader.GetName(i), reader.GetValue(i))
                    Next
                    result.Add(row)
                    row = Nothing
                End While
            End If
            reader.Close()
        Catch ex As Exception
            Throw
        Finally
            Command.Dispose()
        End Try

        Return result
    End Function


    Public Function ExecuteNonQuery(ByVal Query As String) As Integer
        Dim Command As New SQLiteCommand(Connexion)
        Dim result As Integer
        Dim tran As SQLiteTransaction

        tran = Connexion.BeginTransaction()
        Command.CommandText = Query
        Try
            result = Command.ExecuteNonQuery
            tran.Commit()
        Catch ex As Exception
            Throw
        Finally
            Command.Dispose()
            tran.Dispose()
        End Try

        Return result
    End Function

    Public Function ExecuteNonQuery(ByVal Query As String, ByVal params As ArrayList) As Integer
        Dim Command As New SQLiteCommand(Connexion)
        Dim result As Integer
        Dim tran As SQLiteTransaction

        tran = Connexion.BeginTransaction()
        Command = PrepareQuery(Query, params)
        Try
            result = Command.ExecuteNonQuery
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            Throw
        Finally
            Command.Dispose()
            tran.Dispose()
        End Try

        Return result
    End Function

    Private Function PrepareQuery(ByVal Query As String, ByVal params As ArrayList) As SQLiteCommand
        Dim it As IEnumerator
        Dim result As New SQLiteCommand(Query, Connexion)

        it = params.GetEnumerator
        While it.MoveNext
            result.Parameters.AddWithValue(Nothing, it.Current)
        End While

        Return result
    End Function
End Class
