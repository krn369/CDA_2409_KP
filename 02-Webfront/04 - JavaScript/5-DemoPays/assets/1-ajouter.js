import { Pays } from './pays.js';

document.addEventListener('DOMContentLoaded', () => {
  const form = document.getElementById('countryForm');
  const tbody = document.getElementById('countryTableBody');
  let pays = JSON.parse(localStorage.getItem('pays')) || [];

  // Initialize table
  mettreAJourTableau();

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
      
      pays.push(nouveauPays);
      localStorage.setItem('pays', JSON.stringify(pays));
      mettreAJourTableau();
      form.reset();
      
      afficherMessage('Pays ajouté avec succès!', 'success');
    } catch (error) {
      afficherMessage(error.message, 'error');
    }
  });

  function mettreAJourTableau() {
    tbody.innerHTML = pays.map((p, i) => `
      <tr>
        <td>${p.code}</td>
        <td>${p.nom}</td>
        <td><button class="delete-btn" data-index="${i}">Supprimer</button></td>
      </tr>
    `).join('');

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

  function afficherMessage(msg, type) {
    const div = document.getElementById('result');
    div.textContent = msg;
    div.className = type;
  }
});