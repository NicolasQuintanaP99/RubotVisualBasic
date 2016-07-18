Public Class FrmMenu

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        CboDiv.Items.Clear()
        CboMulti.Items.Clear()
        CboResta.Items.Clear()
        CboSuma.Items.Clear()
    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click


    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim veces As Integer
        Dim valor As Integer
        valor = Val(TxtNumero.Text)
        veces = Val(TxtVeces.Text)
        For Each CboOpciones.CheckedItems
            If valor = 0 Then
                CboDiv.Items.Add("Imposible dividir entre 0")
            End If
            For j = 1 To veces Step 1
                CboSuma.Items.Add(valor & " + " & valor & " = " & valor + valor)
                CboResta.Items.Add(valor & " - " & valor & " = " & valor - valor)
                CboMulti.Items.Add(valor & " * " & valor & " = " & valor * valor)
                If valor <> 0 Then
                    CboDiv.Items.Add(valor & " + " & valor & " = " & valor + valor)
                End If


            Next
        Next



    End Sub
End Class
