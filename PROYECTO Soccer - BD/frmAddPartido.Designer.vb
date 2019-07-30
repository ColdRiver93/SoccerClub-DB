<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPartido
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
        Me.txtCodP = New System.Windows.Forms.TextBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtGE2 = New System.Windows.Forms.TextBox()
        Me.txtGE1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbCampP = New System.Windows.Forms.ComboBox()
        Me.btnAddP = New System.Windows.Forms.Button()
        Me.btnReg5 = New System.Windows.Forms.Button()
        Me.dtpFP = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbEQ1 = New System.Windows.Forms.ComboBox()
        Me.cbEQ2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtCodP
        '
        Me.txtCodP.Location = New System.Drawing.Point(166, 248)
        Me.txtCodP.Name = "txtCodP"
        Me.txtCodP.Size = New System.Drawing.Size(98, 20)
        Me.txtCodP.TabIndex = 1
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(166, 274)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Size = New System.Drawing.Size(98, 20)
        Me.txtRes.TabIndex = 2
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(166, 215)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(98, 20)
        Me.txtDes.TabIndex = 3
        '
        'txtGE2
        '
        Me.txtGE2.Location = New System.Drawing.Point(166, 177)
        Me.txtGE2.Name = "txtGE2"
        Me.txtGE2.Size = New System.Drawing.Size(98, 20)
        Me.txtGE2.TabIndex = 4
        '
        'txtGE1
        '
        Me.txtGE1.Location = New System.Drawing.Point(166, 126)
        Me.txtGE1.Name = "txtGE1"
        Me.txtGE1.Size = New System.Drawing.Size(98, 20)
        Me.txtGE1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Equipo 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Campeonato"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Codigo de partido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Goles de Eq2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Goles de Eq1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Equipo 2 "
        '
        'cbCampP
        '
        Me.cbCampP.FormattingEnabled = True
        Me.cbCampP.Location = New System.Drawing.Point(477, 126)
        Me.cbCampP.Name = "cbCampP"
        Me.cbCampP.Size = New System.Drawing.Size(164, 21)
        Me.cbCampP.TabIndex = 15
        '
        'btnAddP
        '
        Me.btnAddP.Location = New System.Drawing.Point(378, 177)
        Me.btnAddP.Name = "btnAddP"
        Me.btnAddP.Size = New System.Drawing.Size(133, 57)
        Me.btnAddP.TabIndex = 16
        Me.btnAddP.Text = "ANADIR"
        Me.btnAddP.UseVisualStyleBackColor = True
        '
        'btnReg5
        '
        Me.btnReg5.Location = New System.Drawing.Point(626, 178)
        Me.btnReg5.Name = "btnReg5"
        Me.btnReg5.Size = New System.Drawing.Size(133, 57)
        Me.btnReg5.TabIndex = 17
        Me.btnReg5.Text = "REGRESAR"
        Me.btnReg5.UseVisualStyleBackColor = True
        '
        'dtpFP
        '
        Me.dtpFP.CustomFormat = "yyyy-MM-dd"
        Me.dtpFP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFP.Location = New System.Drawing.Point(457, 39)
        Me.dtpFP.Name = "dtpFP"
        Me.dtpFP.Size = New System.Drawing.Size(156, 20)
        Me.dtpFP.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(395, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha"
        '
        'cbEQ1
        '
        Me.cbEQ1.FormattingEnabled = True
        Me.cbEQ1.Location = New System.Drawing.Point(128, 32)
        Me.cbEQ1.Name = "cbEQ1"
        Me.cbEQ1.Size = New System.Drawing.Size(125, 21)
        Me.cbEQ1.TabIndex = 20
        '
        'cbEQ2
        '
        Me.cbEQ2.FormattingEnabled = True
        Me.cbEQ2.Location = New System.Drawing.Point(128, 74)
        Me.cbEQ2.Name = "cbEQ2"
        Me.cbEQ2.Size = New System.Drawing.Size(125, 21)
        Me.cbEQ2.TabIndex = 21
        '
        'frmAddPartido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbEQ2)
        Me.Controls.Add(Me.cbEQ1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFP)
        Me.Controls.Add(Me.btnReg5)
        Me.Controls.Add(Me.btnAddP)
        Me.Controls.Add(Me.cbCampP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGE1)
        Me.Controls.Add(Me.txtGE2)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtCodP)
        Me.Name = "frmAddPartido"
        Me.Text = "frmAddPartido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodP As TextBox
    Friend WithEvents txtRes As TextBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents txtGE2 As TextBox
    Friend WithEvents txtGE1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbCampP As ComboBox
    Friend WithEvents btnAddP As Button
    Friend WithEvents btnReg5 As Button
    Friend WithEvents dtpFP As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cbEQ1 As ComboBox
    Friend WithEvents cbEQ2 As ComboBox
End Class
