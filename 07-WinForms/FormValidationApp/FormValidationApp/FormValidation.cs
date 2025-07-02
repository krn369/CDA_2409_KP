using ClassLibraryValidations;
using ClassLibraryPerson;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FormValidationApp
{
    public partial class FormValidation : Form
    {
        public FormValidation()
        {
            InitializeComponent();
        }

        // Clear all fields and reset state
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtCP.Clear();
            txtDate.Clear();
            txtMontant.Clear();

            errorProvider1.SetError(txtNom, "");
            errorProvider1.SetError(txtCP, "");
            errorProvider1.SetError(txtDate, "");
            errorProvider1.SetError(txtMontant, "");

            txtNom.BackColor = Color.White;
            txtCP.BackColor = Color.White;
            txtDate.BackColor = Color.White;
            txtMontant.BackColor = Color.White;

            txtNom.Focus();
        }

        // Validate input fields and create a Person object
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!ValidationRegles.IsNomValid(txtNom.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Le nom de famille est invalide (lettres uniquement, max 30 caractères).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                return;
            }

            if (!ValidationRegles.IsDateValid(txtDate.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("La date doit être au format jj/mm/aaaa et supérieure à aujourd'hui.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDate.Focus();
                return;
            }

            if (!ValidationRegles.IsMontantValid(txtMontant.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Le montant doit être un nombre positif avec un séparateur décimal valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMontant.Focus();
                return;
            }

            if (!ValidationRegles.IsCodePostalValid(txtCP.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Le code postal doit contenir exactement 5 chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCP.Focus();
                return;
            }

            // Create Person object using valid values
            Person personne = new Person(
                txtNom.Text.Trim(),
                DateTime.ParseExact(txtDate.Text.Trim(), "dd/MM/yyyy", null),
                decimal.Parse(txtMontant.Text.Trim()),
                txtCP.Text.Trim()
            );

            // Show summary
            MessageBox.Show(personne.Resume(), "Validation effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Warn if appointment is in less than 7 days
            if (personne.IsAppointmentImminent())
            {
                MessageBox.Show("⚠️ Le rendez-vous est prévu dans moins de 7 jours.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Custom confirmation dialog on close
        private void FormValidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingDialog confirmForm = new FormClosingDialog(this.txtNom.Text);
            DialogResult result = confirmForm.ShowDialog();

            if (result != DialogResult.OK)
            {
                e.Cancel = true; // Cancel the close
            }
        }

        // Live validation for 'Nom'
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (ValidationRegles.IsNomValid(txtNom.Text))
            {
                errorProvider1.SetError(txtNom, "");
                txtNom.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(txtNom, "Nom invalide! (lettres uniquement, max 30 caractères).");
                txtNom.BackColor = Color.MistyRose;
            }
        }

        // Live validation for 'Montant'
        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            if (ValidationRegles.IsMontantValid(txtMontant.Text))
            {
                errorProvider1.SetError(txtMontant, "");
                txtMontant.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(txtMontant, "Montant invalide! (nombre positif attendu).");
                txtMontant.BackColor = Color.MistyRose;
            }
        }

        // Live validation for 'Date'
        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (ValidationRegles.IsDateValid(txtDate.Text))
            {
                errorProvider1.SetError(txtDate, "");
                txtDate.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(txtDate, "Date invalide! (format attendu : JJ/MM/AAAA).");
                txtDate.BackColor = Color.MistyRose;
            }
        }

        // Live validation for 'Code Postal'
        private void txtCP_TextChanged(object sender, EventArgs e)
        {
            if (ValidationRegles.IsCodePostalValid(txtCP.Text))
            {
                errorProvider1.SetError(txtCP, "");
                txtCP.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(txtCP, "Code postal invalide! (5 chiffres requis).");
                txtCP.BackColor = Color.MistyRose;
            }
        }
    }
}
