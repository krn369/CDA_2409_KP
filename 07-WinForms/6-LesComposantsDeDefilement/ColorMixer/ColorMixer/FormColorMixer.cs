using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class FormColorMixer : Form
    {
        public FormColorMixer()
        {
            InitializeComponent();

            // Initialisation avec blanc (255 pour tous les composants)
            InitialiserComposants();
            MettreAJourCouleurMixte();           
        }

        private void InitialiserComposants()
        {
            // Configuration des barres de défilement et NumericUpDown
            InitializerScrollBar(hsbRouge, numRouge, lblCouleurRouge, Color.Red, 255);
            InitializerScrollBar(hsbVert, numVert, lblCouleurVert, Color.Green,  255);
            InitializerScrollBar(hsbBleu, numBleu, lblCouleurBleu, Color.Blue, 255);

            // Configuration du label de résultat
            lblCouleurMix.BorderStyle = BorderStyle.FixedSingle;
            lblCouleurMix.AutoSize = false;
            lblCouleurMix.Size = new Size(200, 40);
        }

        private void InitializerScrollBar(HScrollBar scrollBar, NumericUpDown numericUpDown, Label labelCouleur, Color couleurDeBase,  int valeurInitiale)
        {
            // Scroll bar configuration || Configuration de la barre de défilement
            scrollBar.Minimum = 0;
            scrollBar.SmallChange = 1;
            scrollBar.LargeChange = 10;
            scrollBar.Maximum = 255 + scrollBar.LargeChange - 1;
            scrollBar.Value = valeurInitiale;

            // NumericUpDown configuration  || Configuration du NumericUpDown
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 255;
            numericUpDown.Value = valeurInitiale;


            // // Preview label configuration  ||  Configuration du label de prévisualisation
            labelCouleur.BorderStyle = BorderStyle.FixedSingle;
            labelCouleur.AutoSize = false;
            labelCouleur.Size = new Size(40, 20);
            MettreAJourLabelCouleur(labelCouleur, valeurInitiale, couleurDeBase);
        }

        private void MettreAJourLabelCouleur(Label label, int valeur, Color couleurDeBase)
        {
            label.BackColor = Color.FromArgb(
                couleurDeBase == Color.Red ? valeur : 0,
                couleurDeBase == Color.Green ? valeur : 0,
                couleurDeBase == Color.Blue ? valeur : 0);
          
        }

        private void MettreAJourCouleurMixte()
        {
            int rouge = hsbRouge.Value;
            int vert = hsbVert.Value;
            int bleu = hsbBleu.Value;

            lblCouleurMix.BackColor = Color.FromArgb(rouge, vert, bleu);
            lblCouleurMix.Text = $"R:{rouge}    V:{vert}    B:{bleu} \nHex: #{rouge:X2}  {vert:X2}  {bleu:X2}";
        }

        // Single handler for Scroll and ValueChanged events || Gestionnaire unique pour les événements Scroll et ValueChanged
        private void GestionnaireScrollBar(object sender, EventArgs e)
        {
            // Get the scroll bar that triggered the event
            HScrollBar scrollBar = (HScrollBar)sender;
            int valeur = scrollBar.Value;

            // Update the corresponding NumericUpDown and color label
            if (scrollBar == hsbRouge)
            {
                numRouge.Value = valeur;
                lblCouleurRouge.BackColor = Color.FromArgb(valeur, 0, 0);
            }
            else if (scrollBar == hsbVert)
            {
                numVert.Value = valeur;
                lblCouleurVert.BackColor = Color.FromArgb(0, valeur, 0);
            }
            else if (scrollBar == hsbBleu)
            {
                numBleu.Value = valeur;
                lblCouleurBleu.BackColor = Color.FromArgb(0, 0, valeur);
            }

            MettreAJourCouleurMixte();

        }


        // NumericUpDown ValueChanged event || Gestionnaire pour NumericUpDown
        private void num_ValeurChangee(object sender, EventArgs e)
        {
            // Get the NumericUpDown that was changed
            NumericUpDown numeric = (NumericUpDown)sender;

            // Get its current value (automatically between 0-255)
            int valeur = (int)numeric.Value;

            // Update the matching scrollbar and color preview
            if (numeric == numRouge)
            {
                hsbRouge.Value = valeur;
                lblCouleurRouge.BackColor = Color.FromArgb(valeur, 0, 0);
            }
            else if (numeric == numVert)
            {
                hsbVert.Value = valeur;
                lblCouleurVert.BackColor = Color.FromArgb(0, valeur, 0);
            }
            else if (numeric == numBleu)
            {
                hsbBleu.Value = valeur;
                lblCouleurBleu.BackColor = Color.FromArgb(0, 0, valeur);
            }

            
            MettreAJourCouleurMixte();
        }

    }
}
