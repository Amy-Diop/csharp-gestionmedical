using System;
using System.Windows.Forms;

namespace AppGroupe2.View
{
    partial class frmSoin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Déclarations des contrôles
        /// </summary>
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgSoins;

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgSoins = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 - Libellé
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé :";

            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(100, 27);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(200, 20);
            this.txtLibelle.TabIndex = 1;

            // 
            // label2 - Coût
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coût :";

            // 
            // txtCout
            // 
            this.txtCout.Location = new System.Drawing.Point(100, 67);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(200, 20);
            this.txtCout.TabIndex = 3;

            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(320, 45);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // 
            // dgSoins
            // 
            this.dgSoins.AllowUserToAddRows = false;
            this.dgSoins.AllowUserToDeleteRows = false;
            this.dgSoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoins.Location = new System.Drawing.Point(30, 110);
            this.dgSoins.Name = "dgSoins";
            this.dgSoins.ReadOnly = true;
            this.dgSoins.Size = new System.Drawing.Size(600, 250);
            this.dgSoins.TabIndex = 5;
            this.dgSoins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSoins_CellContentClick);

            //
            // Colonnes du DataGridView
            //
            var colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colId.Name = "IdSoin";
            colId.HeaderText = "ID";

            var colLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLibelle.Name = "Libelle";
            colLibelle.HeaderText = "Libellé";

            var colCout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCout.Name = "Cout";
            colCout.HeaderText = "Coût";

            var btnModify = new System.Windows.Forms.DataGridViewButtonColumn();
            btnModify.HeaderText = "Modifier";
            btnModify.Text = "Modifier";
            btnModify.UseColumnTextForButtonValue = true;

            var btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            btnDelete.HeaderText = "Supprimer";
            btnDelete.Text = "Supprimer";
            btnDelete.UseColumnTextForButtonValue = true;

            this.dgSoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colId, colLibelle, colCout, btnModify, btnDelete });

            // 
            // frmSoin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.dgSoins);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label1);
            this.Name = "frmSoin";
            this.Text = "Gestion des Soins";
            this.Load += new System.EventHandler(this.frmSoin_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgSoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

       


        #endregion
    }
}
