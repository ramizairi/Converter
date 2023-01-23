<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.codagebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.mesurebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.cod_spec = New Guna.UI2.WinForms.Guna2Separator()
        Me.mes_spec = New Guna.UI2.WinForms.Guna2Separator()
        Me.dev_spec = New Guna.UI2.WinForms.Guna2Separator()
        Me.devicebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.codagebtn)
        Me.Guna2Panel1.Controls.Add(Me.mesurebtn)
        Me.Guna2Panel1.Controls.Add(Me.cod_spec)
        Me.Guna2Panel1.Controls.Add(Me.mes_spec)
        Me.Guna2Panel1.Controls.Add(Me.dev_spec)
        Me.Guna2Panel1.Controls.Add(Me.devicebtn)
        Me.Guna2Panel1.Location = New System.Drawing.Point(9, 44)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(783, 68)
        Me.Guna2Panel1.TabIndex = 0
        '
        'codagebtn
        '
        Me.codagebtn.Animated = True
        Me.codagebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.codagebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.codagebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.codagebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.codagebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.codagebtn.FillColor = System.Drawing.Color.Transparent
        Me.codagebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.codagebtn.ForeColor = System.Drawing.Color.White
        Me.codagebtn.Image = Global.Convertisseur.My.Resources.Resources.binima
        Me.codagebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.codagebtn.Location = New System.Drawing.Point(555, 15)
        Me.codagebtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.codagebtn.Name = "codagebtn"
        Me.codagebtn.Size = New System.Drawing.Size(171, 38)
        Me.codagebtn.TabIndex = 6
        Me.codagebtn.Text = "Codage"
        '
        'mesurebtn
        '
        Me.mesurebtn.Animated = True
        Me.mesurebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesurebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.mesurebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.mesurebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.mesurebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.mesurebtn.FillColor = System.Drawing.Color.Transparent
        Me.mesurebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mesurebtn.ForeColor = System.Drawing.Color.White
        Me.mesurebtn.Image = Global.Convertisseur.My.Resources.Resources.ruler24
        Me.mesurebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.mesurebtn.Location = New System.Drawing.Point(276, 15)
        Me.mesurebtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mesurebtn.Name = "mesurebtn"
        Me.mesurebtn.Size = New System.Drawing.Size(171, 38)
        Me.mesurebtn.TabIndex = 5
        Me.mesurebtn.Text = "Mesure"
        '
        'cod_spec
        '
        Me.cod_spec.FillColor = System.Drawing.Color.Transparent
        Me.cod_spec.Location = New System.Drawing.Point(497, 52)
        Me.cod_spec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cod_spec.Name = "cod_spec"
        Me.cod_spec.Size = New System.Drawing.Size(251, 12)
        Me.cod_spec.TabIndex = 4
        '
        'mes_spec
        '
        Me.mes_spec.FillColor = System.Drawing.Color.Transparent
        Me.mes_spec.Location = New System.Drawing.Point(255, 52)
        Me.mes_spec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mes_spec.Name = "mes_spec"
        Me.mes_spec.Size = New System.Drawing.Size(235, 12)
        Me.mes_spec.TabIndex = 3
        '
        'dev_spec
        '
        Me.dev_spec.FillColor = System.Drawing.Color.Transparent
        Me.dev_spec.Location = New System.Drawing.Point(37, 52)
        Me.dev_spec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dev_spec.Name = "dev_spec"
        Me.dev_spec.Size = New System.Drawing.Size(209, 12)
        Me.dev_spec.TabIndex = 0
        '
        'devicebtn
        '
        Me.devicebtn.Animated = True
        Me.devicebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.devicebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.devicebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.devicebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.devicebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.devicebtn.FillColor = System.Drawing.Color.Transparent
        Me.devicebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.devicebtn.ForeColor = System.Drawing.Color.White
        Me.devicebtn.Image = CType(resources.GetObject("devicebtn.Image"), System.Drawing.Image)
        Me.devicebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.devicebtn.Location = New System.Drawing.Point(37, 15)
        Me.devicebtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.devicebtn.Name = "devicebtn"
        Me.devicebtn.Size = New System.Drawing.Size(171, 38)
        Me.devicebtn.TabIndex = 0
        Me.devicebtn.Text = "Device"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(727, 6)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(61, 30)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(657, 6)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(61, 30)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(9, 126)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(783, 313)
        Me.Guna2Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Multi Convertisseur"
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.AnimatedGIF = True
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ImageButton1.HoverState.Image = Global.Convertisseur.My.Resources.Resources.about_oran
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2ImageButton1.IndicateFocus = True
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(613, 2)
        Me.Guna2ImageButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(33, 31)
        Me.Guna2ImageButton1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Convertisseur.My.Resources.Resources.olla1
        Me.PictureBox1.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 455)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents devicebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cod_spec As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents mes_spec As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents dev_spec As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents codagebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mesurebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
