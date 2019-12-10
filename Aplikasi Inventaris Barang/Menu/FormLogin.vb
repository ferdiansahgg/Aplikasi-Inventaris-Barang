Imports System.Data.OleDb

Public Class FormLogin

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            CheckBox1.Checked = False
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Kolom Username Belum Anda Isi !!", MsgBoxStyle.Critical, "WARNING !!!")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("Kolom Password Belum Anda Isi !!", MsgBoxStyle.Critical, "WARNING !!!")
            TextBox2.Focus()
        Else
            Call Koneksi()
            CMD = New OleDbCommand("SELECT * FROM tbdaftar WHERE username='" & TextBox1.Text & "' AND password='" & TextBox2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.Hide()
                MsgBox("LOGIN SUCCESS", MsgBoxStyle.Information, "CONFIRMATION")
                splashscreen.Show()
            Else
                MsgBox("Username atau Password yang anda masukkan salah !!!", MsgBoxStyle.Critical, "WARNING !!!")
                TextBox1.Focus()
            End If
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = "" Then
                MsgBox("Kolom Username Belum Anda Isi !!", MsgBoxStyle.Critical, "WARNING !!!")
                TextBox1.Focus()
            ElseIf TextBox2.Text = "" Then
                MsgBox("Kolom Password Belum Anda Isi !!", MsgBoxStyle.Critical, "WARNING !!!")
                TextBox2.Focus()
            Else
                Call Koneksi()
                CMD = New OleDbCommand("SELECT * FROM tbdaftar WHERE username='" & TextBox1.Text & "' AND password='" & TextBox2.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Me.Hide()
                    MsgBox("LOGIN SUCCESS", MsgBoxStyle.Information, "CONFIRMATION")
                    splashscreen.Show()
                Else
                    MsgBox("Username atau Password yang anda masukkan salah !!!", MsgBoxStyle.Critical, "WARNING !!!")
                    TextBox1.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub login1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormDaftar.Show()
        Me.Hide()
    End Sub
End Class