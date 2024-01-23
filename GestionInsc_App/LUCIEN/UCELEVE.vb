
Public Class UCELEVE

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        Me.TextBox1.Text = DGV1.CurrentRow.Cells(0).Value.ToString
        Me.TextBox2.Text = DGV1.CurrentRow.Cells(1).Value.ToString
        Me.TextBox3.Text = DGV1.CurrentRow.Cells(2).Value.ToString
        Me.TextBox4.Text = DGV1.CurrentRow.Cells(3).Value.ToString
        Me.ComboBox1.Text = DGV1.CurrentRow.Cells(4).Value.ToString
        Me.TextBox5.Text = DGV1.CurrentRow.Cells(5).Value.ToString
        Me.TextBox6.Text = DGV1.CurrentRow.Cells(6).Value.ToString
        Me.TextBox7.Text = DGV1.CurrentRow.Cells(7).Value.ToString
        Me.TextBox8.Text = DGV1.CurrentRow.Cells(8).Value.ToString
    End Sub

    Private Sub BTNQUITTER_Click(sender As Object, e As EventArgs) Handles BTNQUITTER.Click
        Me.Hide()
    End Sub

    Private Sub BtnAJouter_Click(sender As Object, e As EventArgs) Handles BtnAJouter.Click
        ' Dim check As Boolean = False
        If (TextBox1.Text = "") Then
            MessageBox.Show("veillez saisir tous le champ")
            Dim v
            v = CreateObject("SAPI.SPvoice")
            v.speak("veillez saisir tous le champ")
        Else
            ' For i As Integer = 0 To (DGV1.RowCount - 1)
            'If (TextBox2.Text = DGV1.Rows(i).Cells("nom").Value.ToString()) Then
            ' check = False
            ' El() 'se
            ' check = True
            '  End If
            '  If (check = True) Then
            Try
                Dim d As New Donnees
                d.connecter()
                d.cmd = d.con.CreateCommand
                d.con.CreateCommand()
                d.cmd.CommandText = "insert into ELEVE(MATRICUL_ELEVE,NOM,POST_NOM,PRENOM ,SEXE,NOM_DU_PERE,NOM_DELA_MERE,DATE_DE_NAISSANCE,LIEU_DE_NAISSANCE ) values(@MATRICUL_ELEVE,@NOM,@POST_NOM,@PRENOM,@SEXE,@NOM_DU_PERE,@NOM_DELA_MERE,@DATE_DE_NAISSANCE,@LIEU_DE_NAISSANCE)"
                Dim Message As MsgBoxResult = MsgBox("voulez vous enregistrer ? " & TextBox1.Text, MsgBoxStyle.YesNo, "Message")
                d.cmd.Parameters.AddWithValue("@MATRICUL_ELEVE", Me.TextBox1.Text)
                d.cmd.Parameters.AddWithValue("@NOM", Me.TextBox2.Text)
                d.cmd.Parameters.AddWithValue("@POST_NOM", Me.TextBox3.Text)
                d.cmd.Parameters.AddWithValue("@PRENOM", Me.TextBox4.Text)
                d.cmd.Parameters.AddWithValue("@SEXE", Me.ComboBox1.Text)
                d.cmd.Parameters.AddWithValue("@NOM_DU_PERE", Me.TextBox5.Text)
                d.cmd.Parameters.AddWithValue("@NOM_DELA_MERE", Me.TextBox6.Text)
                d.cmd.Parameters.AddWithValue("@DATE_DE_NAISSANCE", Me.TextBox8.Text)
                d.cmd.Parameters.AddWithValue("@LIEU_DE_NAISSANCE", Me.TextBox7.Text)
                d.cmd.ExecuteNonQuery()
                d.deconnecter()
                d.remplirDGV("select*from ELEVE ", DGV1)
                Dim vc
                vc = CreateObject("SAPI.SPvoice")
                vc.Speak("VERY GOOD,VERY GOOD,okey soon   CAN YOU speak french? PLEASE ")
            Catch ex As Exception
                Dim v
                v = CreateObject("SAPI.SPvoice")
                v.speak("vueillez enregistrer une autre personne svp!")
            End Try
            ' Else
            'MessageBox.Show(" Ce nom existe deja")
            'End If
            'Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        Dim v
        v = CreateObject("SAPI.SPvoice")
        v.speak("voulez vous modifié les informations élève?")
        MessageBox.Show("voulez vous modifié les informations eleve?", "yesno", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        d.cmd.CommandText = " UPDATE ELEVE SET NOM=@NOM,POST_NOM=@POST_NOM,PRENOM=@PRENOM,SEXE=@SEXE,NOM_DU_PERE=@NOM_DU_PERE,NOM_DELA_MERE=@NOM_DELA_MERE,DATE_DE_NAISSANCE=@DATE_DE_NAISSANCE,LIEU_DE_NAISSANCE=@LIEU_DE_NAISSANCE where MATRICUL_ELEVE=@MATRICUL_ELEVE"
        d.cmd.Parameters.AddWithValue("@MATRICUL_ELEVE", Me.TextBox1.Text)
        d.cmd.Parameters.AddWithValue("@NOM", Me.TextBox2.Text)
        d.cmd.Parameters.AddWithValue("@POST_NOM", Me.TextBox3.Text)
        d.cmd.Parameters.AddWithValue("@PRENOM", Me.TextBox4.Text)
        d.cmd.Parameters.AddWithValue("@SEXE", Me.ComboBox1.Text)
        d.cmd.Parameters.AddWithValue("@NOM_DU_PERE", Me.TextBox5.Text)
        d.cmd.Parameters.AddWithValue("@NOM_DELA_MERE", Me.TextBox6.Text)
        d.cmd.Parameters.AddWithValue("@DATE_DE_NAISSANCE", Me.TextBox8.Text)
        d.cmd.Parameters.AddWithValue("@LIEU_DE_NAISSANCE", Me.TextBox7.Text)
        d.cmd.ExecuteNonQuery()
        d.deconnecter()
        d.remplirDGV("select*from ELEVE", DGV1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        d.cmd.CommandText = "delete ELEVE where MATRICUL_ELEVE= @MATRICUL_ELEVE"
        d.cmd.Parameters.AddWithValue("@MATRICUL_ELEVE", Me.TextBox1.Text)
        d.cmd.ExecuteNonQuery()
        d.deconnecter()
        d.remplirDGV("select*from ELEVE", DGV1)
        MessageBox.Show("bien supprimer")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.ComboBox1.Text = ""
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, TextRECHERCHE.MouseLeave
        Dim d As New Donnees
        d.connecter()
        d.cmd = d.con.CreateCommand
        d.con.CreateCommand()
        d.remplirDGV("select*from ELEVE", DGV1)
    End Sub

    Private Sub TextRECHERCHE_TextChanged(sender As Object, e As EventArgs) Handles TextRECHERCHE.MouseEnter
        TextRECHERCHE.Text = ""
    End Sub


    Private Sub TextRECHERCHE_TextChanged_1(sender As Object, e As EventArgs) Handles TextRECHERCHE.TextChanged
        Dim d As New Donnees
        d.recherche(DGV1, TextRECHERCHE.Text, "select * from eleve where MATRICUL_ELEVE  like '%" + TextRECHERCHE.Text + "%' or prenom like '%" + TextRECHERCHE.Text + "%'")

    End Sub

    Private Sub TextRECHERCHE_MouseDown(sender As Object, e As MouseEventArgs) Handles TextRECHERCHE.MouseDown
        'TextRECHERCHE.Text = ""
    End Sub
End Class
