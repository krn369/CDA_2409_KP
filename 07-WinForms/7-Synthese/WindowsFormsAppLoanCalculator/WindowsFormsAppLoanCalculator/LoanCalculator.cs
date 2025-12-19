using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLoanCalculator
{
    public partial class LoanCalculator : Form
    {
        public LoanCalculator()
        {
            InitializeComponent();
        }

        private void LoanCalculator_Load(object sender, EventArgs e)
        {
            // Set focus to name field
            txtNom.Focus();

            // Initialize payment frequency dropdown
            cmbPeriodicite.Items.AddRange(new string[] { "Mensulle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" });
            cmbPeriodicite.SelectedIndex = 0;

            // Initialize other values

        }
    }
}
