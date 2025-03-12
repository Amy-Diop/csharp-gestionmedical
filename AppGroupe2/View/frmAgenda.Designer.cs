namespace AppGroupe2.View
{
    partial class frmAgenda
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
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModidier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtCreneau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAgenda = new System.Windows.Forms.DataGridView();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.txtDateAgenda = new System.Windows.Forms.DateTimePicker();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.lblIdMedecin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(326, 4);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(85, 44);
            this.btnChoisir.TabIndex = 48;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(196, 581);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(102, 44);
            this.btnSupprimer.TabIndex = 50;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModidier
            // 
            this.btnModidier.Location = new System.Drawing.Point(105, 581);
            this.btnModidier.Name = "btnModidier";
            this.btnModidier.Size = new System.Drawing.Size(85, 44);
            this.btnModidier.TabIndex = 49;
            this.btnModidier.Text = "Modifier";
            this.btnModidier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(2, 581);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(97, 44);
            this.btnAjouter.TabIndex = 46;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtCreneau
            // 
            this.txtCreneau.Location = new System.Drawing.Point(2, 442);
            this.txtCreneau.Name = "txtCreneau";
            this.txtCreneau.Size = new System.Drawing.Size(257, 26);
            this.txtCreneau.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Creneau";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(2, 364);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(257, 26);
            this.txtLieu.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Lieu";
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Location = new System.Drawing.Point(2, 286);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(257, 26);
            this.txtHeureFin.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Heure fin";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(2, 208);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(257, 26);
            this.txtHeureDebut.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Heure debut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(2, 54);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(257, 26);
            this.txtTitre.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Titre";
            // 
            // dgAgenda
            // 
            this.dgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgenda.Location = new System.Drawing.Point(326, 61);
            this.dgAgenda.Name = "dgAgenda";
            this.dgAgenda.RowHeadersWidth = 62;
            this.dgAgenda.RowTemplate.Height = 28;
            this.dgAgenda.Size = new System.Drawing.Size(656, 578);
            this.dgAgenda.TabIndex = 34;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.Location = new System.Drawing.Point(1, 651);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(0, 26);
            this.lblMedecin.TabIndex = 53;
            // 
            // txtDateAgenda
            // 
            this.txtDateAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateAgenda.Location = new System.Drawing.Point(2, 119);
            this.txtDateAgenda.Name = "txtDateAgenda";
            this.txtDateAgenda.Size = new System.Drawing.Size(257, 26);
            this.txtDateAgenda.TabIndex = 54;
            // 
            // BtnFermer
            // 
            this.BtnFermer.Location = new System.Drawing.Point(1105, 4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(85, 44);
            this.BtnFermer.TabIndex = 55;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // lblIdMedecin
            // 
            this.lblIdMedecin.AutoSize = true;
            this.lblIdMedecin.Location = new System.Drawing.Point(2, 505);
            this.lblIdMedecin.Name = "lblIdMedecin";
            this.lblIdMedecin.Size = new System.Drawing.Size(0, 20);
            this.lblIdMedecin.TabIndex = 56;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 840);
            this.ControlBox = false;
            this.Controls.Add(this.lblIdMedecin);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.txtDateAgenda);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModidier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtCreneau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHeureFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAgenda);
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModidier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtCreneau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAgenda;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.DateTimePicker txtDateAgenda;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label lblIdMedecin;
    }
}