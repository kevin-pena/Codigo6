Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim datos As String = txtDatos.Text
            Dim archivo As FileStream = File.Create("datos.bin")
            Dim escritor As New BinaryWriter(archivo)
            escritor.Write(datos)
            escritor.Close()
            archivo.Close()
            MsgBox("Datos guardados correctamente.")
        Catch ex As Exception
            MsgBox("Ocurrió un error al guardar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim archivo As FileStream = File.OpenRead("datos.bin")
            Dim lector As New BinaryReader(archivo)
            Dim datos As String = lector.ReadString()
            lector.Close()
            archivo.Close()
            txtResultado.Text = datos
            MsgBox("Datos cargados correctamente.")
        Catch ex As Exception
            MsgBox("Ocurrió un error al cargar los datos: " & ex.Message)
        End Try
    End Sub
End Class
