Public Class Form1
    Private Sub Ejecutar_Click(sender As Object, e As EventArgs) Handles Ejecutar.Click
        Dim a, b As Integer
        a = InputBox("Ingresar valor", "Ejemplo 1a", 0)
        b = InputBox("Ingresar valor", "Ejemplo 1a", 0)
        If a > b Then
            mostrarMayor.Text = "El mayor es: " & a
            mostrarMenor.Text = "El menor es: " & b
        Else
            mostrarMenor.Text = "El menor es: " & a
            mostrarMayor.Text = "El mayor es: " & b
        End If
    End Sub
End Class
