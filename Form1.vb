Public Class Form1
    Private Sub Textbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Texto1.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, res As Double

        num1 = Texto1.Text
        num2 = Texto2.Text

        res = num1 + num2

        Label1.Text = res
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, res As Double

        num1 = Texto1.Text
        num2 = Texto2.Text

        res = num1 - num2

        Label1.Text = res
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2, res As Double

        num1 = Texto1.Text
        num2 = Texto2.Text

        res = num1 * num2

        Label1.Text = res
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2, res As Double

        num1 = Texto1.Text
        num2 = Texto2.Text

        res = num1 / num2

        Label1.Text = res
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub textbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Texto2.KeyPress
        If Not IsNumeric(e.KeyChar) Then

            e.Handled = True

                    (Object sender.KeyPressEventArgs) {
    DirectCast(sender, TextBox).Clear()

        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Texto1_TextChanged(sender As Object, e As EventArgs) Handles Texto1.TextChanged

    End Sub
End Class
