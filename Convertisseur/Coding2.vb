Imports System.ComponentModel

Public Class Coding2
    Private Sub Guna2Separator1_Click(sender As Object, e As EventArgs) Handles Guna2Separator1.Click

    End Sub

    Private Sub Actu_btn_Click(sender As Object, e As EventArgs) Handles Actu_btn.Click
        BinTextBox.Text = ""
        DecTextBox.Text = ""
        HexTextBox.Text = ""
        OctTextBox.Text = ""
        EnterTextBox.Text = ""

    End Sub

    Private Sub Conver_Dev_btn_Click(sender As Object, e As EventArgs) Handles Conver_Dev_btn.Click
        Dim numConverter As Integer = Integer.Parse(EnterTextBox.Text)
        BinTextBox.Text = Convert.ToString(numConverter, 2)
        DecTextBox.Text = numConverter.ToString()
        HexTextBox.Text = Convert.ToString(numConverter, 16)
        OctTextBox.Text = Convert.ToString(numConverter, 8)
    End Sub

    Private Sub EnterTextBox_TextChanged(sender As Object, e As EventArgs) Handles EnterTextBox.TextChanged

    End Sub

    Private Sub EnterTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EnterTextBox.KeyPress
        If (Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57) Or (Asc(e.KeyChar) = 46) Then
            e.Handled = True
            MessageBox.Show("Tu Peut Selement Entrer Un Nombre !")
        End If
    End Sub

    Private Sub EnterTextBox_Validating(sender As Object, e As CancelEventArgs) Handles EnterTextBox.Validating
        If String.IsNullOrEmpty(EnterTextBox.Text.Trim) Then

            ErrorProvider1.SetError(EnterTextBox, "Choisir Votre Type")

        End If

    End Sub

    Private Sub Conver_Dev_btn_Validated(sender As Object, e As EventArgs) Handles Conver_Dev_btn.Validated

    End Sub
End Class