Public Class UCOPTION

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub btnAJOP_Click(sender As Object, e As EventArgs) Handles btnAJOP.Click
        Try
            Dim d As New Donnees
            d.connecter()
            d.cmd = d.con.CreateCommand
            d.con.CreateCommand()
            MessageBox.Show("voulez vous ajouter sur le formulaire OPTIONT?", "yesno", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            d.cmd.CommandText = "insert into OPTIONT(IDENTITY_OPTIONT,DESIGNATION_OPTIONT)values( @IDENTITY_OPTIONT,@DESIGNATION_OPTIONT)"
            d.cmd.Parameters.AddWithValue("@IDENTITY_OPTIONT", Me.Text1Opt.Text)
            d.cmd.Parameters.AddWithValue("@DESIGNATION_OPTIONT", Me.TextBox1.Text)
            d.cmd.ExecuteNonQuery()
            d.deconnecter()
            d.remplirDGV("select*from OPTIONT", DgvOpt)
        Catch ex As Exception
            MessageBox.Show("VUEILLEZ SAISIR UNE AUTRE CLES SVP!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        MessageBox.Show("voulez vous ajouter sur le formulaire OPTIONT?", "yesno", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        d.cmd.CommandText = "UPDATE OPTIONT SET DESIGNATION_OPTIONT=@DESIGNATION_OPTIONT where IDENTITY_OPTIONT=@IDENTITY_OPTIONT"
        d.cmd.Parameters.AddWithValue("@IDENTITY_OPTIONT", Me.Text1Opt.Text)
        d.cmd.Parameters.AddWithValue("@DESIGNATION_OPTIONT", Me.TextBox1.Text)
        d.cmd.ExecuteNonQuery()
        d.deconnecter()
        d.remplirDGV("select*from OPTIONT", DgvOpt)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        MessageBox.Show("voulez vous ajouter sur le formulaire OPTIONT?", "yesno", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        d.cmd.CommandText = "DELETE OPTIONT where IDENTITY_OPTIONT=@IDENTITY_OPTIONT"
        d.cmd.Parameters.AddWithValue("@IDENTITY_OPTIONT", Me.Text1Opt.Text)
        ' d.cmd.Parameters.AddWithValue("@DESIGNATION_OPTIONT", Me.cboOption.Text)
        d.cmd.ExecuteNonQuery()
        d.deconnecter()
        d.remplirDGV("select*from OPTIONT", DgvOpt)
    End Sub

    Private Sub Text1Opt_TextChanged(sender As Object, e As EventArgs) Handles Text1Opt.TextChanged, TextBox1.TextChanged, TextBox2.TextChanged
        Dim d As New Donnees
        d.recherche(DgvOpt, TextBox2.Text, "select * from OPTIONT where  DESIGNATION_OPTIONT like '%" + TextBox2.Text + "%'")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Text1Opt.Text = ""
        Me.TextBox1.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class