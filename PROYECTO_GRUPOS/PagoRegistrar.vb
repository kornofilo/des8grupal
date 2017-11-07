Public Class PagoRegistrar
    Dim obj As New ConnectionDB
    Dim idCompraTB As Integer
    Public IDProveedor As Integer
    Public SaldoActual As Decimal


    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        If IsNumeric(TextBoxBuscarCompra.Text) = True Then
            obj.BuscarCompraRegistroPago(TextBoxBuscarCompra.Text)
            idCompraTB = TextBoxBuscarCompra.Text
        Else
            MsgBox("Por favor, ingrese un código de compra válido.", 16)
        End If
    End Sub

    Private Sub ButtonRegistrarPago_Click(sender As Object, e As EventArgs) Handles ButtonRegistrarPago.Click
        If IsNumeric(TextBoxNuevoPago.Text) Then
            If Val(SaldoActual - TextBoxNuevoPago.Text) > 0 Then
                Try

                    Dim dts As New Datos_Pagos
                    Dim func As New fpagos


                    dts.IDProveedor = IDProveedor
                    dts.Monto = TextBoxNuevoPago.Text
                    dts.IDCompra = idCompraTB
                    dts.Saldo = Val(SaldoActual - TextBoxNuevoPago.Text)

                    If func.insert_pago(dts) Then
                        MessageBox.Show("Pago Registrado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        obj.limpiarcampos(Me)
                    Else
                        MessageBox.Show("Pago Registrado Correctamente", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                    obj.BuscarCompraRegistroPago(idCompraTB)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Monto ingresado es mayor al saldo de la deuda.", 16)
            End If

        Else
            MsgBox("Por Favor ingrese un monto válido.")
        End If

    End Sub

    Private Sub GroupBoxDatosCompra_Enter(sender As Object, e As EventArgs) Handles GroupBoxDatosCompra.Enter

    End Sub
End Class