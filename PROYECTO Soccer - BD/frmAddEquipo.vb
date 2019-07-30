Public Class frmAddEquipo
    Private Sub btnReg3_Click(sender As Object, e As EventArgs) Handles btnReg3.Click
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
        cargacombo1()
    End Sub
    Private Sub cargacombo1()
        Dim sSQL1 As String

        sSQL1 = "SELECT nombre FROM campeonato "
        Dim cmd1 As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd1.CommandText = sSQL1
        cmd1.Connection = con
        dr = cmd1.ExecuteReader()
        While dr.Read()
            cbCamp.Items.Add(dr(0))
        End While
    End Sub
    Private Sub btnAddE_Click(sender As Object, e As EventArgs) Handles btnAddE.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand

        Try
            sSQL = "INSERT INTO equipo VALUES ("
            sSQL = sSQL + " '" + txtNE.Text + "', "
            sSQL = sSQL + " (" + "SELECT cod_camp FROM campeonato WHERE nombre = " + " '" + cbCamp.Text + "'),"
            sSQL = sSQL + " '" + txtCE.Text + "', "
            sSQL = sSQL + " '" + txtRep.Text + "', "
            sSQL = sSQL + txtPJE.Text
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Class Form1 --> Funcion btnAdd_Click:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió un equipo")
        txtNE.ResetText()
        txtCE.ResetText()
        txtPJE.ResetText()
        txtRep.ResetText()
        cbCamp.ResetText()
    End Sub
End Class