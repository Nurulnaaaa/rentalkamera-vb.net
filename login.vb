Imports System.Data.Odbc

Public Class Form3
    Sub Terbuka()
        FormMenu.LOGINToolStripMenuItem.Visible = False
        FormMenu.LOGOUTToolStripMenuItem.Visible = True
        FormMenu.MENUToolStripMenuItem.Visible = True
        FormMenu.PELANGGANToolStripMenuItem.Visible = True
        FormMenu.LAYANANToolStripMenuItem.Visible = True
        FormMenu.KELUARToolStripMenuItem.Visible = True
        FormMenu.TRANSAKSIToolStripMenuItem.Visible = True

    End Sub


    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()


    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username atau Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            CMd = New OdbcCommand("Select * From login where username='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'", Con)
            Rd = CMd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                'If TextBox1.Text = "AA" And TextBox2.Text = "BB" Then
                Me.Close()
                Call Terbuka()
            Else
                MsgBox("Username atau Password Salah!")
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub
End Class