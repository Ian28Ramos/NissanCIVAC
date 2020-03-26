<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.RMPbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MC = New System.Windows.Forms.MonthCalendar()
        Me.StarTxt = New System.Windows.Forms.TextBox()
        Me.EndTxt = New System.Windows.Forms.TextBox()
        Me.RMFbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RMPbtn
        '
        Me.RMPbtn.Location = New System.Drawing.Point(676, 12)
        Me.RMPbtn.Name = "RMPbtn"
        Me.RMPbtn.Size = New System.Drawing.Size(81, 29)
        Me.RMPbtn.TabIndex = 0
        Me.RMPbtn.Text = "Regresar"
        Me.RMPbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de salida:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Recuperada", "TRIM Chasis", "Body", "Seguro", "Cristal", "Cuenta"})
        Me.ComboBox1.Location = New System.Drawing.Point(200, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de termino:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.28!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(200, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Generar reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MC
        '
        Me.MC.Location = New System.Drawing.Point(420, 93)
        Me.MC.MaxSelectionCount = 31
        Me.MC.Name = "MC"
        Me.MC.TabIndex = 8
        '
        'StarTxt
        '
        Me.StarTxt.Location = New System.Drawing.Point(200, 147)
        Me.StarTxt.Name = "StarTxt"
        Me.StarTxt.Size = New System.Drawing.Size(174, 22)
        Me.StarTxt.TabIndex = 9
        '
        'EndTxt
        '
        Me.EndTxt.Location = New System.Drawing.Point(200, 203)
        Me.EndTxt.Name = "EndTxt"
        Me.EndTxt.Size = New System.Drawing.Size(174, 22)
        Me.EndTxt.TabIndex = 10
        '
        'RMFbtn
        '
        Me.RMFbtn.Location = New System.Drawing.Point(676, 12)
        Me.RMFbtn.Name = "RMFbtn"
        Me.RMFbtn.Size = New System.Drawing.Size(81, 29)
        Me.RMFbtn.TabIndex = 11
        Me.RMFbtn.Text = "Regresar"
        Me.RMFbtn.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.RMFbtn)
        Me.Controls.Add(Me.EndTxt)
        Me.Controls.Add(Me.StarTxt)
        Me.Controls.Add(Me.MC)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RMPbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RMPbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MC As MonthCalendar
    Friend WithEvents StarTxt As TextBox
    Friend WithEvents EndTxt As TextBox
    Friend WithEvents RMFbtn As Button
End Class
