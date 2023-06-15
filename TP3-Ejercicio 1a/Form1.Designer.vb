<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.mostrarMayor = New System.Windows.Forms.Label()
        Me.mostrarMenor = New System.Windows.Forms.Label()
        Me.Ejecutar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mostrarMayor
        '
        Me.mostrarMayor.AutoSize = True
        Me.mostrarMayor.Location = New System.Drawing.Point(227, 128)
        Me.mostrarMayor.Name = "mostrarMayor"
        Me.mostrarMayor.Size = New System.Drawing.Size(61, 13)
        Me.mostrarMayor.TabIndex = 1
        Me.mostrarMayor.Text = "El mayor es"
        '
        'mostrarMenor
        '
        Me.mostrarMenor.AutoSize = True
        Me.mostrarMenor.Location = New System.Drawing.Point(432, 128)
        Me.mostrarMenor.Name = "mostrarMenor"
        Me.mostrarMenor.Size = New System.Drawing.Size(62, 13)
        Me.mostrarMenor.TabIndex = 2
        Me.mostrarMenor.Text = "El menor es"
        '
        'Ejecutar
        '
        Me.Ejecutar.Location = New System.Drawing.Point(312, 188)
        Me.Ejecutar.Name = "Ejecutar"
        Me.Ejecutar.Size = New System.Drawing.Size(75, 23)
        Me.Ejecutar.TabIndex = 3
        Me.Ejecutar.Text = "Ejecutar"
        Me.Ejecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ejecutar)
        Me.Controls.Add(Me.mostrarMenor)
        Me.Controls.Add(Me.mostrarMayor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mostrarMayor As Label
    Friend WithEvents mostrarMenor As Label
    Friend WithEvents Ejecutar As Button
End Class
