/**
 * Données améliorées pour la France
 */
const laFrance = {
    code: "FR",
    nom: "France",
    capitale: "Paris",
    population: "67 millions",
    langue: "Français",
    drapeau: "🇫🇷",
    description: "Pays de la gastronomie et de la culture"
  };
  
  /**
   * Crée et retourne une carte de pays
   * @param {object} pays - Objet contenant les données du pays
   * @param {number} numero - Numéro d'ordre
   * @returns {HTMLElement} Élément HTML de la carte
   */
  function afficherPays(pays, numero) {
    const article = document.createElement('article');
    article.className = 'carte-pays fade-in';
    article.setAttribute('aria-labelledby', `titre-pays-${numero}`);
    
    article.innerHTML = `
      <header>
        <span class="drapeau" aria-hidden="true">${pays.drapeau}</span>
        <h2 id="titre-pays-${numero}">${pays.nom} <small>(${pays.code})</small></h2>
      </header>
      <div class="infos-pays" style="display: none;">
        <p><strong>Capitale:</strong> ${pays.capitale}</p>
        <p><strong>Population:</strong> ${pays.population}</p>
        <p><strong>Langue:</strong> ${pays.langue}</p>
        <p class="description">${pays.description}</p>
      </div>
      <button class="btn-details" aria-expanded="false" aria-controls="infos-pays-${numero}">
        Voir détails
      </button>
    `;
    
    const btnDetails = article.querySelector('.btn-details');
    const infosPays = article.querySelector('.infos-pays');
    infosPays.id = `infos-pays-${numero}`;
    
    // Gère le clic sur le bouton
    btnDetails.addEventListener('click', (e) => {
      e.stopPropagation();
      
      const estVisible = infosPays.style.display === 'block';
      infosPays.style.display = estVisible ? 'none' : 'block';
      btnDetails.textContent = estVisible ? 'Voir détails' : 'Masquer';
      btnDetails.setAttribute('aria-expanded', !estVisible);
      article.classList.toggle('active', !estVisible);
    });
  
    return article;
  }
  
  /**
   * Point d'entrée principal
   */
  document.addEventListener('DOMContentLoaded', async () => {
    const main = document.getElementById('principal');
    
    // Affiche un indicateur de chargement
    const loading = document.createElement('div');
    loading.className = 'loading';
    loading.innerHTML = '<div class="spinner"></div><p>Chargement des données...</p>';
    main.appendChild(loading);
  
    // Affiche la France immédiatement
    main.appendChild(afficherPays(laFrance, 1));
  
    // Charge et affiche la Belgique avec un délai (simulation)
    try {
      setTimeout(async () => {
        const reponse = await fetch('data/belgique.json');
        if (!reponse.ok) throw new Error('Erreur de chargement');
        
        const laBelgique = await reponse.json();
        
        // Complète les données de la Belgique
        const belgiqueComplete = {
          ...laBelgique,
          drapeau: "🇧🇪",
          capitale: "Bruxelles",
          population: "11.5 millions",
          langue: "Néerlandais, Français, Allemand",
          description: "Pays connu pour son chocolat et ses frites"
        };
        
        main.appendChild(afficherPays(belgiqueComplete, 2));
        loading.remove();
      }, 1500); // Simule un délai réseau
    } catch (erreur) {
      loading.innerHTML = '<p class="error">Échec du chargement des données</p>';
      console.error('Erreur:', erreur);
    }
  });