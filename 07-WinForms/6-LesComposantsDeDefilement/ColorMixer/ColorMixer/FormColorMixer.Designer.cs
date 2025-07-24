namespace ColorMixer
{
    partial class FormColorMixer
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
            this.lblRouge = new System.Windows.Forms.Label();
            this.hsbRouge = new System.Windows.Forms.HScrollBar();
            this.numRouge = new System.Windows.Forms.NumericUpDown();
            this.lblCouleurRouge = new System.Windows.Forms.Label();
            this.lblCouleurBleu = new System.Windows.Forms.Label();
            this.numBleu = new System.Windows.Forms.NumericUpDown();
            this.hsbBleu = new System.Windows.Forms.HScrollBar();
            this.lblBleu = new System.Windows.Forms.Label();
            this.lblCouleurVert = new System.Windows.Forms.Label();
            this.numVert = new System.Windows.Forms.NumericUpDown();
            this.hsbVert = new System.Windows.Forms.HScrollBar();
            this.lblVert = new System.Windows.Forms.Label();
            this.lblCouleurMix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRouge
            // 
            this.lblRouge.AutoSize = true;
            this.lblRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouge.Location = new System.Drawing.Point(12, 45);
            this.lblRouge.Name = "lblRouge";
            this.lblRouge.Size = new System.Drawing.Size(48, 16);
            this.lblRouge.TabIndex = 0;
            this.lblRouge.Text = "Rouge";
            // 
            // hsbRouge
            // 
            this.hsbRouge.Location = new System.Drawing.Point(73, 41);
            this.hsbRouge.LargeChange = 10;
            this.hsbRouge.Maximum = 264;
            this.hsbRouge.Name = "hsbRouge";
            this.hsbRouge.Size = new System.Drawing.Size(205, 20);
            this.hsbRouge.TabIndex = 1;
            this.hsbRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GestionnaireScrollBar);
            this.hsbRouge.ValueChanged += new System.EventHandler(this.GestionnaireScrollBar);
            // 
            // numRouge
            // 
            this.numRouge.Location = new System.Drawing.Point(281, 41);
            this.numRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRouge.Name = "numRouge";
            this.numRouge.Size = new System.Drawing.Size(65, 20);
            this.numRouge.TabIndex = 2;
            this.numRouge.ValueChanged += new System.EventHandler(this.num_ValeurChangee);
            // 
            // lblCouleurRouge
            // 
            this.lblCouleurRouge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCouleurRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleurRouge.Location = new System.Drawing.Point(352, 41);
            this.lblCouleurRouge.Name = "lblCouleurRouge";
            this.lblCouleurRouge.Size = new System.Drawing.Size(69, 20);
            this.lblCouleurRouge.TabIndex = 3;
            // 
            // lblCouleurBleu
            // 
            this.lblCouleurBleu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCouleurBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleurBleu.Location = new System.Drawing.Point(352, 74);
            this.lblCouleurBleu.Name = "lblCouleurBleu";
            this.lblCouleurBleu.Size = new System.Drawing.Size(69, 20);
            this.lblCouleurBleu.TabIndex = 7;
            // 
            // numBleu
            // 
            this.numBleu.Location = new System.Drawing.Point(281, 74);
            this.numBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBleu.Name = "numBleu";
            this.numBleu.Size = new System.Drawing.Size(65, 20);
            this.numBleu.TabIndex = 6;
            this.numBleu.ValueChanged += new System.EventHandler(this.num_ValeurChangee);
            // 
            // hsbBleu
            // 
            this.hsbBleu.Location = new System.Drawing.Point(73, 74);
            this.hsbBleu.LargeChange = 10;
            this.hsbBleu.Maximum = 264;
            this.hsbBleu.Name = "hsbBleu";
            this.hsbBleu.Size = new System.Drawing.Size(205, 20);
            this.hsbBleu.TabIndex = 5;
            this.hsbBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GestionnaireScrollBar);
            this.hsbBleu.ValueChanged += new System.EventHandler(this.GestionnaireScrollBar);
            // 
            // lblBleu
            // 
            this.lblBleu.AutoSize = true;
            this.lblBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBleu.Location = new System.Drawing.Point(12, 78);
            this.lblBleu.Name = "lblBleu";
            this.lblBleu.Size = new System.Drawing.Size(34, 16);
            this.lblBleu.TabIndex = 4;
            this.lblBleu.Text = "Bleu";
            // 
            // lblCouleurVert
            // 
            this.lblCouleurVert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCouleurVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleurVert.Location = new System.Drawing.Point(352, 105);
            this.lblCouleurVert.Name = "lblCouleurVert";
            this.lblCouleurVert.Size = new System.Drawing.Size(69, 20);
            this.lblCouleurVert.TabIndex = 11;
            // 
            // numVert
            // 
            this.numVert.Location = new System.Drawing.Point(281, 105);
            this.numVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numVert.Name = "numVert";
            this.numVert.Size = new System.Drawing.Size(65, 20);
            this.numVert.TabIndex = 10;
            this.numVert.ValueChanged += new System.EventHandler(this.num_ValeurChangee);
            // 
            // hsbVert
            // 
            this.hsbVert.Location = new System.Drawing.Point(73, 105);
            this.hsbVert.LargeChange = 10;
            this.hsbVert.Maximum = 264;
            this.hsbVert.Name = "hsbVert";
            this.hsbVert.Size = new System.Drawing.Size(205, 20);
            this.hsbVert.TabIndex = 9;
            this.hsbVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GestionnaireScrollBar);
            this.hsbVert.ValueChanged += new System.EventHandler(this.GestionnaireScrollBar);
            // 
            // lblVert
            // 
            this.lblVert.AutoSize = true;
            this.lblVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVert.Location = new System.Drawing.Point(12, 109);
            this.lblVert.Name = "lblVert";
            this.lblVert.Size = new System.Drawing.Size(31, 16);
            this.lblVert.TabIndex = 8;
            this.lblVert.Text = "Vert";
            // 
            // lblCouleurMix
            // 
            this.lblCouleurMix.BackColor = System.Drawing.SystemColors.Window;
            this.lblCouleurMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleurMix.Location = new System.Drawing.Point(70, 162);
            this.lblCouleurMix.Name = "lblCouleurMix";
            this.lblCouleurMix.Size = new System.Drawing.Size(276, 50);
            this.lblCouleurMix.TabIndex = 12;
            this.lblCouleurMix.Text = "Couleur Mixte";
            // 
            // FormColorMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(433, 265);
            this.Controls.Add(this.lblCouleurMix);
            this.Controls.Add(this.lblCouleurVert);
            this.Controls.Add(this.numVert);
            this.Controls.Add(this.hsbVert);
            this.Controls.Add(this.lblVert);
            this.Controls.Add(this.lblCouleurBleu);
            this.Controls.Add(this.numBleu);
            this.Controls.Add(this.hsbBleu);
            this.Controls.Add(this.lblBleu);
            this.Controls.Add(this.lblCouleurRouge);
            this.Controls.Add(this.numRouge);
            this.Controls.Add(this.hsbRouge);
            this.Controls.Add(this.lblRouge);
            this.Name = "FormColorMixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRouge;
        private System.Windows.Forms.HScrollBar hsbRouge;
        private System.Windows.Forms.NumericUpDown numRouge;
        private System.Windows.Forms.Label lblCouleurRouge;
        private System.Windows.Forms.Label lblCouleurBleu;
        private System.Windows.Forms.NumericUpDown numBleu;
        private System.Windows.Forms.HScrollBar hsbBleu;
        private System.Windows.Forms.Label lblBleu;
        private System.Windows.Forms.Label lblCouleurVert;
        private System.Windows.Forms.NumericUpDown numVert;
        private System.Windows.Forms.HScrollBar hsbVert;
        private System.Windows.Forms.Label lblVert;
        private System.Windows.Forms.Label lblCouleurMix;
    }
}

