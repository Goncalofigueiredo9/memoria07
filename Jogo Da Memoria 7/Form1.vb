Public Class Form1
    Private Sub Clicar(sender As Object, e As EventArgs) Handles p1.Click, p2.Click, p3.Click, p4.Click, p5.Click, p6.Click, p7.Click, p8.Click, p9.Click, p10.Click, p11.Click, p12.Click
        Dim fig As New PictureBox
        Dim i = Int(Rnd() * 6)
        fig.Image = My.Resources.Chelsea

        Select Case i
            Case 0 : fig.Image = My.Resources.Chelsea
            Case 1 : fig.Image = My.Resources.ManU
            Case 2 : fig.Image = My.Resources.Liverpool
            Case 3 : fig.Image = My.Resources.ManCity
            Case 4 : fig.Image = My.Resources.Wolves
            Case 5 : fig.Image = My.Resources.Spurs
        End Select

        Select Case sender.name
            Case "p1" : p1.BackgroundImage = fig.Image
            Case "p2" : p2.BackgroundImage = fig.Image
            Case "p3" : p3.BackgroundImage = fig.Image
            Case "p4" : p4.BackgroundImage = fig.Image
            Case "p5" : p5.BackgroundImage = fig.Image
            Case "p6" : p6.BackgroundImage = fig.Image
            Case "p7" : p7.BackgroundImage = fig.Image
            Case "p8" : p8.BackgroundImage = fig.Image
            Case "p9" : p9.BackgroundImage = fig.Image
            Case "p10" : p10.BackgroundImage = fig.Image
            Case "p11" : p11.BackgroundImage = fig.Image
            Case "p12" : p12.BackgroundImage = fig.Image
        End Select

    End Sub
End Class