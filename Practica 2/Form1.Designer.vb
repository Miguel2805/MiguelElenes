<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.nCasa = New System.Windows.Forms.TextBox()
        Me.calle = New System.Windows.Forms.TextBox()
        Me.colonia = New System.Windows.Forms.TextBox()
        Me.aMaterno = New System.Windows.Forms.TextBox()
        Me.aPaterno = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.borrar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bGuardar
        '
        Me.bGuardar.Location = New System.Drawing.Point(181, 339)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(75, 23)
        Me.bGuardar.TabIndex = 0
        Me.bGuardar.Text = "GUARDAR"
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CODIGO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NOMBRE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "APELLIDO PATERNO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "APELLIDO MATERNO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "COLONIA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "CALLE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "NUMERO DE CASA:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(31, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(680, 426)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.nCasa)
        Me.TabPage1.Controls.Add(Me.calle)
        Me.TabPage1.Controls.Add(Me.colonia)
        Me.TabPage1.Controls.Add(Me.aMaterno)
        Me.TabPage1.Controls.Add(Me.aPaterno)
        Me.TabPage1.Controls.Add(Me.nombre)
        Me.TabPage1.Controls.Add(Me.fecha)
        Me.TabPage1.Controls.Add(Me.codigo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.bGuardar)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(672, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "REGISTRAR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'nCasa
        '
        Me.nCasa.Location = New System.Drawing.Point(145, 297)
        Me.nCasa.Name = "nCasa"
        Me.nCasa.Size = New System.Drawing.Size(144, 23)
        Me.nCasa.TabIndex = 16
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(79, 258)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(196, 23)
        Me.calle.TabIndex = 15
        '
        'colonia
        '
        Me.colonia.Location = New System.Drawing.Point(97, 223)
        Me.colonia.Name = "colonia"
        Me.colonia.Size = New System.Drawing.Size(140, 23)
        Me.colonia.TabIndex = 14
        '
        'aMaterno
        '
        Me.aMaterno.Location = New System.Drawing.Point(156, 187)
        Me.aMaterno.Name = "aMaterno"
        Me.aMaterno.Size = New System.Drawing.Size(165, 23)
        Me.aMaterno.TabIndex = 13
        '
        'aPaterno
        '
        Me.aPaterno.Location = New System.Drawing.Point(151, 144)
        Me.aPaterno.Name = "aPaterno"
        Me.aPaterno.Size = New System.Drawing.Size(162, 23)
        Me.aPaterno.TabIndex = 12
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(94, 108)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(181, 23)
        Me.nombre.TabIndex = 11
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(82, 72)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(113, 23)
        Me.fecha.TabIndex = 10
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(90, 29)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 23)
        Me.codigo.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.borrar)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.bBuscar)
        Me.TabPage2.Controls.Add(Me.TextBox9)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(672, 398)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONSULTAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(209, 27)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 12
        Me.bBuscar.Text = "BUSCAR"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(103, 28)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 23)
        Me.TextBox9.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "CODIGO:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 282)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 23)
        Me.TextBox1.TabIndex = 32
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 243)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 23)
        Me.TextBox2.TabIndex = 31
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(110, 208)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 23)
        Me.TextBox3.TabIndex = 30
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(169, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(165, 23)
        Me.TextBox4.TabIndex = 29
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(164, 129)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(162, 23)
        Me.TextBox5.TabIndex = 28
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(107, 93)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(181, 23)
        Me.TextBox6.TabIndex = 27
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(95, 57)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(113, 23)
        Me.TextBox7.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "NUMERO DE CASA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "FECHA:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(42, 246)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "CALLE:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(42, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "NOMBRE:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(42, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 15)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "COLONIA:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 15)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "APELLIDO PATERNO:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(42, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 15)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "APELLIDO MATERNO:"
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(185, 329)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(75, 23)
        Me.borrar.TabIndex = 33
        Me.borrar.Text = "BORRAR"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents nombre As TextBox
    Friend WithEvents fecha As TextBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents nCasa As TextBox
    Friend WithEvents calle As TextBox
    Friend WithEvents colonia As TextBox
    Friend WithEvents aMaterno As TextBox
    Friend WithEvents aPaterno As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents borrar As Button
End Class
