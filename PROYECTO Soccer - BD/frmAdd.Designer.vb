<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.btnCamp = New System.Windows.Forms.Button()
        Me.btnEq = New System.Windows.Forms.Button()
        Me.btnPar = New System.Windows.Forms.Button()
        Me.btnJug = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCamp
        '
        Me.btnCamp.Location = New System.Drawing.Point(74, 60)
        Me.btnCamp.Name = "btnCamp"
        Me.btnCamp.Size = New System.Drawing.Size(186, 69)
        Me.btnCamp.TabIndex = 0
        Me.btnCamp.Text = "CAMPEONATO"
        Me.btnCamp.UseVisualStyleBackColor = True
        '
        'btnEq
        '
        Me.btnEq.Location = New System.Drawing.Point(74, 193)
        Me.btnEq.Name = "btnEq"
        Me.btnEq.Size = New System.Drawing.Size(186, 69)
        Me.btnEq.TabIndex = 1
        Me.btnEq.Text = "EQUIPO"
        Me.btnEq.UseVisualStyleBackColor = True
        '
        'btnPar
        '
        Me.btnPar.Location = New System.Drawing.Point(544, 71)
        Me.btnPar.Name = "btnPar"
        Me.btnPar.Size = New System.Drawing.Size(186, 69)
        Me.btnPar.TabIndex = 2
        Me.btnPar.Text = "PARTIDO"
        Me.btnPar.UseVisualStyleBackColor = True
        '
        'btnJug
        '
        Me.btnJug.Location = New System.Drawing.Point(557, 214)
        Me.btnJug.Name = "btnJug"
        Me.btnJug.Size = New System.Drawing.Size(186, 69)
        Me.btnJug.TabIndex = 3
        Me.btnJug.Text = "JUGADOR"
        Me.btnJug.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(343, 150)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(123, 88)
        Me.btnReg.TabIndex = 4
        Me.btnReg.Text = "REGRESAR"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnJug)
        Me.Controls.Add(Me.btnPar)
        Me.Controls.Add(Me.btnEq)
        Me.Controls.Add(Me.btnCamp)
        Me.Name = "frmAdd"
        Me.Text = "Agregar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCamp As Button
    Friend WithEvents btnEq As Button
    Friend WithEvents btnPar As Button
    Friend WithEvents btnJug As Button
    Friend WithEvents btnReg As Button
End Class
