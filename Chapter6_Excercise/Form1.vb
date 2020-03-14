''Jennifer Pezzulo
''Chapter 6 Excercise

Public Class ProjectileForm

    Const GRAVITY As Integer = 32

    Private Sub QuitProgram()

        Me.Close()

    End Sub

    Private Function MaxHeight(height As Double, velocity As Double) As Double

        Return height + velocity * (velocity / GRAVITY) - 16 * ((velocity / GRAVITY) * (velocity / GRAVITY))

    End Function

    Private Function GetHeight() As Double

        Return Convert.ToDouble(heightBox.Text)

    End Function

    Private Function GetVelocity() As Double

        Return Convert.ToDouble(velocityBox.Text)

    End Function

    Private Sub ClearInputFields()

        heightBox.Clear()
        velocityBox.Clear()

    End Sub

    Private Sub ClearOutputField()

        TotalOutputBox.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        QuitProgram()

    End Sub

    Private Sub MaxHeightButton_Click(sender As Object, e As EventArgs) Handles MaxHeightButton.Click

        ClearOutputField()
        TotalOutputBox.AppendText("Max Height:    " + Convert.ToString(MaxHeight(GetHeight(), GetVelocity())) & Environment.NewLine)


    End Sub
End Class
