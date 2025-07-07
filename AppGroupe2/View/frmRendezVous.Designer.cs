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
