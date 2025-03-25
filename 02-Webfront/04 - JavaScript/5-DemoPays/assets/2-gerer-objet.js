// Enhanced country data with additional information
const laFrance = {
    code: "FR",
    nom: "France",
    capitale: "Paris",
    population: "67 millions",
    langue: "Français",
    drapeau: "🇫🇷",
    description: "Pays de la gastronomie et de la culture"
  };
  
  // Enhanced display function with interactive card
  function afficherPays(pays, numero) {
    const article = document.createElement('article');
    article.className = 'carte-pays';
    article.innerHTML = `
      <header>
        <span class="drapeau">${pays.drapeau}</span>
        <h2>${pays.nom} <small>(${pays.code})</small></h2>
      </header>
      <div class="infos-pays" style="display: none;">
        <p><strong>Capitale:</strong> ${pays.capitale}</p>
        <p><strong>Population:</strong> ${pays.population}</p>
        <p><strong>Langue:</strong> ${pays.langue}</p>
        <p class="description">${pays.description}</p>
      </div>
      <button class="btn-details">Voir détails</button>
    `;
    
    // Get references to elements
    const btnDetails = article.querySelector('.btn-details');
    const infosPays = article.querySelector('.infos-pays');
    
    // Add click handler to button only
    btnDetails.addEventListener('click', (e) => {
      e.stopPropagation(); // Prevent event bubbling
      
      if (infosPays.style.display === 'none') {
        infosPays.style.display = 'block';
        btnDetails.textContent = 'Masquer';
        article.classList.add('active');
      } else {
        infosPays.style.display = 'none';
        btnDetails.textContent = 'Voir détails';
        article.classList.remove('active');
      }
    });
  
    return article;
  }
  
  // Main execution with loading state
  document.addEventListener('DOMContentLoaded', async () => {
    const main = document.getElementById('principal');
    
    // Create loading element
    const loading = document.createElement('div');
    loading.className = 'loading';
    loading.innerHTML = '<div class="spinner"></div><p>Chargement des données...</p>';
    main.appendChild(loading);
  
    // Display France immediately
    main.appendChild(afficherPays(laFrance, 1));
  
    // Load and display Belgium with delay for demo
    try {
      setTimeout(async () => {
        const reponse = await fetch('data/belgique.json');
        const laBelgique = await reponse.json();
        
        // Enhance Belgium data
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
      }, 1500); // Simulate network delay
    } catch (erreur) {
      loading.innerHTML = '<p class="erreur">Échec du chargement des données</p>';
      console.error('Erreur:', erreur);
    }
  });