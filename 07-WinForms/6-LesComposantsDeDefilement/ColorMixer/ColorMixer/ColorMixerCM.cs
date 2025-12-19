using System;
using System.Drawing;

namespace ColorMixer
{
    public class ColorMixerCM
    {
        public int Rouge { get; private set; }
        public int Vert { get; private set; }
        public int Bleu { get; private set; }

        public ColorMixerCM() : this(255, 255, 255) { }

        public ColorMixerCM(int rouge, int vert, int bleu)
        {
            DefinirCouleur(rouge, vert, bleu);
        }

        public void DefinirCouleur(int rouge, int vert, int bleu)
        {
            Rouge = ValiderValeur(rouge);
            Vert = ValiderValeur(vert);
            Bleu = ValiderValeur(bleu);
        }

        public Color ObtenirCouleur()
        {
            return Color.FromArgb(Rouge, Vert, Bleu);
        }

        public string ObtenirInfosCouleur()
        {
            return $"R:{Rouge}    V:{Vert}    B:{Bleu} \nHex: #{Rouge:X2}{Vert:X2}{Bleu:X2}";
        }

        private int ValiderValeur(int valeur)
        {
            return Math.Max(0, Math.Min(255, valeur));
        }

        public static Color HexEnCouleur(string hex)
        {
            if (hex.StartsWith("#")) hex = hex.Substring(1);
            if (hex.Length != 6) throw new ArgumentException("Format HEX invalide.");

            int r = Convert.ToInt32(hex.Substring(0, 2), 16);
            int g = Convert.ToInt32(hex.Substring(2, 2), 16);
            int b = Convert.ToInt32(hex.Substring(4, 2), 16);

            return Color.FromArgb(r, g, b);
        }
    }
}
