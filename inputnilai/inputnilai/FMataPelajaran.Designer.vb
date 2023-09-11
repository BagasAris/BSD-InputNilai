<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMataPelajaran
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
        Me.DGmapel = New System.Windows.Forms.DataGridView()
        CType(Me.DGmapel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cariBtn
        '
        Me.cariBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cariBtn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cariBtn.Location = New System.Drawing.Point(707, 375)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(75, 23)
        Me.cariBtn.TabIndex = 31
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = False
        '
        'keluarBtn
        '
        Me.keluarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keluarBtn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarBtn.Location = New System.Drawing.Point(322, 375)
        Me.keluarBtn.Name = "keluarBtn"
        Me.keluarBtn.Size = New System.Drawing.Size(75, 23)
        Me.keluarBtn.TabIndex = 30
        Me.keluarBtn.Text = "KELUAR"
        Me.keluarBtn.UseVisualStyleBackColor = False
        '
        'hapusBtn
        '
        Me.hapusBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hapusBtn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusBtn.Location = New System.Drawing.Point(225, 376)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusBtn.TabIndex = 29
        Me.hapusBtn.Text = "HAPUS"
        Me.hapusBtn.UseVisualStyleBackColor = False
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.editBtn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.Location = New System.Drawing.Point(128, 375)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 28
        Me.editBtn.Text = "EDIT"
        Me.editBtn.UseVisualStyleBackColor = False
        '
        'tambahBtn
        '
        Me.tambahBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tambahBtn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahBtn.Location = New System.Drawing.Point(27, 375)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(75, 23)
        Me.tambahBtn.TabIndex = 27
        Me.tambahBtn.Text = "TAMBAH"
        Me.tambahBtn.UseVisualStyleBackColor = False
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(501, 378)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(200, 20)
        Me.cariTxt.TabIndex = 26
        '
        'namaTxt
        '
        Me.namaTxt.Location = New System.Drawing.Point(530, 84)
        Me.namaTxt.Name = "namaTxt"
        Me.namaTxt.Size = New System.Drawing.Size(249, 20)
        Me.namaTxt.TabIndex = 24
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(52, 87)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(205, 20)
        Me.idTxt.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(456, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama Mata Pelajaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yellowtail", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 67)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Form Mata Pelajaran"
        '
        'DGmapel
        '
        Me.DGmapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGmapel.Location = New System.Drawing.Point(27, 128)
        Me.DGmapel.Name = "DGmapel"
        Me.DGmapel.Size = New System.Drawing.Size(752, 232)
        Me.DGmapel.TabIndex = 17
        '
        'FMataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Controls.Add(Me.DGmapel)
        Me.Name = "FMataPelajaran"
        Me.Text = "FMataPelajaran"
        CType(Me.DGmapel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DGmapel As DataGridView
End Class
