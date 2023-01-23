<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Device
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.DevTextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DevComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DevComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DevTextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Actu_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Conver_Dev_btn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.HasFormShadow = False
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'DevTextBox1
        '
        Me.DevTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DevTextBox1.DefaultText = ""
        Me.DevTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DevTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DevTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DevTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DevTextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DevTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DevTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DevTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DevTextBox1.Location = New System.Drawing.Point(226, 63)
        Me.DevTextBox1.Name = "DevTextBox1"
        Me.DevTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DevTextBox1.PlaceholderForeColor = System.Drawing.Color.White
        Me.DevTextBox1.PlaceholderText = ""
        Me.DevTextBox1.SelectedText = ""
        Me.DevTextBox1.Size = New System.Drawing.Size(136, 29)
        Me.DevTextBox1.TabIndex = 2
        '
        'DevComboBox1
        '
        Me.DevComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.DevComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DevComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DevComboBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DevComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DevComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DevComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DevComboBox1.ForeColor = System.Drawing.Color.White
        Me.DevComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox1.ItemHeight = 30
        Me.DevComboBox1.Items.AddRange(New Object() {"USD", "EUR", "TND"})
        Me.DevComboBox1.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox1.ItemsAppearance.ForeColor = System.Drawing.Color.White
        Me.DevComboBox1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox1.Location = New System.Drawing.Point(34, 37)
        Me.DevComboBox1.Name = "DevComboBox1"
        Me.DevComboBox1.Size = New System.Drawing.Size(149, 36)
        Me.DevComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "De"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(405, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "A"
        '
        'DevComboBox2
        '
        Me.DevComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.DevComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DevComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DevComboBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DevComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DevComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DevComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DevComboBox2.ForeColor = System.Drawing.Color.White
        Me.DevComboBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox2.ItemHeight = 30
        Me.DevComboBox2.Items.AddRange(New Object() {"TND", "EUR", "USD"})
        Me.DevComboBox2.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox2.ItemsAppearance.ForeColor = System.Drawing.Color.White
        Me.DevComboBox2.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DevComboBox2.Location = New System.Drawing.Point(410, 37)
        Me.DevComboBox2.Name = "DevComboBox2"
        Me.DevComboBox2.Size = New System.Drawing.Size(149, 36)
        Me.DevComboBox2.TabIndex = 7
        '
        'DevTextBox2
        '
        Me.DevTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DevTextBox2.DefaultText = ""
        Me.DevTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DevTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DevTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DevTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DevTextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DevTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DevTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.DevTextBox2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.DevTextBox2.Location = New System.Drawing.Point(226, 110)
        Me.DevTextBox2.Name = "DevTextBox2"
        Me.DevTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DevTextBox2.PlaceholderText = ""
        Me.DevTextBox2.ReadOnly = True
        Me.DevTextBox2.SelectedText = ""
        Me.DevTextBox2.Size = New System.Drawing.Size(136, 29)
        Me.DevTextBox2.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.Actu_btn.Location = New System.Drawing.Point(375, 177)
        Me.Actu_btn.Name = "Actu_btn"
        Me.Actu_btn.Size = New System.Drawing.Size(132, 43)
        Me.Actu_btn.TabIndex = 1
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
        Me.Conver_Dev_btn.Location = New System.Drawing.Point(88, 177)
        Me.Conver_Dev_btn.Name = "Conver_Dev_btn"
        Me.Conver_Dev_btn.Size = New System.Drawing.Size(132, 43)
        Me.Conver_Dev_btn.TabIndex = 0
        Me.Conver_Dev_btn.Text = "Convertir"
        '
        'Device
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 254)
        Me.Controls.Add(Me.DevTextBox2)
        Me.Controls.Add(Me.DevComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DevComboBox1)
        Me.Controls.Add(Me.DevTextBox1)
        Me.Controls.Add(Me.Actu_btn)
        Me.Controls.Add(Me.Conver_Dev_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Device"
        Me.Text = "Device"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents DevTextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Actu_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DevComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DevComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Conver_Dev_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DevTextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
