Public Class Form1
    Dim first As Double
    Dim opr As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "1"
        TextBox2.Text = TextBox2.Text & "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "2"
        TextBox2.Text = TextBox2.Text & "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"
        TextBox2.Text = TextBox2.Text & "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "4"
        TextBox2.Text = TextBox2.Text & "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "5"
        TextBox2.Text = TextBox2.Text & "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "6"
        TextBox2.Text = TextBox2.Text & "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "7"
        TextBox2.Text = TextBox2.Text & "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "8"
        TextBox2.Text = TextBox2.Text & "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "9"
        TextBox2.Text = TextBox2.Text & "9"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & "0"
        TextBox2.Text = TextBox2.Text & "0"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & " + "
        opr = "+"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & " - "
        opr = "-"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & " X "
        opr = "X"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & " / "
        opr = "/"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim second, result As Double
        second = Val(TextBox1.Text)
        Select Case opr
            Case "+"
                result = first + second
            Case "-"
                result = first - second
            Case "X"
                result = first * second
            Case "/"
                result = first / second
        End Select
        TextBox1.Text = result
        TextBox2.Text = TextBox2.Text & " = " & result
        first = result
    End Sub
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Font = New Font("BROADWAY", 15, FontStyle.Bold)
        TextBox1.TextAlign = HorizontalAlignment.Right
        TextBox1.Enabled = False
        TextBox2.Font = New Font("BROADWAY", 15, FontStyle.Bold)
        TextBox2.TextAlign = HorizontalAlignment.Right
        TextBox2.Enabled = False
    End Sub
End Class
