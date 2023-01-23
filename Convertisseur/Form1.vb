Public Class Form1
    Dim x, y, z As Double
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Device_Click(sender As Object, e As EventArgs) Handles devicebtn.Click

        devicebtn.Image = My.Resources.PngItem_1111058_orang
        dev_spec.FillColor = Color.FromArgb(255, 61, 67)
        mesurebtn.Image = My.Resources.ruler24
        mes_spec.FillColor = Color.Transparent
        codagebtn.Image = My.Resources.binima
        cod_spec.FillColor = Color.Transparent
        switchFrom(Device)
    End Sub

    Private Sub mesurebtn_Click_1(sender As Object, e As EventArgs) Handles mesurebtn.Click
        devicebtn.Image = My.Resources.PngItem_1111058
        dev_spec.FillColor = Color.Transparent
        mesurebtn.Image = My.Resources.ruler24_oran
        mes_spec.FillColor = Color.FromArgb(255, 61, 67)
        codagebtn.Image = My.Resources.binima
        cod_spec.FillColor = Color.Transparent
        switchFrom(Form2)

    End Sub

    Private Sub codagebtn_Click_1(sender As Object, e As EventArgs) Handles codagebtn.Click
        devicebtn.Image = My.Resources.PngItem_1111058
        dev_spec.FillColor = Color.Transparent
        mesurebtn.Image = My.Resources.ruler24
        mes_spec.FillColor = Color.Transparent
        codagebtn.Image = My.Resources.bin_oran
        cod_spec.FillColor = Color.FromArgb(255, 61, 67)
        switchFrom(Coding2)
    End Sub

    Private Sub switchFrom(from As Form)
        Guna2Panel2.Controls.Clear()
        from.TopLevel = False
        Guna2Panel2.Controls.Add(from)
        from.Show()
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cod_spec_Click(sender As Object, e As EventArgs) Handles cod_spec.Click

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        switchFrom(AboutMe)

    End Sub
End Class
