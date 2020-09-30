<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprincipal636
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
        Me.btnjuego1636 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnloculto636 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtperdi636 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgana636 = New System.Windows.Forms.TextBox()
        Me.btnjuego2636 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnloculto636.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnjuego1636
        '
        Me.btnjuego1636.BackColor = System.Drawing.Color.Blue
        Me.btnjuego1636.Location = New System.Drawing.Point(33, 55)
        Me.btnjuego1636.Name = "btnjuego1636"
        Me.btnjuego1636.Size = New System.Drawing.Size(76, 53)
        Me.btnjuego1636.TabIndex = 0
        Me.btnjuego1636.Text = "Juego 1"
        Me.btnjuego1636.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ganaste:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.Controls.Add(Me.pnloculto636)
        Me.Panel1.Controls.Add(Me.txtperdi636)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtgana636)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 150)
        Me.Panel1.TabIndex = 2
        '
        'pnloculto636
        '
        Me.pnloculto636.BackColor = System.Drawing.Color.Turquoise
        Me.pnloculto636.Controls.Add(Me.Button1)
        Me.pnloculto636.Location = New System.Drawing.Point(0, 1)
        Me.pnloculto636.Name = "pnloculto636"
        Me.pnloculto636.Size = New System.Drawing.Size(308, 149)
        Me.pnloculto636.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 58)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "calcular Ganadas/Perdidas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtperdi636
        '
        Me.txtperdi636.Location = New System.Drawing.Point(141, 77)
        Me.txtperdi636.Name = "txtperdi636"
        Me.txtperdi636.ReadOnly = True
        Me.txtperdi636.Size = New System.Drawing.Size(100, 22)
        Me.txtperdi636.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Perdiste:"
        '
        'txtgana636
        '
        Me.txtgana636.Location = New System.Drawing.Point(141, 36)
        Me.txtgana636.Name = "txtgana636"
        Me.txtgana636.ReadOnly = True
        Me.txtgana636.Size = New System.Drawing.Size(100, 22)
        Me.txtgana636.TabIndex = 2
        '
        'btnjuego2636
        '
        Me.btnjuego2636.BackColor = System.Drawing.Color.Fuchsia
        Me.btnjuego2636.Location = New System.Drawing.Point(205, 55)
        Me.btnjuego2636.Name = "btnjuego2636"
        Me.btnjuego2636.Size = New System.Drawing.Size(76, 53)
        Me.btnjuego2636.TabIndex = 3
        Me.btnjuego2636.Text = "Juego 2"
        Me.btnjuego2636.UseVisualStyleBackColor = False
        '
        'frmprincipal636
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(326, 297)
        Me.Controls.Add(Me.btnjuego2636)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnjuego1636)
        Me.Name = "frmprincipal636"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnloculto636.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnjuego1636 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtperdi636 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtgana636 As TextBox
    Friend WithEvents btnjuego2636 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnloculto636 As Panel
End Class
