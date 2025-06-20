using System;
using System.Text.RegularExpressions;

namespace ClassLibraryValidations
{

        public static class ValidationRegles
        {

            public static bool IsNomCompletValid(string nomComplet)
            {
                // Supports Names with accents, apostrophes,space and hyphens
                return Regex.IsMatch(nomComplet.Trim(), @"^[A-Za-zÀ-ÖØ-öø-ÿ'’-]+ [A-Za-zÀ-ÖØ-öø-ÿ'’-]+$");
            }

            public static bool IsCodePostalValid(string code)
            {
            // // French-style 5-digit postal code
            return Regex.IsMatch(code, @"^\d{5}$");
            }

            public static bool IsMontantValid(string montant)
            {
            // // Valid decimal number with optional commas or dots
            return Regex.IsMatch(montant, @"^\d+([.,]\d{1,2})?$");
            }

        public static bool IsDateValid(string date)
        {
            // 1. Regex to check format: two digits / two digits / four digits
            if (!Regex.IsMatch(date, @"^\d{2}/\d{2}/\d{4}$"))
                return false;

            // 2. Check if it’s a valid calendar date using French format
            return DateTime.TryParseExact(
                date,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out _);
        }


    }
}
