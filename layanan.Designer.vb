<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class layanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.tkode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.KODE_PESAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JENIS_KAMERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUMLAH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADMIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tharga = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Calisto MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(862, 397)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(189, 56)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "         REFRESH"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(366, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RENTAL KAMERA "
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calisto MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(862, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(189, 56)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "        DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calisto MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(862, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 54)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "      SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calisto MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(862, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 58)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "      NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tharga)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cb2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Controls.Add(Me.tkode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calisto MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(92, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 263)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PILIH PESANAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Harga"
        '
        'cb2
        '
        Me.cb2.FormattingEnabled = True
        Me.cb2.Items.AddRange(New Object() {"Satria", "Nurul"})
        Me.cb2.Location = New System.Drawing.Point(254, 207)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(186, 30)
        Me.cb2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ADMIN"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"-", "DSLR", "Mirrorless", "Analog", "Action", "Polaroid", "Underwater"})
        Me.cb1.Location = New System.Drawing.Point(254, 90)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(186, 30)
        Me.cb1.TabIndex = 4
        '
        'tkode
        '
        Me.tkode.Location = New System.Drawing.Point(254, 38)
        Me.tkode.Name = "tkode"
        Me.tkode.Size = New System.Drawing.Size(100, 31)
        Me.tkode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "JENIS KAMERA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "KODE PESAN"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODE_PESAN, Me.JENIS_KAMERA, Me.JUMLAH, Me.ADMIN})
        Me.DataGridView1.Location = New System.Drawing.Point(92, 387)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(748, 181)
        Me.DataGridView1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.rental_kamera.My.Resources.Resources._new
        Me.PictureBox1.Location = New System.Drawing.Point(871, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.rental_kamera.My.Resources.Resources.sv
        Me.PictureBox2.Location = New System.Drawing.Point(871, 225)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.rental_kamera.My.Resources.Resources.delete
        Me.PictureBox3.Location = New System.Drawing.Point(871, 317)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.rental_kamera.My.Resources.Resources.refresh
        Me.PictureBox4.Location = New System.Drawing.Point(871, 408)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Calisto MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(862, 477)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(189, 56)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "BACK"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'KODE_PESAN
        '
        Me.KODE_PESAN.HeaderText = "KODE_PESAN"
        Me.KODE_PESAN.Name = "KODE_PESAN"
        '
        'JENIS_KAMERA
        '
        Me.JENIS_KAMERA.HeaderText = "JENIS_KAMERA"
        Me.JENIS_KAMERA.Name = "JENIS_KAMERA"
        '
        'JUMLAH
        '
        Me.JUMLAH.HeaderText = "JENIS_LENSA"
        Me.JUMLAH.Name = "JUMLAH"
        '
        'ADMIN
        '
        Me.ADMIN.HeaderText = "ADMIN"
        Me.ADMIN.Name = "ADMIN"
        '
        'tharga
        '
        Me.tharga.Location = New System.Drawing.Point(254, 155)
        Me.tharga.Name = "tharga"
        Me.tharga.Size = New System.Drawing.Size(186, 31)
        Me.tharga.TabIndex = 9
        '
        'layanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.rental_kamera.My.Resources.Resources.R
        Me.ClientSize = New System.Drawing.Size(1454, 700)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Name = "layanan"
        Me.Text = "layanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents tkode As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KODE_PESAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JENIS_KAMERA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUMLAH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADMIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tharga As System.Windows.Forms.TextBox
End Class
