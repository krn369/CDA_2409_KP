import { Pays } from './pays.js';

// Get DOM elements
const monTitre = document.getElementById('titre');
const monBouton = document.getElementById('validate');
const inputCodePays = document.getElementById('codePays');
const inputNomPays = document.getElementById('nomPays');
const divResult = document.getElementById('result');

// Change page title
monTitre.textContent = 'Ajouter un pays';

// Add event listener to button
monBouton.addEventListener('click', (event) => {
    event.preventDefault();
    
    // Clear previous messages
    divResult.textContent = '';
    divResult.className = '';
    
    try {
        // Get and trim input values
        const codePays = inputCodePays.value.trim();
        const nomPays = inputNomPays.value.trim();
        
        // Create new country object (validation happens in the constructor)
        const monPays = new Pays(codePays, nomPays);
        
        // Display success message
        divResult.textContent = `Pays ajouté : ${monPays.country_code} - ${monPays.country_name}`;
        divResult.className = 'success';
        
        // Here you would typically save the object (to localStorage, server, etc.)
        console.log('Nouveau pays créé :', monPays);
        
    } catch (error) {
        // Display error message
        divResult.textContent = error.message;
        divResult.className = 'error';
        console.error('Erreur:', error.message);
    }
});