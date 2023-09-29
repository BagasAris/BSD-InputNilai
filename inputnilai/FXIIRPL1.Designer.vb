<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FXIIRPL1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOut = New Guna.UI.WinForms.GunaButton()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSiswaToolStripMenuItem, Me.NilaiToolStripMenuItem, Me.MataPelajaranToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataSiswaToolStripMenuItem
        '
        Me.DataSiswaToolStripMenuItem.Name = "DataSiswaToolStripMenuItem"
        Me.DataSiswaToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.DataSiswaToolStripMenuItem.Text = "Data Siswa"
        '
        'NilaiToolStripMenuItem
        '
        Me.NilaiToolStripMenuItem.Name = "NilaiToolStripMenuItem"
        Me.NilaiToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NilaiToolStripMenuItem.Text = "Nilai"
        '
        'MataPelajaranToolStripMenuItem
        '
        Me.MataPelajaranToolStripMenuItem.Name = "MataPelajaranToolStripMenuItem"
        Me.MataPelajaranToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.MataPelajaranToolStripMenuItem.Text = "Mata Pelajaran"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LogOut
        '
        Me.LogOut.AnimationHoverSpeed = 0.07!
        Me.LogOut.AnimationSpeed = 0.03!
        Me.LogOut.BackColor = System.Drawing.Color.Transparent
        Me.LogOut.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOut.BorderColor = System.Drawing.Color.Black
        Me.LogOut.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LogOut.FocusedColor = System.Drawing.Color.Empty
        Me.LogOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.Color.Black
        Me.LogOut.Image = Nothing
        Me.LogOut.ImageSize = New System.Drawing.Size(20, 20)
        Me.LogOut.Location = New System.Drawing.Point(686, 27)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LogOut.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LogOut.OnHoverForeColor = System.Drawing.Color.White
        Me.LogOut.OnHoverImage = Nothing
        Me.LogOut.OnPressedColor = System.Drawing.Color.Black
        Me.LogOut.Radius = 20
        Me.LogOut.Size = New System.Drawing.Size(102, 42)
        Me.LogOut.TabIndex = 3
        Me.LogOut.Text = "Log Out"
        Me.LogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.inputnilai.My.Resources.Resources.nilai
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(33, 44)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(452, 353)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 4
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'FXIIRPL1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FXIIRPL1"
        Me.Text = "FXIIRPL1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataSiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NilaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MataPelajaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOut As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
