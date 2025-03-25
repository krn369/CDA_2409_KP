export class Pays {
    constructor(code, nom) {
      this.code = this.validerCode(code);
      this.nom = this.validerNom(nom);
    }
  
    validerCode(code) {
      const codeNettoye = code.trim();
      if (!/^[A-Za-z]{2}$/.test(codeNettoye)) {
        throw new Error('Le code pays doit contenir exactement 2 lettres non accentuées');
      }
      return codeNettoye.toUpperCase();
    }
  
    validerNom(nom) {
      const nomNettoye = nom.trim();
      
      if (nomNettoye.length < 4) {
        throw new Error('Le nom du pays doit contenir au moins 4 caractères');
      }
      
      // Allow letters, spaces, hyphens, apostrophes and international characters
      if (!/^[\p{L}\s'-]+$/u.test(nomNettoye)) {
        throw new Error('Le nom contient des caractères non autorisés');
      }
      
      // Capitalize each word
      return nomNettoye.split(/(\s|-)+/)
        .map(word => word.charAt(0).toUpperCase() + word.slice(1).toLowerCase())
        .join(' ')
        .replace(/\s+/g, ' ');
    }
  }