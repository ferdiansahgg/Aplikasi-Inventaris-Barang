Imports System.Data.OleDb

Public Class FormDaftar
    Sub Nonaktif()
        TBNama.Text = ""
        TBNama.Enabled = False
        TBPass.Text = ""
        TBPass.Enabled = False
        TextBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Text = ""
        TextBox2.Enabled = False
        TBKode.Text = ""
        TBKode.Enabled = False
    End Sub
    Sub Aktif()
        TBNama.Text = ""
        TBNama.Enabled = True
        TBPass.Text = ""
        TBPass.Enabled = True
        TextBox1.Text = ""
        TextBox1.Enabled = True
        TextBox2.Text = ""
        TextBox2.Enabled = True
        TBKode.Text = ""
        TBKode.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "DAFTAR" Then
            Call Aktif()
            Button1.Text = "SIMPAN"
            Button2.Text = "BATAL"

        Else
            If TBNama.Text = "" Or TBPass.Text = "" Or TBKode.Text = "" Then
                MsgBox("Data Belum Lengkap !!!", MsgBoxStyle.Critical, "WARNING !!!")
                TBNama.Focus()
            Else
                Call Koneksi()
                CMD = New OleDbCommand("SELECT * FROM tbdaftar WHERE username='" & TBNama.Text & "' AND password='" & TBPass.Text & "' AND email='" & TextBox1.Text & "' AND nohp='" & TextBox2.Text & "' AND kode='" & TBKode.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If Not DR.HasRows Then

                    Dim SIMPAN As String = "INSERT INTO tbdaftar VALUES ('" & TBNama.Text & "','" & TBPass.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TBKode.Text & "')"
                    CMD = New OleDbCommand(SIMPAN, CONN)
                    CMD.ExecuteNonQuery()
                    Button1.Text = "DAFTAR"
                    Button2.Text = "KEMBALI"
                    MsgBox("Data User : " & TBNama.Text & " PENDAFTARAN SUKSESS !!!", MsgBoxStyle.Information, "KONFIRMASI")
                    DR.Close()
                    Call Nonaktif()
                Else
                    MsgBox("Username Telah digunakan!!!", MsgBoxStyle.Critical, "WARNING !!!")

                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub daftar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Nonaktif()
    End Sub
End Class