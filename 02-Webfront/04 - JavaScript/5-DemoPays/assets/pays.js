/**
 * Classe représentant un pays avec validation
 */
export class Pays {
    /**
     * Crée une instance de Pays
     * @param {string} code - Code pays sur 2 lettres
     * @param {string} nom - Nom du pays
     */
    constructor(code, nom) {
      this.code = this.validerCode(code);
      this.nom = this.validerNom(nom);
    }
  
    /**
     * Valide le code pays
     * @param {string} code - Code à valider
     * @returns {string} Code validé en majuscules
     * @throws {Error} Si le code est invalide
     */
    validerCode(code) {
      const codeNettoye = code.trim();
      if (!/^[A-Za-z]{2}$/.test(codeNettoye)) {
        throw new Error('Le code pays doit contenir exactement 2 lettres non accentuées');
      }
      return codeNettoye.toUpperCase();
    }
  
    /**
     * Valide le nom du pays
     * @param {string} nom - Nom à valider
     * @returns {string} Nom validé et formaté
     * @throws {Error} Si le nom est invalide
     */
    validerNom(nom) {
      const nomNettoye = nom.trim();
      
      if (nomNettoye.length < 4) {
        throw new Error('Le nom du pays doit contenir au moins 4 caractères');
      }
      
      // Autorise lettres, espaces, tirets, apostrophes et caractères internationaux
      if (!/^[\p{L}\s'-]+$/u.test(nomNettoye)) {
        throw new Error('Le nom contient des caractères non autorisés');
      }
      
      // Capitalise chaque mot
      return nomNettoye.split(/(\s|-)+/)
        .map(word => word.charAt(0).toUpperCase() + word.slice(1).toLowerCase())
        .join(' ')
        .replace(/\s+/g, ' ');
    }
  }