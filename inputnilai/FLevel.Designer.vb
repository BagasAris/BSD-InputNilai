<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLevel
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
        Me.DGdatalevel = New System.Windows.Forms.DataGridView()
        CType(Me.DGdatalevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cariBtn
        '
        Me.cariBtn.Location = New System.Drawing.Point(704, 339)
        Me.cariBtn.Name = "cariBtn"
        Me.cariBtn.Size = New System.Drawing.Size(75, 23)
        Me.cariBtn.TabIndex = 52
        Me.cariBtn.Text = "CARI"
        Me.cariBtn.UseVisualStyleBackColor = True
        '
        'keluarBtn
        '
        Me.keluarBtn.Location = New System.Drawing.Point(349, 339)
        Me.keluarBtn.Name = "keluarBtn"
        Me.keluarBtn.Size = New System.Drawing.Size(75, 23)
        Me.keluarBtn.TabIndex = 51
        Me.keluarBtn.Text = "KELUAR"
        Me.keluarBtn.UseVisualStyleBackColor = True
        '
        'hapusBtn
        '
        Me.hapusBtn.Location = New System.Drawing.Point(240, 339)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusBtn.TabIndex = 50
        Me.hapusBtn.Text = "HAPUS"
        Me.hapusBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(126, 339)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 49
        Me.editBtn.Text = "EDIT"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'tambahBtn
        '
        Me.tambahBtn.Location = New System.Drawing.Point(21, 339)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(75, 23)
        Me.tambahBtn.TabIndex = 48
        Me.tambahBtn.Text = "TAMBAH"
        Me.tambahBtn.UseVisualStyleBackColor = True
        '
        'cariTxt
        '
        Me.cariTxt.Location = New System.Drawing.Point(491, 339)
        Me.cariTxt.Name = "cariTxt"
        Me.cariTxt.Size = New System.Drawing.Size(207, 20)
        Me.cariTxt.TabIndex = 47
        '
        'namaTxt
        '
        Me.namaTxt.Location = New System.Drawing.Point(491, 70)
        Me.namaTxt.Name = "namaTxt"
        Me.namaTxt.Size = New System.Drawing.Size(285, 20)
        Me.namaTxt.TabIndex = 46
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(103, 70)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(285, 20)
        Me.idTxt.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(451, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Form Data Level"
        '
        'DGdatalevel
        '
        Me.DGdatalevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdatalevel.Location = New System.Drawing.Point(27, 118)
        Me.DGdatalevel.Name = "DGdatalevel"
        Me.DGdatalevel.Size = New System.Drawing.Size(752, 206)
        Me.DGdatalevel.TabIndex = 39
        '
        'FLevel
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
        Me.Controls.Add(Me.DGdatalevel)
        Me.Name = "FLevel"
        Me.Text = "FLevel"
        CType(Me.DGdatalevel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DGdatalevel As DataGridView
End Class
