Public Class Form1
    Public inputstate As Boolean
    Private Sub BtnClick(s As String)
        If inputstate Then
            ExprLabel.Text = ExprLabel.Text + s
        Else
            ExprLabel.Text = s
            inputstate = True
        End If
    End Sub
    Private Sub NumBtn7_Click(sender As Object, e As EventArgs) Handles NumBtn7.Click
        BtnClick("7")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputstate = True
    End Sub

    Private Sub NumBtn1_Click(sender As Object, e As EventArgs) Handles NumBtn1.Click
        BtnClick("1")
    End Sub

    Private Sub NumBtn0_Click(sender As Object, e As EventArgs) Handles NumBtn0.Click
        BtnClick("0")
    End Sub

    Private Sub NumBtn2_Click(sender As Object, e As EventArgs) Handles NumBtn2.Click
        BtnClick("2")
    End Sub

    Private Sub NumBtn3_Click(sender As Object, e As EventArgs) Handles NumBtn3.Click
        BtnClick("3")
    End Sub

    Private Sub NumBtn4_Click(sender As Object, e As EventArgs) Handles NumBtn4.Click
        BtnClick("4")
    End Sub

    Private Sub NumBtn5_Click(sender As Object, e As EventArgs) Handles NumBtn5.Click
        BtnClick("5")
    End Sub

    Private Sub NumBtn6_Click(sender As Object, e As EventArgs) Handles NumBtn6.Click
        BtnClick("6")
    End Sub

    Private Sub NumBtn8_Click(sender As Object, e As EventArgs) Handles NumBtn8.Click
        BtnClick("8")
    End Sub

    Private Sub NumBtn9_Click(sender As Object, e As EventArgs) Handles NumBtn9.Click
        BtnClick("9")
    End Sub

    Private Sub DotBtn_Click(sender As Object, e As EventArgs) Handles DotBtn.Click
        BtnClick(".")
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        BtnClick("+")
    End Sub

    Private Sub SubBtn_Click(sender As Object, e As EventArgs) Handles SubBtn.Click
        BtnClick("-")
    End Sub

    Private Sub MulBtn_Click(sender As Object, e As EventArgs) Handles MulBtn.Click
        BtnClick("*")
    End Sub

    Private Sub DivBtn_Click(sender As Object, e As EventArgs) Handles DivBtn.Click
        BtnClick("/")
    End Sub

    Private Sub ACBtn_Click(sender As Object, e As EventArgs) Handles ACBtn.Click
        ExprLabel.Text = ""
        inputstate = True
    End Sub

    Private Sub LeftParenBtn_Click(sender As Object, e As EventArgs) Handles LeftParenBtn.Click
        BtnClick("(")
    End Sub

    Private Sub RightParenBtn_Click(sender As Object, e As EventArgs) Handles RightParenBtn.Click
        BtnClick(")")
    End Sub

    Private Sub PowerBtn_Click(sender As Object, e As EventArgs) Handles PowerBtn.Click
        BtnClick("^")
    End Sub

    Private Sub ModBtn_Click(sender As Object, e As EventArgs) Handles ModBtn.Click
        BtnClick("%")
    End Sub

    Private Sub ExpBtn_Click(sender As Object, e As EventArgs) Handles ExpBtn.Click
        BtnClick("exp(")
    End Sub

    Private Sub AnsBtn_Click(sender As Object, e As EventArgs)
        BtnClick("ANS")
    End Sub

    Private Sub SinBtn_Click(sender As Object, e As EventArgs) Handles SinBtn.Click
        BtnClick("sin(")
    End Sub

    Private Sub CosBtn_Click(sender As Object, e As EventArgs) Handles CosBtn.Click
        BtnClick("cos(")
    End Sub

    Private Sub TanBtn_Click(sender As Object, e As EventArgs) Handles TanBtn.Click
        BtnClick("tan(")
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        While Len(ExprLabel.Text) > 0
            ExprLabel.Text = Mid(ExprLabel.Text, 1, Len(ExprLabel.Text) - 1)
            If Len(ExprLabel.Text) > 0 Then
                If ExprLabel.Text(Len(ExprLabel.Text) - 1) < "a" Then Exit While
            End If
        End While
        inputstate = True
    End Sub

    Private Sub LnBtn_Click(sender As Object, e As EventArgs) Handles LnBtn.Click
        BtnClick("ln(")
    End Sub

    Private Sub AsinBtn_Click(sender As Object, e As EventArgs) Handles AsinBtn.Click
        BtnClick("asin(")
    End Sub

    Private Sub AcosBtn_Click(sender As Object, e As EventArgs) Handles AcosBtn.Click
        BtnClick("acos(")
    End Sub

    Private Sub AtanBtn_Click(sender As Object, e As EventArgs) Handles AtanBtn.Click
        BtnClick("atan(")
    End Sub

    Private Sub LogBtn_Click(sender As Object, e As EventArgs) Handles LogBtn.Click
        BtnClick("log(")
    End Sub

    Private Sub FacBtn_Click(sender As Object, e As EventArgs) Handles FacBtn.Click
        BtnClick("fact(")
    End Sub

    Private Sub EBtn_Click(sender As Object, e As EventArgs) Handles EBtn.Click
        BtnClick("e")
    End Sub

    Private Sub PiBtn_Click(sender As Object, e As EventArgs) Handles PiBtn.Click
        BtnClick("pi")
    End Sub

    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        inputstate = False
        Dim f As IO.FileStream
        Dim r As IO.StreamWriter
        Dim z As IO.StreamReader
        Dim c As Integer
        f = IO.File.Open("expr.txt", IO.FileMode.Create)
        r = New IO.StreamWriter(f)
        If AngleRadioButton0.Checked = True Then
            r.WriteLine("0")
        ElseIf AngleRadioButton1.Checked = True Then
            r.WriteLine("1")
        Else
            r.WriteLine("2")
        End If
        r.WriteLine(ExprLabel.Text)
        r.Flush()
        r.Close()
        f.Close()
        c = Shell("eval.exe", AppWinStyle.Hide, True, 5000)
        If c Then
            ExprLabel.Text = "time out"
        Else
        f = IO.File.Open("ans.txt", IO.FileMode.Open)
        z = New IO.StreamReader(f)
        ExprLabel.Text = z.ReadLine()
        z.Close()
        f.Close()
        End If
    End Sub

    Private Sub SinhBtn_Click(sender As Object, e As EventArgs) Handles SinhBtn.Click
        BtnClick("sinh(")
    End Sub

    Private Sub CoshBtn_Click(sender As Object, e As EventArgs) Handles CoshBtn.Click
        BtnClick("cosh(")
    End Sub

    Private Sub TanhBtn_Click(sender As Object, e As EventArgs) Handles TanhBtn.Click
        BtnClick("tanh(")
    End Sub

    Private Sub AsinhBtn_Click(sender As Object, e As EventArgs) Handles AsinhBtn.Click
        BtnClick("asinh(")
    End Sub

    Private Sub AcoshBtn_Click(sender As Object, e As EventArgs) Handles AcoshBtn.Click
        BtnClick("acosh(")
    End Sub

    Private Sub AtanhBtn_Click(sender As Object, e As EventArgs) Handles AtanhBtn.Click
        BtnClick("atanh(")
    End Sub


End Class
