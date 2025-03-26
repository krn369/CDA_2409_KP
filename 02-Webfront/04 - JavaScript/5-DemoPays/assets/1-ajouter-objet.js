import { Pays } from './pays.js';

document.addEventListener('DOMContentLoaded', () => {
  // 1. Elements vérifiés
  const formulaire = document.getElementById('countryForm');
  const champCode = document.getElementById('codePays');
  const champNom = document.getElementById('nomPays');
  const divResultat = document.getElementById('result');
  const tbody = document.getElementById('countryTableBody'); // Ajout direct
  
  console.log('Éléments DOM:', { formulaire, champCode, champNom, divResultat, tbody }); // Debug

  // 2. Initialisation avec vérification
  let pays = [];
  try {
    const donneesSauvegardees = localStorage.getItem('pays');
    pays = donneesSauvegardees ? JSON.parse(donneesSauvegardees) : [];
    console.log('Pays chargés:', pays); // Debug
  } catch (e) {
    console.error('Erreur localStorage:', e);
    pays = [];
  }

  mettreAJourTableauPays(); // Premier rendu

  formulaire.addEventListener('submit', (e) => {
    e.preventDefault();
    reinitialiserAffichageErreur();

    try {
      const code = champCode.value.trim();
      const nom = champNom.value.trim();
      
      if (!code || !nom) {
        throw new Error('Tous les champs sont requis');
      }

      const nouveauPays = new Pays(code, nom);
      
      // Vérification doublon améliorée
      if (pays.some(p => p.code === nouveauPays.code)) {
        throw new Error(`Le code ${nouveauPays.code} existe déjà`);
      }

      pays.push(nouveauPays);
      localStorage.setItem('pays', JSON.stringify(pays));
      console.log('Nouveau pays ajouté:', nouveauPays, 'Liste complète:', pays); // Debug

      mettreAJourInterface();
      afficherMessage('Pays ajouté avec succès!', 'success');

    } catch (erreur) {
      console.error('Erreur:', erreur); // Debug
      afficherMessage(erreur.message, 'error');
      if (erreur.message.includes('code')) {
        champCode.classList.add('error-input');
        champCode.focus();
      } else {
        champNom.classList.add('error-input');
        champNom.focus();
      }
    }
  });

  function mettreAJourInterface() {
    mettreAJourTableauPays();
    formulaire.reset();
  }

  function mettreAJourTableauPays() {
    console.log('Mise à jour tableau avec:', pays); // Debug
    if (!tbody) {
      console.error('tbody non trouvé!');
      return;
    }

    tbody.innerHTML = pays.length > 0
      ? pays.map((p, index) => `
          <tr>
            <td>${p.code}</td>
            <td>${p.nom}</td>
            <td>
              <button class="delete-btn" data-index="${index}">
                Supprimer
              </button>
            </td>
          </tr>
        `).join('')
      : '<tr><td colspan="3" class="vide">Aucun pays enregistré</td></tr>';

    // Gestion des boutons de suppression
    document.querySelectorAll('.delete-btn').forEach(btn => {
      btn.addEventListener('click', (e) => {
        const index = parseInt(e.target.dataset.index);
        if (isNaN(index) || index < 0 || index >= pays.length) return;
        
        const paysSupprime = pays[index].nom;
        pays.splice(index, 1);
        localStorage.setItem('pays', JSON.stringify(pays));
        mettreAJourTableauPays();
        afficherMessage(`${paysSupprime} supprimé`, 'warning');
      });
    });
  }

  function afficherMessage(msg, type) {
    divResultat.textContent = msg;
    divResultat.className = type;
    setTimeout(() => divResultat.classList.add('visible'), 10);
  }

  function reinitialiserAffichageErreur() {
    divResultat.textContent = '';
    divResultat.className = '';
    champCode.classList.remove('error-input');
    champNom.classList.remove('error-input');
  }
});