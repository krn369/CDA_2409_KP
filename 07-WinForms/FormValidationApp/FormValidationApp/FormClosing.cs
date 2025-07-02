using System;
using System.Windows.Forms;

namespace FormValidationApp
{
    public partial class FormClosingDialog : Form
    {
        private string nomUtilisateur;

        // Default constructor
        public FormClosingDialog()
        {
            InitializeComponent();
        }

        // Constructor with user name
        public FormClosingDialog(string nom)
        {
            InitializeComponent();
            this.nomUtilisateur = nom;

            // Display name in label (optional)
            this.label1.Text = $"Souhaitez-vous vraiment quitter, {nom} ?";
        }

        // YES button click — confirm closing
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // NO button click — cancel closing
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
