Imports System.ComponentModel

Public Class Device
    Dim x, y, z As String
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Device_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DevTextBox1_TextChanged(sender As Object, e As EventArgs) Handles DevTextBox1.TextChanged

    End Sub

    Private Sub Conver_Dev_btn_Click(sender As Object, e As EventArgs) Handles Conver_Dev_btn.Click
        Try
            x = DevTextBox1.Text
        Catch ex As Exception
            MsgBox("Invalid Operation")
        End Try

        If DevComboBox1.Text = "USD" And DevComboBox2.Text = "TND" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 3.21
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "USD" And DevComboBox2.Text = "EUR" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 1
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "USD" And DevComboBox2.Text = "USD" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 1
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "EUR" And DevComboBox2.Text = "TND" Then
            DevTextBox2.Text = Nothing
            y = x * 3.2
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "EUR" And DevComboBox2.Text = "USD" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 1
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "EUR" And DevComboBox2.Text = "EUR" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 1
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "TND" And DevComboBox2.Text = "USD" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 0.31
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "TND" And DevComboBox2.Text = "EUR" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 0.31
            DevTextBox2.Text = y
        ElseIf DevComboBox1.Text = "TND" And DevComboBox2.Text = "TND" Then
            DevTextBox2.Text = Nothing
            x = DevTextBox1.Text
            y = x * 1
            DevTextBox2.Text = y
        End If
    End Sub

    Private Sub Actu_btn_Click(sender As Object, e As EventArgs) Handles Actu_btn.Click
        DevComboBox1.Text = ""
        DevComboBox2.Text = ""
        DevTextBox1.Text = ""
        DevTextBox2.Text = ""

    End Sub

    Private Sub DevTextBox1_Validating(sender As Object, e As CancelEventArgs) Handles DevTextBox1.Validating
        If String.IsNullOrEmpty(DevComboBox1.Text.Trim) Then

            ErrorProvider1.SetError(DevComboBox1, "Choisir Votre Type")

        End If
        If String.IsNullOrEmpty(DevComboBox2.Text.Trim) Then

            ErrorProvider1.SetError(DevComboBox2, "Choisir Votre Type")

        End If
    End Sub

    Private Sub DevTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DevTextBox1.KeyPress
        If (Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57) Or (Asc(e.KeyChar) = 46) Then
            e.Handled = True
            MessageBox.Show("Tu Peut Selement Entrer Un Nombre !")
        End If

    End Sub

    Private Sub DevComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DevComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Conver_Dev_btn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Conver_Dev_btn.KeyPress

    End Sub

    Private Sub DevTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles DevTextBox1.KeyDown

    End Sub
End Class