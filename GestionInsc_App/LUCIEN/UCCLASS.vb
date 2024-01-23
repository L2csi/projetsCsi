Public Class UCCLASS

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim d As New Donnees
            d.connecter()
            d.cmd = d.con.CreateCommand
            d.con.CreateCommand()
            d.cmd.CommandText = "insert into CLASSE(REFERENCE_CLASSE,DESIGNATION_CLASSE,IDENTITY_OPTIONT)values (@REFERENCE_CLASSE,@DESIGNATION_CLASSE,@IDENTITY_OPTIONT)"
            d.cmd.Parameters.AddWithValue("@REFERENCE_CLASSE", Me.TextCLA.Text)
            d.cmd.Parameters.AddWithValue("@DESIGNATION_CLASSE", Me.TextCLA2.Text)
            d.cmd.Parameters.AddWithValue("@IDENTITY_OPTIONT", Me.TextBox3CLAS.Text)
            d.cmd.ExecuteNonQuery()
            d.deconnecter()
            d.remplirDGV("select*from CLASSE", dgvCLAS)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        MessageBox.Show("voulez vous modifier le nom de l'élève?", "yesno", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        d.cmd.CommandText = " UPDATE CLASSE SET DESIGNATION_CLASSE=@DESIGNATION_CLASSE,IDENTITY_OPTIONT=@IDENTITY_OPTIONT where REFERENCE_CLASSE=@REFERENCE_CLASSE"
        d.cmd.Parameters.AddWithValue("@REFERENCE_CLASSE", Me.TextCLA.Text)
        d.cmd.Parameters.AddWithValue("@DESIGNATION_CLASSE", Me.TextCLA2.Text)
        d.cmd.Parameters.AddWithValue("@IDENTITY_OPTIONT", Me.TextBox3CLAS.Text)
        d.cmd.ExecuteNonQuery()
        d.deconnecter()
        d.remplirDGV("select*from CLASSE", dgvCLAS)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        MessageBox.Show("voulez vous supprimer un eleve?", "yesno", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        d.cmd.CommandText = "DELETE CLASSE  WHERE REFERENCE_CLASSE=@REFERENCE_CLASSE "
        d.cmd.Parameters.AddWithValue("@REFERENCE_CLASSE", Me.TextCLA.Text)
        d.cmd.Parameters.AddWithValue("@DESIGNATION_CLASSE", Me.TextCLA2.Text)
        d.cmd.Parameters.AddWithValue("@IDENTITY_OPTIONT", Me.TextBox3CLAS.Text)
        d.cmd.ExecuteNonQuery()
        d.deconnecter()
        d.remplirDGV("select*from CLASSE", dgvCLAS)
    End Sub
End Class
