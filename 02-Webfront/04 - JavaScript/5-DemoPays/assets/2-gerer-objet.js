// Object literal for France
const laFrance = {
    "country_code": "FR",
    "country_name": "France"
};

// Main function to display countries
async function afficherPays() {
    const mainElement = document.getElementById('principal');
    
    // Clear existing content
    mainElement.innerHTML = '';
    
    // Display France (first country)
    ajouterPays(mainElement, laFrance, 1);
    
    try {
        // Load and display Belgium (second country)
        const reponse = await fetch('data/belgique.json');
        if (!reponse.ok) {
            throw new Error('Erreur lors du chargement du fichier JSON');
        }
        const laBelgique = await reponse.json();
        ajouterPays(mainElement, laBelgique, 2);
    } catch (erreur) {
        console.error('Erreur:', erreur);
        const article = document.createElement('article');
        article.innerHTML = `<p>Erreur: ${erreur.message}</p>`;
        mainElement.appendChild(article);
    }
}

// Helper function to add a country to the DOM
function ajouterPays(container, pays, numero) {
    const article = document.createElement('article');
    article.innerHTML = `<p>Pays ${numero} : ${pays.country_name} (${pays.country_code})</p>`;
    container.appendChild(article);
}

// Execute when DOM is loaded
document.addEventListener('DOMContentLoaded', afficherPays);