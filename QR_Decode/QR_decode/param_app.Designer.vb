<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class param_app
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_cmis10 = New System.Windows.Forms.TextBox()
        Me.tb_cmis11 = New System.Windows.Forms.TextBox()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.tb_mdp = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_pdf_error = New System.Windows.Forms.TextBox()
        Me.tb_pdf_ok = New System.Windows.Forms.TextBox()
        Me.tb_pdf_in_2 = New System.Windows.Forms.TextBox()
        Me.tb_pdf_in = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tb_xml = New System.Windows.Forms.TextBox()
        Me.tb_log = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.b_save_param = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_mdp)
        Me.GroupBox1.Controls.Add(Me.tb_user)
        Me.GroupBox1.Controls.Add(Me.tb_cmis11)
        Me.GroupBox1.Controls.Add(Me.tb_cmis10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection CMIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chaine de connection cmis 1.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chaine de connection cmis 1.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Utilisateur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mot de passe"
        '
        'tb_cmis10
        '
        Me.tb_cmis10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cmis10.Location = New System.Drawing.Point(197, 23)
        Me.tb_cmis10.Name = "tb_cmis10"
        Me.tb_cmis10.Size = New System.Drawing.Size(428, 20)
        Me.tb_cmis10.TabIndex = 4
        '
        'tb_cmis11
        '
        Me.tb_cmis11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cmis11.Location = New System.Drawing.Point(197, 45)
        Me.tb_cmis11.Name = "tb_cmis11"
        Me.tb_cmis11.Size = New System.Drawing.Size(428, 20)
        Me.tb_cmis11.TabIndex = 5
        '
        'tb_user
        '
        Me.tb_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(197, 68)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(428, 20)
        Me.tb_user.TabIndex = 6
        '
        'tb_mdp
        '
        Me.tb_mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mdp.Location = New System.Drawing.Point(197, 94)
        Me.tb_mdp.Name = "tb_mdp"
        Me.tb_mdp.Size = New System.Drawing.Size(428, 20)
        Me.tb_mdp.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_pdf_error)
        Me.GroupBox2.Controls.Add(Me.tb_pdf_ok)
        Me.GroupBox2.Controls.Add(Me.tb_pdf_in_2)
        Me.GroupBox2.Controls.Add(Me.tb_pdf_in)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 129)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dossiers"
        '
        'tb_pdf_error
        '
        Me.tb_pdf_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pdf_error.Location = New System.Drawing.Point(197, 94)
        Me.tb_pdf_error.Name = "tb_pdf_error"
        Me.tb_pdf_error.Size = New System.Drawing.Size(428, 20)
        Me.tb_pdf_error.TabIndex = 7
        '
        'tb_pdf_ok
        '
        Me.tb_pdf_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pdf_ok.Location = New System.Drawing.Point(197, 68)
        Me.tb_pdf_ok.Name = "tb_pdf_ok"
        Me.tb_pdf_ok.Size = New System.Drawing.Size(428, 20)
        Me.tb_pdf_ok.TabIndex = 6
        '
        'tb_pdf_in_2
        '
        Me.tb_pdf_in_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pdf_in_2.Location = New System.Drawing.Point(197, 45)
        Me.tb_pdf_in_2.Name = "tb_pdf_in_2"
        Me.tb_pdf_in_2.Size = New System.Drawing.Size(428, 20)
        Me.tb_pdf_in_2.TabIndex = 5
        '
        'tb_pdf_in
        '
        Me.tb_pdf_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pdf_in.Location = New System.Drawing.Point(197, 23)
        Me.tb_pdf_in.Name = "tb_pdf_in"
        Me.tb_pdf_in.Size = New System.Drawing.Size(428, 20)
        Me.tb_pdf_in.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Dossier transfert pdf avec erreur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Dossier transfert pdf ok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Dossier de recherche avec ss dossiers"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Dossier de recherche"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tb_xml)
        Me.GroupBox3.Controls.Add(Me.tb_log)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(639, 77)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fichiers"
        '
        'tb_xml
        '
        Me.tb_xml.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_xml.Location = New System.Drawing.Point(197, 45)
        Me.tb_xml.Name = "tb_xml"
        Me.tb_xml.Size = New System.Drawing.Size(428, 20)
        Me.tb_xml.TabIndex = 5
        '
        'tb_log
        '
        Me.tb_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_log.Location = New System.Drawing.Point(197, 23)
        Me.tb_log.Name = "tb_log"
        Me.tb_log.Size = New System.Drawing.Size(428, 20)
        Me.tb_log.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Fichier XML de config"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Fichier log"
        '
        'b_save_param
        '
        Me.b_save_param.Location = New System.Drawing.Point(12, 379)
        Me.b_save_param.Name = "b_save_param"
        Me.b_save_param.Size = New System.Drawing.Size(75, 23)
        Me.b_save_param.TabIndex = 10
        Me.b_save_param.Text = "Sauver"
        Me.b_save_param.UseVisualStyleBackColor = True
        '
        'param_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 414)
        Me.Controls.Add(Me.b_save_param)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "param_app"
        Me.Text = "Paramètres de l'application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_mdp As TextBox
    Friend WithEvents tb_user As TextBox
    Friend WithEvents tb_cmis11 As TextBox
    Friend WithEvents tb_cmis10 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_pdf_error As TextBox
    Friend WithEvents tb_pdf_ok As TextBox
    Friend WithEvents tb_pdf_in_2 As TextBox
    Friend WithEvents tb_pdf_in As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tb_xml As TextBox
    Friend WithEvents tb_log As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents b_save_param As Button
End Class
