<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GpbCabezal = New System.Windows.Forms.GroupBox
        Me.CboOpciones = New System.Windows.Forms.CheckedListBox
        Me.LblNumero = New System.Windows.Forms.Label
        Me.TxtNumero = New System.Windows.Forms.TextBox
        Me.TxtVeces = New System.Windows.Forms.Label
        Me.GpbResultados = New System.Windows.Forms.GroupBox
        Me.TxtCantidad = New System.Windows.Forms.TextBox
        Me.CboSuma = New System.Windows.Forms.ComboBox
        Me.LblSuma = New System.Windows.Forms.Label
        Me.LblResta = New System.Windows.Forms.Label
        Me.LblMulti = New System.Windows.Forms.Label
        Me.CboResta = New System.Windows.Forms.ComboBox
        Me.CboMulti = New System.Windows.Forms.ComboBox
        Me.LblDiv = New System.Windows.Forms.Label
        Me.CboDiv = New System.Windows.Forms.ComboBox
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.BtnCalcular = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GpbCabezal.SuspendLayout()
        Me.GpbResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpbCabezal
        '
        Me.GpbCabezal.Controls.Add(Me.TxtVeces)
        Me.GpbCabezal.Controls.Add(Me.TxtCantidad)
        Me.GpbCabezal.Controls.Add(Me.TxtNumero)
        Me.GpbCabezal.Controls.Add(Me.LblNumero)
        Me.GpbCabezal.Controls.Add(Me.CboOpciones)
        Me.GpbCabezal.Location = New System.Drawing.Point(12, 12)
        Me.GpbCabezal.Name = "GpbCabezal"
        Me.GpbCabezal.Size = New System.Drawing.Size(678, 88)
        Me.GpbCabezal.TabIndex = 0
        Me.GpbCabezal.TabStop = False
        '
        'CboOpciones
        '
        Me.CboOpciones.FormattingEnabled = True
        Me.CboOpciones.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division"})
        Me.CboOpciones.Location = New System.Drawing.Point(543, 13)
        Me.CboOpciones.Name = "CboOpciones"
        Me.CboOpciones.Size = New System.Drawing.Size(129, 64)
        Me.CboOpciones.TabIndex = 0
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(109, 16)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(44, 13)
        Me.LblNumero.TabIndex = 1
        Me.LblNumero.Text = "Numero"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(159, 13)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(145, 20)
        Me.TxtNumero.TabIndex = 2
        '
        'TxtVeces
        '
        Me.TxtVeces.AutoSize = True
        Me.TxtVeces.Location = New System.Drawing.Point(12, 51)
        Me.TxtVeces.Name = "TxtVeces"
        Me.TxtVeces.Size = New System.Drawing.Size(141, 13)
        Me.TxtVeces.TabIndex = 4
        Me.TxtVeces.Text = "Cantidad de veces a realizar"
        '
        'GpbResultados
        '
        Me.GpbResultados.Controls.Add(Me.CboDiv)
        Me.GpbResultados.Controls.Add(Me.LblDiv)
        Me.GpbResultados.Controls.Add(Me.CboMulti)
        Me.GpbResultados.Controls.Add(Me.CboResta)
        Me.GpbResultados.Controls.Add(Me.LblMulti)
        Me.GpbResultados.Controls.Add(Me.LblResta)
        Me.GpbResultados.Controls.Add(Me.LblSuma)
        Me.GpbResultados.Controls.Add(Me.CboSuma)
        Me.GpbResultados.Location = New System.Drawing.Point(12, 145)
        Me.GpbResultados.Name = "GpbResultados"
        Me.GpbResultados.Size = New System.Drawing.Size(672, 112)
        Me.GpbResultados.TabIndex = 1
        Me.GpbResultados.TabStop = False
        Me.GpbResultados.Text = "Resultados"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(159, 48)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(145, 20)
        Me.TxtCantidad.TabIndex = 3
        '
        'CboSuma
        '
        Me.CboSuma.FormattingEnabled = True
        Me.CboSuma.Location = New System.Drawing.Point(52, 46)
        Me.CboSuma.Name = "CboSuma"
        Me.CboSuma.Size = New System.Drawing.Size(121, 21)
        Me.CboSuma.TabIndex = 0
        '
        'LblSuma
        '
        Me.LblSuma.AutoSize = True
        Me.LblSuma.Location = New System.Drawing.Point(95, 16)
        Me.LblSuma.Name = "LblSuma"
        Me.LblSuma.Size = New System.Drawing.Size(34, 13)
        Me.LblSuma.TabIndex = 1
        Me.LblSuma.Text = "Suma"
        '
        'LblResta
        '
        Me.LblResta.AutoSize = True
        Me.LblResta.Location = New System.Drawing.Point(265, 16)
        Me.LblResta.Name = "LblResta"
        Me.LblResta.Size = New System.Drawing.Size(35, 13)
        Me.LblResta.TabIndex = 2
        Me.LblResta.Text = "Resta"
        '
        'LblMulti
        '
        Me.LblMulti.AutoSize = True
        Me.LblMulti.Location = New System.Drawing.Point(406, 16)
        Me.LblMulti.Name = "LblMulti"
        Me.LblMulti.Size = New System.Drawing.Size(71, 13)
        Me.LblMulti.TabIndex = 3
        Me.LblMulti.Text = "Multiplicacion"
        '
        'CboResta
        '
        Me.CboResta.FormattingEnabled = True
        Me.CboResta.Location = New System.Drawing.Point(219, 46)
        Me.CboResta.Name = "CboResta"
        Me.CboResta.Size = New System.Drawing.Size(121, 21)
        Me.CboResta.TabIndex = 4
        '
        'CboMulti
        '
        Me.CboMulti.FormattingEnabled = True
        Me.CboMulti.Location = New System.Drawing.Point(378, 46)
        Me.CboMulti.Name = "CboMulti"
        Me.CboMulti.Size = New System.Drawing.Size(121, 21)
        Me.CboMulti.TabIndex = 5
        '
        'LblDiv
        '
        Me.LblDiv.AutoSize = True
        Me.LblDiv.Location = New System.Drawing.Point(571, 16)
        Me.LblDiv.Name = "LblDiv"
        Me.LblDiv.Size = New System.Drawing.Size(44, 13)
        Me.LblDiv.TabIndex = 6
        Me.LblDiv.Text = "Division"
        '
        'CboDiv
        '
        Me.CboDiv.FormattingEnabled = True
        Me.CboDiv.Location = New System.Drawing.Point(526, 46)
        Me.CboDiv.Name = "CboDiv"
        Me.CboDiv.Size = New System.Drawing.Size(121, 21)
        Me.CboDiv.TabIndex = 7
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(90, 116)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(318, 116)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 3
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(555, 116)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 268)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GpbResultados)
        Me.Controls.Add(Me.GpbCabezal)
        Me.Name = "FrmMenu"
        Me.Text = "Form1"
        Me.GpbCabezal.ResumeLayout(False)
        Me.GpbCabezal.PerformLayout()
        Me.GpbResultados.ResumeLayout(False)
        Me.GpbResultados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpbCabezal As System.Windows.Forms.GroupBox
    Friend WithEvents CboOpciones As System.Windows.Forms.CheckedListBox
    Friend WithEvents TxtVeces As System.Windows.Forms.Label
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents GpbResultados As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents CboDiv As System.Windows.Forms.ComboBox
    Friend WithEvents LblDiv As System.Windows.Forms.Label
    Friend WithEvents CboMulti As System.Windows.Forms.ComboBox
    Friend WithEvents CboResta As System.Windows.Forms.ComboBox
    Friend WithEvents LblMulti As System.Windows.Forms.Label
    Friend WithEvents LblResta As System.Windows.Forms.Label
    Friend WithEvents LblSuma As System.Windows.Forms.Label
    Friend WithEvents CboSuma As System.Windows.Forms.ComboBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button

End Class
