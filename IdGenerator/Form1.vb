Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gen(0)
    End Sub
    Private Sub gen(g As Integer)

        '---------- yıl - ters
        Dim a1 As String = DateAndTime.Year(Now)
        Dim aa1 As String = a1.Remove(0, 2)
        Dim aa2 As String = a1.Remove(2, 2)
        Dim a As String = aa1 + "-" + aa2


        '---------- ay, gün - düz
        Dim b1 As String = DateAndTime.Month(Now)
        Dim b2 As String = DateAndTime.Day(Now)
        If b1.Length = 1 Then b1 = "0" + b1
        If b2.Length = 1 Then b2 = "0" + b2
        Dim b As String = b1 + "-" + b2


        '---------- saat, dakika - ters
        Dim c1 As String = DateAndTime.Hour(Now)
        Dim c2 As String = DateAndTime.Minute(Now)
        Dim c As String = c1 + "-" + c2


        '---------- saniye, rastgele(10, 100) - düz
        Dim d1 As String = DateAndTime.Second(Now)
        Dim d2 As Random = New Random
        Dim d3 As Integer = d2.Next(10, 100)
        Dim d As String = d1 + "-" + d3.ToString


        Dim s As String = a + "|" + b + "|" + c + "|" + d
        Label1.Text = s

        If g = 1 Then
            Clipboard.SetText(s)
            Button2.ForeColor = Color.LightSeaGreen
            Button2.Text = "Copied.."
            Timer1.Start()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gen(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button2.ForeColor = Color.White
        Button2.Text = "Generate && Copy"
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("● Year(yy,xx)" + vbNewLine + "● Month + Day(xx,yy)" + vbNewLine + "● Hour + Min(yy,xx)" + vbNewLine + "● Second + Random(xx,(10,100))" + vbNewLine + vbNewLine + "Creator: NoPlayer.D")
    End Sub
End Class
