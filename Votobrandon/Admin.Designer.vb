<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.BtnResultado = New System.Windows.Forms.Button()
        Me.Btnregistro = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnResultado
        '
        Me.BtnResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnResultado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnResultado.Location = New System.Drawing.Point(68, 167)
        Me.BtnResultado.Name = "BtnResultado"
        Me.BtnResultado.Size = New System.Drawing.Size(256, 45)
        Me.BtnResultado.TabIndex = 3
        Me.BtnResultado.Text = "Ver Resultados de votacion"
        Me.BtnResultado.UseVisualStyleBackColor = False
        '
        'Btnregistro
        '
        Me.Btnregistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnregistro.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btnregistro.Location = New System.Drawing.Point(68, 102)
        Me.Btnregistro.Name = "Btnregistro"
        Me.Btnregistro.Size = New System.Drawing.Size(256, 45)
        Me.Btnregistro.TabIndex = 4
        Me.Btnregistro.Text = "Registrar Candidatos"
        Me.Btnregistro.UseVisualStyleBackColor = False
        '
        'Btnregresar
        '
        Me.Btnregresar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btnregresar.Location = New System.Drawing.Point(146, 240)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(102, 23)
        Me.Btnregresar.TabIndex = 7
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("French Script MT", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(108, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 42)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Administracion "
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(376, 321)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnregistro)
        Me.Controls.Add(Me.BtnResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnResultado As Button
    Friend WithEvents Btnregistro As Button
    Friend WithEvents Btnregresar As Button
    Friend WithEvents Label7 As Label
End Class
