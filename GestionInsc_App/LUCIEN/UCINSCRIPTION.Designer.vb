<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCINSCRIPTION
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtID_INSCRIT = New System.Windows.Forms.TextBox()
        Me.TextCLAINSCRIT = New System.Windows.Forms.TextBox()
        Me.TextELE = New System.Windows.Forms.TextBox()
        Me.TextMONTINSCRIT = New System.Windows.Forms.TextBox()
        Me.TextDATEINSCRIT = New System.Windows.Forms.TextBox()
        Me.TextANNSCOLAIRE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVINSCRI = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVINSCRI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FRM_INSCRIPTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID_INSCRIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ANNEE_SCOLAIRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DATE D'INSCRIPTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "MONTANT D'INSCRIPTION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "N° CLASSE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID_ELEVE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 10)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 358)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(663, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 368)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 368)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(663, 10)
        Me.Panel4.TabIndex = 1
        '
        'txtID_INSCRIT
        '
        Me.txtID_INSCRIT.Font = New System.Drawing.Font("Agency FB", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID_INSCRIT.Location = New System.Drawing.Point(193, 72)
        Me.txtID_INSCRIT.Name = "txtID_INSCRIT"
        Me.txtID_INSCRIT.Size = New System.Drawing.Size(163, 27)
        Me.txtID_INSCRIT.TabIndex = 2
        '
        'TextCLAINSCRIT
        '
        Me.TextCLAINSCRIT.Font = New System.Drawing.Font("Agency FB", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCLAINSCRIT.Location = New System.Drawing.Point(193, 212)
        Me.TextCLAINSCRIT.Name = "TextCLAINSCRIT"
        Me.TextCLAINSCRIT.Size = New System.Drawing.Size(163, 27)
        Me.TextCLAINSCRIT.TabIndex = 2
        '
        'TextELE
        '
        Me.TextELE.Font = New System.Drawing.Font("Agency FB", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextELE.Location = New System.Drawing.Point(193, 244)
        Me.TextELE.Name = "TextELE"
        Me.TextELE.Size = New System.Drawing.Size(163, 27)
        Me.TextELE.TabIndex = 2
        '
        'TextMONTINSCRIT
        '
        Me.TextMONTINSCRIT.Font = New System.Drawing.Font("Agency FB", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMONTINSCRIT.Location = New System.Drawing.Point(193, 177)
        Me.TextMONTINSCRIT.Name = "TextMONTINSCRIT"
        Me.TextMONTINSCRIT.Size = New System.Drawing.Size(163, 27)
        Me.TextMONTINSCRIT.TabIndex = 2
        '
        'TextDATEINSCRIT
        '
        Me.TextDATEINSCRIT.Font = New System.Drawing.Font("Agency FB", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDATEINSCRIT.Location = New System.Drawing.Point(193, 143)
        Me.TextDATEINSCRIT.Name = "TextDATEINSCRIT"
        Me.TextDATEINSCRIT.Size = New System.Drawing.Size(163, 27)
        Me.TextDATEINSCRIT.TabIndex = 2
        '
        'TextANNSCOLAIRE
        '
        Me.TextANNSCOLAIRE.Font = New System.Drawing.Font("Agency FB", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextANNSCOLAIRE.Location = New System.Drawing.Point(193, 110)
        Me.TextANNSCOLAIRE.Name = "TextANNSCOLAIRE"
        Me.TextANNSCOLAIRE.Size = New System.Drawing.Size(163, 27)
        Me.TextANNSCOLAIRE.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(362, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 179)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOUTONS"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(8, 126)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 39)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "AFFICHER"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(127, 82)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 39)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "SUPPRIMER"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(7, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 39)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "NOUVEAU"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 39)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "MODIFIER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "AJOUTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGVINSCRI
        '
        Me.DGVINSCRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVINSCRI.Location = New System.Drawing.Point(24, 277)
        Me.DGVINSCRI.Name = "DGVINSCRI"
        Me.DGVINSCRI.Size = New System.Drawing.Size(611, 85)
        Me.DGVINSCRI.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Agency FB", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(386, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(249, 27)
        Me.TextBox1.TabIndex = 2
        '
        'UCINSCRIPTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGVINSCRI)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextELE)
        Me.Controls.Add(Me.TextANNSCOLAIRE)
        Me.Controls.Add(Me.TextDATEINSCRIT)
        Me.Controls.Add(Me.TextMONTINSCRIT)
        Me.Controls.Add(Me.TextCLAINSCRIT)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtID_INSCRIT)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCINSCRIPTION"
        Me.Size = New System.Drawing.Size(673, 378)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVINSCRI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtID_INSCRIT As System.Windows.Forms.TextBox
    Friend WithEvents TextCLAINSCRIT As System.Windows.Forms.TextBox
    Friend WithEvents TextELE As System.Windows.Forms.TextBox
    Friend WithEvents TextMONTINSCRIT As System.Windows.Forms.TextBox
    Friend WithEvents TextDATEINSCRIT As System.Windows.Forms.TextBox
    Friend WithEvents TextANNSCOLAIRE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGVINSCRI As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
