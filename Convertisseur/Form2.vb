Imports System.ComponentModel

Public Class Form2
    Dim x, y, z As String

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MesComboBox1.Text = ""
        MesComboBox2.Text = ""
        MesTextBox1.Text = ""
        MesTextBox2.Text = ""
    End Sub

    Private Sub MesTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MesTextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MesComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MesComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Conver_Dev_btn_Click(sender As Object, e As EventArgs) Handles Conver_Dev_btn.Click
        Try
            x = MesTextBox1.Text
        Catch ex As Exception
            MsgBox("Invalid Operation")
        End Try
        Convert.ToString(x)
        Convert.ToString(y)
        If MesComboBox1.Text = "M" And MesComboBox2.Text = "DM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 10
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "M" And MesComboBox2.Text = "CM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 100
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "M" And MesComboBox2.Text = "MM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 1000
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "M" And MesComboBox2.Text = "M" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 1
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "DM" And MesComboBox2.Text = "M" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x / 10
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "DM" And MesComboBox2.Text = "CM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 10
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "DM" And MesComboBox2.Text = "MM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 100
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "DM" And MesComboBox2.Text = "DM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 1
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "CM" And MesComboBox2.Text = "M" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x / 100
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "CM" And MesComboBox2.Text = "DM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x / 10
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "CM" And MesComboBox2.Text = "MM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 10
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "CM" And MesComboBox2.Text = "CM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 1
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "MM" And MesComboBox2.Text = "M" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x / 1000
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "MM" And MesComboBox2.Text = "DM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x / 100
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "MM" And MesComboBox2.Text = "CM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x / 10
            MesTextBox2.Text = y
        ElseIf MesComboBox1.Text = "MM" And MesComboBox2.Text = "MM" Then
            MesTextBox2.Text = Nothing
            x = MesTextBox1.Text
            y = x * 1
            MesTextBox2.Text = y
        End If
    End Sub

    Private Sub MesTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MesTextBox1.KeyPress
        If (Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57) Or (Asc(e.KeyChar) = 46) Then
            e.Handled = True
            MessageBox.Show("Tu Peut Selement Entrer Un Nombre !")
        End If

    End Sub

    Private Sub MesComboBox1_Validating(sender As Object, e As CancelEventArgs) Handles MesComboBox1.Validating

        If String.IsNullOrEmpty(MesComboBox1.Text.Trim) Then

            ErrorProvider1.SetError(MesComboBox1, "Choisir Votre Type")

        End If
        If String.IsNullOrEmpty(MesComboBox2.Text.Trim) Then

            ErrorProvider1.SetError(MesComboBox2, "Choisir Votre Type")

        End If
    End Sub
End Class