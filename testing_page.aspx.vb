Imports System.Data.SqlClient
'Imports System.Configuration
Public Class testing_page

    Inherits System.Web.UI.Page

    Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("con_string").ConnectionString)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn1_Click(sender As Object, e As EventArgs)
        Dim q1 As String = "insert into table1 values(@nm1)"
        Dim cmd As New SqlCommand(q1, con)
        cmd.Parameters.AddWithValue("@nm1", txt1.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class