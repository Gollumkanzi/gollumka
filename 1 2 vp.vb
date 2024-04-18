Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        suma = valor1 + valor2
        Label3.Text = suma
        MessageBox.Show(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            Width = 100
            Height = 200
        Else
            If RadioButton2.Checked = True Then
                Width = 500
                Height = 600

            Else
                If RadioButton3.Checked = True Then
                    Width = 1200
                    Height = 1000
                Else
                    If RadioButton4.Checked = True Then
                        Width = 3000
                        Height = 3000
                    End If
                End If
                End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resta As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        resta = valor1 - valor2
        Label3.Text = resta

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim multiplicacion As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        multiplicacion = valor1 * valor2
        Label3.Text = multiplicacion
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
