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
    public partial class SuccessForm : Form
    {
        public SuccessForm(string sectionName, string fullName, int remainingDays)
        {
            InitializeComponent();

            lblSection.Text = "Section: " + sectionName;
            lblNomStagiaire = "Stagiaire: " + fullName;

            if (remainingDays < 0)
            {
                lblJoursRestants.Text = "Formation terminée.";
                lblJoursRestants.ForeColor = Color.Gray;
            }

            else if (remainingDays == 0)
            {
                lblJoursRestants.Text = "Dernier jour de formation !";
                lblJoursRestants.ForeColor = Color.Orange;
            }

            else if (remainingDays == 1)
            {
                lblJoursRestants.Text = "Il vous reste 1 jour de formation";
                lblJoursRestants.ForeColor = Color.Blue;
            }

            else
            {
                lblJoursRestants.Text = $"Il vous reste {remainingDays} jours de formation";
                lblJoursRestants.ForeColor = Color.Green;

            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouvelleInscription_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
