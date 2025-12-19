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

namespace ColorMixer
{
    public partial class FormColorMixer : Form
    {

        private ColorMixerCM _melangeur;


        // Default constructor
        public FormColorMixer():this(Color.White)
        {         
        }

        // Constructor with initial couleurInitial
        public FormColorMixer(Color couleurInitiale)
        {
            
            InitializeComponent();

            _melangeur = new ColorMixerCM(couleurInitiale.R, couleurInitiale.G, couleurInitiale.B);


            InitialiserComposants();
            MettreAJourToutIHM();
        }

        private void InitialiserComposants()
        {
            InitialiserScrollBar(hsbRouge, numRouge, lblCouleurRouge, Color.Red, _melangeur.Rouge);
            InitialiserScrollBar(hsbVert, numVert, lblCouleurVert, Color.Green, _melangeur.Vert);
            InitialiserScrollBar(hsbBleu, numBleu, lblCouleurBleu, Color.Blue, _melangeur.Bleu);

            lblCouleurMix.BorderStyle = BorderStyle.FixedSingle;
            lblCouleurMix.AutoSize = false;
            lblCouleurMix.Size = new Size(200, 40);
        }

        private void InitializerScrollBar(HScrollBar scrollBar, NumericUpDown numericUpDown, Label labelCouleur, Color couleurDeBase, int valeurInitiale)
        {

            scrollBar.Minimum = 0;
            scrollBar.Maximum = 255;
            scrollBar.Value = value;

            numeric.Minimum = 0;
            numeric.Maximum = 255;
            numeric.Value = value;

            label.BorderStyle = BorderStyle.FixedSingle;
            label.AutoSize = false;
            label.Size = new Size(40, 20);

            MettreAJourLabelCouleur(label, value, baseColor);
        }

        private void MettreAJourLabelCouleur(Label label, int valeur, Color couleurBase)
        {
            label.BackColor = Color.FromArgb(
                couleurBase == Color.Red ? value : 0,
                couleurBase == Color.Green ? value : 0,
                couleurBase == Color.Blue ? value : 0
            );

        }



        private void MettreAJourToutIHM()
        {
            Color currentColor = _melangeur.ObtenirCouleur();

            hsbRouge.Value = _melangeur.Rouge;
            hsbVert.Value = _melangeur.Vert;
            hsbBleu.Value = _melangeur.Bleu;

            numRouge.Value = _melangeur.Rouge;
            numVert.Value = _melangeur.Vert;
            numBleu.Value = _melangeur.Bleu;

            lblCouleurMix.BackColor = currentColor;
            lblCouleurMix.Text = _melangeur.ObtenirInfosCouleur();
        }

        





        private void MettreAJourCouleurMixte()
        {
            int r = hsbRouge.Value;
            int g = hsbVert.Value;
            int b = hsbBleu.Value;

            _melangeur.DefinirCouleur(r, g, b);
            MettreAJourToutIHM();
        }

        // Single handler for Scroll and ValueChanged events || Gestionnaire unique pour les événements Scroll et ValueChanged
        private void GestionnaireScrollBar(object sender, EventArgs e)
        {
            HScrollBar scrollBar = (HScrollBar)sender;
            int value = scrollBar.Value;

            if (scrollBar == hsbRouge)
                numRouge.Value = value;
            else if (scrollBar == hsbVert)
                numVert.Value = value;
            else if (scrollBar == hsbBleu)
                numBleu.Value = value;

            MettreAJourCouleurMixte();

        }


        // NumericUpDown ValueChanged event || Gestionnaire pour NumericUpDown
        private void num_ValeurChangee(object sender, EventArgs e)
        {
            // Get the NumericUpDown that was changed
            NumericUpDown numeric = (NumericUpDown)sender;

            // Get its current value (automatically between 0-255)
            int valeur = (int)numeric.Value;

            // Update the matching scrollbar and couleurInitial preview
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
