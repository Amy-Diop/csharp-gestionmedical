namespace AppGroupe2.View
{
    partial class frmRendezVous
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dtpDateRv = new System.Windows.Forms.DateTimePicker();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.cbSoin = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.dgRendezVous = new System.Windows.Forms.DataGridView();
            this.lblDateRv = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblSoin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // Labels
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(30, 30);
            this.lblPatient.Text = "Patient:";
            //
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(30, 70);
            this.lblMedecin.Text = "Médecin:";
            //
            this.lblSoin.AutoSize = true;
            this.lblSoin.Location = new System.Drawing.Point(30, 110);
            this.lblSoin.Text = "Soin:";
            //
            this.lblDateRv.AutoSize = true;
            this.lblDateRv.Location = new System.Drawing.Point(30, 150);
            this.lblDateRv.Text = "Date du RDV:";
            //
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(30, 190);
            this.lblStatut.Text = "Statut:";

            // ComboBoxes
            this.cbPatient.Location = new System.Drawing.Point(150, 30);
            this.cbMedecin.Location = new System.Drawing.Point(150, 70);
            this.cbSoin.Location = new System.Drawing.Point(150, 110);

            // DateTimePicker
            this.dtpDateRv.Location = new System.Drawing.Point(150, 150);

            // TextBox
            this.txtStatut.Location = new System.Drawing.Point(150, 190);

            // Buttons
            this.btnAjouter.Location = new System.Drawing.Point(420, 30);
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            this.btnModifier.Location = new System.Drawing.Point(420, 70);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            this.btnSupprimer.Location = new System.Drawing.Point(420, 110);
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            this.btnChoisir.Location = new System.Drawing.Point(420, 150);
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);

            // DataGridView
            this.dgRendezVous.Location = new System.Drawing.Point(30, 240);
            this.dgRendezVous.Size = new System.Drawing.Size(550, 200);

            // frmRendezVous
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.lblSoin);
            this.Controls.Add(this.lblDateRv);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.cbPatient);
            this.Controls.Add(this.cbMedecin);
            this.Controls.Add(this.cbSoin);
            this.Controls.Add(this.dtpDateRv);
            this.Controls.Add(this.txtStatut);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.dgRendezVous);
            this.Text = "Gestion des Rendez-Vous";
=======
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(224, 4);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(57, 29);
            this.btnChoisir.TabIndex = 48;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(137, 382);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(68, 29);
            this.btnSupprimer.TabIndex = 50;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModidier
            // 
            this.btnModidier.Location = new System.Drawing.Point(76, 382);
            this.btnModidier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModidier.Name = "btnModidier";
            this.btnModidier.Size = new System.Drawing.Size(57, 29);
            this.btnModidier.TabIndex = 49;
            this.btnModidier.Text = "Modifier";
            this.btnModidier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(7, 382);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(65, 29);
            this.btnAjouter.TabIndex = 46;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // txtNumeroOrdreMedecin
            // 
            this.txtNumeroOrdreMedecin.Location = new System.Drawing.Point(8, 339);
            this.txtNumeroOrdreMedecin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroOrdreMedecin.Name = "txtNumeroOrdreMedecin";
            this.txtNumeroOrdreMedecin.Size = new System.Drawing.Size(173, 20);
            this.txtNumeroOrdreMedecin.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Numero Ordre Medecin";
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(8, 289);
            this.txtSpecialite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(173, 20);
            this.txtSpecialite.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Specialite";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(8, 238);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(173, 20);
            this.txtIdentifiant.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Identifiant";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(8, 187);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(173, 20);
            this.txtTel.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(8, 86);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(173, 20);
            this.txtAdresse.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Adresse";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(8, 35);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(173, 20);
            this.txtNomPrenom.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nom Prenom";
            // 
            // dgMedecin
            // 
            this.dgMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedecin.Location = new System.Drawing.Point(224, 41);
            this.dgMedecin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.RowHeadersWidth = 62;
            this.dgMedecin.RowTemplate.Height = 28;
            this.dgMedecin.Size = new System.Drawing.Size(437, 376);
            this.dgMedecin.TabIndex = 34;
            this.dgMedecin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedecin_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(623, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 29);
            this.btnClose.TabIndex = 53;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModidier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumeroOrdreMedecin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMedecin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRendezVous";
            this.Text = "frmRendezVous";
>>>>>>> 7dca2b7eded134c4a8b98e40ec5cd32df444e37b
            this.Load += new System.EventHandler(this.frmRendezVous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateRv;
        private System.Windows.Forms.TextBox txtStatut;
        private System.Windows.Forms.ComboBox cbMedecin;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.ComboBox cbSoin;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.DataGridView dgRendezVous;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Label lblSoin;
        private System.Windows.Forms.Label lblDateRv;
        private System.Windows.Forms.Label lblStatut;
    }
}
