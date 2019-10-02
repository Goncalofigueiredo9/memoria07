Public Class Form1
    Dim Matriz(12) As Integer
    Dim Quadros() As PictureBox
    Private Sub Inicializa()
        Dim i As Integer
        For i = 0 To 11
            Matriz(i) = 0
            Quadros(i).BackgroundImage = My.Resources.vazio
        Next

        For par = 0 To 5
            For x = 0 To 1
                Do : i = Int(Rnd() * 12)
                Loop While Matriz(i) > 0
                Matriz(i) = par
            Next
        Next


    End Sub
    Private Sub Imagem(quadro)
        Dim fig As New PictureBox
        Select Case Matriz(quadro)
            Case 0 : fig.BackgroundImage = My.Resources.Chelsea
            Case 1 : fig.BackgroundImage = My.Resources.Liverpool
            Case 2 : fig.BackgroundImage = My.Resources.ManCity
            Case 3 : fig.BackgroundImage = My.Resources.ManU
            Case 4 : fig.BackgroundImage = My.Resources.Wolves
            Case 5 : fig.BackgroundImage = My.Resources.Spurs
        End Select

        Quadros(quadro).BackgroundImage = fig.BackgroundImage
    End Sub
    Private Sub Clicar(sender As Object, e As EventArgs) Handles p1.Click, p2.Click, p4.Click, p3.Click, p9.Click, p8.Click, p7.Click, p6.Click, p5.Click, p12.Click, p11.Click, p10.Click
        Select Case sender.name
            Case "P1" : Imagem(0)
            Case "P2" : Imagem(1)
            Case "P3" : Imagem(2)
            Case "P4" : Imagem(3)
            Case "P5" : Imagem(4)
            Case "P6" : Imagem(5)
            Case "P7" : Imagem(6)
            Case "P8" : Imagem(7)
            Case "P9" : Imagem(8)
            Case "P10" : Imagem(9)
            Case "P11" : Imagem(10)
            Case "P12" : Imagem(11)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fig As New PictureBox
        Dim resposta = MsgBox("Tem a Certeza", vbYesNo, "Novo Jogo")
        If resposta = vbNo Then Return
        p1.BackgroundImage = My.Resources.vazio
        p2.BackgroundImage = My.Resources.vazio
        p3.BackgroundImage = My.Resources.vazio
        p4.BackgroundImage = My.Resources.vazio
        p5.BackgroundImage = My.Resources.vazio
        p6.BackgroundImage = My.Resources.vazio
        p7.BackgroundImage = My.Resources.vazio
        p8.BackgroundImage = My.Resources.vazio
        p9.BackgroundImage = My.Resources.vazio
        p10.BackgroundImage = My.Resources.vazio
        p11.BackgroundImage = My.Resources.vazio
        p12.BackgroundImage = My.Resources.vazio
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quadros = {p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12}
        Call Inicializa()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub
End Class