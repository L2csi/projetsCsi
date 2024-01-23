
Imports System.Data.SqlClient
Imports CrystalDecisions.Windows.Forms.CrystalReportViewer
Imports System.Data.SqlClient.SqlDataReader
Public Class Donnees
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public dtta As New DataTable
    Public info As Integer
    'Public dr As New SqlDataReader
    'Méthode connexion
    Public Sub connecter()
        Try
            If (con.State = ConnectionState.Closed) Then
                con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=GESTIONINSCRIPTION;Integrated Security=True"
                con.Open()
                connecter()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Public Function recu(ak As String) As DataSet

    'End Function
    Public Sub deconnecter()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'REMPLISSAGE 
    Public Sub remplirDGV(ByVal sqlStatement As String, ByVal dgv As DataGridView)
        connecter()
        cmd = con.CreateCommand()
        cmd.CommandText = sqlStatement
        da.SelectCommand = cmd
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        deconnecter()
    End Sub
    'Public Sub chargement()
    '    dtta.Clear()
    '    ds.Clear()
    '    cmd.CommandText = "select*from nomTable"
    '    cmd.ExecuteNonQuery()
    '    da.Fill(ds, "nomTable")
    '    dtta = ds.Tables("nomTable")
    '    con.Close()
    '    info = dtta.Rows.Count

    'End Sub
    'Remplissage combo box
    Public Function remplirCBO(ByVal sqlStatement As String, ByVal cbo As ComboBox, ByVal valueMember As String, ByVal displayMembr As String) As Boolean
        Dim b As Boolean
        b = False
        Try
            Dim da As New SqlDataAdapter()
            Dim ds As New DataSet()
            connecter()
            Dim cmd1 As New SqlCommand()
            cmd1 = con.CreateCommand()
            cmd1.CommandText = sqlStatement
            da.SelectCommand = cmd1
            da.Fill(ds)
            cbo.DisplayMember = displayMembr
            cbo.ValueMember = valueMember
            cbo.DataSource = ds.Tables(0)
            deconnecter()
            b = True
        Catch ex As Exception
            Throw
        End Try
        Return b
    End Function

    Sub recherche(d As DataGridView, mot As String, requete As String)
        connecter()
        cmd = New SqlCommand(requete, con)
        cmd.Parameters.AddWithValue("@nom", mot)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "eleve")
        d.DataSource = ds.Tables("eleve")


    End Sub
    ' Sub appel_recu()
    'connecter()
    'cmd = New SqlCommand()
    'da = New SqlDataAdapter("select * from recuinscription", con)
    '  ds = New DataSet()
    '  da.Fill(ds, "recuinscription")
    'Dim ar As New recu_eleve
    'Dim ar As New affichage_rapport()
    '   ar.Show()
    'ar.SetDataSource = ds
    'rep()





    ' End Sub
End Class

