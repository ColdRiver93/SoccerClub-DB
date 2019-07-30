<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEquipo
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
        Me.txtNE = New System.Windows.Forms.TextBox()
        Me.txtPJE = New System.Windows.Forms.TextBox()
        Me.txtRep = New System.Windows.Forms.TextBox()
        Me.txtCE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCamp = New System.Windows.Forms.ComboBox()
        Me.btnAddE = New System.Windows.Forms.Button()
        Me.btnReg3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNE
        '
        Me.txtNE.Location = New System.Drawing.Point(240, 76)
        Me.txtNE.Name = "txtNE"
        Me.txtNE.Size = New System.Drawing.Size(121, 20)
        Me.txtNE.TabIndex = 0
        '
        'txtPJE
        '
        Me.txtPJE.Location = New System.Drawing.Point(240, 210)
        Me.txtPJE.Name = "txtPJE"
        Me.txtPJE.Size = New System.Drawing.Size(121, 20)
        Me.txtPJE.TabIndex = 1
        '
        'txtRep
        '
        Me.txtRep.Location = New System.Drawing.Point(240, 160)
        Me.txtRep.Name = "txtRep"
        Me.txtRep.Size = New System.Drawing.Size(121, 20)
        Me.txtRep.TabIndex = 2
        '
        'txtCE
        '
        Me.txtCE.Location = New System.Drawing.Point(240, 113)
        Me.txtCE.Name = "txtCE"
        Me.txtCE.Size = New System.Drawing.Size(121, 20)
        Me.txtCE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Codigo equipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Representante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Partidos Jugados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Campeonato"
        '
        'cbCamp
        '
        Me.cbCamp.FormattingEnabled = True
        Me.cbCamp.Location = New System.Drawing.Point(575, 143)
        Me.cbCamp.Name = "cbCamp"
        Me.cbCamp.Size = New System.Drawing.Size(171, 21)
        Me.cbCamp.TabIndex = 9
        '
        'btnAddE
        '
        Me.btnAddE.Location = New System.Drawing.Point(543, 58)
        Me.btnAddE.Name = "btnAddE"
        Me.btnAddE.Size = New System.Drawing.Size(146, 55)
        Me.btnAddE.TabIndex = 10
        Me.btnAddE.Text = "ANADIR"
        Me.btnAddE.UseVisualStyleBackColor = True
        '
        'btnReg3
        '
        Me.btnReg3.Location = New System.Drawing.Point(543, 196)
        Me.btnReg3.Name = "btnReg3"
        Me.btnReg3.Size = New System.Drawing.Size(146, 55)
        Me.btnReg3.TabIndex = 11
        Me.btnReg3.Text = "REGRESAR"
        Me.btnReg3.UseVisualStyleBackColor = True
        '
        'frmAddEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReg3)
        Me.Controls.Add(Me.btnAddE)
        Me.Controls.Add(Me.cbCamp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCE)
        Me.Controls.Add(Me.txtRep)
        Me.Controls.Add(Me.txtPJE)
        Me.Controls.Add(Me.txtNE)
        Me.Name = "frmAddEquipo"
        Me.Text = "frmAddEquipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNE As TextBox
    Friend WithEvents txtPJE As TextBox
    Friend WithEvents txtRep As TextBox
    Friend WithEvents txtCE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbCamp As ComboBox
    Friend WithEvents btnAddE As Button
    Friend WithEvents btnReg3 As Button
End Class
