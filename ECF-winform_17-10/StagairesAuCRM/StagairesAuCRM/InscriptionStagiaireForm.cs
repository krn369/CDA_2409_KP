using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StagairesAuCRM
{
    public partial class InscriptionStagiaireForm : Form
    {
        public InscriptionStagiaireForm()
        {
            InitializeComponent();
        }

        private void InscriptionStagiaireForm_Load(object sender, EventArgs e)
        {
            comboFormation.Items.Add("CDA");
            comboFormation.Items.Add("DWWM");
            comboFormation.Items.Add("ABC-DEV");

            txtDateDebut.Text = DateTime.Today.ToShortDateString();
            txtDateFin.Text = DateTime.Today.AddMonths(6).ToShortDateString();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            if (!ValidateForm())
            {
                MessageBox.Show("La validation a échoué. Veuillez corrifer les erreurs.", "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DateTime dateDebut = DateTime.Parse(txtDateDebut.Text);
                DateTime dateFin = DateTime.Parse(txtDateFin.Text);

                string sectionName = comboFormation.SelectedItem.ToString() + dateDebut.Year;
                string fullName = txtPrenom.Text + " " + txtNom.Text;
                int remainingDays = (dateFin - DateTime.Today).Days;

                ShowSuccessForm(sectionName, fullName, remainingDays);

            }

        }

        private bool ValidateForm()
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Le prénom est obligatoire.", "Champ manquant",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrenom.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom est obligatoire.", "Champ manquant",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDateDebut.Text))
            {
                MessageBox.Show("La date de début est obligatoire.", "Champ manquant",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateDebut.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDateFin.Text))
            {
                MessageBox.Show("La date de fin est obligatoire.", "Champ manquant",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateFin.Focus();
                return false;
            }

            if (comboFormation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une formation.", "Champ manquant",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboFormation.Focus();
                return false;
            }

            if (!IsNameValid(txtPrenom.Text))
            {
                MessageBox.Show("Le prénom est invalide.\n- Maximum 25 caractères\n- Pas de chiffres\n- Pas d'espaces",
                    "Prénom invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrenom.Focus();
                return false;
            }

            if (!IsNameValid(txtNom.Text))
            {
                MessageBox.Show("Le nom est invalide.\n- Maximum 25 caractères\n- Pas de chiffres\n- Pas d'espaces",
                    "Nom invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDateDebut.Text, out DateTime dateDebut))
            {
                MessageBox.Show("La date de début n'est pas valide.\nFormat attendu: " + DateTime.Today.ToShortDateString(),
                    "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateDebut.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDateFin.Text, out DateTime dateFin))
            {
                MessageBox.Show("La date de fin n'est pas valide.\nFormat attendu: " + DateTime.Today.ToShortDateString(),
                    "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateFin.Focus();
                return false;
            }

            if (dateFin <= dateDebut)
            {
                MessageBox.Show("La date de fin doit être postérieure à la date de début.",
                    "Dates invalides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateFin.Focus();
                return false;
            }

            return true;
        }

        private bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            if (name.Length > 25)
                return false;

            foreach (char c in name)
            {
                if (char.IsDigit(c) || char.IsWhiteSpace(c))
                    return false;
            }

            return true;
        }

        private void ShowSuccessForm(string sectionName, string fullName, int remainingDays)
        {
            SuccessForm successForm = new SuccessForm(sectionName, fullName, remainingDays);
            DialogResult result = successForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPrenom.Clear();
                txtNom.Clear();
                txtDateDebut.Text = DateTime.Today.ToShortDateString();
                txtDateFin.Text = DateTime.Today.AddMonths(6).ToShortDateString();
                comboFormation.SelectedIndex = -1;
                txtPrenom.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtPrenom.Clear();
            txtNom.Clear();
            txtDateDebut.Text = DateTime.Today.ToShortDateString();
            txtDateFin.Text = DateTime.Today.AddMonths(6).ToShortDateString();
            comboFormation.SelectedIndex = -1;
            txtPrenom.Focus();
        }
    }


   
    
}
