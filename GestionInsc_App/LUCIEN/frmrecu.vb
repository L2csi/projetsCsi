Public Class frmrecu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        If TextBox1.Text = "" Then
            MessageBox.Show("saisir la reference svp")
        Else
            Dim d As New Donnees
            Dim rec As New CrystalReport5
            Try
                d.con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=GESTIONINSCRIPTION;Integrated Security=True")
                d.con.Open()
                d.da = New SqlClient.SqlDataAdapter("select * from recu where REFERENCE_INSCRIPTION='" + TextBox1.Text + "'", d.con)
                d.da.Fill(d.ds, "lucien")
                rec.SetDataSource(d.ds.Tables("lucien"))
                CrystalReportViewer1.ReportSource = rec
                CrystalReportViewer1.Refresh()
                d.con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub frmrecu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class