<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label4 = New Label()
        num_vol = New TextBox()
        dest = New TextBox()
        prix = New TextBox()
        Label5 = New Label()
        Date_vol = New DateTimePicker()
        num_place = New NumericUpDown()
        Label6 = New Label()
        ajt_v = New Button()
        mdf_v = New Button()
        sup_v = New Button()
        lst_vol = New DataGridView()
        CType(num_place, ComponentModel.ISupportInitialize).BeginInit()
        CType(lst_vol, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(271, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 38)
        Label1.TabIndex = 2
        Label1.Text = "Gestion de vols"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(51, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 28)
        Label2.TabIndex = 8
        Label2.Text = "Num de vol:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(51, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 28)
        Label3.TabIndex = 9
        Label3.Text = "destination:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(86, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 28)
        Label4.TabIndex = 10
        Label4.Text = "prix:"
        ' 
        ' num_vol
        ' 
        num_vol.Location = New Point(331, 101)
        num_vol.Name = "num_vol"
        num_vol.Size = New Size(125, 27)
        num_vol.TabIndex = 11
        ' 
        ' dest
        ' 
        dest.Location = New Point(331, 162)
        dest.Name = "dest"
        dest.Size = New Size(125, 27)
        dest.TabIndex = 12
        ' 
        ' prix
        ' 
        prix.Location = New Point(331, 238)
        prix.Name = "prix"
        prix.Size = New Size(125, 27)
        prix.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(570, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 28)
        Label5.TabIndex = 14
        Label5.Text = "date:"
        ' 
        ' Date_vol
        ' 
        Date_vol.Location = New Point(665, 103)
        Date_vol.Name = "Date_vol"
        Date_vol.Size = New Size(250, 27)
        Date_vol.TabIndex = 15
        ' 
        ' num_place
        ' 
        num_place.Location = New Point(802, 158)
        num_place.Name = "num_place"
        num_place.Size = New Size(150, 27)
        num_place.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(570, 158)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 28)
        Label6.TabIndex = 17
        Label6.Text = "place disponible:"
        ' 
        ' ajt_v
        ' 
        ajt_v.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ajt_v.ForeColor = SystemColors.HotTrack
        ajt_v.Location = New Point(312, 338)
        ajt_v.Name = "ajt_v"
        ajt_v.Size = New Size(144, 34)
        ajt_v.TabIndex = 18
        ajt_v.Text = "ajouter"
        ajt_v.UseVisualStyleBackColor = True
        ' 
        ' mdf_v
        ' 
        mdf_v.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mdf_v.ForeColor = SystemColors.HotTrack
        mdf_v.Location = New Point(513, 338)
        mdf_v.Name = "mdf_v"
        mdf_v.Size = New Size(144, 34)
        mdf_v.TabIndex = 19
        mdf_v.Text = "modifier"
        mdf_v.UseVisualStyleBackColor = True
        ' 
        ' sup_v
        ' 
        sup_v.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sup_v.ForeColor = SystemColors.HotTrack
        sup_v.Location = New Point(749, 338)
        sup_v.Name = "sup_v"
        sup_v.Size = New Size(144, 34)
        sup_v.TabIndex = 20
        sup_v.Text = "supprimer"
        sup_v.UseVisualStyleBackColor = True
        ' 
        ' lst_vol
        ' 
        lst_vol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        lst_vol.Location = New Point(382, 436)
        lst_vol.Name = "lst_vol"
        lst_vol.RowHeadersWidth = 51
        lst_vol.Size = New Size(465, 286)
        lst_vol.TabIndex = 21
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1227, 784)
        Controls.Add(lst_vol)
        Controls.Add(sup_v)
        Controls.Add(mdf_v)
        Controls.Add(ajt_v)
        Controls.Add(Label6)
        Controls.Add(num_place)
        Controls.Add(Date_vol)
        Controls.Add(Label5)
        Controls.Add(prix)
        Controls.Add(dest)
        Controls.Add(num_vol)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form5"
        CType(num_place, ComponentModel.ISupportInitialize).EndInit()
        CType(lst_vol, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents num_vol As TextBox
    Friend WithEvents dest As TextBox
    Friend WithEvents prix As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Date_vol As DateTimePicker
    Friend WithEvents num_place As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents ajt_v As Button
    Friend WithEvents mdf_v As Button
    Friend WithEvents sup_v As Button
    Friend WithEvents lst_vol As DataGridView
End Class
