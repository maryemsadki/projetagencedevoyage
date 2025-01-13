<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        nom_u = New TextBox()
        Label5 = New Label()
        prenom_u = New TextBox()
        Label6 = New Label()
        numtel_u = New TextBox()
        btn_reserv = New Button()
        aff_res = New DataGridView()
        Label7 = New Label()
        CType(aff_res, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(219, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 38)
        Label1.TabIndex = 3
        Label1.Text = "réservation des billets"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(263, 28)
        Label2.TabIndex = 9
        Label2.Text = "recherche par destination:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 28)
        Label3.TabIndex = 10
        Label3.Text = "recherche par date:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(304, 68)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 11
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(231, 132)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 28)
        Label4.TabIndex = 13
        Label4.Text = "nom:"
        ' 
        ' nom_u
        ' 
        nom_u.Location = New Point(105, 205)
        nom_u.Name = "nom_u"
        nom_u.Size = New Size(125, 27)
        nom_u.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(304, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 28)
        Label5.TabIndex = 15
        Label5.Text = "prénom:"
        ' 
        ' prenom_u
        ' 
        prenom_u.Location = New Point(414, 209)
        prenom_u.Name = "prenom_u"
        prenom_u.Size = New Size(125, 27)
        prenom_u.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(165, 255)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 28)
        Label6.TabIndex = 17
        Label6.Text = "num de tel:"
        ' 
        ' numtel_u
        ' 
        numtel_u.Location = New Point(356, 259)
        numtel_u.Name = "numtel_u"
        numtel_u.Size = New Size(125, 27)
        numtel_u.TabIndex = 18
        ' 
        ' btn_reserv
        ' 
        btn_reserv.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reserv.ForeColor = SystemColors.HotTrack
        btn_reserv.Location = New Point(252, 309)
        btn_reserv.Name = "btn_reserv"
        btn_reserv.Size = New Size(144, 34)
        btn_reserv.TabIndex = 19
        btn_reserv.Text = "réserver"
        btn_reserv.UseVisualStyleBackColor = True
        ' 
        ' aff_res
        ' 
        aff_res.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        aff_res.Location = New Point(637, 98)
        aff_res.Name = "aff_res"
        aff_res.RowHeadersWidth = 51
        aff_res.Size = New Size(300, 188)
        aff_res.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(866, 348)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 21
        Label7.Text = "Label7"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1137, 450)
        Controls.Add(Label7)
        Controls.Add(aff_res)
        Controls.Add(btn_reserv)
        Controls.Add(numtel_u)
        Controls.Add(Label6)
        Controls.Add(prenom_u)
        Controls.Add(Label5)
        Controls.Add(nom_u)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        CType(aff_res, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents nom_u As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents prenom_u As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents numtel_u As TextBox
    Friend WithEvents btn_reserv As Button
    Friend WithEvents aff_res As DataGridView
    Friend WithEvents Label7 As Label
End Class
