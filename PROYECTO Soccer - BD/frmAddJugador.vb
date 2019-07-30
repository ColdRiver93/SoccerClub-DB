Public Class frmAddJugador
    Private Sub btnReg4_Click(sender As Object, e As EventArgs) Handles btnReg4.Click
        frmAdd.Show()
        Me.Close()
    End Sub
    Public con As New Odbc.OdbcConnection

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
        cargacombo2()
    End Sub
    Private Sub cargacombo2()
        Dim sSQL1 As String

        sSQL1 = "SELECT DISTINCT nombre FROM campeonato"
        Dim cmd1 As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd1.CommandText = sSQL1
        cmd1.Connection = con
        dr = cmd1.ExecuteReader()
        While dr.Read()
            cbCamp1.Items.Add(dr(0))
        End While
    End Sub

    Private Sub cargacombo3()
        Dim sSQL2 As String

        sSQL2 = "SELECT DISTINCT nombre FROM equipo where cod_camp = "
        sSQL2 = sSQL2 + " (" + "SELECT cod_camp FROM campeonato WHERE nombre = " + " '" + cbCamp1.Text + "')"
        Dim cmd2 As New Odbc.OdbcCommand
        Dim dr1 As Odbc.OdbcDataReader
        cmd2.CommandText = sSQL2
        cmd2.Connection = con
        dr1 = cmd2.ExecuteReader()
        While dr1.Read()
            cbEq.Items.Add(dr1(0))
        End While
    End Sub

    Private Sub btnAddJ_Click(sender As Object, e As EventArgs) Handles btnAddJ.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand

        Try
            sSQL = "INSERT INTO jugador VALUES ("
            sSQL = sSQL + " '" + txtNJ.Text + "', "
            sSQL = sSQL + " '" + txtCJ.Text + "', "
            sSQL = sSQL + " '" + txtEmail.Text + "',"
            sSQL = sSQL + " (" + "SELECT cod_camp FROM campeonato WHERE nombre = " + " '" + cbCamp1.Text + "'),"
            sSQL = sSQL + " (" + "SELECT cod_equipo FROM equipo WHERE nombre = " + " '" + cbEq.Text + "'),"
            sSQL = sSQL + " '" + txtCI.Text + "'"
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        Catch
            MsgBox(" Error: " + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió un jugador")
        txtCI.ResetText()
        txtCJ.ResetText()
        txtEmail.ResetText()
        txtNJ.ResetText()
        cbEq.ResetText()
        cbCamp1.ResetText()

    End Sub

    Private Sub cbCamp1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCamp1.SelectedIndexChanged
        cbEq.Items.Clear()
        cargacombo3()
    End Sub
End Class