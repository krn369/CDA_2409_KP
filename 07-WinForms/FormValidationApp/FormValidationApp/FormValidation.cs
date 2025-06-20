using ClassLibraryValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormValidationApp
{
    public partial class FormValidation : Form
    {
        public FormValidation()
        {
            InitializeComponent();
            this.errorProviderMontant.SetError(this.txtMontant, "trop nulle");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string codePostal = txtCodePostal.Text;

            // For checking if the date is valid.
            DateTime dateValue;
            bool estDateValide = DateTime.TryParse(txtDate.Text, out dateValue);

            if(!estDateValide)
            {
                MessageBox.Show("Veuillez entrer une date valide.");
                return;
            }

            // Validate and parse amount
            decimal montant;
            bool estValide = ValidationRegles.IsMontantValid(txtMontant.Text);//Decimal.TryParse(txtMontant.Text, out montant);

            if (!estValide)
            {
                MessageBox.Show("Veuillez entrer un montant valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            


            // Build the message
           // string message = $"Nom : {nom}\nDate : {date}\nMontant : {montant}\nCode : {codePostal}";
           // MessageBox.Show(message, "Validation effectuée");
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtMontant.Clear();
            txtCodePostal.Clear();
            txtDate.Clear();

           
        }

        private void FormValidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the close
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
