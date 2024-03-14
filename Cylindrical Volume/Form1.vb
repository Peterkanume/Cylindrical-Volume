Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VolumeButton.Click
        Const pi As Double = 3.142
        Dim Radius As Double
        Dim Height As Double
        Dim Volume As Double

        If Double.TryParse(RadiusTextBox.Text, Radius) Then
            If Double.TryParse(HeightTextBox.Text, Height) Then
                Volume = (pi * Radius * Radius) * Height

                AnswerTextBox.Text = $"{Volume}cm³"
            Else

                MessageBox.Show("Please enter a valid numeric value for Height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else

            MessageBox.Show("Please enter a valid numeric value for Radius.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub AnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles AnswerTextBox.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ResetButton.Click
        RadiusTextBox.Clear()
        HeightTextBox.Clear()
        AnswerTextBox.Clear()
    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RadiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles RadiusTextBox.TextChanged

    End Sub


End Class
