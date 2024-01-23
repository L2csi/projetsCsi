Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.PanelLUCIEN.Controls.Clear()
        Dim LUCIEN As New UCELEVE()
        Me.PanelLUCIEN.Controls.Add(LUCIEN)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.PanelLUCIEN.Controls.Clear()
        Dim LUCIENOK As New UCOPTION()
        Me.PanelLUCIEN.Controls.Add(LUCIENOK)
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.PanelLUCIEN.Controls.Clear()
        Dim OK As New UCCLASS()
        Me.PanelLUCIEN.Controls.Add(OK)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.PanelLUCIEN.Controls.Clear()
        Dim OKOK As New UCINSCRIPTION()
        Me.PanelLUCIEN.Controls.Add(OKOK)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.PanelLUCIEN.Controls.Clear()
        Dim OKOKok As New UCRAPPORT()
        Me.PanelLUCIEN.Controls.Add(OKOKok)
    End Sub

   

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
