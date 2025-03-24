export class Pays {
    // Static regex patterns for validation
    static regexCodePays = /^[A-Za-z]{2}$/;
    static regexNomPays = /^[A-Za-z]{4,}$/;

    constructor(codePays, nomPays) {
        // Validate and format country code
        if (!Pays.regexCodePays.test(codePays)) {
            throw new Error('Le code pays doit contenir exactement 2 lettres non accentuées');
        }
        
        // Validate and format country name
        if (!Pays.regexNomPays.test(nomPays)) {
            throw new Error('Le nom du pays doit contenir au moins 4 lettres non accentuées');
        }

        // Format properties
        this.country_code = codePays.toUpperCase();
        this.country_name = nomPays.charAt(0).toUpperCase() + nomPays.slice(1).toLowerCase();
    }
}