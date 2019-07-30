<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVer
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
        Me.btnVerIm = New System.Windows.Forms.Button()
        Me.btnVerDatos = New System.Windows.Forms.Button()
        Me.btnReg1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVerIm
        '
        Me.btnVerIm.Location = New System.Drawing.Point(75, 116)
        Me.btnVerIm.Name = "btnVerIm"
        Me.btnVerIm.Size = New System.Drawing.Size(201, 78)
        Me.btnVerIm.TabIndex = 0
        Me.btnVerIm.Text = "IMPACTO"
        Me.btnVerIm.UseVisualStyleBackColor = True
        '
        'btnVerDatos
        '
        Me.btnVerDatos.Location = New System.Drawing.Point(533, 116)
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Size = New System.Drawing.Size(201, 78)
        Me.btnVerDatos.TabIndex = 1
        Me.btnVerDatos.Text = "DATOS"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'btnReg1
        '
        Me.btnReg1.Location = New System.Drawing.Point(344, 218)
        Me.btnReg1.Name = "btnReg1"
        Me.btnReg1.Size = New System.Drawing.Size(154, 88)
        Me.btnReg1.TabIndex = 2
        Me.btnReg1.Text = "REGRESAR"
        Me.btnReg1.UseVisualStyleBackColor = True
        '
        'frmVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReg1)
        Me.Controls.Add(Me.btnVerDatos)
        Me.Controls.Add(Me.btnVerIm)
        Me.Name = "frmVer"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVerIm As Button
    Friend WithEvents btnVerDatos As Button
    Friend WithEvents btnReg1 As Button
End Class
