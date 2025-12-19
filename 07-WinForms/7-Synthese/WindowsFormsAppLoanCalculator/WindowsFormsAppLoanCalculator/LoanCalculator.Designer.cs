namespace WindowsFormsAppLoanCalculator
{
    partial class LoanCalculator
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblCE = new System.Windows.Forms.Label();
            this.txtCE = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lblDureeMois = new System.Windows.Forms.Label();
            this.cmbPeriodicite = new System.Windows.Forms.ComboBox();
            this.lblPeriodicite = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTaux9 = new System.Windows.Forms.RadioButton();
            this.rdoTaux8 = new System.Windows.Forms.RadioButton();
            this.rdoTaux7 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblRemboursements = new System.Windows.Forms.Label();
            this.lblMontantRemboursement = new System.Windows.Forms.Label();
            this.lblTxtRemboursements = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(36, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(151, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(128, 22);
            this.txtNom.TabIndex = 1;
            // 
            // lblCE
            // 
            this.lblCE.AutoSize = true;
            this.lblCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCE.Location = new System.Drawing.Point(12, 50);
            this.lblCE.Name = "lblCE";
            this.lblCE.Size = new System.Drawing.Size(109, 16);
            this.lblCE.TabIndex = 2;
            this.lblCE.Text = "Capital Emprunté";
            // 
            // txtCE
            // 
            this.txtCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCE.Location = new System.Drawing.Point(151, 44);
            this.txtCE.Name = "txtCE";
            this.txtCE.Size = new System.Drawing.Size(128, 22);
            this.txtCE.TabIndex = 3;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(234, 85);
            this.hScrollBar1.Maximum = 120;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(101, 20);
            this.hScrollBar1.TabIndex = 4;
            this.hScrollBar1.Value = 1;
            // 
            // lblDureeMois
            // 
            this.lblDureeMois.AutoSize = true;
            this.lblDureeMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeMois.Location = new System.Drawing.Point(12, 85);
            this.lblDureeMois.Name = "lblDureeMois";
            this.lblDureeMois.Size = new System.Drawing.Size(209, 16);
            this.lblDureeMois.TabIndex = 5;
            this.lblDureeMois.Text = "Durée en mois du remboursement";
            // 
            // cmbPeriodicite
            // 
            this.cmbPeriodicite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriodicite.FormattingEnabled = true;
            this.cmbPeriodicite.Location = new System.Drawing.Point(15, 176);
            this.cmbPeriodicite.Name = "cmbPeriodicite";
            this.cmbPeriodicite.Size = new System.Drawing.Size(264, 24);
            this.cmbPeriodicite.TabIndex = 6;
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicite.Location = new System.Drawing.Point(12, 157);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(187, 16);
            this.lblPeriodicite.TabIndex = 7;
            this.lblPeriodicite.Text = "Périodicité de remboursement";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTaux9);
            this.groupBox1.Controls.Add(this.rdoTaux8);
            this.groupBox1.Controls.Add(this.rdoTaux7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(379, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'intérêt";
            // 
            // rdoTaux9
            // 
            this.rdoTaux9.AutoSize = true;
            this.rdoTaux9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTaux9.Location = new System.Drawing.Point(28, 105);
            this.rdoTaux9.Name = "rdoTaux9";
            this.rdoTaux9.Size = new System.Drawing.Size(46, 20);
            this.rdoTaux9.TabIndex = 2;
            this.rdoTaux9.TabStop = true;
            this.rdoTaux9.Text = "9%";
            this.rdoTaux9.UseVisualStyleBackColor = true;
            // 
            // rdoTaux8
            // 
            this.rdoTaux8.AutoSize = true;
            this.rdoTaux8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTaux8.Location = new System.Drawing.Point(28, 69);
            this.rdoTaux8.Name = "rdoTaux8";
            this.rdoTaux8.Size = new System.Drawing.Size(46, 20);
            this.rdoTaux8.TabIndex = 1;
            this.rdoTaux8.TabStop = true;
            this.rdoTaux8.Text = "8%";
            this.rdoTaux8.UseVisualStyleBackColor = true;
            // 
            // rdoTaux7
            // 
            this.rdoTaux7.AutoSize = true;
            this.rdoTaux7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTaux7.Location = new System.Drawing.Point(28, 32);
            this.rdoTaux7.Name = "rdoTaux7";
            this.rdoTaux7.Size = new System.Drawing.Size(46, 20);
            this.rdoTaux7.TabIndex = 0;
            this.rdoTaux7.TabStop = true;
            this.rdoTaux7.Text = "7%";
            this.rdoTaux7.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(521, 41);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(521, 78);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblRemboursements
            // 
            this.lblRemboursements.AutoSize = true;
            this.lblRemboursements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemboursements.ForeColor = System.Drawing.Color.Red;
            this.lblRemboursements.Location = new System.Drawing.Point(412, 183);
            this.lblRemboursements.Name = "lblRemboursements";
            this.lblRemboursements.Size = new System.Drawing.Size(19, 20);
            this.lblRemboursements.TabIndex = 11;
            this.lblRemboursements.Text = "1";
            // 
            // lblMontantRemboursement
            // 
            this.lblMontantRemboursement.AutoSize = true;
            this.lblMontantRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantRemboursement.ForeColor = System.Drawing.Color.Red;
            this.lblMontantRemboursement.Location = new System.Drawing.Point(475, 226);
            this.lblMontantRemboursement.Name = "lblMontantRemboursement";
            this.lblMontantRemboursement.Size = new System.Drawing.Size(54, 20);
            this.lblMontantRemboursement.TabIndex = 12;
            this.lblMontantRemboursement.Text = "0,00€";
            // 
            // lblTxtRemboursements
            // 
            this.lblTxtRemboursements.AutoSize = true;
            this.lblTxtRemboursements.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtRemboursements.Location = new System.Drawing.Point(446, 184);
            this.lblTxtRemboursements.Name = "lblTxtRemboursements";
            this.lblTxtRemboursements.Size = new System.Drawing.Size(141, 18);
            this.lblTxtRemboursements.TabIndex = 13;
            this.lblTxtRemboursements.Text = "Remboursements";
            // 
            // LoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(625, 324);
            this.Controls.Add(this.lblTxtRemboursements);
            this.Controls.Add(this.lblMontantRemboursement);
            this.Controls.Add(this.lblRemboursements);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPeriodicite);
            this.Controls.Add(this.cmbPeriodicite);
            this.Controls.Add(this.lblDureeMois);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.txtCE);
            this.Controls.Add(this.lblCE);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "LoanCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator d\'Emprunt";
            this.Load += new System.EventHandler(this.LoanCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblCE;
        private System.Windows.Forms.TextBox txtCE;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label lblDureeMois;
        private System.Windows.Forms.ComboBox cmbPeriodicite;
        private System.Windows.Forms.Label lblPeriodicite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTaux7;
        private System.Windows.Forms.RadioButton rdoTaux9;
        private System.Windows.Forms.RadioButton rdoTaux8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblRemboursements;
        private System.Windows.Forms.Label lblMontantRemboursement;
        private System.Windows.Forms.Label lblTxtRemboursements;
    }
}

