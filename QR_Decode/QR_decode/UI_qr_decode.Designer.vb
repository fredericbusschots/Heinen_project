<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_qr_decode
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_qr_decode))
        Me.TXT_GUID = New System.Windows.Forms.TextBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.b_decode_pdf = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBL_Titre = New System.Windows.Forms.TextBox()
        Me.LBL_Fichier = New System.Windows.Forms.TextBox()
        Me.LBL_Client = New System.Windows.Forms.TextBox()
        Me.LBL_Dossier = New System.Windows.Forms.TextBox()
        Me.LBL_PATH = New System.Windows.Forms.TextBox()
        Me.LBL_Cat = New System.Windows.Forms.TextBox()
        Me.LBL_TS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b_test_dossier = New System.Windows.Forms.Button()
        Me.b_copy_file = New System.Windows.Forms.Button()
        Me.cb_automatique = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lab_vers_qr = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cb_debug = New System.Windows.Forms.CheckBox()
        Me.b_param_email = New System.Windows.Forms.Button()
        Me.b_open_lf = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_doc_ko = New System.Windows.Forms.TextBox()
        Me.tb_doc_ok = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FICHIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUITTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARAMETRESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARAMETRESEMAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.b_open_pdf_ok = New System.Windows.Forms.Button()
        Me.b_open_pdf_error = New System.Windows.Forms.Button()
        Me.b_open_scan_in = New System.Windows.Forms.Button()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_GUID
        '
        Me.TXT_GUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_GUID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_GUID.Location = New System.Drawing.Point(119, 47)
        Me.TXT_GUID.Multiline = True
        Me.TXT_GUID.Name = "TXT_GUID"
        Me.TXT_GUID.Size = New System.Drawing.Size(286, 63)
        Me.TXT_GUID.TabIndex = 2
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(451, 27)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(406, 515)
        Me.AxAcroPDF1.TabIndex = 5
        '
        'b_decode_pdf
        '
        Me.b_decode_pdf.Location = New System.Drawing.Point(6, 30)
        Me.b_decode_pdf.Name = "b_decode_pdf"
        Me.b_decode_pdf.Size = New System.Drawing.Size(97, 25)
        Me.b_decode_pdf.TabIndex = 6
        Me.b_decode_pdf.Text = "DECODE PDF"
        Me.b_decode_pdf.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(7, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Titre du  fichier :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(7, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nom du  fichier :"
        '
        'LBL_Titre
        '
        Me.LBL_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LBL_Titre.Location = New System.Drawing.Point(121, 142)
        Me.LBL_Titre.Name = "LBL_Titre"
        Me.LBL_Titre.Size = New System.Drawing.Size(286, 20)
        Me.LBL_Titre.TabIndex = 25
        '
        'LBL_Fichier
        '
        Me.LBL_Fichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Fichier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LBL_Fichier.Location = New System.Drawing.Point(121, 116)
        Me.LBL_Fichier.Name = "LBL_Fichier"
        Me.LBL_Fichier.Size = New System.Drawing.Size(286, 20)
        Me.LBL_Fichier.TabIndex = 24
        '
        'LBL_Client
        '
        Me.LBL_Client.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Client.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LBL_Client.Location = New System.Drawing.Point(121, 168)
        Me.LBL_Client.Name = "LBL_Client"
        Me.LBL_Client.Size = New System.Drawing.Size(288, 20)
        Me.LBL_Client.TabIndex = 22
        '
        'LBL_Dossier
        '
        Me.LBL_Dossier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Dossier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LBL_Dossier.Location = New System.Drawing.Point(121, 194)
        Me.LBL_Dossier.Name = "LBL_Dossier"
        Me.LBL_Dossier.Size = New System.Drawing.Size(288, 20)
        Me.LBL_Dossier.TabIndex = 21
        '
        'LBL_PATH
        '
        Me.LBL_PATH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PATH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LBL_PATH.Location = New System.Drawing.Point(121, 276)
        Me.LBL_PATH.Multiline = True
        Me.LBL_PATH.Name = "LBL_PATH"
        Me.LBL_PATH.Size = New System.Drawing.Size(288, 20)
        Me.LBL_PATH.TabIndex = 19
        '
        'LBL_Cat
        '
        Me.LBL_Cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Cat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LBL_Cat.Location = New System.Drawing.Point(121, 220)
        Me.LBL_Cat.Name = "LBL_Cat"
        Me.LBL_Cat.Size = New System.Drawing.Size(286, 20)
        Me.LBL_Cat.TabIndex = 30
        '
        'LBL_TS
        '
        Me.LBL_TS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LBL_TS.Location = New System.Drawing.Point(121, 246)
        Me.LBL_TS.Name = "LBL_TS"
        Me.LBL_TS.Size = New System.Drawing.Size(286, 20)
        Me.LBL_TS.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(7, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Client :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(7, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Dossier :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(7, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Categorie :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(7, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Date heure :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(9, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Contenu QR  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(7, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Path :"
        '
        'b_test_dossier
        '
        Me.b_test_dossier.Location = New System.Drawing.Point(136, 30)
        Me.b_test_dossier.Name = "b_test_dossier"
        Me.b_test_dossier.Size = New System.Drawing.Size(110, 25)
        Me.b_test_dossier.TabIndex = 42
        Me.b_test_dossier.Text = "CHECK DOSSIER"
        Me.b_test_dossier.UseVisualStyleBackColor = True
        '
        'b_copy_file
        '
        Me.b_copy_file.Location = New System.Drawing.Point(282, 30)
        Me.b_copy_file.Name = "b_copy_file"
        Me.b_copy_file.Size = New System.Drawing.Size(97, 25)
        Me.b_copy_file.TabIndex = 43
        Me.b_copy_file.Text = "COPIE FICHIER"
        Me.b_copy_file.UseVisualStyleBackColor = True
        '
        'cb_automatique
        '
        Me.cb_automatique.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb_automatique.AutoSize = True
        Me.cb_automatique.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_automatique.Location = New System.Drawing.Point(119, 12)
        Me.cb_automatique.Name = "cb_automatique"
        Me.cb_automatique.Size = New System.Drawing.Size(72, 23)
        Me.cb_automatique.TabIndex = 44
        Me.cb_automatique.Text = "CheckBox1"
        Me.cb_automatique.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.b_open_pdf_ok)
        Me.GroupBox1.Controls.Add(Me.b_open_pdf_error)
        Me.GroupBox1.Controls.Add(Me.b_open_scan_in)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 68)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ouvrir dossiers/log file"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(113, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Pdf OK"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(209, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Pdf error"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Scan In"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.b_copy_file)
        Me.GroupBox2.Controls.Add(Me.b_test_dossier)
        Me.GroupBox2.Controls.Add(Me.b_decode_pdf)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 406)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 66)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions Manuelles"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(258, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "->"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "->"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(7, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Version QR :"
        '
        'lab_vers_qr
        '
        Me.lab_vers_qr.AutoSize = True
        Me.lab_vers_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_vers_qr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lab_vers_qr.Location = New System.Drawing.Point(118, 303)
        Me.lab_vers_qr.Name = "lab_vers_qr"
        Me.lab_vers_qr.Size = New System.Drawing.Size(23, 13)
        Me.lab_vers_qr.TabIndex = 53
        Me.lab_vers_qr.Text = "null"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(451, 515)
        Me.TabControl1.TabIndex = 54
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TXT_GUID)
        Me.TabPage1.Controls.Add(Me.LBL_PATH)
        Me.TabPage1.Controls.Add(Me.lab_vers_qr)
        Me.TabPage1.Controls.Add(Me.LBL_Dossier)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.LBL_Client)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.LBL_Fichier)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.LBL_Titre)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cb_automatique)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.LBL_Cat)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.LBL_TS)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(443, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "GENERAL"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label13.Location = New System.Drawing.Point(9, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Status :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cb_debug)
        Me.TabPage2.Controls.Add(Me.b_param_email)
        Me.TabPage2.Controls.Add(Me.b_open_lf)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.tb_doc_ko)
        Me.TabPage2.Controls.Add(Me.tb_doc_ok)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(443, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LOG"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cb_debug
        '
        Me.cb_debug.AutoSize = True
        Me.cb_debug.Location = New System.Drawing.Point(373, 463)
        Me.cb_debug.Name = "cb_debug"
        Me.cb_debug.Size = New System.Drawing.Size(64, 17)
        Me.cb_debug.TabIndex = 49
        Me.cb_debug.Text = "DEBUG"
        Me.cb_debug.UseVisualStyleBackColor = True
        '
        'b_param_email
        '
        Me.b_param_email.Location = New System.Drawing.Point(142, 459)
        Me.b_param_email.Name = "b_param_email"
        Me.b_param_email.Size = New System.Drawing.Size(124, 22)
        Me.b_param_email.TabIndex = 48
        Me.b_param_email.Text = "Paramètres Emails"
        Me.b_param_email.UseVisualStyleBackColor = True
        '
        'b_open_lf
        '
        Me.b_open_lf.Location = New System.Drawing.Point(12, 459)
        Me.b_open_lf.Name = "b_open_lf"
        Me.b_open_lf.Size = New System.Drawing.Size(124, 22)
        Me.b_open_lf.TabIndex = 47
        Me.b_open_lf.Text = "Ouvrir log file complet"
        Me.b_open_lf.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 229)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(206, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "10 Derniers documents avec erreur"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "10 Derniers documents ajoutés"
        '
        'tb_doc_ko
        '
        Me.tb_doc_ko.Location = New System.Drawing.Point(12, 245)
        Me.tb_doc_ko.Multiline = True
        Me.tb_doc_ko.Name = "tb_doc_ko"
        Me.tb_doc_ko.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_doc_ko.Size = New System.Drawing.Size(425, 208)
        Me.tb_doc_ko.TabIndex = 1
        '
        'tb_doc_ok
        '
        Me.tb_doc_ok.Location = New System.Drawing.Point(12, 33)
        Me.tb_doc_ok.Multiline = True
        Me.tb_doc_ok.Name = "tb_doc_ok"
        Me.tb_doc_ok.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_doc_ok.Size = New System.Drawing.Size(425, 193)
        Me.tb_doc_ok.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FICHIERToolStripMenuItem, Me.PARAMETRESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(857, 24)
        Me.MenuStrip1.TabIndex = 55
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FICHIERToolStripMenuItem
        '
        Me.FICHIERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QUITTERToolStripMenuItem})
        Me.FICHIERToolStripMenuItem.Name = "FICHIERToolStripMenuItem"
        Me.FICHIERToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FICHIERToolStripMenuItem.Text = "FICHIER"
        '
        'QUITTERToolStripMenuItem
        '
        Me.QUITTERToolStripMenuItem.Name = "QUITTERToolStripMenuItem"
        Me.QUITTERToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.QUITTERToolStripMenuItem.Text = "QUITTER"
        '
        'PARAMETRESToolStripMenuItem
        '
        Me.PARAMETRESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SETTINGSToolStripMenuItem, Me.PARAMETRESEMAILSToolStripMenuItem})
        Me.PARAMETRESToolStripMenuItem.Name = "PARAMETRESToolStripMenuItem"
        Me.PARAMETRESToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.PARAMETRESToolStripMenuItem.Text = "PARAMETRES"
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.SETTINGSToolStripMenuItem.Text = "PARAMETRES APPLICATION"
        '
        'PARAMETRESEMAILSToolStripMenuItem
        '
        Me.PARAMETRESEMAILSToolStripMenuItem.Name = "PARAMETRESEMAILSToolStripMenuItem"
        Me.PARAMETRESEMAILSToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.PARAMETRESEMAILSToolStripMenuItem.Text = "PARAMETRES EMAILS (ERREURS)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(61, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'b_open_pdf_ok
        '
        Me.b_open_pdf_ok.BackgroundImage = Global.QR_decode.My.Resources.Resources.dossier
        Me.b_open_pdf_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_open_pdf_ok.Location = New System.Drawing.Point(160, 29)
        Me.b_open_pdf_ok.Name = "b_open_pdf_ok"
        Me.b_open_pdf_ok.Size = New System.Drawing.Size(31, 24)
        Me.b_open_pdf_ok.TabIndex = 49
        Me.b_open_pdf_ok.UseVisualStyleBackColor = True
        '
        'b_open_pdf_error
        '
        Me.b_open_pdf_error.BackgroundImage = Global.QR_decode.My.Resources.Resources.dossier
        Me.b_open_pdf_error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_open_pdf_error.Location = New System.Drawing.Point(262, 29)
        Me.b_open_pdf_error.Name = "b_open_pdf_error"
        Me.b_open_pdf_error.Size = New System.Drawing.Size(34, 24)
        Me.b_open_pdf_error.TabIndex = 48
        Me.b_open_pdf_error.UseVisualStyleBackColor = True
        '
        'b_open_scan_in
        '
        Me.b_open_scan_in.BackgroundImage = Global.QR_decode.My.Resources.Resources.dossier
        Me.b_open_scan_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_open_scan_in.Location = New System.Drawing.Point(63, 29)
        Me.b_open_scan_in.Name = "b_open_scan_in"
        Me.b_open_scan_in.Size = New System.Drawing.Size(33, 24)
        Me.b_open_scan_in.TabIndex = 47
        Me.b_open_scan_in.UseVisualStyleBackColor = True
        '
        'UI_qr_decode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(857, 541)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UI_qr_decode"
        Me.Text = "Décode et injecte"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_GUID As TextBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents b_decode_pdf As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_Titre As TextBox
    Friend WithEvents LBL_Fichier As TextBox
    Friend WithEvents LBL_Client As TextBox
    Friend WithEvents LBL_Dossier As TextBox
    Friend WithEvents LBL_PATH As TextBox
    Friend WithEvents LBL_Cat As TextBox
    Friend WithEvents LBL_TS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents b_test_dossier As Button
    Friend WithEvents b_copy_file As Button
    Friend WithEvents cb_automatique As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents b_open_scan_in As Button
    Friend WithEvents b_open_pdf_error As Button
    Friend WithEvents b_open_pdf_ok As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lab_vers_qr As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tb_doc_ok As TextBox
    Friend WithEvents b_open_lf As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tb_doc_ko As TextBox
    Friend WithEvents b_param_email As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cb_debug As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FICHIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QUITTERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PARAMETRESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PARAMETRESEMAILSToolStripMenuItem As ToolStripMenuItem
End Class
