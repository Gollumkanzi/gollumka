Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1 As Integer
        Dim Nm As Integer

        valor1 = TextBox1.Text


        Nm = valor1 * 0.5906
        Label1.Text = Nm





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor1 As Integer
        Dim den As Integer

        valor1 = TextBox2.Text


        den = 5315 / valor1
        Label3.Text = den
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valor1 As Integer
        Dim tex As Integer

        valor1 = TextBox3.Text


        tex = 590.6 / valor1
        Label4.Text = tex
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim valor1 As Integer
        Dim nec As Integer

        valor1 = TextBox4.Text


        nec = valor1 * 1
        Label5.Text = nec
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim valor1 As Integer
        Dim nec As Integer

        valor1 = TextBox5.Text


        nec = valor1 * 0.5906
        Label2.Text = nec

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim valor1 As Integer
        Dim nm As Integer

        valor1 = TextBox6.Text


        nm = valor1 * 1
        Label6.Text = nm
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim valor1 As Integer
        Dim dem As Integer

        valor1 = TextBox7.Text


        dem = 9000 / valor1
        Label7.Text = dem
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim valor1 As Integer
        Dim tex As Integer

        valor1 = TextBox8.Text


        tex = 1000 / valor1
        Label8.Text = tex
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim valor1 As Integer
        Dim nec As Integer

        valor1 = TextBox9.Text


        nec = 5315 / valor1
        Label9.Text = nec
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim valor1 As Integer
        Dim nm As Integer

        valor1 = TextBox10.Text


        nm = 9000 / valor1
        Label10.Text = nm
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim valor1 As Integer
        Dim dem As Integer

        valor1 = TextBox11.Text


        dem = 1 * valor1
        Label11.Text = dem
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim valor1 As Integer
        Dim tex As Integer

        valor1 = TextBox12.Text


        tex = valor1 * 9
        Label12.Text = tex
    End Sub
End Class
