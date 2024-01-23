Public Class LOGIN

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("entrer le nom d'utilisateur")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("entrer le mot de passe")
        ElseIf (Not TextBox1.Text = "lucien") Then
            MessageBox.Show(" le nom d'utilisateur est inccorect")
        ElseIf Not TextBox2.Text = "bulondo" Then
            MessageBox.Show("Le mot de passe est incorrect")

        ElseIf TextBox1.Text = "lucien" And TextBox2.Text = "bulondo" Then
            Form1.Show()
            Me.Hide()
            MessageBox.Show("vous etes connecter avec succés")
            Timer1.Start()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        
        ProgressBar1.Value = 0
        Timer1.Interval = 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ProgressBar1.Value = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Form1.Show()


            Me.Hide()
        End If
    End Sub
End Class