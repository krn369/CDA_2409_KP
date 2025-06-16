using System;
using System.Windows.Forms;

namespace WindowsFormsAppCalculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
            LierChiffres(); // Call our method to connect all digit buttons
        }

        /// <summary>
        /// This method connects all digit buttons (0–9) to a single event handler.
        /// It uses the Tag property of each button to know which digit to add.
        /// </summary>
        private void LierChiffres()
        {
            // Go through all the controls on the form
            foreach (Control c in this.Controls)
            {
                // Check if the control is a Button and has a Tag value
                if (c is Button btn && btn.Tag != null)
                {
                    // When this button is clicked, run the DigitButton_Click method
                    btn.Click += DigitButton_Click;
                }
            }
        }

        /// <summary>
        /// This method runs when a digit button is clicked.
        /// It adds the digit (from the button's Tag) to the TextBox, followed by a '+' sign.
        /// </summary>
        private void DigitButton_Click(object sender, EventArgs e)
        {
            // Get the button that was clicked
            if (sender is Button btn && btn.Tag != null)
            {
                // Add the digit and "+" to the TextBox
                textBox1.Text += btn.Tag.ToString() + "+";
            }
        }

        /// <summary>
        /// This method calculates the sum of the digits entered and shows the result.
        /// </summary>
        private void btnCalculer_Click(object sender, EventArgs e)
        {
            // Split the text by "+" into parts (e.g., "2+3+4+" becomes ["2", "3", "4", ""])
            string[] parts = textBox1.Text.Split('+');
            int sum = 0;

            // Loop through each part
            foreach (string part in parts)
            {
                // Try converting it to a number; ignore if it's not a valid number (like empty string)
                if (int.TryParse(part, out int number))
                {
                    sum += number;
                }
            }

            // Display the result at the end of the TextBox
            textBox1.Text += "= " + sum.ToString() + "+";
        }

        /// <summary>
        /// This method clears the TextBox when the "Vider" button is clicked.
        /// </summary>
        private void btnVider_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Clear all text
        }

    }
}
