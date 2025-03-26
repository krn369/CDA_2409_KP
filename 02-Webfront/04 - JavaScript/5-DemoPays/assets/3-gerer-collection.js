/**
 * Charge et affiche la collection de pays
 */
async function chargerPays() {
    try {
      const reponse = await fetch('data/collectionPays.json');
      if (!reponse.ok) throw new Error('Erreur de chargement');
      
      const pays = await reponse.json();
      const tbody = document.getElementById('mesPays');
      
      if (!pays.length) {
        tbody.innerHTML = '<tr><td colspan="2">Aucun pays disponible</td></tr>';
        return;
      }
      
      tbody.innerHTML = pays.map(p => `
        <tr>
          <td>${p.country_code}</td>
          <td>${p.country_name}</td>
        </tr>
      `).join('');
    } catch (erreur) {
      console.error('Erreur:', erreur);
      const tbody = document.getElementById('mesPays');
      tbody.innerHTML = `
        <tr>
          <td colspan="2" class="error">
            Impossible de charger les données des pays
          </td>
        </tr>
      `;
    }
  }
  
  // Initialise au chargement
  document.addEventListener('DOMContentLoaded', chargerPays);