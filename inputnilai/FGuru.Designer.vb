<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FGuru
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
        Me.nipTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jk = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGdataguru = New System.Windows.Forms.DataGridView()
        Me.level = New System.Windows.Forms.ComboBox()
        CType(Me.DGdataguru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nipTxt
        '
        Me.nipTxt.Location = New System.Drawing.Point(103, 138)
        Me.nipTxt.Name = "nipTxt"
        Me.nipTxt.Size = New System.Drawing.Size(285, 20)
        Me.nipTxt.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Nip"
        '
        'jk
        '
        Me.jk.FormattingEnabled = True
        Me.jk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.jk.Location = New System.Drawing.Point(491, 69)
        Me.jk.Name = "jk"
        Me.jk.Size = New System.Drawing.Size(285, 21)
        Me.jk.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Jenis Kelamin"
        '
        'cariBtn
        '
        Me.cariBtn.Location = New System.Drawing.Point(704, 401)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(75, 23)
        Me.cariBtn.TabIndex = 33
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = True
        '
        'keluarBtn
        '
        Me.keluarBtn.Location = New System.Drawing.Point(349, 401)
        Me.keluarBtn.Name = "keluarBtn"
        Me.keluarBtn.Size = New System.Drawing.Size(75, 23)
        Me.keluarBtn.TabIndex = 32
        Me.keluarBtn.Text = "KELUAR"
        Me.keluarBtn.UseVisualStyleBackColor = True
        '
        'hapusBtn
        '
        Me.hapusBtn.Location = New System.Drawing.Point(240, 401)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusBtn.TabIndex = 31
        Me.hapusBtn.Text = "HAPUS"
        Me.hapusBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(126, 401)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 30
        Me.editBtn.Text = "EDIT"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'tambahBtn
        '
        Me.tambahBtn.Location = New System.Drawing.Point(21, 401)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(75, 23)
        Me.tambahBtn.TabIndex = 29
        Me.tambahBtn.Text = "TAMBAH"
        Me.tambahBtn.UseVisualStyleBackColor = True
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(491, 401)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(207, 20)
        Me.cariTxt.TabIndex = 28
        '
        'namaTxt
        '
        Me.namaTxt.Location = New System.Drawing.Point(103, 102)
        Me.namaTxt.Name = "namaTxt"
        Me.namaTxt.Size = New System.Drawing.Size(285, 20)
        Me.namaTxt.TabIndex = 26
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(103, 70)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(285, 20)
        Me.idTxt.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(451, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Id Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Form Data Guru"
        '
        'DGdataguru
        '
        Me.DGdataguru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdataguru.Location = New System.Drawing.Point(27, 180)
        Me.DGdataguru.Name = "DGdataguru"
        Me.DGdataguru.Size = New System.Drawing.Size(752, 206)
        Me.DGdataguru.TabIndex = 19
        '
        'level
        '
        Me.level.FormattingEnabled = True
        Me.level.Location = New System.Drawing.Point(491, 109)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(285, 21)
        Me.level.TabIndex = 38
        '
        'FGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.level)
        Me.Controls.Add(Me.nipTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.jk)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGdataguru)
        Me.Name = "FGuru"
        Me.Text = "FGuru"
        CType(Me.DGdataguru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nipTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents jk As ComboBox
    Friend WithEvents Label6 As Label
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGdataguru As DataGridView
    Friend WithEvents level As ComboBox
End Class
