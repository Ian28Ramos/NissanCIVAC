<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salidas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CapBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CantBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TiSaBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cap = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.FechaBox = New System.Windows.Forms.TextBox()
        Me.Cons = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REC:"
        '
        'CapBox
        '
        Me.CapBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CapBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CapBox.Location = New System.Drawing.Point(175, 81)
        Me.CapBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CapBox.Name = "CapBox"
        Me.CapBox.Size = New System.Drawing.Size(216, 22)
        Me.CapBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad:"
        '
        'CantBox
        '
        Me.CantBox.Location = New System.Drawing.Point(175, 121)
        Me.CantBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CantBox.Name = "CantBox"
        Me.CantBox.Size = New System.Drawing.Size(216, 22)
        Me.CantBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de salida:"
        '
        'TiSaBox
        '
        Me.TiSaBox.FormattingEnabled = True
        Me.TiSaBox.Items.AddRange(New Object() {"Recuperada", "TRIM Chasis", "Body", "Seguro", "Cristal", "Cuenta"})
        Me.TiSaBox.Location = New System.Drawing.Point(201, 170)
        Me.TiSaBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TiSaBox.Name = "TiSaBox"
        Me.TiSaBox.Size = New System.Drawing.Size(190, 24)
        Me.TiSaBox.TabIndex = 5
        Me.TiSaBox.Text = "<Seleccione  una opción>"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cap
        '
        Me.Cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cap.Location = New System.Drawing.Point(142, 321)
        Me.Cap.Margin = New System.Windows.Forms.Padding(4)
        Me.Cap.Name = "Cap"
        Me.Cap.Size = New System.Drawing.Size(118, 27)
        Me.Cap.TabIndex = 7
        Me.Cap.Text = "Capturar"
        Me.Cap.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 255)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(249, 22)
        Me.DateTimePicker1.TabIndex = 9
        '
        'FechaBox
        '
        Me.FechaBox.Location = New System.Drawing.Point(175, 212)
        Me.FechaBox.Name = "FechaBox"
        Me.FechaBox.Size = New System.Drawing.Size(216, 22)
        Me.FechaBox.TabIndex = 10
        '
        'Cons
        '
        Me.Cons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cons.Location = New System.Drawing.Point(273, 321)
        Me.Cons.Name = "Cons"
        Me.Cons.Size = New System.Drawing.Size(118, 28)
        Me.Cons.TabIndex = 11
        Me.Cons.Text = "Consultar"
        Me.Cons.UseVisualStyleBackColor = True
        '
        'Salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cons)
        Me.Controls.Add(Me.FechaBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cap)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TiSaBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CantBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CapBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Salidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de salidas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CapBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CantBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TiSaBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Cap As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents FechaBox As TextBox
    Friend WithEvents Cons As Button
End Class
