﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenuAdmin
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaliKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOut = New Guna.UI.WinForms.GunaButton()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.StatusToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuruToolStripMenuItem, Me.WaliKelasToolStripMenuItem, Me.KelasToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'GuruToolStripMenuItem
        '
        Me.GuruToolStripMenuItem.Name = "GuruToolStripMenuItem"
        Me.GuruToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.GuruToolStripMenuItem.Text = "Guru"
        '
        'WaliKelasToolStripMenuItem
        '
        Me.WaliKelasToolStripMenuItem.Name = "WaliKelasToolStripMenuItem"
        Me.WaliKelasToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.WaliKelasToolStripMenuItem.Text = "Wali Kelas"
        '
        'KelasToolStripMenuItem
        '
        Me.KelasToolStripMenuItem.Name = "KelasToolStripMenuItem"
        Me.KelasToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.KelasToolStripMenuItem.Text = "Kelas"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LevelToolStripMenuItem})
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'LevelToolStripMenuItem
        '
        Me.LevelToolStripMenuItem.Name = "LevelToolStripMenuItem"
        Me.LevelToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.LevelToolStripMenuItem.Text = "Level"
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
        Me.LogOut.Location = New System.Drawing.Point(698, 52)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LogOut.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LogOut.OnHoverForeColor = System.Drawing.Color.White
        Me.LogOut.OnHoverImage = Nothing
        Me.LogOut.OnPressedColor = System.Drawing.Color.Black
        Me.LogOut.Radius = 20
        Me.LogOut.Size = New System.Drawing.Size(102, 42)
        Me.LogOut.TabIndex = 2
        Me.LogOut.Text = "Log Out"
        Me.LogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FMenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FMenuAdmin"
        Me.Text = "FMenuAdmin"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaliKelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOut As Guna.UI.WinForms.GunaButton
End Class
