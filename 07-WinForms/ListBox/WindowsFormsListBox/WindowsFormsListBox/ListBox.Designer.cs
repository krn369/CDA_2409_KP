namespace WindowsFormsListBox
{
    partial class ListBox
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
            this.LstListe = new System.Windows.Forms.ListBox();
            this.txtNouvelElement = new System.Windows.Forms.TextBox();
            this.txtIndexElement = new System.Windows.Forms.TextBox();
            this.labelNE = new System.Windows.Forms.Label();
            this.labelIE = new System.Windows.Forms.Label();
            this.btnAjoutListe = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnViderListe = new System.Windows.Forms.Button();
            this.labelLL = new System.Windows.Forms.Label();
            this.textBoxTxt = new System.Windows.Forms.TextBox();
            this.labelIC = new System.Windows.Forms.Label();
            this.labelSI = new System.Windows.Forms.Label();
            this.labeltxt = new System.Windows.Forms.Label();
            this.textBoxIC = new System.Windows.Forms.TextBox();
            this.textBoxSI = new System.Windows.Forms.TextBox();
            this.grpProprietes = new System.Windows.Forms.GroupBox();
            this.grpProprietes.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstListe
            // 
            this.LstListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstListe.FormattingEnabled = true;
            this.LstListe.ItemHeight = 16;
            this.LstListe.Location = new System.Drawing.Point(12, 158);
            this.LstListe.Name = "LstListe";
            this.LstListe.Size = new System.Drawing.Size(147, 132);
            this.LstListe.TabIndex = 0;
            this.LstListe.SelectedIndexChanged += new System.EventHandler(this.LstListe_SelectedIndexChanged);
            // 
            // txtNouvelElement
            // 
            this.txtNouvelElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouvelElement.Location = new System.Drawing.Point(12, 28);
            this.txtNouvelElement.Name = "txtNouvelElement";
            this.txtNouvelElement.Size = new System.Drawing.Size(147, 22);
            this.txtNouvelElement.TabIndex = 1;
            // 
            // txtIndexElement
            // 
            this.txtIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndexElement.Location = new System.Drawing.Point(212, 28);
            this.txtIndexElement.Name = "txtIndexElement";
            this.txtIndexElement.Size = new System.Drawing.Size(100, 22);
            this.txtIndexElement.TabIndex = 2;
            // 
            // labelNE
            // 
            this.labelNE.AutoSize = true;
            this.labelNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNE.Location = new System.Drawing.Point(12, 9);
            this.labelNE.Name = "labelNE";
            this.labelNE.Size = new System.Drawing.Size(116, 16);
            this.labelNE.TabIndex = 3;
            this.labelNE.Text = "Nouvel Elément";
            // 
            // labelIE
            // 
            this.labelIE.AutoSize = true;
            this.labelIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIE.Location = new System.Drawing.Point(209, 9);
            this.labelIE.Name = "labelIE";
            this.labelIE.Size = new System.Drawing.Size(104, 16);
            this.labelIE.TabIndex = 4;
            this.labelIE.Text = "Index Elément";
            // 
            // btnAjoutListe
            // 
            this.btnAjoutListe.BackColor = System.Drawing.SystemColors.Info;
            this.btnAjoutListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutListe.Location = new System.Drawing.Point(12, 57);
            this.btnAjoutListe.Name = "btnAjoutListe";
            this.btnAjoutListe.Size = new System.Drawing.Size(109, 23);
            this.btnAjoutListe.TabIndex = 5;
            this.btnAjoutListe.Text = "Ajouter la Liste";
            this.btnAjoutListe.UseVisualStyleBackColor = false;
            this.btnAjoutListe.Click += new System.EventHandler(this.btnAjoutListe_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.SystemColors.Info;
            this.btnSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionner.Location = new System.Drawing.Point(341, 28);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(126, 23);
            this.btnSelectionner.TabIndex = 6;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnViderListe
            // 
            this.btnViderListe.BackColor = System.Drawing.SystemColors.Info;
            this.btnViderListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViderListe.Location = new System.Drawing.Point(341, 57);
            this.btnViderListe.Name = "btnViderListe";
            this.btnViderListe.Size = new System.Drawing.Size(126, 23);
            this.btnViderListe.TabIndex = 7;
            this.btnViderListe.Text = "Vider la Liste";
            this.btnViderListe.UseVisualStyleBackColor = false;
            this.btnViderListe.Click += new System.EventHandler(this.btnViderListe_Click);
            // 
            // labelLL
            // 
            this.labelLL.AutoSize = true;
            this.labelLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLL.Location = new System.Drawing.Point(9, 127);
            this.labelLL.Name = "labelLL";
            this.labelLL.Size = new System.Drawing.Size(60, 16);
            this.labelLL.TabIndex = 8;
            this.labelLL.Text = "LstListe";
            // 
            // textBoxTxt
            // 
            this.textBoxTxt.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTxt.Location = new System.Drawing.Point(143, 85);
            this.textBoxTxt.Name = "textBoxTxt";
            this.textBoxTxt.ReadOnly = true;
            this.textBoxTxt.Size = new System.Drawing.Size(130, 22);
            this.textBoxTxt.TabIndex = 15;
            // 
            // labelIC
            // 
            this.labelIC.AutoSize = true;
            this.labelIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIC.Location = new System.Drawing.Point(15, 34);
            this.labelIC.Name = "labelIC";
            this.labelIC.Size = new System.Drawing.Size(76, 16);
            this.labelIC.TabIndex = 10;
            this.labelIC.Text = "Items.Count";
            // 
            // labelSI
            // 
            this.labelSI.AutoSize = true;
            this.labelSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSI.Location = new System.Drawing.Point(15, 61);
            this.labelSI.Name = "labelSI";
            this.labelSI.Size = new System.Drawing.Size(93, 16);
            this.labelSI.TabIndex = 11;
            this.labelSI.Text = "SelectedIndex";
            // 
            // labeltxt
            // 
            this.labeltxt.AutoSize = true;
            this.labeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltxt.Location = new System.Drawing.Point(15, 88);
            this.labeltxt.Name = "labeltxt";
            this.labeltxt.Size = new System.Drawing.Size(33, 16);
            this.labeltxt.TabIndex = 12;
            this.labeltxt.Text = "Text";
            // 
            // textBoxIC
            // 
            this.textBoxIC.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIC.Location = new System.Drawing.Point(143, 28);
            this.textBoxIC.Name = "textBoxIC";
            this.textBoxIC.ReadOnly = true;
            this.textBoxIC.Size = new System.Drawing.Size(34, 22);
            this.textBoxIC.TabIndex = 13;
            // 
            // textBoxSI
            // 
            this.textBoxSI.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSI.Location = new System.Drawing.Point(143, 55);
            this.textBoxSI.Name = "textBoxSI";
            this.textBoxSI.ReadOnly = true;
            this.textBoxSI.Size = new System.Drawing.Size(34, 22);
            this.textBoxSI.TabIndex = 14;
            // 
            // grpProprietes
            // 
            this.grpProprietes.Controls.Add(this.labelIC);
            this.grpProprietes.Controls.Add(this.textBoxTxt);
            this.grpProprietes.Controls.Add(this.labelSI);
            this.grpProprietes.Controls.Add(this.textBoxSI);
            this.grpProprietes.Controls.Add(this.labeltxt);
            this.grpProprietes.Controls.Add(this.textBoxIC);
            this.grpProprietes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProprietes.Location = new System.Drawing.Point(194, 152);
            this.grpProprietes.Name = "grpProprietes";
            this.grpProprietes.Size = new System.Drawing.Size(278, 138);
            this.grpProprietes.TabIndex = 16;
            this.grpProprietes.TabStop = false;
            this.grpProprietes.Text = "Propriétés";
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(479, 302);
            this.Controls.Add(this.grpProprietes);
            this.Controls.Add(this.labelLL);
            this.Controls.Add(this.btnViderListe);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjoutListe);
            this.Controls.Add(this.labelIE);
            this.Controls.Add(this.labelNE);
            this.Controls.Add(this.txtIndexElement);
            this.Controls.Add(this.txtNouvelElement);
            this.Controls.Add(this.LstListe);
            this.Name = "ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les listes et leurs propriétés";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.grpProprietes.ResumeLayout(false);
            this.grpProprietes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstListe;
        private System.Windows.Forms.TextBox txtNouvelElement;
        private System.Windows.Forms.TextBox txtIndexElement;
        private System.Windows.Forms.Label labelNE;
        private System.Windows.Forms.Label labelIE;
        private System.Windows.Forms.Button btnAjoutListe;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnViderListe;
        private System.Windows.Forms.Label labelLL;
        private System.Windows.Forms.TextBox textBoxTxt;
        private System.Windows.Forms.Label labelIC;
        private System.Windows.Forms.Label labelSI;
        private System.Windows.Forms.Label labeltxt;
        private System.Windows.Forms.TextBox textBoxIC;
        private System.Windows.Forms.TextBox textBoxSI;
        private System.Windows.Forms.GroupBox grpProprietes;
    }
}

