<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLaporan
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
        Me.DGdatasiswa = New System.Windows.Forms.DataGridView()
        Me.DGmapel = New System.Windows.Forms.DataGridView()
        Me.DGnilai = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.keluarBtn = New System.Windows.Forms.Button()
        CType(Me.DGdatasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGmapel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGnilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGdatasiswa
        '
        Me.DGdatasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdatasiswa.Location = New System.Drawing.Point(12, 23)
        Me.DGdatasiswa.Name = "DGdatasiswa"
        Me.DGdatasiswa.Size = New System.Drawing.Size(788, 109)
        Me.DGdatasiswa.TabIndex = 0
        '
        'DGmapel
        '
        Me.DGmapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGmapel.Location = New System.Drawing.Point(12, 349)
        Me.DGmapel.Name = "DGmapel"
        Me.DGmapel.Size = New System.Drawing.Size(788, 100)
        Me.DGmapel.TabIndex = 1
        '
        'DGnilai
        '
        Me.DGnilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGnilai.Location = New System.Drawing.Point(12, 158)
        Me.DGnilai.Name = "DGnilai"
        Me.DGnilai.Size = New System.Drawing.Size(788, 165)
        Me.DGnilai.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Siswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data Mata Pelajaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data Nilai"
        '
        'keluarBtn
        '
        Me.keluarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keluarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keluarBtn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarBtn.Location = New System.Drawing.Point(714, 0)
        Me.keluarBtn.Name = "keluarBtn"
        Me.keluarBtn.Size = New System.Drawing.Size(86, 23)
        Me.keluarBtn.TabIndex = 6
        Me.keluarBtn.Text = "KELUAR"
        Me.keluarBtn.UseVisualStyleBackColor = False
        '
        'FLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.keluarBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGnilai)
        Me.Controls.Add(Me.DGmapel)
        Me.Controls.Add(Me.DGdatasiswa)
        Me.Name = "FLaporan"
        Me.Text = "FLaporan"
        CType(Me.DGdatasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGmapel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGnilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGdatasiswa As DataGridView
    Friend WithEvents DGmapel As DataGridView
    Friend WithEvents DGnilai As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents keluarBtn As Button
End Class
