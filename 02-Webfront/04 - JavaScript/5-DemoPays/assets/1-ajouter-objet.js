import { Pays } from './pays.js';

document.addEventListener('DOMContentLoaded', () => {
  const form = document.getElementById('countryForm');
  const codeInput = document.getElementById('codePays');
  const nomInput = document.getElementById('nomPays');
  const resultDiv = document.getElementById('result');
  
  // Load countries from localStorage
  let pays = JSON.parse(localStorage.getItem('pays')) || [];

  // Update the table on load
  updateCountryTable();

  form.addEventListener('submit', (e) => {
    e.preventDefault();
    console.log('Form submitted with values:', {
      code: codeInput.value,
      nom: nomInput.value
    });

    // Clear previous messages and errors
    resultDiv.textContent = '';
    resultDiv.className = '';
    codeInput.classList.remove('error-input');
    nomInput.classList.remove('error-input');

    try {
      // Trim inputs before validation
      const code = codeInput.value.trim();
      const nom = nomInput.value.trim();

      // Debug: Log trimmed values
      console.log('Trimmed values:', { code, nom });

      // Validate and create new country
      const nouveauPays = new Pays(code, nom);
      console.log('New country created:', nouveauPays);

      // Add to collection and save
      pays.push(nouveauPays);
      localStorage.setItem('pays', JSON.stringify(pays));

      // Update UI
      updateCountryTable();
      form.reset();

      // Show success
      resultDiv.textContent = 'Pays ajouté avec succès!';
      resultDiv.className = 'success';

    } catch (error) {
      console.error('Validation error:', error.message);
      
      // Show error message
      resultDiv.textContent = error.message;
      resultDiv.className = 'error';
      
      // Highlight problematic field
      if (error.message.includes('code')) {
        codeInput.classList.add('error-input');
        codeInput.focus();
      } else {
        nomInput.classList.add('error-input');
        nomInput.focus();
      }
    }
  });

  function updateCountryTable() {
    const tbody = document.getElementById('countryTableBody');
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
      : '<tr><td colspan="3">Aucun pays enregistré</td></tr>';

    // Add event listeners to delete buttons
    document.querySelectorAll('.delete-btn').forEach(btn => {
      btn.addEventListener('click', (e) => {
        const index = e.target.dataset.index;
        pays.splice(index, 1);
        localStorage.setItem('pays', JSON.stringify(pays));
        updateCountryTable();
        resultDiv.textContent = 'Pays supprimé avec succès';
        resultDiv.className = 'success';
      });
    });
  }
});