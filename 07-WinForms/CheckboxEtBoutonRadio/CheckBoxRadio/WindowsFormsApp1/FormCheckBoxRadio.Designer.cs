namespace WindowsFormsCheckBoxRadio
{
    partial class FormCheckBoxRadio
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelTxtBox = new System.Windows.Forms.Label();
            this.ckBoxBC = new System.Windows.Forms.CheckBox();
            this.ckBoxTC = new System.Windows.Forms.CheckBox();
            this.ckBoxCase = new System.Windows.Forms.CheckBox();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.groupBoxBG = new System.Windows.Forms.GroupBox();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.radioBtnGreen = new System.Windows.Forms.RadioButton();
            this.radioBtnPink = new System.Windows.Forms.RadioButton();
            this.groupBoxTC = new System.Windows.Forms.GroupBox();
            this.radioTxtYellow = new System.Windows.Forms.RadioButton();
            this.radioTxtWhite = new System.Windows.Forms.RadioButton();
            this.radioTxtRed = new System.Windows.Forms.RadioButton();
            this.groupBoxCase = new System.Windows.Forms.GroupBox();
            this.radioUpper = new System.Windows.Forms.RadioButton();
            this.radioLower = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxBG.SuspendLayout();
            this.groupBoxTC.SuspendLayout();
            this.groupBoxCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(27, 46);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(235, 22);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // labelTxtBox
            // 
            this.labelTxtBox.AutoSize = true;
            this.labelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxtBox.Location = new System.Drawing.Point(24, 18);
            this.labelTxtBox.Name = "labelTxtBox";
            this.labelTxtBox.Size = new System.Drawing.Size(127, 16);
            this.labelTxtBox.TabIndex = 1;
            this.labelTxtBox.Text = "Tapez votre texte";
            // 
            // ckBoxBC
            // 
            this.ckBoxBC.AutoSize = true;
            this.ckBoxBC.Enabled = false;
            this.ckBoxBC.Location = new System.Drawing.Point(16, 19);
            this.ckBoxBC.Name = "ckBoxBC";
            this.ckBoxBC.Size = new System.Drawing.Size(101, 17);
            this.ckBoxBC.TabIndex = 2;
            this.ckBoxBC.Text = "Couleur du fond";
            this.ckBoxBC.UseVisualStyleBackColor = true;
            this.ckBoxBC.CheckedChanged += new System.EventHandler(this.ckBoxBC_CheckedChanged);
            // 
            // ckBoxTC
            // 
            this.ckBoxTC.AutoSize = true;
            this.ckBoxTC.Enabled = false;
            this.ckBoxTC.Location = new System.Drawing.Point(16, 42);
            this.ckBoxTC.Name = "ckBoxTC";
            this.ckBoxTC.Size = new System.Drawing.Size(135, 17);
            this.ckBoxTC.TabIndex = 3;
            this.ckBoxTC.Text = "Couleur des caractères";
            this.ckBoxTC.UseVisualStyleBackColor = true;
            this.ckBoxTC.CheckedChanged += new System.EventHandler(this.ckBoxTC_CheckedChanged);
            // 
            // ckBoxCase
            // 
            this.ckBoxCase.AutoSize = true;
            this.ckBoxCase.Enabled = false;
            this.ckBoxCase.Location = new System.Drawing.Point(16, 65);
            this.ckBoxCase.Name = "ckBoxCase";
            this.ckBoxCase.Size = new System.Drawing.Size(55, 17);
            this.ckBoxCase.TabIndex = 4;
            this.ckBoxCase.Text = "Casse";
            this.ckBoxCase.UseVisualStyleBackColor = true;
            this.ckBoxCase.CheckedChanged += new System.EventHandler(this.ckBoxCase_CheckedChanged);
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.ckBoxBC);
            this.groupBoxChoix.Controls.Add(this.ckBoxCase);
            this.groupBoxChoix.Controls.Add(this.ckBoxTC);
            this.groupBoxChoix.Location = new System.Drawing.Point(280, 18);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(162, 100);
            this.groupBoxChoix.TabIndex = 5;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // groupBoxBG
            // 
            this.groupBoxBG.Controls.Add(this.radioBtnBlue);
            this.groupBoxBG.Controls.Add(this.radioBtnGreen);
            this.groupBoxBG.Controls.Add(this.radioBtnPink);
            this.groupBoxBG.Location = new System.Drawing.Point(27, 156);
            this.groupBoxBG.Name = "groupBoxBG";
            this.groupBoxBG.Size = new System.Drawing.Size(117, 89);
            this.groupBoxBG.TabIndex = 6;
            this.groupBoxBG.TabStop = false;
            this.groupBoxBG.Text = "Fond";
            this.groupBoxBG.Visible = false;
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.AutoSize = true;
            this.radioBtnBlue.Location = new System.Drawing.Point(6, 65);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(46, 17);
            this.radioBtnBlue.TabIndex = 2;
            this.radioBtnBlue.TabStop = true;
            this.radioBtnBlue.Text = "Bleu";
            this.radioBtnBlue.UseVisualStyleBackColor = true;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.radioBtnBlue_CheckedChanged);
            // 
            // radioBtnGreen
            // 
            this.radioBtnGreen.AutoSize = true;
            this.radioBtnGreen.Location = new System.Drawing.Point(6, 42);
            this.radioBtnGreen.Name = "radioBtnGreen";
            this.radioBtnGreen.Size = new System.Drawing.Size(44, 17);
            this.radioBtnGreen.TabIndex = 1;
            this.radioBtnGreen.TabStop = true;
            this.radioBtnGreen.Text = "Vert";
            this.radioBtnGreen.UseVisualStyleBackColor = true;
            this.radioBtnGreen.CheckedChanged += new System.EventHandler(this.radioBtnGreen_CheckedChanged);
            // 
            // radioBtnPink
            // 
            this.radioBtnPink.AutoSize = true;
            this.radioBtnPink.Location = new System.Drawing.Point(6, 19);
            this.radioBtnPink.Name = "radioBtnPink";
            this.radioBtnPink.Size = new System.Drawing.Size(50, 17);
            this.radioBtnPink.TabIndex = 0;
            this.radioBtnPink.TabStop = true;
            this.radioBtnPink.Text = "Rose";
            this.radioBtnPink.UseVisualStyleBackColor = true;
            this.radioBtnPink.CheckedChanged += new System.EventHandler(this.radioBtnPink_CheckedChanged);
            // 
            // groupBoxTC
            // 
            this.groupBoxTC.Controls.Add(this.radioTxtYellow);
            this.groupBoxTC.Controls.Add(this.radioTxtWhite);
            this.groupBoxTC.Controls.Add(this.radioTxtRed);
            this.groupBoxTC.Location = new System.Drawing.Point(150, 156);
            this.groupBoxTC.Name = "groupBoxTC";
            this.groupBoxTC.Size = new System.Drawing.Size(108, 89);
            this.groupBoxTC.TabIndex = 7;
            this.groupBoxTC.TabStop = false;
            this.groupBoxTC.Text = "Caractères";
            this.groupBoxTC.Visible = false;
            // 
            // radioTxtYellow
            // 
            this.radioTxtYellow.AutoSize = true;
            this.radioTxtYellow.Location = new System.Drawing.Point(6, 65);
            this.radioTxtYellow.Name = "radioTxtYellow";
            this.radioTxtYellow.Size = new System.Drawing.Size(56, 17);
            this.radioTxtYellow.TabIndex = 3;
            this.radioTxtYellow.TabStop = true;
            this.radioTxtYellow.Text = "Yellow";
            this.radioTxtYellow.UseVisualStyleBackColor = true;
            this.radioTxtYellow.CheckedChanged += new System.EventHandler(this.radioTxtYellow_CheckedChanged);
            // 
            // radioTxtWhite
            // 
            this.radioTxtWhite.AutoSize = true;
            this.radioTxtWhite.Location = new System.Drawing.Point(6, 42);
            this.radioTxtWhite.Name = "radioTxtWhite";
            this.radioTxtWhite.Size = new System.Drawing.Size(52, 17);
            this.radioTxtWhite.TabIndex = 2;
            this.radioTxtWhite.TabStop = true;
            this.radioTxtWhite.Text = "Blanc";
            this.radioTxtWhite.UseVisualStyleBackColor = true;
            this.radioTxtWhite.CheckedChanged += new System.EventHandler(this.radioTxtWhite_CheckedChanged);
            // 
            // radioTxtRed
            // 
            this.radioTxtRed.AutoSize = true;
            this.radioTxtRed.Location = new System.Drawing.Point(6, 19);
            this.radioTxtRed.Name = "radioTxtRed";
            this.radioTxtRed.Size = new System.Drawing.Size(57, 17);
            this.radioTxtRed.TabIndex = 1;
            this.radioTxtRed.TabStop = true;
            this.radioTxtRed.Text = "Rouge";
            this.radioTxtRed.UseVisualStyleBackColor = true;
            this.radioTxtRed.CheckedChanged += new System.EventHandler(this.radioTxtRed_CheckedChanged);
            // 
            // groupBoxCase
            // 
            this.groupBoxCase.Controls.Add(this.radioUpper);
            this.groupBoxCase.Controls.Add(this.radioLower);
            this.groupBoxCase.Location = new System.Drawing.Point(264, 175);
            this.groupBoxCase.Name = "groupBoxCase";
            this.groupBoxCase.Size = new System.Drawing.Size(111, 70);
            this.groupBoxCase.TabIndex = 8;
            this.groupBoxCase.TabStop = false;
            this.groupBoxCase.Text = "Casse";
            this.groupBoxCase.Visible = false;
            // 
            // radioUpper
            // 
            this.radioUpper.AutoSize = true;
            this.radioUpper.Location = new System.Drawing.Point(6, 42);
            this.radioUpper.Name = "radioUpper";
            this.radioUpper.Size = new System.Drawing.Size(78, 17);
            this.radioUpper.TabIndex = 3;
            this.radioUpper.TabStop = true;
            this.radioUpper.Text = "Majuscules";
            this.radioUpper.UseVisualStyleBackColor = true;
            this.radioUpper.CheckedChanged += new System.EventHandler(this.radioUpper_CheckedChanged);
            // 
            // radioLower
            // 
            this.radioLower.AutoSize = true;
            this.radioLower.Location = new System.Drawing.Point(6, 19);
            this.radioLower.Name = "radioLower";
            this.radioLower.Size = new System.Drawing.Size(78, 17);
            this.radioLower.TabIndex = 2;
            this.radioLower.TabStop = true;
            this.radioLower.Text = "Minuscules";
            this.radioLower.UseVisualStyleBackColor = true;
            this.radioLower.CheckedChanged += new System.EventHandler(this.radioLower_CheckedChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.Info;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelResult.Location = new System.Drawing.Point(23, 98);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 9;
            // 
            // FormCheckBoxRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 317);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupBoxCase);
            this.Controls.Add(this.groupBoxTC);
            this.Controls.Add(this.groupBoxBG);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.labelTxtBox);
            this.Controls.Add(this.textBoxUser);
            this.Name = "FormCheckBoxRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox et RadioButton";
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxBG.ResumeLayout(false);
            this.groupBoxBG.PerformLayout();
            this.groupBoxTC.ResumeLayout(false);
            this.groupBoxTC.PerformLayout();
            this.groupBoxCase.ResumeLayout(false);
            this.groupBoxCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelTxtBox;
        private System.Windows.Forms.CheckBox ckBoxBC;
        private System.Windows.Forms.CheckBox ckBoxTC;
        private System.Windows.Forms.CheckBox ckBoxCase;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.GroupBox groupBoxBG;
        private System.Windows.Forms.GroupBox groupBoxTC;
        private System.Windows.Forms.GroupBox groupBoxCase;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.RadioButton radioBtnGreen;
        private System.Windows.Forms.RadioButton radioBtnPink;
        private System.Windows.Forms.RadioButton radioTxtRed;
        private System.Windows.Forms.RadioButton radioTxtYellow;
        private System.Windows.Forms.RadioButton radioTxtWhite;
        private System.Windows.Forms.RadioButton radioUpper;
        private System.Windows.Forms.RadioButton radioLower;
        private System.Windows.Forms.Label labelResult;
    }
}

