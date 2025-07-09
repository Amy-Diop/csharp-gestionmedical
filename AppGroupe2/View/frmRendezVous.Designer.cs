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
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.lblSoin = new System.Windows.Forms.Label();
            this.lblDateRv = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateRv
            // 
            this.dtpDateRv.Location = new System.Drawing.Point(169, 188);
            this.dtpDateRv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateRv.Name = "dtpDateRv";
            this.dtpDateRv.Size = new System.Drawing.Size(281, 26);
            this.dtpDateRv.TabIndex = 8;
            // 
            // txtStatut
            // 
            this.txtStatut.Location = new System.Drawing.Point(169, 238);
            this.txtStatut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(281, 26);
            this.txtStatut.TabIndex = 9;
            // 
            // cbMedecin
            // 
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(169, 88);
            this.cbMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(281, 28);
            this.cbMedecin.TabIndex = 6;
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(169, 38);
            this.cbPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(281, 28);
            this.cbPatient.TabIndex = 5;
            // 
            // cbSoin
            // 
            this.cbSoin.FormattingEnabled = true;
            this.cbSoin.Location = new System.Drawing.Point(169, 138);
            this.cbSoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSoin.Name = "cbSoin";
            this.cbSoin.Size = new System.Drawing.Size(281, 28);
            this.cbSoin.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(472, 38);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 38);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(472, 88);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 38);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(472, 138);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 38);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(472, 188);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(112, 38);
            this.btnChoisir.TabIndex = 13;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // dgRendezVous
            // 
            this.dgRendezVous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRendezVous.Location = new System.Drawing.Point(34, 300);
            this.dgRendezVous.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRendezVous.Name = "dgRendezVous";
            this.dgRendezVous.RowHeadersWidth = 62;
            this.dgRendezVous.Size = new System.Drawing.Size(619, 250);
            this.dgRendezVous.TabIndex = 14;
            this.dgRendezVous.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRendezVous_CellContentClick);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(34, 38);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(63, 20);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Patient:";
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(34, 88);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(73, 20);
            this.lblMedecin.TabIndex = 1;
            this.lblMedecin.Text = "Médecin:";
            // 
            // lblSoin
            // 
            this.lblSoin.AutoSize = true;
            this.lblSoin.Location = new System.Drawing.Point(34, 138);
            this.lblSoin.Name = "lblSoin";
            this.lblSoin.Size = new System.Drawing.Size(45, 20);
            this.lblSoin.TabIndex = 2;
            this.lblSoin.Text = "Soin:";
            // 
            // lblDateRv
            // 
            this.lblDateRv.AutoSize = true;
            this.lblDateRv.Location = new System.Drawing.Point(34, 188);
            this.lblDateRv.Name = "lblDateRv";
            this.lblDateRv.Size = new System.Drawing.Size(109, 20);
            this.lblDateRv.TabIndex = 3;
            this.lblDateRv.Text = "Date du RDV:";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(34, 238);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(57, 20);
            this.lblStatut.TabIndex = 4;
            this.lblStatut.Text = "Statut:";
            // 
            // frmRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 600);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRendezVous";
            this.Text = "Gestion des Rendez-Vous";
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
