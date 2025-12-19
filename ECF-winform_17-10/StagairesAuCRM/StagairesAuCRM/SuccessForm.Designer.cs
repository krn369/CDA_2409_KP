namespace StagairesAuCRM
{
    partial class SuccessForm
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblNomStagiaire = new System.Windows.Forms.Label();
            this.lblJoursRestants = new System.Windows.Forms.Label();
            this.btnNouvelleInscription = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitre.Location = new System.Drawing.Point(50, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(350, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Inscription Validée !";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSection
            // 
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(50, 70);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(300, 25);
            this.lblSection.TabIndex = 1;
            this.lblSection.Text = "Section";
            this.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomStagiaire
            // 
            this.lblNomStagiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomStagiaire.Location = new System.Drawing.Point(50, 105);
            this.lblNomStagiaire.Name = "lblNomStagiaire";
            this.lblNomStagiaire.Size = new System.Drawing.Size(350, 20);
            this.lblNomStagiaire.TabIndex = 2;
            this.lblNomStagiaire.Text = "Stagiaire";
            this.lblNomStagiaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJoursRestants
            // 
            this.lblJoursRestants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoursRestants.ForeColor = System.Drawing.Color.Blue;
            this.lblJoursRestants.Location = new System.Drawing.Point(50, 135);
            this.lblJoursRestants.Name = "lblJoursRestants";
            this.lblJoursRestants.Size = new System.Drawing.Size(350, 20);
            this.lblJoursRestants.TabIndex = 3;
            this.lblJoursRestants.Text = "Jours restants";
            this.lblJoursRestants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNouvelleInscription
            // 
            this.btnNouvelleInscription.BackColor = System.Drawing.Color.LightBlue;
            this.btnNouvelleInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleInscription.Location = new System.Drawing.Point(80, 190);
            this.btnNouvelleInscription.Name = "btnNouvelleInscription";
            this.btnNouvelleInscription.Size = new System.Drawing.Size(130, 35);
            this.btnNouvelleInscription.TabIndex = 4;
            this.btnNouvelleInscription.Text = "Nouvelle Inscription";
            this.btnNouvelleInscription.UseVisualStyleBackColor = false;
            this.btnNouvelleInscription.Click += new System.EventHandler(this.btnNouvelleInscription_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightPink;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(250, 190);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 35);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouvelleInscription);
            this.Controls.Add(this.lblJoursRestants);
            this.Controls.Add(this.lblNomStagiaire);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription Validée !";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblNomStagiaire;
        private System.Windows.Forms.Label lblJoursRestants;
        private System.Windows.Forms.Button btnNouvelleInscription;
        private System.Windows.Forms.Button btnFermer;
    }
}