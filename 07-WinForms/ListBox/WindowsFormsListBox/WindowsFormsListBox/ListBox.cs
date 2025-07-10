using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListBox
{
    public partial class ListBox : Form
    {
        // This is the constructor (runs when the form starts).
        public ListBox()
        {
            InitializeComponent(); 
        }


        // When the form loads, clear properties. 
        private void ListBox_Load(object sender, EventArgs e)
        {
            EffacerProprietes();
        }

        // Add a new item to the ListBox
        private void btnAjoutListe_Click(object sender, EventArgs e)
        {
            // Get the text from Nouvel Element textbox
            string nouvelElement = txtNouvelElement.Text.Trim();

            // Check if the textbox is not empty and the item doesn't already exist
            if (!string.IsNullOrEmpty(nouvelElement))
            {
                if(!LstListe.Items.Contains(nouvelElement))
                {
                    // Add the new item to the ListBox
                    LstListe.Items.Add(nouvelElement);

                    // Clear the textbox and set focus back to it
                    txtNouvelElement.Text = "";
                    txtNouvelElement.Focus();
                }
                else
                {
                    MessageBox.Show("Cet élément existe déjà !", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un élément.", "Erreur");
            }
        }


        // Select an item by its index
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtIndexElement.Text, out int index))
            {
                if (index >= 0 && index < LstListe.Items.Count)
                {
                    LstListe.SelectedIndex = index;
                    txtIndexElement.Text = "";
                }
                else
                {
                    MessageBox.Show("Index invalide. ", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre. ", "Erreur");
            }
       
        }

        // Clear the ListBox
        private void btnViderListe_Click(object sender, EventArgs e)
        {
            LstListe.Items.Clear();
            EffacerProprietes();
        }


        // Update properties when selection changes
        private void LstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When user selects an item from the list, display its properties
            AfficherProprietes();
        }

        // Display properties in the GroupBox
        private void AfficherProprietes()
        {
            textBoxIC.Text = LstListe.Items.Count.ToString();
            textBoxSI.Text = LstListe.SelectedIndex.ToString();
            textBoxTxt.Text = (LstListe.SelectedItem != null) ? LstListe.SelectedItem.ToString() : "";
        }

        // Clear property displays
        private void EffacerProprietes()
        {
            textBoxIC.Text = "0";
            textBoxSI.Text = "";
            textBoxTxt.Text = "";
        }


    }
}
