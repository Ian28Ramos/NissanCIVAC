<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GesPiezas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GesPiezas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CosBox = New System.Windows.Forms.TextBox()
        Me.OriBox = New System.Windows.Forms.ComboBox()
        Me.MonBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DesBox = New System.Windows.Forms.ComboBox()
        Me.NPBox = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No de pieza:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Origen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Moneda:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(42, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(339, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CosBox
        '
        Me.CosBox.Location = New System.Drawing.Point(210, 170)
        Me.CosBox.Name = "CosBox"
        Me.CosBox.Size = New System.Drawing.Size(252, 22)
        Me.CosBox.TabIndex = 8
        '
        'OriBox
        '
        Me.OriBox.FormattingEnabled = True
        Me.OriBox.Location = New System.Drawing.Point(210, 115)
        Me.OriBox.Name = "OriBox"
        Me.OriBox.Size = New System.Drawing.Size(252, 24)
        Me.OriBox.TabIndex = 9
        '
        'MonBox
        '
        Me.MonBox.FormattingEnabled = True
        Me.MonBox.Location = New System.Drawing.Point(210, 280)
        Me.MonBox.Name = "MonBox"
        Me.MonBox.Size = New System.Drawing.Size(252, 24)
        Me.MonBox.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(190, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 40)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DesBox
        '
        Me.DesBox.FormattingEnabled = True
        Me.DesBox.Location = New System.Drawing.Point(210, 223)
        Me.DesBox.Name = "DesBox"
        Me.DesBox.Size = New System.Drawing.Size(252, 24)
        Me.DesBox.TabIndex = 13
        '
        'NPBox
        '
        Me.NPBox.FormattingEnabled = True
        Me.NPBox.Location = New System.Drawing.Point(210, 65)
        Me.NPBox.Name = "NPBox"
        Me.NPBox.Size = New System.Drawing.Size(252, 24)
        Me.NPBox.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(462, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 26)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Regresar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GesPiezas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NPBox)
        Me.Controls.Add(Me.DesBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MonBox)
        Me.Controls.Add(Me.OriBox)
        Me.Controls.Add(Me.CosBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GesPiezas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GesPiezas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CosBox As TextBox
    Friend WithEvents OriBox As ComboBox
    Friend WithEvents MonBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DesBox As ComboBox
    Friend WithEvents NPBox As ComboBox
    Friend WithEvents Button4 As Button
End Class
