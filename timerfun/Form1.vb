Public Class Form1
    Public counter As Integer = 0
    Public millis As Double = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'counter = counter + 1
        count.Text = CStr(CDec(millis / 100))
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Timer2.Start()
        Timer1.Start()
    End Sub

    Private Sub stoptimer_Click(sender As Object, e As EventArgs) Handles stoptimer.Click
        Timer1.Stop()
        Timer2.Stop()
        count.Text = CStr(CDec(millis / 100))
        millis = 0
        counter = 0
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        Timer1.Stop()
        counter = 0
        count.Text = "0"
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        millis = millis + 1
    End Sub
End Class
