<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorreo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCorreo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmisor = New System.Windows.Forms.TextBox()
        Me.txtReceptor = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.rtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbArchivos = New System.Windows.Forms.RichTextBox()
        Me.txtHTML = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "De:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Para:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Asunto:"
        '
        'txtEmisor
        '
        Me.txtEmisor.Location = New System.Drawing.Point(59, 13)
        Me.txtEmisor.Name = "txtEmisor"
        Me.txtEmisor.Size = New System.Drawing.Size(206, 20)
        Me.txtEmisor.TabIndex = 3
        '
        'txtReceptor
        '
        Me.txtReceptor.Location = New System.Drawing.Point(59, 39)
        Me.txtReceptor.Name = "txtReceptor"
        Me.txtReceptor.Size = New System.Drawing.Size(206, 20)
        Me.txtReceptor.TabIndex = 4
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(59, 65)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(206, 20)
        Me.txtAsunto.TabIndex = 5
        '
        'rtbMensaje
        '
        Me.rtbMensaje.Location = New System.Drawing.Point(59, 253)
        Me.rtbMensaje.Name = "rtbMensaje"
        Me.rtbMensaje.Size = New System.Drawing.Size(464, 46)
        Me.rtbMensaje.TabIndex = 6
        Me.rtbMensaje.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEnviar.Location = New System.Drawing.Point(58, 314)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(89, 36)
        Me.BtnEnviar.TabIndex = 7
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contraseña:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(341, 13)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(182, 20)
        Me.txtPassword.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Adjuntar:"
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.Location = New System.Drawing.Point(59, 92)
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.Size = New System.Drawing.Size(414, 20)
        Me.txtRutaArchivo.TabIndex = 11
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(479, 90)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(43, 23)
        Me.btnRuta.TabIndex = 12
        Me.btnRuta.Text = "....."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Archivos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(228, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Mensaje"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(228, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "HTML"
        '
        'rbArchivos
        '
        Me.rbArchivos.Location = New System.Drawing.Point(58, 154)
        Me.rbArchivos.Name = "rbArchivos"
        Me.rbArchivos.Size = New System.Drawing.Size(464, 66)
        Me.rbArchivos.TabIndex = 13
        Me.rbArchivos.Text = ""
        '
        'txtHTML
        '
        Me.txtHTML.Location = New System.Drawing.Point(58, 359)
        Me.txtHTML.Multiline = True
        Me.txtHTML.Name = "txtHTML"
        Me.txtHTML.Size = New System.Drawing.Size(464, 184)
        Me.txtHTML.TabIndex = 18
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FrmCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(535, 567)
        Me.Controls.Add(Me.txtHTML)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbArchivos)
        Me.Controls.Add(Me.btnRuta)
        Me.Controls.Add(Me.txtRutaArchivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.rtbMensaje)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtReceptor)
        Me.Controls.Add(Me.txtEmisor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCorreo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Enviar Correo"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmisor As System.Windows.Forms.TextBox
    Friend WithEvents txtReceptor As System.Windows.Forms.TextBox
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents rtbMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRutaArchivo As System.Windows.Forms.TextBox
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbArchivos As System.Windows.Forms.RichTextBox
    Friend WithEvents txtHTML As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
