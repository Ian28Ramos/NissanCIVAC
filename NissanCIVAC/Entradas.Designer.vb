<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entradas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cap = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.NoParte = New System.Windows.Forms.ComboBox()
        Me.TiDa = New System.Windows.Forms.ComboBox()
        Me.Prioridad = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ArRe = New System.Windows.Forms.ComboBox()
        Me.Capturar = New System.Windows.Forms.Button()
        Me.Consulta = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Desc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NomArea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.27!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.27!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "N° de Parte:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de daño:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Prioridad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(487, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha:"
        '
        'Cap
        '
        Me.Cap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cap.Location = New System.Drawing.Point(226, 67)
        Me.Cap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cap.Name = "Cap"
        Me.Cap.Size = New System.Drawing.Size(199, 22)
        Me.Cap.TabIndex = 8
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(226, 106)
        Me.Cantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(199, 22)
        Me.Cantidad.TabIndex = 9
        '
        'NoParte
        '
        Me.NoParte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NoParte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NoParte.DropDownWidth = 150
        Me.NoParte.FormattingEnabled = True
        Me.NoParte.Location = New System.Drawing.Point(226, 149)
        Me.NoParte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NoParte.Name = "NoParte"
        Me.NoParte.Size = New System.Drawing.Size(199, 24)
        Me.NoParte.TabIndex = 10
        Me.NoParte.Text = "<Selecciona una opción>"
        '
        'TiDa
        '
        Me.TiDa.FormattingEnabled = True
        Me.TiDa.Items.AddRange(New Object() {"ABOLLADO", "FRACTURADO ", "DEFORMADO", "OXIDADO", "RAYADURA", "MOJADO", "ROTO", "FALTA PIEZA", "OTROS"})
        Me.TiDa.Location = New System.Drawing.Point(226, 232)
        Me.TiDa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TiDa.Name = "TiDa"
        Me.TiDa.Size = New System.Drawing.Size(199, 24)
        Me.TiDa.TabIndex = 11
        '
        'Prioridad
        '
        Me.Prioridad.FormattingEnabled = True
        Me.Prioridad.Items.AddRange(New Object() {"ORDINARIO", "URGENTE"})
        Me.Prioridad.Location = New System.Drawing.Point(226, 276)
        Me.Prioridad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Prioridad.Name = "Prioridad"
        Me.Prioridad.Size = New System.Drawing.Size(199, 24)
        Me.Prioridad.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(775, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 323)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ID Área:"
        '
        'ArRe
        '
        Me.ArRe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ArRe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArRe.FormattingEnabled = True
        Me.ArRe.Location = New System.Drawing.Point(226, 319)
        Me.ArRe.Margin = New System.Windows.Forms.Padding(4)
        Me.ArRe.Name = "ArRe"
        Me.ArRe.Size = New System.Drawing.Size(199, 24)
        Me.ArRe.TabIndex = 17
        Me.ArRe.Text = "<Selecciona una opción>"
        '
        'Capturar
        '
        Me.Capturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Capturar.Location = New System.Drawing.Point(491, 323)
        Me.Capturar.Margin = New System.Windows.Forms.Padding(4)
        Me.Capturar.Name = "Capturar"
        Me.Capturar.Size = New System.Drawing.Size(123, 38)
        Me.Capturar.TabIndex = 18
        Me.Capturar.Text = "Capturar"
        Me.Capturar.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.Consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consulta.Location = New System.Drawing.Point(622, 323)
        Me.Consulta.Margin = New System.Windows.Forms.Padding(4)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(123, 38)
        Me.Consulta.TabIndex = 19
        Me.Consulta.Text = "Consultar"
        Me.Consulta.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editar.Location = New System.Drawing.Point(752, 323)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(123, 38)
        Me.Editar.TabIndex = 20
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Descripción:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(491, 96)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 23
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(557, 65)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(167, 22)
        Me.Fecha.TabIndex = 24
        '
        'Limpiar
        '
        Me.Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.Location = New System.Drawing.Point(226, 420)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(123, 38)
        Me.Limpiar.TabIndex = 25
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Desc
        '
        Me.Desc.Location = New System.Drawing.Point(226, 193)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(199, 22)
        Me.Desc.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Nombre del Área:"
        '
        'NomArea
        '
        Me.NomArea.Location = New System.Drawing.Point(226, 368)
        Me.NomArea.Name = "NomArea"
        Me.NomArea.Size = New System.Drawing.Size(199, 22)
        Me.NomArea.TabIndex = 28
        '
        'Entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.NomArea)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Editar)
        Me.Controls.Add(Me.Consulta)
        Me.Controls.Add(Me.Capturar)
        Me.Controls.Add(Me.ArRe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Prioridad)
        Me.Controls.Add(Me.TiDa)
        Me.Controls.Add(Me.NoParte)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Cap)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Entradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de entradas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Cap As TextBox
    Friend WithEvents Cantidad As TextBox
    Friend WithEvents NoParte As ComboBox
    Friend WithEvents TiDa As ComboBox
    Friend WithEvents Prioridad As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ArRe As ComboBox
    Friend WithEvents Capturar As Button
    Friend WithEvents Consulta As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Fecha As TextBox
    Friend WithEvents Limpiar As Button
    Friend WithEvents Desc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NomArea As TextBox
End Class
