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
            this.dgPatient.Location = new System.Drawing.Point(351, 140);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.RowHeadersWidth = 62;
            this.dgPatient.RowTemplate.Height = 28;
            this.dgPatient.Size = new System.Drawing.Size(837, 511);
            this.dgPatient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Prenom";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(17, 53);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(257, 26);
            this.txtNomPrenom.TabIndex = 1;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(17, 131);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(257, 26);
            this.txtAdresse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(17, 287);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(257, 26);
            this.txtTel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone";
            // 
            // txtGroupeSanguin
            // 
            this.txtGroupeSanguin.Location = new System.Drawing.Point(17, 365);
            this.txtGroupeSanguin.Name = "txtGroupeSanguin";
            this.txtGroupeSanguin.Size = new System.Drawing.Size(257, 26);
            this.txtGroupeSanguin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Groupe Sanguin";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(17, 443);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(257, 26);
            this.txtPoids.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Poids";
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(17, 521);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(257, 26);
            this.txtTaille.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Taille";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 647);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(97, 44);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModidier
            // 
            this.btnModidier.Location = new System.Drawing.Point(124, 647);
            this.btnModidier.Name = "btnModidier";
            this.btnModidier.Size = new System.Drawing.Size(85, 44);
            this.btnModidier.TabIndex = 10;
            this.btnModidier.Text = "Modifier";
            this.btnModidier.UseVisualStyleBackColor = true;
            this.btnModidier.Click += new System.EventHandler(this.btnModidier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(215, 647);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(102, 44);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(289, 17);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(103, 44);
            this.btnChoisir.TabIndex = 9;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Location = new System.Drawing.Point(616, 54);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(115, 44);
            this.btnRendezVous.TabIndex = 15;
            this.btnRendezVous.Text = "RendezVous";
            this.btnRendezVous.UseVisualStyleBackColor = true;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click_1);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(509, 54);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(103, 44);
            this.btnRecherche.TabIndex = 14;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telephone";
            // 
            // txtRTelephone
            // 
            this.txtRTelephone.Location = new System.Drawing.Point(6, 54);
            this.txtRTelephone.Name = "txtRTelephone";
            this.txtRTelephone.Size = new System.Drawing.Size(195, 26);
            this.txtRTelephone.TabIndex = 12;
            this.txtRTelephone.TextChanged += new System.EventHandler(this.txtRtelephone_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Email";
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
            this.grpPatient.Location = new System.Drawing.Point(421, 12);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(794, 100);
            this.grpPatient.TabIndex = 24;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Recherche";
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(218, 56);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.Size = new System.Drawing.Size(223, 26);
            this.txtREmail.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Date Naissance";
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateNaissance.Location = new System.Drawing.Point(17, 597);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(257, 26);
            this.txtDateNaissance.TabIndex = 28;
            this.txtDateNaissance.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 840);
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