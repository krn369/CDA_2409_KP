// Load and display countries
async function chargerPays() {
    try {
      const reponse = await fetch('data/collectionPays.json');
      const pays = await reponse.json();
      const tbody = document.getElementById('mesPays');
      
      tbody.innerHTML = pays.map(p => `
        <tr>
          <td>${p.country_code}</td>
          <td>${p.country_name}</td>
        </tr>
      `).join('');
    } catch (erreur) {
      console.error('Erreur:', erreur);
    }
  }
  
  // Initialize on load
  document.addEventListener('DOMContentLoaded', chargerPays);