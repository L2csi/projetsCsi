Public Class UCINSCRIPTION

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        d.remplirDGV("select*from INSCRIPTION", DGVINSCRI)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.txtID_INSCRIT.Text = ""
        Me.TextCLAINSCRIT.Text = ""
        Me.TextELE.Text = ""
        Me.TextMONTINSCRIT.Text = ""
        Me.TextDATEINSCRIT.Text = ""
        Me.TextANNSCOLAIRE.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim d As New Donnees
            d.connecter()
            d.cmd = d.con.CreateCommand
            d.con.CreateCommand()
            d.cmd.CommandText = "insert into INSCRIPTION (REFERENCE_INSCRIPTION,ANNEE_SCOLAIRE,DATE_INSCRIPTION,MONTANT_INSCRIPTION,REFERENCE_CLASSE,MATRICUL_ELEVE)values(@REFERENCE_INSCRIPTION,@ANNEE_SCOLAIRE,@DATE_INSCRIPTION,@MONTANT_INSCRIPTION,@REFERENCE_CLASSE,@MATRICUL_ELEVE)"
            d.cmd.Parameters.AddWithValue("@REFERENCE_INSCRIPTION", Me.txtID_INSCRIT.Text)
            d.cmd.Parameters.AddWithValue("@ANNEE_SCOLAIRE", Me.TextANNSCOLAIRE.Text)
            d.cmd.Parameters.AddWithValue("@DATE_INSCRIPTION", Me.TextDATEINSCRIT.Text)
            d.cmd.Parameters.AddWithValue("@MONTANT_INSCRIPTION", Me.TextMONTINSCRIT.Text)
            d.cmd.Parameters.AddWithValue("@REFERENCE_CLASSE", Me.TextCLAINSCRIT.Text)
            d.cmd.Parameters.AddWithValue("@MATRICUL_ELEVE", Me.TextELE.Text)
            d.cmd.ExecuteNonQuery()
            d.deconnecter()
            d.remplirDGV("select*from INSCRIPTION", DGVINSCRI)
        Catch ex As Exception
            MessageBox.Show("VUEILLEZ SAISIR  TOUS LE CHAMP SVP! LA BONNE INFORMATION")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim d As New Donnees
            d.connecter()
            d.cmd = d.con.CreateCommand
            d.con.CreateCommand()
            d.cmd.CommandText = "delete INSCRIPTION where REFERENCE_INSCRIPTION= @REFERENCE_INSCRIPTION"
            d.cmd.Parameters.AddWithValue("@REFERENCE_INSCRIPTION", Me.txtID_INSCRIT.Text)
            d.cmd.ExecuteNonQuery()
            d.deconnecter()
            d.remplirDGV("select*from ELEVE", DGVINSCRI)
            MessageBox.Show("bien supprimer")
        Catch ex As Exception
            MessageBox.Show(" vueillez ajouter une cles svp")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        MessageBox.Show("voulez vous ajouter sur le formulaire cet eleve?", "yesno", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        d.cmd.CommandText = "UPDATE INSCRIPTION SET ANNEE_SCOLAIRE=@ANNEE_SCOLAIRE,DATE_INSCRIPTION=@DATE_INSCRIPTION,MONTANT_INSCRIPTION=@MONTANT_INSCRIPTION,REFERENCE_CLASSE=@REFERENCE_CLASSE,MATRICUL_ELEVE=@MATRICUL_ELEVE where REFERENCE_INSCRIPTION=@REFERENCE_INSCRIPTION"
        d.cmd.Parameters.AddWithValue("@REFERENCE_INSCRIPTION", Me.txtID_INSCRIT.Text)
        d.cmd.Parameters.AddWithValue("@ANNEE_SCOLAIRE", Me.TextANNSCOLAIRE.Text)
        d.cmd.Parameters.AddWithValue("@DATE_INSCRIPTION", Me.TextDATEINSCRIT.Text)
        d.cmd.Parameters.AddWithValue("@MONTANT_INSCRIPTION", Me.TextMONTINSCRIT.Text)
        d.cmd.Parameters.AddWithValue("@REFERENCE_CLASSE", Me.TextCLAINSCRIT.Text)
        d.cmd.Parameters.AddWithValue("@MATRICUL_ELEVE", Me.TextELE.Text)
        d.cmd.ExecuteNonQuery()
        d.deconnecter()
        d.remplirDGV("select*from INSCRIPTION", DGVINSCRI)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Dim rt As New Donnees
        'rt.recherche(DGVINSCRI, TextBox1.Text, )
    End Sub
End Class
