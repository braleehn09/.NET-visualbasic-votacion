<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Btnadmin = New System.Windows.Forms.Button()
        Me.Btnvotar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnadmin
        '
        Me.Btnadmin.BackColor = System.Drawing.Color.White
        Me.Btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnadmin.Font = New System.Drawing.Font("French Script MT", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btnadmin.Location = New System.Drawing.Point(12, 96)
        Me.Btnadmin.Name = "Btnadmin"
        Me.Btnadmin.Size = New System.Drawing.Size(245, 216)
        Me.Btnadmin.TabIndex = 1
        Me.Btnadmin.Text = "Administración"
        Me.Btnadmin.UseVisualStyleBackColor = False
        '
        'Btnvotar
        '
        Me.Btnvotar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btnvotar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnvotar.Font = New System.Drawing.Font("French Script MT", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btnvotar.ForeColor = System.Drawing.Color.White
        Me.Btnvotar.Location = New System.Drawing.Point(281, 96)
        Me.Btnvotar.Name = "Btnvotar"
        Me.Btnvotar.Size = New System.Drawing.Size(245, 216)
        Me.Btnvotar.TabIndex = 14
        Me.Btnvotar.Text = "Ingresar a la Votación"
        Me.Btnvotar.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(538, 372)
        Me.Controls.Add(Me.Btnvotar)
        Me.Controls.Add(Me.Btnadmin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnadmin As Button
    Friend WithEvents Btnvotar As Button
End Class
