Imports System.Data.Odbc

Public Class FormMenu
    Sub Terkunci()
        LOGINToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MENUToolStripMenuItem.Visible = False
        LAYANANToolStripMenuItem.Visible = False
        PELANGGANToolStripMenuItem.Visible = False
        KELUARToolStripMenuItem.Visible = False
        TRANSAKSIToolStripMenuItem.Visible = False

    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub PELANGGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PELANGGANToolStripMenuItem.Click
        pelanggan.ShowDialog()
    End Sub

    Private Sub LAYANANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAYANANToolStripMenuItem.Click
        layanan.ShowDialog()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        transaksi.ShowDialog()
    End Sub
End Class