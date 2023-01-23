<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Coding2
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.EnterTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelBin = New System.Windows.Forms.Label()
        Me.LabelOct = New System.Windows.Forms.Label()
        Me.LabelHex = New System.Windows.Forms.Label()
        Me.LabelDec = New System.Windows.Forms.Label()
        Me.BinTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OctTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.HexTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DecTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Actu_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Conver_Dev_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrer Un Nombre"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(16, 29)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'EnterTextBox
        '
        Me.EnterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EnterTextBox.DefaultText = ""
        Me.EnterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EnterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EnterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EnterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EnterTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EnterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EnterTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EnterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EnterTextBox.Location = New System.Drawing.Point(50, 71)
        Me.EnterTextBox.Name = "EnterTextBox"
        Me.EnterTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EnterTextBox.PlaceholderForeColor = System.Drawing.Color.White
        Me.EnterTextBox.PlaceholderText = ""
        Me.EnterTextBox.SelectedText = ""
        Me.EnterTextBox.Size = New System.Drawing.Size(216, 29)
        Me.EnterTextBox.TabIndex = 2
        '
        'LabelBin
        '
        Me.LabelBin.AutoSize = True
        Me.LabelBin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBin.ForeColor = System.Drawing.Color.White
        Me.LabelBin.Location = New System.Drawing.Point(68, 135)
        Me.LabelBin.Name = "LabelBin"
        Me.LabelBin.Size = New System.Drawing.Size(56, 16)
        Me.LabelBin.TabIndex = 3
        Me.LabelBin.Text = "Binaire"
        '
        'LabelOct
        '
        Me.LabelOct.AutoSize = True
        Me.LabelOct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOct.ForeColor = System.Drawing.Color.White
        Me.LabelOct.Location = New System.Drawing.Point(456, 135)
        Me.LabelOct.Name = "LabelOct"
        Me.LabelOct.Size = New System.Drawing.Size(43, 16)
        Me.LabelOct.TabIndex = 4
        Me.LabelOct.Text = "Octal"
        '
        'LabelHex
        '
        Me.LabelHex.AutoSize = True
        Me.LabelHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHex.ForeColor = System.Drawing.Color.White
        Me.LabelHex.Location = New System.Drawing.Point(304, 135)
        Me.LabelHex.Name = "LabelHex"
        Me.LabelHex.Size = New System.Drawing.Size(100, 16)
        Me.LabelHex.TabIndex = 5
        Me.LabelHex.Text = "HexaDecimal"
        '
        'LabelDec
        '
        Me.LabelDec.AutoSize = True
        Me.LabelDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDec.ForeColor = System.Drawing.Color.White
        Me.LabelDec.Location = New System.Drawing.Point(193, 135)
        Me.LabelDec.Name = "LabelDec"
        Me.LabelDec.Size = New System.Drawing.Size(64, 16)
        Me.LabelDec.TabIndex = 6
        Me.LabelDec.Text = "Decimal"
        '
        'BinTextBox
        '
        Me.BinTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BinTextBox.DefaultText = ""
        Me.BinTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BinTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BinTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BinTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BinTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BinTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BinTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BinTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BinTextBox.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.BinTextBox.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BinTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.BinTextBox.Location = New System.Drawing.Point(50, 170)
        Me.BinTextBox.Name = "BinTextBox"
        Me.BinTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BinTextBox.PlaceholderForeColor = System.Drawing.Color.White
        Me.BinTextBox.PlaceholderText = ""
        Me.BinTextBox.ReadOnly = True
        Me.BinTextBox.SelectedText = ""
        Me.BinTextBox.Size = New System.Drawing.Size(103, 29)
        Me.BinTextBox.TabIndex = 7
        '
        'OctTextBox
        '
        Me.OctTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OctTextBox.DefaultText = ""
        Me.OctTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.OctTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.OctTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OctTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OctTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.OctTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OctTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.OctTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.OctTextBox.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.OctTextBox.Location = New System.Drawing.Point(427, 170)
        Me.OctTextBox.Name = "OctTextBox"
        Me.OctTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OctTextBox.PlaceholderText = ""
        Me.OctTextBox.ReadOnly = True
        Me.OctTextBox.SelectedText = ""
        Me.OctTextBox.Size = New System.Drawing.Size(103, 29)
        Me.OctTextBox.TabIndex = 8
        '
        'HexTextBox
        '
        Me.HexTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HexTextBox.DefaultText = ""
        Me.HexTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.HexTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.HexTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.HexTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.HexTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.HexTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HexTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.HexTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.HexTextBox.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.HexTextBox.Location = New System.Drawing.Point(300, 170)
        Me.HexTextBox.Name = "HexTextBox"
        Me.HexTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HexTextBox.PlaceholderText = ""
        Me.HexTextBox.ReadOnly = True
        Me.HexTextBox.SelectedText = ""
        Me.HexTextBox.Size = New System.Drawing.Size(103, 29)
        Me.HexTextBox.TabIndex = 9
        '
        'DecTextBox
        '
        Me.DecTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DecTextBox.DefaultText = ""
        Me.DecTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DecTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DecTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DecTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DecTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DecTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DecTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DecTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.DecTextBox.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.DecTextBox.Location = New System.Drawing.Point(175, 170)
        Me.DecTextBox.Name = "DecTextBox"
        Me.DecTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DecTextBox.PlaceholderText = ""
        Me.DecTextBox.ReadOnly = True
        Me.DecTextBox.SelectedText = ""
        Me.DecTextBox.Size = New System.Drawing.Size(103, 29)
        Me.DecTextBox.TabIndex = 10
        '
        'Actu_btn
        '
        Me.Actu_btn.Animated = True
        Me.Actu_btn.AutoRoundedCorners = True
        Me.Actu_btn.BorderColor = System.Drawing.Color.White
        Me.Actu_btn.BorderRadius = 20
        Me.Actu_btn.BorderThickness = 1
        Me.Actu_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actu_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Actu_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Actu_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Actu_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Actu_btn.FillColor = System.Drawing.Color.Transparent
        Me.Actu_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Actu_btn.ForeColor = System.Drawing.Color.White
        Me.Actu_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Actu_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Actu_btn.HoverState.Image = Global.Convertisseur.My.Resources.Resources.clear_oran
        Me.Actu_btn.Image = Global.Convertisseur.My.Resources.Resources.clear
        Me.Actu_btn.ImageSize = New System.Drawing.Size(18, 18)
        Me.Actu_btn.Location = New System.Drawing.Point(459, 64)
        Me.Actu_btn.Name = "Actu_btn"
        Me.Actu_btn.Size = New System.Drawing.Size(112, 42)
        Me.Actu_btn.TabIndex = 12
        Me.Actu_btn.Text = "Actualiser"
        '
        'Conver_Dev_btn
        '
        Me.Conver_Dev_btn.Animated = True
        Me.Conver_Dev_btn.AutoRoundedCorners = True
        Me.Conver_Dev_btn.BackColor = System.Drawing.Color.Transparent
        Me.Conver_Dev_btn.BorderColor = System.Drawing.Color.White
        Me.Conver_Dev_btn.BorderRadius = 20
        Me.Conver_Dev_btn.BorderThickness = 1
        Me.Conver_Dev_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Conver_Dev_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Conver_Dev_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Conver_Dev_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Conver_Dev_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Conver_Dev_btn.FillColor = System.Drawing.Color.Transparent
        Me.Conver_Dev_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Conver_Dev_btn.ForeColor = System.Drawing.Color.White
        Me.Conver_Dev_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Conver_Dev_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Conver_Dev_btn.HoverState.Image = Global.Convertisseur.My.Resources.Resources.convert_oran
        Me.Conver_Dev_btn.Image = Global.Convertisseur.My.Resources.Resources.convert_wh
        Me.Conver_Dev_btn.ImageSize = New System.Drawing.Size(15, 15)
        Me.Conver_Dev_btn.Location = New System.Drawing.Point(322, 64)
        Me.Conver_Dev_btn.Name = "Conver_Dev_btn"
        Me.Conver_Dev_btn.Size = New System.Drawing.Size(112, 42)
        Me.Conver_Dev_btn.TabIndex = 11
        Me.Conver_Dev_btn.Text = "Convertir"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Coding2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 254)
        Me.Controls.Add(Me.Actu_btn)
        Me.Controls.Add(Me.Conver_Dev_btn)
        Me.Controls.Add(Me.DecTextBox)
        Me.Controls.Add(Me.HexTextBox)
        Me.Controls.Add(Me.OctTextBox)
        Me.Controls.Add(Me.BinTextBox)
        Me.Controls.Add(Me.LabelDec)
        Me.Controls.Add(Me.LabelHex)
        Me.Controls.Add(Me.LabelOct)
        Me.Controls.Add(Me.LabelBin)
        Me.Controls.Add(Me.EnterTextBox)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Coding2"
        Me.Text = "Coding2"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents EnterTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DecTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents HexTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OctTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BinTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelDec As Label
    Friend WithEvents LabelHex As Label
    Friend WithEvents LabelOct As Label
    Friend WithEvents LabelBin As Label
    Friend WithEvents Actu_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Conver_Dev_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
