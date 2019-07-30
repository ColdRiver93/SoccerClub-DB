Public Class frmAdd
    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnCamp_Click(sender As Object, e As EventArgs) Handles btnCamp.Click
        frmAddCamp.Show()
        Me.Close()
    End Sub

    Private Sub btnEq_Click(sender As Object, e As EventArgs) Handles btnEq.Click
        frmAddEquipo.Show()
        Me.Close()
    End Sub

    Private Sub btnJug_Click(sender As Object, e As EventArgs) Handles btnJug.Click
        frmAddJugador.Show()
        Me.Close()
    End Sub

    Private Sub btnPar_Click(sender As Object, e As EventArgs) Handles btnPar.Click
        frmAddPartido.Show()
        Me.Close()
    End Sub
End Class