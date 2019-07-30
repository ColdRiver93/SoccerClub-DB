Public Class frmAddPartido
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
        cargacombo()
    End Sub
    Private Sub cargaequipos()
        Dim sSQL2 As String

        sSQL2 = "SELECT DISTINCT nombre FROM equipo where cod_camp = "
        sSQL2 = sSQL2 + " (" + "SELECT cod_camp FROM campeonato WHERE nombre = " + " '" + cbCampP.Text + "')"
        Dim cmdx As New Odbc.OdbcCommand
        Dim drx As Odbc.OdbcDataReader
        cmdx.CommandText = sSQL2
        cmdx.Connection = con
        drx = cmdx.ExecuteReader()
        While drx.Read()
            cbEQ1.Items.Add(drx(0))
            cbEQ2.Items.Add(drx(0))
        End While
    End Sub
    Private Sub btnReg5_Click(sender As Object, e As EventArgs) Handles btnReg5.Click
        frmAdd.Show()
        Me.Close()
    End Sub

    Private Sub cargacombo()
        Dim sSQL1 As String

        sSQL1 = "SELECT nombre FROM campeonato "
        Dim cmd1 As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd1.CommandText = sSQL1
        cmd1.Connection = con
        dr = cmd1.ExecuteReader()
        While dr.Read()
            cbCampP.Items.Add(dr(0))
        End While
    End Sub

    Private Sub btnAddP_Click(sender As Object, e As EventArgs) Handles btnAddP.Click
        If cbEQ1.Text = cbEQ2.Text Then
            MsgBox("No puede ingresar el mismo equipo")
            Exit Sub
            Me.Show()
        End If
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand

        Try
            sSQL = "INSERT INTO partido VALUES ("
            sSQL = sSQL + " (" + "SELECT cod_equipo FROM equipo WHERE nombre = " + " '" + cbEQ1.Text + "' " + "AND cod_camp= (SELECT cod_camp FROM campeonato WHERE nombre = " + " '" + cbCampP.Text + "')) ,"
            sSQL = sSQL + " (" + "SELECT cod_equipo FROM equipo WHERE nombre = " + " '" + cbEQ2.Text + "' " + "AND cod_camp= (SELECT cod_camp FROM campeonato WHERE nombre = " + " '" + cbCampP.Text + "')) ,"
            sSQL = sSQL + txtGE1.Text + ", "
            sSQL = sSQL + txtGE2.Text + ", "
            sSQL = sSQL + " (" + "SELECT cod_camp FROM campeonato WHERE nombre = " + " '" + cbCampP.Text + "'),"
            sSQL = sSQL + " '" + txtDes.Text + "', "
            sSQL = sSQL + " '" + txtCodP.Text + "', "
            sSQL = sSQL + " '" + txtRes.Text + "' "
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("No vale " + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió un partido")
        cbEQ1.ResetText()
        cbEQ2.ResetText()
        cbCampP.ResetText()
        txtGE1.ResetText()
        txtGE2.ResetText()
        txtDes.ResetText()
        txtCodP.ResetText()
        txtRes.ResetText()
    End Sub

    Private Sub cbCampP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCampP.SelectedIndexChanged
        cbEQ1.Items.Clear()
        cbEQ2.Items.Clear()
        cargaequipos()
    End Sub

    Private Sub txtGE1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGE1.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = e.KeyChar
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub
    Private Sub txtGE2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGE2.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = e.KeyChar
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

End Class