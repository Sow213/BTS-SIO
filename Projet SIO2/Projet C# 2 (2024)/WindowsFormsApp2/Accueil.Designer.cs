namespace WindowsFormsApp2
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Accueille = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.radioButtonresponsable = new System.Windows.Forms.RadioButton();
            this.radioButtonrtechnicien = new System.Windows.Forms.RadioButton();
            this.radioButtonutilisateur = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.Incident = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxNv = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonafficherincident = new System.Windows.Forms.Button();
            this.buttonEnregsitrerincident = new System.Windows.Forms.Button();
            this.listBoxincident = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxProbleme = new System.Windows.Forms.TextBox();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Responsable = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonmodifiercompte = new System.Windows.Forms.Button();
            this.buttonenregistrercompte = new System.Windows.Forms.Button();
            this.buttonsupprimerintervenant = new System.Windows.Forms.Button();
            this.buttonajoutercompte = new System.Windows.Forms.Button();
            this.Technicien = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonaffichermateriel = new System.Windows.Forms.Button();
            this.listBoxmateriel = new System.Windows.Forms.ListBox();
            this.buttonenregistrerincident = new System.Windows.Forms.Button();
            this.buttonetatincident = new System.Windows.Forms.Button();
            this.buttonaffilerincident = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxmateriel = new System.Windows.Forms.TextBox();
            this.richTextBoxincident = new System.Windows.Forms.RichTextBox();
            this.buttonconsulterincident = new System.Windows.Forms.Button();
            this.buttondeletemateriel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonajoutermateriel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Accueille.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Incident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Responsable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Technicien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.fnds;
            this.pictureBox1.Location = new System.Drawing.Point(20, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Accueille);
            this.tabControl1.Controls.Add(this.Incident);
            this.tabControl1.Controls.Add(this.Responsable);
            this.tabControl1.Controls.Add(this.Technicien);
            this.tabControl1.Location = new System.Drawing.Point(270, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 670);
            this.tabControl1.TabIndex = 11;
            // 
            // Accueille
            // 
            this.Accueille.Controls.Add(this.label19);
            this.Accueille.Controls.Add(this.label18);
            this.Accueille.Controls.Add(this.radioButtonresponsable);
            this.Accueille.Controls.Add(this.radioButtonrtechnicien);
            this.Accueille.Controls.Add(this.radioButtonutilisateur);
            this.Accueille.Controls.Add(this.pictureBox1);
            this.Accueille.Controls.Add(this.label2);
            this.Accueille.Controls.Add(this.buttonConnexion);
            this.Accueille.Controls.Add(this.panel1);
            this.Accueille.Controls.Add(this.label1);
            this.Accueille.Controls.Add(this.textBoxpassword);
            this.Accueille.Controls.Add(this.textBoxusername);
            this.Accueille.Location = new System.Drawing.Point(4, 22);
            this.Accueille.Name = "Accueille";
            this.Accueille.Padding = new System.Windows.Forms.Padding(3);
            this.Accueille.Size = new System.Drawing.Size(315, 644);
            this.Accueille.TabIndex = 0;
            this.Accueille.Text = "Accueil";
            this.Accueille.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 331);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 15);
            this.label19.TabIndex = 14;
            this.label19.Text = "Password :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 15);
            this.label18.TabIndex = 13;
            this.label18.Text = "Username :";
            // 
            // radioButtonresponsable
            // 
            this.radioButtonresponsable.AutoSize = true;
            this.radioButtonresponsable.Location = new System.Drawing.Point(180, 230);
            this.radioButtonresponsable.Name = "radioButtonresponsable";
            this.radioButtonresponsable.Size = new System.Drawing.Size(87, 17);
            this.radioButtonresponsable.TabIndex = 12;
            this.radioButtonresponsable.TabStop = true;
            this.radioButtonresponsable.Text = "Responsable";
            this.radioButtonresponsable.UseVisualStyleBackColor = true;
            // 
            // radioButtonrtechnicien
            // 
            this.radioButtonrtechnicien.AutoSize = true;
            this.radioButtonrtechnicien.Location = new System.Drawing.Point(87, 230);
            this.radioButtonrtechnicien.Name = "radioButtonrtechnicien";
            this.radioButtonrtechnicien.Size = new System.Drawing.Size(78, 17);
            this.radioButtonrtechnicien.TabIndex = 11;
            this.radioButtonrtechnicien.TabStop = true;
            this.radioButtonrtechnicien.Text = "Technicien";
            this.radioButtonrtechnicien.UseVisualStyleBackColor = true;
            // 
            // radioButtonutilisateur
            // 
            this.radioButtonutilisateur.AutoSize = true;
            this.radioButtonutilisateur.Location = new System.Drawing.Point(6, 230);
            this.radioButtonutilisateur.Name = "radioButtonutilisateur";
            this.radioButtonutilisateur.Size = new System.Drawing.Size(71, 17);
            this.radioButtonutilisateur.TabIndex = 10;
            this.radioButtonutilisateur.TabStop = true;
            this.radioButtonutilisateur.Text = "Utilisateur";
            this.radioButtonutilisateur.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login :";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexion.Location = new System.Drawing.Point(93, 352);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexion.TabIndex = 1;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(59, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 1);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sélectione votre statut :";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(82, 326);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxpassword.TabIndex = 6;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(82, 300);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(100, 20);
            this.textBoxusername.TabIndex = 5;
            // 
            // Incident
            // 
            this.Incident.Controls.Add(this.label21);
            this.Incident.Controls.Add(this.comboBoxNv);
            this.Incident.Controls.Add(this.label20);
            this.Incident.Controls.Add(this.textBoxMatricule);
            this.Incident.Controls.Add(this.label13);
            this.Incident.Controls.Add(this.buttonafficherincident);
            this.Incident.Controls.Add(this.buttonEnregsitrerincident);
            this.Incident.Controls.Add(this.listBoxincident);
            this.Incident.Controls.Add(this.label12);
            this.Incident.Controls.Add(this.label11);
            this.Incident.Controls.Add(this.textBoxProbleme);
            this.Incident.Controls.Add(this.textBoxnom);
            this.Incident.Controls.Add(this.label10);
            this.Incident.Controls.Add(this.pictureBox3);
            this.Incident.Location = new System.Drawing.Point(4, 22);
            this.Incident.Name = "Incident";
            this.Incident.Padding = new System.Windows.Forms.Padding(3);
            this.Incident.Size = new System.Drawing.Size(315, 644);
            this.Incident.TabIndex = 1;
            this.Incident.Text = "Incident";
            this.Incident.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(197, 247);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Niveaux d\'intervation :";
            // 
            // comboBoxNv
            // 
            this.comboBoxNv.FormattingEnabled = true;
            this.comboBoxNv.Location = new System.Drawing.Point(188, 263);
            this.comboBoxNv.Name = "comboBoxNv";
            this.comboBoxNv.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNv.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 241);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Matricule :";
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.Location = new System.Drawing.Point(77, 241);
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatricule.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "Suivie des Incidents:";
            // 
            // buttonafficherincident
            // 
            this.buttonafficherincident.Location = new System.Drawing.Point(112, 605);
            this.buttonafficherincident.Name = "buttonafficherincident";
            this.buttonafficherincident.Size = new System.Drawing.Size(101, 33);
            this.buttonafficherincident.TabIndex = 8;
            this.buttonafficherincident.Text = "Afficher ";
            this.buttonafficherincident.UseVisualStyleBackColor = true;
            this.buttonafficherincident.Click += new System.EventHandler(this.buttonafficherincident_Click);
            // 
            // buttonEnregsitrerincident
            // 
            this.buttonEnregsitrerincident.Location = new System.Drawing.Point(93, 316);
            this.buttonEnregsitrerincident.Name = "buttonEnregsitrerincident";
            this.buttonEnregsitrerincident.Size = new System.Drawing.Size(78, 25);
            this.buttonEnregsitrerincident.TabIndex = 7;
            this.buttonEnregsitrerincident.Text = "Enregistrer";
            this.buttonEnregsitrerincident.UseVisualStyleBackColor = true;
            this.buttonEnregsitrerincident.Click += new System.EventHandler(this.buttonEnregsitrerincident_Click);
            // 
            // listBoxincident
            // 
            this.listBoxincident.FormattingEnabled = true;
            this.listBoxincident.Location = new System.Drawing.Point(13, 478);
            this.listBoxincident.Name = "listBoxincident";
            this.listBoxincident.Size = new System.Drawing.Size(285, 121);
            this.listBoxincident.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Probleme :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nom Matériel :";
            // 
            // textBoxProbleme
            // 
            this.textBoxProbleme.Location = new System.Drawing.Point(77, 290);
            this.textBoxProbleme.Name = "textBoxProbleme";
            this.textBoxProbleme.Size = new System.Drawing.Size(100, 20);
            this.textBoxProbleme.TabIndex = 3;
            // 
            // textBoxnom
            // 
            this.textBoxnom.Location = new System.Drawing.Point(77, 264);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(100, 20);
            this.textBoxnom.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Declare l\'incincident :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.fnds;
            this.pictureBox3.Location = new System.Drawing.Point(26, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 194);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Responsable
            // 
            this.Responsable.Controls.Add(this.label14);
            this.Responsable.Controls.Add(this.panel3);
            this.Responsable.Controls.Add(this.label3);
            this.Responsable.Controls.Add(this.label9);
            this.Responsable.Controls.Add(this.label8);
            this.Responsable.Controls.Add(this.label7);
            this.Responsable.Controls.Add(this.label6);
            this.Responsable.Controls.Add(this.label5);
            this.Responsable.Controls.Add(this.label4);
            this.Responsable.Controls.Add(this.pictureBox2);
            this.Responsable.Controls.Add(this.comboBox2);
            this.Responsable.Controls.Add(this.comboBox1);
            this.Responsable.Controls.Add(this.textBox6);
            this.Responsable.Controls.Add(this.textBox5);
            this.Responsable.Controls.Add(this.textBox4);
            this.Responsable.Controls.Add(this.textBox3);
            this.Responsable.Controls.Add(this.buttonmodifiercompte);
            this.Responsable.Controls.Add(this.buttonenregistrercompte);
            this.Responsable.Controls.Add(this.buttonsupprimerintervenant);
            this.Responsable.Controls.Add(this.buttonajoutercompte);
            this.Responsable.Location = new System.Drawing.Point(4, 22);
            this.Responsable.Name = "Responsable";
            this.Responsable.Size = new System.Drawing.Size(315, 644);
            this.Responsable.TabIndex = 2;
            this.Responsable.Text = "Responsable";
            this.Responsable.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(54, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 19);
            this.label14.TabIndex = 21;
            this.label14.Text = "Gestion des Comptes :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(23, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 1);
            this.panel3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prenom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Supprimer un Intervenant :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prenom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.fnds;
            this.pictureBox2.Location = new System.Drawing.Point(23, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 185);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 378);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Choisir ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(54, 213);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 297);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // buttonmodifiercompte
            // 
            this.buttonmodifiercompte.Location = new System.Drawing.Point(203, 321);
            this.buttonmodifiercompte.Name = "buttonmodifiercompte";
            this.buttonmodifiercompte.Size = new System.Drawing.Size(75, 23);
            this.buttonmodifiercompte.TabIndex = 3;
            this.buttonmodifiercompte.Text = "Modifier";
            this.buttonmodifiercompte.UseVisualStyleBackColor = true;
            // 
            // buttonenregistrercompte
            // 
            this.buttonenregistrercompte.Location = new System.Drawing.Point(203, 295);
            this.buttonenregistrercompte.Name = "buttonenregistrercompte";
            this.buttonenregistrercompte.Size = new System.Drawing.Size(75, 23);
            this.buttonenregistrercompte.TabIndex = 2;
            this.buttonenregistrercompte.Text = "Enregistrer";
            this.buttonenregistrercompte.UseVisualStyleBackColor = true;
            // 
            // buttonsupprimerintervenant
            // 
            this.buttonsupprimerintervenant.Location = new System.Drawing.Point(108, 405);
            this.buttonsupprimerintervenant.Name = "buttonsupprimerintervenant";
            this.buttonsupprimerintervenant.Size = new System.Drawing.Size(75, 23);
            this.buttonsupprimerintervenant.TabIndex = 1;
            this.buttonsupprimerintervenant.Text = "Supprimer";
            this.buttonsupprimerintervenant.UseVisualStyleBackColor = true;
            // 
            // buttonajoutercompte
            // 
            this.buttonajoutercompte.Location = new System.Drawing.Point(58, 269);
            this.buttonajoutercompte.Name = "buttonajoutercompte";
            this.buttonajoutercompte.Size = new System.Drawing.Size(75, 23);
            this.buttonajoutercompte.TabIndex = 0;
            this.buttonajoutercompte.Text = "Ajouter";
            this.buttonajoutercompte.UseVisualStyleBackColor = true;
            // 
            // Technicien
            // 
            this.Technicien.Controls.Add(this.label17);
            this.Technicien.Controls.Add(this.buttonaffichermateriel);
            this.Technicien.Controls.Add(this.listBoxmateriel);
            this.Technicien.Controls.Add(this.buttonenregistrerincident);
            this.Technicien.Controls.Add(this.buttonetatincident);
            this.Technicien.Controls.Add(this.buttonaffilerincident);
            this.Technicien.Controls.Add(this.label16);
            this.Technicien.Controls.Add(this.textBoxmateriel);
            this.Technicien.Controls.Add(this.richTextBoxincident);
            this.Technicien.Controls.Add(this.buttonconsulterincident);
            this.Technicien.Controls.Add(this.buttondeletemateriel);
            this.Technicien.Controls.Add(this.label15);
            this.Technicien.Controls.Add(this.pictureBox4);
            this.Technicien.Controls.Add(this.buttonajoutermateriel);
            this.Technicien.Location = new System.Drawing.Point(4, 22);
            this.Technicien.Name = "Technicien";
            this.Technicien.Size = new System.Drawing.Size(315, 644);
            this.Technicien.TabIndex = 3;
            this.Technicien.Text = "Technicien";
            this.Technicien.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, 414);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 19);
            this.label17.TabIndex = 14;
            this.label17.Text = "Gestion des Incidents :";
            // 
            // buttonaffichermateriel
            // 
            this.buttonaffichermateriel.Location = new System.Drawing.Point(142, 322);
            this.buttonaffichermateriel.Name = "buttonaffichermateriel";
            this.buttonaffichermateriel.Size = new System.Drawing.Size(76, 23);
            this.buttonaffichermateriel.TabIndex = 13;
            this.buttonaffichermateriel.Text = "Afficher";
            this.buttonaffichermateriel.UseVisualStyleBackColor = true;
            // 
            // listBoxmateriel
            // 
            this.listBoxmateriel.FormattingEnabled = true;
            this.listBoxmateriel.Location = new System.Drawing.Point(157, 221);
            this.listBoxmateriel.Name = "listBoxmateriel";
            this.listBoxmateriel.Size = new System.Drawing.Size(120, 95);
            this.listBoxmateriel.TabIndex = 12;
            // 
            // buttonenregistrerincident
            // 
            this.buttonenregistrerincident.Location = new System.Drawing.Point(214, 503);
            this.buttonenregistrerincident.Name = "buttonenregistrerincident";
            this.buttonenregistrerincident.Size = new System.Drawing.Size(75, 23);
            this.buttonenregistrerincident.TabIndex = 11;
            this.buttonenregistrerincident.Text = "Enregistrer";
            this.buttonenregistrerincident.UseVisualStyleBackColor = true;
            // 
            // buttonetatincident
            // 
            this.buttonetatincident.Location = new System.Drawing.Point(3, 474);
            this.buttonetatincident.Name = "buttonetatincident";
            this.buttonetatincident.Size = new System.Drawing.Size(75, 23);
            this.buttonetatincident.TabIndex = 10;
            this.buttonetatincident.Text = "Etat";
            this.buttonetatincident.UseVisualStyleBackColor = true;
            // 
            // buttonaffilerincident
            // 
            this.buttonaffilerincident.Location = new System.Drawing.Point(214, 474);
            this.buttonaffilerincident.Name = "buttonaffilerincident";
            this.buttonaffilerincident.Size = new System.Drawing.Size(75, 23);
            this.buttonaffilerincident.TabIndex = 9;
            this.buttonaffilerincident.Text = "Affiller";
            this.buttonaffilerincident.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Matériels :";
            // 
            // textBoxmateriel
            // 
            this.textBoxmateriel.Location = new System.Drawing.Point(7, 240);
            this.textBoxmateriel.Name = "textBoxmateriel";
            this.textBoxmateriel.Size = new System.Drawing.Size(100, 20);
            this.textBoxmateriel.TabIndex = 7;
            // 
            // richTextBoxincident
            // 
            this.richTextBoxincident.Location = new System.Drawing.Point(84, 450);
            this.richTextBoxincident.Name = "richTextBoxincident";
            this.richTextBoxincident.Size = new System.Drawing.Size(124, 104);
            this.richTextBoxincident.TabIndex = 6;
            this.richTextBoxincident.Text = "";
            // 
            // buttonconsulterincident
            // 
            this.buttonconsulterincident.Location = new System.Drawing.Point(3, 503);
            this.buttonconsulterincident.Name = "buttonconsulterincident";
            this.buttonconsulterincident.Size = new System.Drawing.Size(75, 23);
            this.buttonconsulterincident.TabIndex = 4;
            this.buttonconsulterincident.Text = "Consulter";
            this.buttonconsulterincident.UseVisualStyleBackColor = true;
            // 
            // buttondeletemateriel
            // 
            this.buttondeletemateriel.Location = new System.Drawing.Point(224, 322);
            this.buttondeletemateriel.Name = "buttondeletemateriel";
            this.buttondeletemateriel.Size = new System.Drawing.Size(69, 23);
            this.buttondeletemateriel.TabIndex = 3;
            this.buttondeletemateriel.Text = "Delete";
            this.buttondeletemateriel.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Gestion du matériel :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.fnds;
            this.pictureBox4.Location = new System.Drawing.Point(22, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 186);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // buttonajoutermateriel
            // 
            this.buttonajoutermateriel.Location = new System.Drawing.Point(13, 266);
            this.buttonajoutermateriel.Name = "buttonajoutermateriel";
            this.buttonajoutermateriel.Size = new System.Drawing.Size(75, 23);
            this.buttonajoutermateriel.TabIndex = 0;
            this.buttonajoutermateriel.Text = "Ajouter";
            this.buttonajoutermateriel.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 694);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Accueille.ResumeLayout(false);
            this.Accueille.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Incident.ResumeLayout(false);
            this.Incident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Responsable.ResumeLayout(false);
            this.Responsable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Technicien.ResumeLayout(false);
            this.Technicien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Accueille;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TabPage Incident;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonafficherincident;
        private System.Windows.Forms.Button buttonEnregsitrerincident;
        private System.Windows.Forms.ListBox listBoxincident;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxProbleme;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage Responsable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonmodifiercompte;
        private System.Windows.Forms.Button buttonenregistrercompte;
        private System.Windows.Forms.Button buttonsupprimerintervenant;
        private System.Windows.Forms.Button buttonajoutercompte;
        private System.Windows.Forms.TabPage Technicien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonaffichermateriel;
        private System.Windows.Forms.ListBox listBoxmateriel;
        private System.Windows.Forms.Button buttonenregistrerincident;
        private System.Windows.Forms.Button buttonetatincident;
        private System.Windows.Forms.Button buttonaffilerincident;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxmateriel;
        private System.Windows.Forms.RichTextBox richTextBoxincident;
        private System.Windows.Forms.Button buttonconsulterincident;
        private System.Windows.Forms.Button buttondeletemateriel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonajoutermateriel;
        private System.Windows.Forms.RadioButton radioButtonutilisateur;
        private System.Windows.Forms.RadioButton radioButtonresponsable;
        private System.Windows.Forms.RadioButton radioButtonrtechnicien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxMatricule;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxNv;
        private System.Windows.Forms.Label label20;
    }
}

