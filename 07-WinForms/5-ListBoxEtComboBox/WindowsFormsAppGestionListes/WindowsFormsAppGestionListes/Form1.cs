using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGestionListes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Initialize the Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize source countries
            string[] paysSource = { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grèce" };

            // Add countries to the comboBox
            comboSource.Items.AddRange(paysSource);

            // Initialize target countries
            string[] paysCible = { "Bulgarie", "Espagne" };

            // Add countries to the ListBox
            listCible.Items.AddRange(paysCible);

            // Disable buttons initially
            UpdateButtonStates();
        }


        // Implement the Button Functions 
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (comboSource.SelectedIndex != -1)
            {
                // Add the selected item to the ListBox
                listCible.Items.Add(comboSource.SelectedItem);

                // Remove the items from the ComboBox
                comboSource.Items.Remove(comboSource.SelectedItem);

                //Update button states
                UpdateButtonStates();
            }
        }

        private void btnAjouterTous_Click(object sender, EventArgs e)
        {
            // Add all items from ComboBox to ListBox
            foreach (var item in comboSource.Items)
            {
                listCible.Items.Add(item);
            }

            // Clear the ComboBox
            comboSource.Items.Clear();

            // Update button states
            UpdateButtonStates();
        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if(listCible.SelectedIndex != -1)
            {
                // Add the selected item to the ComboBox
                comboSource.Items.Add(listCible.SelectedItem);

                // Remove the items from the ListBox
                listCible.Items.Remove(listCible.SelectedItem);

                // Update button statezs
                UpdateButtonStates();
                    
            }
        }

        private void btnRetournerTous_Click(object sender, EventArgs e)
        {
            // Add all items from ListBox to ComboBox
            foreach (var item in listCible.Items)
            {
                comboSource.Items.Add(item);
            }

            // Clear the ListBox
            listCible.Items.Clear();

            // Update button states
            UpdateButtonStates();
        }

        private void btnMonter_Click(object sender, EventArgs e)
        {
            if (listCible.SelectedIndex > 0) // Can't move first item up
            {
                int selectedIndex = listCible.SelectedIndex;
                object selectedItem = listCible.SelectedItem;

                // Remove the item
                listCible.Items.Remove(selectedItem);

                // Reinsert it one position higher
                listCible.Items.Insert(selectedIndex - 1, selectedItem);

                // Reselect the item
                listCible.SelectedIndex = selectedIndex - 1;

                // Update button states
                UpdateButtonStates();
            }
        }

        private void btnDescendre_Click(object sender, EventArgs e)
        {
            if (listCible.SelectedIndex < listCible.Items.Count - 1 && listCible.SelectedIndex != -1)
            {
                int selectedIndex = listCible.SelectedIndex;
                object selectedItem = listCible.SelectedItem;

                // Remove the item
                listCible.Items.Remove(selectedItem);

                // Reinsert it one position lower
                listCible.Items.Insert(selectedIndex + 1, selectedItem);

                // Reselect the item
                listCible.SelectedIndex = selectedIndex + 1;

                // Update button states
                UpdateButtonStates();
            }
        }

        private void UpdateButtonStates()
        {
            // Enable/disable Add button based on ComboBox selection
            btnAjouter.Enabled = comboSource.SelectedIndex != -1;

            // Enable/disable Add All button based on ComboBox content
            btnAjouterTous.Enabled = comboSource.Items.Count > 0;

            // Enable/disable Return button based on ListBox selection
            btnRetourner.Enabled = listCible.SelectedIndex != -1;

            // Enable/disable Return All button based on ListBox content
            btnRetournerTous.Enabled = listCible.Items.Count > 0;

            // Enable/disable Move Up button
            btnMonter.Enabled = listCible.SelectedIndex > 0;

            // Enable/disable Move Down button
            btnDescendre.Enabled = listCible.SelectedIndex != -1 &&
                                  listCible.SelectedIndex < listCible.Items.Count - 1;
        }

        private void comboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void listCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void comboSource_DropDown(object sender, EventArgs e)
        {
            string newItem = comboSource.Text.Trim();

            if (!string.IsNullOrEmpty(newItem) &&
                !comboSource.Items.Contains(newItem) &&
                !listCible.Items.Contains(newItem))
            {
                comboSource.Items.Add(newItem);
                comboSource.Text = ""; // Clear the text after adding
            }
        }
    }
}
