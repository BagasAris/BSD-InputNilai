<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKelas
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
        Me.cariBtn = New System.Windows.Forms.Button()
        Me.keluarBtn = New System.Windows.Forms.Button()
        Me.hapusBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.tambahBtn = New System.Windows.Forms.Button()
        Me.cariTxt = New System.Windows.Forms.TextBox()
        Me.namaTxt = New System.Windows.Forms.TextBox()
        Me.idTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGdatakelas = New System.Windows.Forms.DataGridView()
        Me.generasiTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DGdatakelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cariBtn
        '
        Me.cariBtn.Location = New System.Drawing.Point(704, 370)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(75, 23)
        Me.cariBtn.TabIndex = 65
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = True
        '
        'keluarBtn
        '
        Me.keluarBtn.Location = New System.Drawing.Point(349, 370)
        Me.keluarBtn.Name = "keluarBtn"
        Me.keluarBtn.Size = New System.Drawing.Size(75, 23)
        Me.keluarBtn.TabIndex = 64
        Me.keluarBtn.Text = "KELUAR"
        Me.keluarBtn.UseVisualStyleBackColor = True
        '
        'hapusBtn
        '
        Me.hapusBtn.Location = New System.Drawing.Point(240, 370)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusBtn.TabIndex = 63
        Me.hapusBtn.Text = "HAPUS"
        Me.hapusBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(126, 370)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 62
        Me.editBtn.Text = "EDIT"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'tambahBtn
        '
        Me.tambahBtn.Location = New System.Drawing.Point(21, 370)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(75, 23)
        Me.tambahBtn.TabIndex = 61
        Me.tambahBtn.Text = "TAMBAH"
        Me.tambahBtn.UseVisualStyleBackColor = True
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(491, 370)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(207, 20)
        Me.cariTxt.TabIndex = 60
        '
        'namaTxt
        '
        Me.namaTxt.Location = New System.Drawing.Point(491, 65)
        Me.namaTxt.Name = "namaTxt"
        Me.namaTxt.Size = New System.Drawing.Size(285, 20)
        Me.namaTxt.TabIndex = 59
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(103, 65)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(285, 20)
        Me.idTxt.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(451, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Form Data Kelas"
        '
        'DGdatakelas
        '
        Me.DGdatakelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdatakelas.Location = New System.Drawing.Point(27, 149)
        Me.DGdatakelas.Name = "DGdatakelas"
        Me.DGdatakelas.Size = New System.Drawing.Size(752, 206)
        Me.DGdatakelas.TabIndex = 53
        '
        'generasiTxt
        '
        Me.generasiTxt.Location = New System.Drawing.Point(103, 102)
        Me.generasiTxt.Name = "generasiTxt"
        Me.generasiTxt.Size = New System.Drawing.Size(285, 20)
        Me.generasiTxt.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Generasi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(412, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Jurusan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pengembangan Perangkat Lunak dan Gim", "Desain Gambar Mesin", "Desain Pemodelan Informasi Bangunan", "Teknik Komputer Jaringan", "Teknik Kendaraan Ringan Otomotif", "Teknik Bisnis Sepeda Motor", "Teknik Instalasi Tenaga Listrik", "Teknik Elektronika Industri", "Teknik Mesin", "Teknik Pengelasan", "Teknik Fabrika Logam dan Manufactur"})
        Me.ComboBox1.Location = New System.Drawing.Point(491, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(285, 21)
        Me.ComboBox1.TabIndex = 69
        '
        'FKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.generasiTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cariBtn)
        Me.Controls.Add(Me.keluarBtn)
        Me.Controls.Add(Me.hapusBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.tambahBtn)
        Me.Controls.Add(Me.cariTxt)
        Me.Controls.Add(Me.namaTxt)
        Me.Controls.Add(Me.idTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGdatakelas)
        Me.Name = "FKelas"
        Me.Text = "FKelas"
        CType(Me.DGdatakelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cariBtn As Button
    Friend WithEvents keluarBtn As Button
    Friend WithEvents hapusBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents tambahBtn As Button
    Friend WithEvents cariTxt As TextBox
    Friend WithEvents namaTxt As TextBox
    Friend WithEvents idTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGdatakelas As DataGridView
    Friend WithEvents generasiTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
