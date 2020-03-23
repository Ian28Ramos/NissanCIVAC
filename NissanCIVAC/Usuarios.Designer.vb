<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.NomBox = New System.Windows.Forms.TextBox()
        Me.ApPBox = New System.Windows.Forms.TextBox()
        Me.ApMBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DropButton = New System.Windows.Forms.Button()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PassBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TiUsBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° de empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido materno:"
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(245, 45)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(172, 22)
        Me.IDBox.TabIndex = 4
        '
        'NomBox
        '
        Me.NomBox.Location = New System.Drawing.Point(245, 87)
        Me.NomBox.Name = "NomBox"
        Me.NomBox.Size = New System.Drawing.Size(172, 22)
        Me.NomBox.TabIndex = 5
        '
        'ApPBox
        '
        Me.ApPBox.Location = New System.Drawing.Point(245, 123)
        Me.ApPBox.Name = "ApPBox"
        Me.ApPBox.Size = New System.Drawing.Size(172, 22)
        Me.ApPBox.TabIndex = 6
        '
        'ApMBox
        '
        Me.ApMBox.Location = New System.Drawing.Point(245, 163)
        Me.ApMBox.Name = "ApMBox"
        Me.ApMBox.Size = New System.Drawing.Size(172, 22)
        Me.ApMBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(587, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(475, 268)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(107, 42)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Agregar"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DropButton
        '
        Me.DropButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropButton.Location = New System.Drawing.Point(475, 45)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(80, 36)
        Me.DropButton.TabIndex = 10
        Me.DropButton.Text = "Eliminar"
        Me.DropButton.UseVisualStyleBackColor = True
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.Location = New System.Drawing.Point(39, 249)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(107, 20)
        Me.Contraseña.TabIndex = 11
        Me.Contraseña.Text = "Contraseña:"
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(245, 247)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(172, 22)
        Me.PassBox.TabIndex = 12
        Me.PassBox.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Repetir contraseña:"
        '
        'PassBox2
        '
        Me.PassBox2.Location = New System.Drawing.Point(245, 288)
        Me.PassBox2.Name = "PassBox2"
        Me.PassBox2.Size = New System.Drawing.Size(172, 22)
        Me.PassBox2.TabIndex = 14
        Me.PassBox2.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tipo de usuario:"
        '
        'TiUsBox
        '
        Me.TiUsBox.FormattingEnabled = True
        Me.TiUsBox.Items.AddRange(New Object() {"FINANCIEROS", "SUPER", "MANEJO DE MATERIALES"})
        Me.TiUsBox.Location = New System.Drawing.Point(245, 207)
        Me.TiUsBox.Name = "TiUsBox"
        Me.TiUsBox.Size = New System.Drawing.Size(172, 24)
        Me.TiUsBox.TabIndex = 16
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.TiUsBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PassBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.DropButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ApMBox)
        Me.Controls.Add(Me.ApPBox)
        Me.Controls.Add(Me.NomBox)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IDBox As TextBox
    Friend WithEvents NomBox As TextBox
    Friend WithEvents ApPBox As TextBox
    Friend WithEvents ApMBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents DropButton As Button
    Friend WithEvents Contraseña As Label
    Friend WithEvents PassBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PassBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TiUsBox As ComboBox
End Class
