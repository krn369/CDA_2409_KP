import { Pays } from './pays.js';

/**
 * Initialise l'application de gestion des pays
 */
document.addEventListener('DOMContentLoaded', () => {
  const form = document.getElementById('countryForm');
  const tbody = document.getElementById('countryTableBody');
  let pays = JSON.parse(localStorage.getItem('pays')) || [];

  // Initialise le tableau
  mettreAJourTableau();

  /**
   * Gère la soumission du formulaire
   */
  form.addEventListener('submit', (e) => {
    e.preventDefault();
    const resultDiv = document.getElementById('result');
    resultDiv.textContent = '';
    resultDiv.className = '';

    try {
      const nouveauPays = new Pays(
        document.getElementById('codePays').value,
        document.getElementById('nomPays').value
      );
      
      // Vérifie si le pays existe déjà
      if (pays.some(p => p.code === nouveauPays.code)) {
        throw new Error('Un pays avec ce code existe déjà');
      }
      
      pays.push(nouveauPays);
      localStorage.setItem('pays', JSON.stringify(pays));
      mettreAJourTableau();
      form.reset();
      
      afficherMessage('Pays ajouté avec succès!', 'success');
    } catch (error) {
      afficherMessage(error.message, 'error');
    }
  });

  /**
   * Met à jour le tableau des pays
   */
  function mettreAJourTableau() {
    tbody.innerHTML = pays.length > 0
      ? pays.map((p, i) => `
          <tr>
            <td>${p.code}</td>
            <td>${p.nom}</td>
            <td><button class="delete-btn" data-index="${i}">Supprimer</button></td>
          </tr>
        `).join('')
      : '<tr><td colspan="3">Aucun pays enregistré</td></tr>';

    // Ajoute les écouteurs d'événements aux boutons de suppression
    document.querySelectorAll('.delete-btn').forEach(btn => {
      btn.addEventListener('click', (e) => {
        const index = e.target.dataset.index;
        pays.splice(index, 1);
        localStorage.setItem('pays', JSON.stringify(pays));
        mettreAJourTableau();
        afficherMessage('Pays supprimé', 'warning');
      });
    });
  }

  /**
   * Affiche un message à l'utilisateur
   * @param {string} msg - Message à afficher
   * @param {string} type - Type de message (success, error, warning)
   */
  function afficherMessage(msg, type) {
    const div = document.getElementById('result');
    div.textContent = msg;
    div.className = type;
  }
});