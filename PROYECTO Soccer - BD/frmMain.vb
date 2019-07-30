Public Class frmMain
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
        MsgBox("GG")
    End Sub

    Public Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAdd.Show()
        Me.Close()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        frmVer.Show()
        Me.Close()
    End Sub
End Class
