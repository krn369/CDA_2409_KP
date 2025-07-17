using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ClassLibraryValidations
{
    public static class ValidationRegles
    {
        public static bool IsNomValid(string nom)
        {
            if (string.IsNullOrWhiteSpace(nom))
                return false;

            nom = nom.Trim();

            if (nom.Length > 30)
                return false;

            // Only letters (including accented) - no spaces or special chars
            return Regex.IsMatch(nom, @"^[A-Za-zÀ-ÖØ-öø-ÿ'’\- ]+$");
        }

        public static bool IsDateValid(string date)
        {
            if (string.IsNullOrWhiteSpace(date))
                return false;

            date = date.Trim();

            // Enforce format dd/MM/yyyy
            if (!Regex.IsMatch(date, @"^\d{2}/\d{2}/\d{4}$"))
                return false;

            // Parse with invariant culture (to match "dd/MM/yyyy" correctly)
            if (!DateTime.TryParseExact(
                    date,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime parsedDate))
                return false;

            // Check that date is in the future
            return parsedDate > DateTime.Today;
        }


        public static bool IsMontantValid(string montant)
        {
            if (string.IsNullOrWhiteSpace(montant))
                return false;

            montant = montant.Trim();

            // Try to parse with NumberStyles.Number (allows decimal + thousands separators)
            if (!decimal.TryParse(montant, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal value))
                return false;

            return value >= 0;
        }

        public static bool IsCodePostalValid(string code)
        {
            code = code?.Trim();

            // French-style 5-digit postal code
            return Regex.IsMatch(code ?? "", @"^\d{5}$");
        }




    }
}
