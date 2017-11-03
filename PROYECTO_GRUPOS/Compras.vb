Public Class Compras
    Dim obj As New ConnectionDB
    Dim funcion As New fcompras

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        mostrar()

    End Sub
    Public Sub mostrar()
        Try
            obj.ShowDataGrid("compras", DataGridView1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtidprovee_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtidprovee.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                funcion.Consulta()


            Catch ex As Exception

            End Try
        End If





    End Sub

    Private Sub txtidprovee_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtidprovee.TextChanged

    End Sub
End Class