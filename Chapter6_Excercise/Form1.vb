''Jennifer Pezzulo
''March 14, 2020
''Chapter 6 Excercise

Public Class ProjectileForm

    Const GRAVITY As Integer = 32

    Private Sub QuitProgram()

        Close()

    End Sub

    Private Function CalculateHeightAsFunctionOfTime(height As Double, velocity As Double, time As Double) As Double

        Return height + velocity * time - 16 * (time * time)

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

    Private Function HeightAndVelocityNotEmpty() As Boolean

        If (Not String.IsNullOrEmpty(heightBox.Text) And Not String.IsNullOrEmpty(velocityBox.Text)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        QuitProgram()

    End Sub

    Private Sub MaxHeightButton_Click(sender As Object, e As EventArgs) Handles MaxHeightButton.Click

        If (HeightAndVelocityNotEmpty()) Then
            ClearOutputField()
            TotalOutputBox.AppendText("Max Height:    " + Convert.ToString(CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), (GetVelocity() / GRAVITY))) & Environment.NewLine)
            ClearInputFields()
        End If


    End Sub
End Class
