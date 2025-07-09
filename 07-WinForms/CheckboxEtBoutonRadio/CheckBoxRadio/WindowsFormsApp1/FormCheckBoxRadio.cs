using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsCheckBoxRadio
{
    public partial class FormCheckBoxRadio : Form
    {
        public FormCheckBoxRadio()
        {
            InitializeComponent();
            InitializeControls();
        }

        // Initializes control states and default values.

        private void InitializeControls()
        {
            // Disable checkboxes initially (no text yet)
            ckBoxBC.Enabled = false;
            ckBoxTC.Enabled = false;
            ckBoxCase.Enabled = false;

            // Hide option groups initially
            groupBoxBG.Visible = false;
            groupBoxTC.Visible = false;
            groupBoxCase.Visible = false;

            //Set default colors (system defaults)
            labelResult.BackColor = SystemColors.Control;
            labelResult.ForeColor = SystemColors.ControlText;
        }


        // Handles text changes in the input box 

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            bool hasText = !string.IsNullOrEmpty(textBoxUser.Text);

            // Enable/Disable checkboxes based on text presence
            ckBoxBC.Enabled = hasText;
            ckBoxTC.Enabled = hasText;
            ckBoxCase.Enabled= hasText;

            if (!hasText)
            {
                // Reset everything if text is deleted
                ckBoxBC.Checked = false;
                ckBoxTC.Checked = false;
                ckBoxCase.Checked = false;

                labelResult.BackColor = SystemColors.Control;
                labelResult.ForeColor = SystemColors.ControlText;
            }

            UpdateDisplay(); // Apply formatting in real-time
        }

        // Updates the label's appearance (colors + case)

        private void UpdateDisplay()
        {
            // Copy text first (before case conversion)
            labelResult.Text = textBoxUser.Text;

            // Apply background color if enabled
            if (ckBoxBC.Checked)
            {
                if (radioBtnPink.Checked) labelResult.BackColor = Color.Pink;
                else if (radioBtnGreen.Checked) labelResult.BackColor = Color.Green;
                else if (radioBtnBlue.Checked) labelResult.BackColor = Color.Blue;
            }
            else
            {
                labelResult.BackColor = SystemColors.Control; // Reset to default
            }

            // Apply text color if enabled
            if (ckBoxTC.Checked)
            {
                if (radioTxtRed.Checked) labelResult.ForeColor = Color.Red;
                if (radioTxtWhite.Checked) labelResult.ForeColor = Color.White;
                if (radioTxtYellow.Checked) labelResult.ForeColor = Color.Yellow;
            }

            else
            {
                labelResult.ForeColor = SystemColors.ControlText; // Reset to default
            }

            // Apply case conversion if enabled
            if (ckBoxCase.Checked)
            {
                labelResult.Text = radioUpper.Checked
                    ? labelResult.Text.ToUpperInvariant()  // More efficient than ToUpper()
                    : labelResult.Text.ToLowerInvariant();
            }

        }


        // Checkbox event handlers

        private void ckBoxBC_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxBG.Visible = ckBoxBC.Checked;
            UpdateDisplay();
        }

        private void ckBoxTC_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTC.Visible = ckBoxTC.Checked;
            UpdateDisplay();
        }

        private void ckBoxCase_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCase.Visible = ckBoxCase.Checked;
            UpdateDisplay();
        }

        // Radio button event handlers (all call UpdateDisplay)

        private void radioBtnPink_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();


        private void radioBtnGreen_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();
    

        private void radioBtnBlue_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();
  

        private void radioTxtRed_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();
    

        private void radioTxtWhite_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();


        private void radioTxtYellow_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();


        private void radioLower_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();
   

        private void radioUpper_CheckedChanged(object sender, EventArgs e) => UpdateDisplay();

    }


}
