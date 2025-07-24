namespace WindowsFormsAppGestionListes
{
    partial class Form1
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
            this.comboSource = new System.Windows.Forms.ComboBox();
            this.listCible = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAjouterTous = new System.Windows.Forms.Button();
            this.btnRetourner = new System.Windows.Forms.Button();
            this.btnRetournerTous = new System.Windows.Forms.Button();
            this.btnMonter = new System.Windows.Forms.Button();
            this.btnDescendre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboSource
            // 
            this.comboSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSource.FormattingEnabled = true;
            this.comboSource.Location = new System.Drawing.Point(12, 40);
            this.comboSource.Name = "comboSource";
            this.comboSource.Size = new System.Drawing.Size(163, 24);
            this.comboSource.TabIndex = 0;
            this.comboSource.DropDown += new System.EventHandler(this.comboSource_DropDown);
            this.comboSource.SelectedIndexChanged += new System.EventHandler(this.comboSource_SelectedIndexChanged);
            // 
            // listCible
            // 
            this.listCible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCible.FormattingEnabled = true;
            this.listCible.ItemHeight = 16;
            this.listCible.Location = new System.Drawing.Point(326, 40);
            this.listCible.Name = "listCible";
            this.listCible.Size = new System.Drawing.Size(157, 180);
            this.listCible.TabIndex = 1;
            this.listCible.SelectedIndexChanged += new System.EventHandler(this.listCible_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(212, 40);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = ">";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAjouterTous
            // 
            this.btnAjouterTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTous.Location = new System.Drawing.Point(212, 69);
            this.btnAjouterTous.Name = "btnAjouterTous";
            this.btnAjouterTous.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTous.TabIndex = 3;
            this.btnAjouterTous.Text = ">>";
            this.btnAjouterTous.UseVisualStyleBackColor = true;
            this.btnAjouterTous.Click += new System.EventHandler(this.btnAjouterTous_Click);
            // 
            // btnRetourner
            // 
            this.btnRetourner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourner.Location = new System.Drawing.Point(212, 166);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(75, 23);
            this.btnRetourner.TabIndex = 4;
            this.btnRetourner.Text = "<";
            this.btnRetourner.UseVisualStyleBackColor = true;
            this.btnRetourner.Click += new System.EventHandler(this.btnRetourner_Click);
            // 
            // btnRetournerTous
            // 
            this.btnRetournerTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetournerTous.Location = new System.Drawing.Point(212, 197);
            this.btnRetournerTous.Name = "btnRetournerTous";
            this.btnRetournerTous.Size = new System.Drawing.Size(75, 23);
            this.btnRetournerTous.TabIndex = 5;
            this.btnRetournerTous.Text = "<<";
            this.btnRetournerTous.UseVisualStyleBackColor = true;
            this.btnRetournerTous.Click += new System.EventHandler(this.btnRetournerTous_Click);
            // 
            // btnMonter
            // 
            this.btnMonter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonter.Location = new System.Drawing.Point(381, 244);
            this.btnMonter.Name = "btnMonter";
            this.btnMonter.Size = new System.Drawing.Size(29, 31);
            this.btnMonter.TabIndex = 6;
            this.btnMonter.Text = "↑";
            this.btnMonter.UseVisualStyleBackColor = true;
            this.btnMonter.Click += new System.EventHandler(this.btnMonter_Click);
            // 
            // btnDescendre
            // 
            this.btnDescendre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescendre.Location = new System.Drawing.Point(416, 244);
            this.btnDescendre.Name = "btnDescendre";
            this.btnDescendre.Size = new System.Drawing.Size(29, 31);
            this.btnDescendre.TabIndex = 7;
            this.btnDescendre.Text = "↓";
            this.btnDescendre.UseVisualStyleBackColor = true;
            this.btnDescendre.Click += new System.EventHandler(this.btnDescendre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(495, 298);
            this.Controls.Add(this.btnDescendre);
            this.Controls.Add(this.btnMonter);
            this.Controls.Add(this.btnRetournerTous);
            this.Controls.Add(this.btnRetourner);
            this.Controls.Add(this.btnAjouterTous);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.listCible);
            this.Controls.Add(this.comboSource);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les listes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSource;
        private System.Windows.Forms.ListBox listCible;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAjouterTous;
        private System.Windows.Forms.Button btnRetourner;
        private System.Windows.Forms.Button btnRetournerTous;
        private System.Windows.Forms.Button btnMonter;
        private System.Windows.Forms.Button btnDescendre;
    }
}

