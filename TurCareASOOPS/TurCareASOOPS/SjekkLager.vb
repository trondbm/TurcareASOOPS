﻿Imports MySql.Data.MySqlClient

Public Class SjekkLager
    Public tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_t4;Uid=g_oops_t4;Pwd=passord123")

    Private Function sporring(ByVal sql As String) As DataTable
        Dim mydata As New DataTable
        Try
            tilkobling.Open()
            Dim kommando As New MySqlCommand(sql, tilkobling)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(mydata)
            tilkobling.Close()
        Catch ex As Exception
            MessageBox.Show("Noe gikk galt. " & ex.Message)
            tilkobling.Close()
        End Try
        Return mydata

    End Function

    Private Sub btnSoek_Click(sender As Object, e As EventArgs) Handles btnSoek.Click

        Dim mydata As New DataTable
        Dim vare As String = txtSoek.Text
        Dim sporring = "Select * from vare where vare_navn = '" & vare & "'"
        Dim sql2 As New MySqlCommand(sporring, tilkobling)
        Dim da2 As New MySqlDataAdapter
        da2.SelectCommand = sql2
        da2.Fill(mydata)
        Dim varen1 = mydata.Rows(0).Item("vare_navn").ToString()
        Dim varen2 = mydata.Rows(0).Item("vare_id").ToString()
        Dim varen3 = mydata.Rows(0).Item("vare_pris").ToString()
        Dim varen4 = mydata.Rows(0).Item("vare_antall").ToString()
        With ListBox1.Items
            .Add("Navn" & vbTab & "ID" & vbTab & "Pris" & vbTab & "Antall")
            .Add("")
            .Add(varen1 & vbTab & varen2 & vbTab & varen3 & vbTab & varen4)
        End With


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Hide()
        meny.Show()

    End Sub
End Class