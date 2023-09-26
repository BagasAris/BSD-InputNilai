<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNilai
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
        Me.idTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGnilai = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uts1Txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.uts2Txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uas1Txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.uas2Txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mapel = New System.Windows.Forms.ComboBox()
        Me.siswa = New System.Windows.Forms.ComboBox()
        CType(Me.DGnilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cariBtn
        '
        Me.cariBtn.Location = New System.Drawing.Point(701, 390)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(75, 23)
        Me.cariBtn.TabIndex = 44
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = True
        '
        'keluarBtn
        '
        Me.keluarBtn.Location = New System.Drawing.Point(319, 390)
        Me.keluarBtn.Name = "keluarBtn"
        Me.keluarBtn.Size = New System.Drawing.Size(75, 23)
        Me.keluarBtn.TabIndex = 43
        Me.keluarBtn.Text = "KELUAR"
        Me.keluarBtn.UseVisualStyleBackColor = True
        '
        'hapusBtn
        '
        Me.hapusBtn.Location = New System.Drawing.Point(222, 391)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusBtn.TabIndex = 42
        Me.hapusBtn.Text = "HAPUS"
        Me.hapusBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(125, 390)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 41
        Me.editBtn.Text = "EDIT"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'tambahBtn
        '
        Me.tambahBtn.Location = New System.Drawing.Point(24, 390)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(75, 23)
        Me.tambahBtn.TabIndex = 40
        Me.tambahBtn.Text = "TAMBAH"
        Me.tambahBtn.UseVisualStyleBackColor = True
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(527, 393)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(168, 20)
        Me.cariTxt.TabIndex = 39
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(141, 43)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(249, 20)
        Me.idTxt.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(412, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nama Mata Pelajaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Form Nilai"
        '
        'DGnilai
        '
        Me.DGnilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGnilai.Location = New System.Drawing.Point(24, 191)
        Me.DGnilai.Name = "DGnilai"
        Me.DGnilai.Size = New System.Drawing.Size(752, 184)
        Me.DGnilai.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nama Siswa"
        '
        'uts1Txt
        '
        Me.uts1Txt.Location = New System.Drawing.Point(141, 119)
        Me.uts1Txt.Name = "uts1Txt"
        Me.uts1Txt.Size = New System.Drawing.Size(249, 20)
        Me.uts1Txt.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "UTS 1"
        '
        'uts2Txt
        '
        Me.uts2Txt.Location = New System.Drawing.Point(141, 165)
        Me.uts2Txt.Name = "uts2Txt"
        Me.uts2Txt.Size = New System.Drawing.Size(249, 20)
        Me.uts2Txt.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "UTS 2"
        '
        'uas1Txt
        '
        Me.uas1Txt.Location = New System.Drawing.Point(523, 127)
        Me.uas1Txt.Name = "uas1Txt"
        Me.uas1Txt.Size = New System.Drawing.Size(253, 20)
        Me.uas1Txt.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(476, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "UAS 1"
        '
        'uas2Txt
        '
        Me.uas2Txt.Location = New System.Drawing.Point(523, 165)
        Me.uas2Txt.Name = "uas2Txt"
        Me.uas2Txt.Size = New System.Drawing.Size(253, 20)
        Me.uas2Txt.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(476, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "UAS 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(408, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 55
        '
        'mapel
        '
        Me.mapel.FormattingEnabled = True
        Me.mapel.Location = New System.Drawing.Point(141, 84)
        Me.mapel.Name = "mapel"
        Me.mapel.Size = New System.Drawing.Size(249, 21)
        Me.mapel.TabIndex = 56
        '
        'siswa
        '
        Me.siswa.FormattingEnabled = True
        Me.siswa.Location = New System.Drawing.Point(523, 40)
        Me.siswa.Name = "siswa"
        Me.siswa.Size = New System.Drawing.Size(249, 21)
        Me.siswa.TabIndex = 57
        '
        'FNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.siswa)
        Me.Controls.Add(Me.mapel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.uas2Txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.uas1Txt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.uts2Txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.uts1Txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cariBtn)
        Me.Controls.Add(Me.keluarBtn)
        Me.Controls.Add(Me.hapusBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.tambahBtn)
        Me.Controls.Add(Me.cariTxt)
        Me.Controls.Add(Me.idTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGnilai)
        Me.Name = "FNilai"
        Me.Text = "FNilai"
        CType(Me.DGnilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cariBtn As Button
    Friend WithEvents keluarBtn As Button
    Friend WithEvents hapusBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents tambahBtn As Button
    Friend WithEvents cariTxt As TextBox
    Friend WithEvents idTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGnilai As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents uts1Txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents uts2Txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents uas1Txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents uas2Txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mapel As ComboBox
    Friend WithEvents siswa As ComboBox
End Class
