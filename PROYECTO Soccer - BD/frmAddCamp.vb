Public Class frmAddCamp
    Dim con As New Odbc.OdbcConnection
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strCon As String
        strCon = "Driver={PostgreSQL ANSI};"
        strCon = strCon + "database=proyecto;"
        strCon = strCon + "server=localhost;"
        strCon = strCon + "port=5432;"
        strCon = strCon + "uid=postgres;"
        strCon = strCon + "pwd=1234;"

        con.ConnectionString = strCon
        con.Open()

    End Sub
    Private Sub btnReg2_Click(sender As Object, e As EventArgs) Handles btnReg2.Click
        frmAdd.Show()
        Me.Close()
    End Sub

    Public Sub btnAddC_Click(sender As Object, e As EventArgs) Handles btnAddC.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand

        Try
            sSQL = "INSERT INTO campeonato VALUES ("
            sSQL = sSQL + " '" + txtNomC.Text + "', "
            sSQL = sSQL + " '" + txtMJ.Text + "', "
            sSQL = sSQL + " '" + txtPrim.Text + "', "
            sSQL = sSQL + " '" + txtSeg.Text + "', "
            sSQL = sSQL + " '" + txtTer.Text + "', "
            sSQL = sSQL + " '" + txtGd.Text + "', "
            sSQL = sSQL + " '" + txtCc.Text + "', "
            sSQL = sSQL + " '" + dtpFI.Text + "', "
            sSQL = sSQL + " '" + dtpFF.Text + "' "
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("No vale " + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió un campeonato")
        txtCc.ResetText()
        txtGd.ResetText()
        txtMJ.ResetText()
        txtNomC.ResetText()
        txtPrim.ResetText()
        txtSeg.ResetText()
        txtTer.ResetText()
        dtpFF.ResetText()
        dtpFI.ResetText()

    End Sub
End Class