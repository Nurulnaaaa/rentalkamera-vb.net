Imports System.Data.Odbc
Public Class transaksi

    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=db_uas"
        con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String = "insert into transaksi(no_ktp,nama,alamat,no_hp,kode_pesan,jenis_kamera,tgl_sewa,tgl_kembali,lama_sewa,harga,total) values('" & cb1.Text & "' , '" & tnama.Text & "' , '" & talamat.Text & "' , '" & thp.Text & "' , '" & cb2.Text & "' , '" & tjenis.Text & "' , '" & DateTimePicker1.Text & "' , '" & DateTimePicker2.Text & "' , " & tlama.Text & " , " & tharga.Text & " , " & ttotal.Text & ")"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from transaksi order by no_ktp asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try

    End Sub
    Sub tampilno_ktp()
        cmd = New OdbcCommand("select no_ktp from pelanggan", con)
        dr = cmd.ExecuteReader
        cb1.Items.Clear()
        Do While dr.Read
            cb1.Items.Add(dr.Item("no_ktp"))
        Loop
    End Sub
    Sub tampilkode()
        cmd = New OdbcCommand("select kode_pesan from layanan", con)
        dr = cmd.ExecuteReader
        cb2.Items.Clear()
        Do While dr.Read
            cb2.Items.Add(dr.Item("kode_pesan"))
        Loop

    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        tampil()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cb1.Text = "-pilih-"
        tnama.Text = ""
        talamat.Text = ""
        thp.Text = ""
        cb2.Text = "-pilih-"
        tjenis.Text = ""
        tlama.Text = ""
        tharga.Text = "0"
        ttotal.Text = "0"
        cb1.Focus()
    End Sub

    Private Sub transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        tampilno_ktp()
        tampilkode()
    End Sub

    Private Sub cb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged
        cmd = New OdbcCommand("select * from pelanggan where no_ktp='" & cb1.Text & "'", con)
        dr = cmd.ExecuteReader

        dr.Read()
        If dr.HasRows Then
            tnama.Text = dr.Item("nama")
            talamat.Text = dr.Item("alamat")
            thp.Text = dr.Item("no_tlp")
        Else
            MsgBox("No ktp pelanggan tidak ada")
        End If
    End Sub

    Private Sub cb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.SelectedIndexChanged
        cmd = New OdbcCommand("select * from layanan where kode_pesan='" & cb2.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tjenis.Text = dr.Item("jenis_kamera")
            tharga.Text = dr.Item("harga")
        Else
            MsgBox("Kode pesan tidak ada")
        End If


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan no_ktp=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from transaksi where no_ktp='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data nilai BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        simpan()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim harga As Integer
        Dim lama As Integer
        Dim total As Integer

        harga = CInt(tharga.Text)
        lama = CInt(tlama.Text)
        total = CSng(harga * lama)
        ttotal.Text = total
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Dim query As String = "SELECT * FROM transaksi ORDER BY no_ktp ASC"
        Try
            Form1.DataSet1.Clear()
            Form1.DataSet1.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(Form1.DataSet1.DataTable1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Form1.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Form1.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Form1.ReportViewer1.ZoomPercent = 25
        Form1.ReportViewer1.RefreshReport()
        Form1.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class