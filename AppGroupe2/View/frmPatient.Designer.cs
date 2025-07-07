namespace AppGroupe2.View
{
    partial class frmPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgPatient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroupeSanguin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModidier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRTelephone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateNaissance = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.grpPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPatient
            // 
            this.dgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatient.Location = new System.Drawing.Point(234, 91);
            this.dgPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.RowHeadersWidth = 62;
            this.dgPatient.RowTemplate.Height = 28;
            this.dgPatient.Size = new System.Drawing.Size(558, 332);
            this.dgPatient.TabIndex = 0;
            this.dgPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPatient_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Prenom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(11, 34);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(173, 20);
            this.txtNomPrenom.TabIndex = 1;
            this.txtNomPrenom.TextChanged += new System.EventHandler(this.txtNomPrenom_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(11, 85);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(173, 20);
            this.txtAdresse.TabIndex = 2;
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(11, 187);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(173, 20);
            this.txtTel.TabIndex = 4;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtGroupeSanguin
            // 
            this.txtGroupeSanguin.Location = new System.Drawing.Point(11, 237);
            this.txtGroupeSanguin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGroupeSanguin.Name = "txtGroupeSanguin";
            this.txtGroupeSanguin.Size = new System.Drawing.Size(173, 20);
            this.txtGroupeSanguin.TabIndex = 5;
            this.txtGroupeSanguin.TextChanged += new System.EventHandler(this.txtGroupeSanguin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Groupe Sanguin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(11, 288);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(173, 20);
            this.txtPoids.TabIndex = 6;
            this.txtPoids.TextChanged += new System.EventHandler(this.txtPoids_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Poids";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(11, 339);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(173, 20);
            this.txtTaille.TabIndex = 7;
            this.txtTaille.TextChanged += new System.EventHandler(this.txtTaille_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Taille";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(14, 421);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(65, 29);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModidier
            // 
            this.btnModidier.Location = new System.Drawing.Point(83, 421);
            this.btnModidier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModidier.Name = "btnModidier";
            this.btnModidier.Size = new System.Drawing.Size(57, 29);
            this.btnModidier.TabIndex = 10;
            this.btnModidier.Text = "Modifier";
            this.btnModidier.UseVisualStyleBackColor = true;
            this.btnModidier.Click += new System.EventHandler(this.btnModidier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(143, 421);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(68, 29);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(193, 11);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(69, 29);
            this.btnChoisir.TabIndex = 9;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Location = new System.Drawing.Point(411, 35);
            this.btnRendezVous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(77, 29);
            this.btnRendezVous.TabIndex = 15;
            this.btnRendezVous.Text = "RendezVous";
            this.btnRendezVous.UseVisualStyleBackColor = true;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click_1);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(339, 35);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(69, 29);
            this.btnRecherche.TabIndex = 14;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telephone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtRTelephone
            // 
            this.txtRTelephone.Location = new System.Drawing.Point(4, 35);
            this.txtRTelephone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRTelephone.Name = "txtRTelephone";
            this.txtRTelephone.Size = new System.Drawing.Size(131, 20);
            this.txtRTelephone.TabIndex = 12;
            this.txtRTelephone.TextChanged += new System.EventHandler(this.txtRtelephone_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Email";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // grpPatient
            // 
            this.grpPatient.BackColor = System.Drawing.Color.Silver;
            this.grpPatient.Controls.Add(this.txtREmail);
            this.grpPatient.Controls.Add(this.label9);
            this.grpPatient.Controls.Add(this.btnRendezVous);
            this.grpPatient.Controls.Add(this.btnRecherche);
            this.grpPatient.Controls.Add(this.txtRTelephone);
            this.grpPatient.Controls.Add(this.label10);
            this.grpPatient.Location = new System.Drawing.Point(281, 8);
            this.grpPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPatient.Size = new System.Drawing.Size(529, 65);
            this.grpPatient.TabIndex = 24;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Recherche";
            this.grpPatient.Enter += new System.EventHandler(this.grpPatient_Enter);
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(145, 36);
            this.txtREmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.Size = new System.Drawing.Size(150, 20);
            this.txtREmail.TabIndex = 13;
            this.txtREmail.TextChanged += new System.EventHandler(this.txtREmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 364);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Date Naissance";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateNaissance.Location = new System.Drawing.Point(11, 388);
            this.txtDateNaissance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(173, 20);
            this.txtDateNaissance.TabIndex = 28;
            this.txtDateNaissance.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.ControlBox = false;
            this.Controls.Add(this.txtDateNaissance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpPatient);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModidier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGroupeSanguin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPatient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroupeSanguin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModidier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRTelephone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.TextBox txtREmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDateNaissance;
    }
}