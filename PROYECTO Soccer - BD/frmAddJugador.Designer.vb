<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddJugador
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
        Me.txtNJ = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCJ = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCamp1 = New System.Windows.Forms.ComboBox()
        Me.cbEq = New System.Windows.Forms.ComboBox()
        Me.btnAddJ = New System.Windows.Forms.Button()
        Me.btnReg4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNJ
        '
        Me.txtNJ.Location = New System.Drawing.Point(179, 44)
        Me.txtNJ.Name = "txtNJ"
        Me.txtNJ.Size = New System.Drawing.Size(104, 20)
        Me.txtNJ.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(179, 202)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(104, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtCJ
        '
        Me.txtCJ.Location = New System.Drawing.Point(179, 150)
        Me.txtCJ.Name = "txtCJ"
        Me.txtCJ.Size = New System.Drawing.Size(104, 20)
        Me.txtCJ.TabIndex = 2
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(179, 95)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(104, 20)
        Me.txtCI.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Equipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Campeonato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Correo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cedula"
        '
        'cbCamp1
        '
        Me.cbCamp1.FormattingEnabled = True
        Me.cbCamp1.Location = New System.Drawing.Point(443, 30)
        Me.cbCamp1.Name = "cbCamp1"
        Me.cbCamp1.Size = New System.Drawing.Size(160, 21)
        Me.cbCamp1.TabIndex = 10
        '
        'cbEq
        '
        Me.cbEq.FormattingEnabled = True
        Me.cbEq.Location = New System.Drawing.Point(443, 110)
        Me.cbEq.Name = "cbEq"
        Me.cbEq.Size = New System.Drawing.Size(160, 21)
        Me.cbEq.TabIndex = 11
        '
        'btnAddJ
        '
        Me.btnAddJ.Location = New System.Drawing.Point(384, 185)
        Me.btnAddJ.Name = "btnAddJ"
        Me.btnAddJ.Size = New System.Drawing.Size(143, 80)
        Me.btnAddJ.TabIndex = 12
        Me.btnAddJ.Text = "ANADIR"
        Me.btnAddJ.UseVisualStyleBackColor = True
        '
        'btnReg4
        '
        Me.btnReg4.Location = New System.Drawing.Point(617, 178)
        Me.btnReg4.Name = "btnReg4"
        Me.btnReg4.Size = New System.Drawing.Size(143, 80)
        Me.btnReg4.TabIndex = 13
        Me.btnReg4.Text = "REGRESAR"
        Me.btnReg4.UseVisualStyleBackColor = True
        '
        'frmAddJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReg4)
        Me.Controls.Add(Me.btnAddJ)
        Me.Controls.Add(Me.cbEq)
        Me.Controls.Add(Me.cbCamp1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.txtCJ)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNJ)
        Me.Name = "frmAddJugador"
        Me.Text = "frmAddJugador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNJ As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCJ As TextBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbCamp1 As ComboBox
    Friend WithEvents cbEq As ComboBox
    Friend WithEvents btnAddJ As Button
    Friend WithEvents btnReg4 As Button
End Class
