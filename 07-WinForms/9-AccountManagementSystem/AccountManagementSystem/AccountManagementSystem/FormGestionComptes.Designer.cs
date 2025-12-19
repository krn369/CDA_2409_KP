namespace AccountManagementSystem
{
    partial class FormGestionComptes
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
            this.btnTestReference = new System.Windows.Forms.Button();
            this.btnTestPersistence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestReference
            // 
            this.btnTestReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestReference.Location = new System.Drawing.Point(12, 25);
            this.btnTestReference.Name = "btnTestReference";
            this.btnTestReference.Size = new System.Drawing.Size(142, 23);
            this.btnTestReference.TabIndex = 0;
            this.btnTestReference.Text = "Test Reference";
            this.btnTestReference.UseVisualStyleBackColor = true;
            this.btnTestReference.Click += new System.EventHandler(this.btnTestReference_Click);
            // 
            // btnTestPersistence
            // 
            this.btnTestPersistence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestPersistence.Location = new System.Drawing.Point(12, 68);
            this.btnTestPersistence.Name = "btnTestPersistence";
            this.btnTestPersistence.Size = new System.Drawing.Size(142, 23);
            this.btnTestPersistence.TabIndex = 1;
            this.btnTestPersistence.Text = "Test Persistence";
            this.btnTestPersistence.UseVisualStyleBackColor = true;
            this.btnTestPersistence.Click += new System.EventHandler(this.btnTestPersistence_Click);
            // 
            // FormGestionComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 413);
            this.Controls.Add(this.btnTestPersistence);
            this.Controls.Add(this.btnTestReference);
            this.Name = "FormGestionComptes";
            this.Text = "AccountManagement";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestReference;
        private System.Windows.Forms.Button btnTestPersistence;
    }
}

