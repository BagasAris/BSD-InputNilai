<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.login1Btn = New Guna.UI.WinForms.GunaButton()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.usernameTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.login1Btn)
        Me.Panel1.Controls.Add(Me.ShowBtn)
        Me.Panel1.Controls.Add(Me.passwordTxt)
        Me.Panel1.Controls.Add(Me.usernameTxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(152, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 335)
        Me.Panel1.TabIndex = 2
        '
        'login1Btn
        '
        Me.login1Btn.AnimationHoverSpeed = 0.07!
        Me.login1Btn.AnimationSpeed = 0.03!
        Me.login1Btn.BackColor = System.Drawing.Color.Transparent
        Me.login1Btn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login1Btn.BorderColor = System.Drawing.Color.Black
        Me.login1Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.login1Btn.FocusedColor = System.Drawing.Color.Empty
        Me.login1Btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.login1Btn.ForeColor = System.Drawing.Color.White
        Me.login1Btn.Image = Nothing
        Me.login1Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.login1Btn.Location = New System.Drawing.Point(239, 245)
        Me.login1Btn.Name = "login1Btn"
        Me.login1Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.login1Btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.login1Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.login1Btn.OnHoverImage = Nothing
        Me.login1Btn.OnPressedColor = System.Drawing.Color.Black
        Me.login1Btn.Radius = 10
        Me.login1Btn.Size = New System.Drawing.Size(113, 32)
        Me.login1Btn.TabIndex = 8
        Me.login1Btn.Text = "Login"
        Me.login1Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordTxt
        '
        Me.passwordTxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.passwordTxt.BackColor = System.Drawing.Color.White
        Me.passwordTxt.Location = New System.Drawing.Point(179, 191)
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.Size = New System.Drawing.Size(242, 20)
        Me.passwordTxt.TabIndex = 4
        '
        'usernameTxt
        '
        Me.usernameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.usernameTxt.BackColor = System.Drawing.Color.White
        Me.usernameTxt.Location = New System.Drawing.Point(179, 129)
        Me.usernameTxt.Name = "usernameTxt"
        Me.usernameTxt.Size = New System.Drawing.Size(242, 20)
        Me.usernameTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(123, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'ShowBtn
        '
        Me.ShowBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowBtn.BackColor = System.Drawing.Color.Transparent
        Me.ShowBtn.BackgroundImage = Global.inputnilai.My.Resources.Resources.show
        Me.ShowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShowBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowBtn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ShowBtn.ImageKey = "(none)"
        Me.ShowBtn.Location = New System.Drawing.Point(436, 182)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(38, 36)
        Me.ShowBtn.TabIndex = 7
        Me.ShowBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ShowBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.inputnilai.My.Resources.Resources.smkn1karawang
        Me.PictureBox1.Location = New System.Drawing.Point(-251, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 720)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowBtn As Button
    Friend WithEvents login1Btn As Guna.UI.WinForms.GunaButton
End Class
