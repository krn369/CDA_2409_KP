// Wait for the DOM to be fully loaded before executing the script
document.addEventListener('DOMContentLoaded', function() {
    // Fetch student data from JSON file
    fetch('eval.json')
        .then(response => response.json()) // Convert response to JSON
        .then(data => {
            // Process each student in the data
            const etudiants = data.map(etudiant => {
                // Split full name into first and last name
                const [nom, prenom] = etudiant.fullname.split(' ');
                return {
                    nom: formatNom(nom), // Format last name
                    prenom: formatNom(prenom), // Format first name
                    note: etudiant.grade, // Get grade
                    obtenu: etudiant.grade >= 12 ? 'Oui' : 'Non' // Determine if passed
                };
            });
            
            // Sort students by grade in descending order
            etudiants.sort((a, b) => b.note - a.note);
            
            // Display students in table and update statistics
            afficherTableau(etudiants);
            mettreAJourStatistiques(etudiants);
            
            // Add event listener for form submission
            document.getElementById('form-etudiant').addEventListener('submit', function(e) {
                e.preventDefault(); // Prevent default form submission
                ajouterEtudiant(etudiants); // Add new student
            });
        })
        .catch(error => console.error('Error loading data:', error)); // Log any errors
});

/**
 * Formats a name string to capitalize first letter and lowercase the rest
 * @param {string} chaine - The name string to format
 * @return {string} - Formatted name
 */
function formatNom(chaine) {
    if (!chaine) return ''; // Return empty string if input is falsy
    return chaine.charAt(0).toUpperCase() + chaine.slice(1).toLowerCase();
}

/**
 * Displays students in the HTML table
 * @param {Array} etudiants - Array of student objects
 */
function afficherTableau(etudiants) {
    const tbody = document.querySelector('#tableau-notes tbody');
    tbody.innerHTML = ''; // Clear existing table content
    
    // Create and append a row for each student
    etudiants.forEach(etudiant => {
        const tr = document.createElement('tr');
        tr.innerHTML = `
            <td>${etudiant.nom}</td>
            <td>${etudiant.prenom}</td>
            <td>${etudiant.note}</td>
            <td class="obtenu-${etudiant.obtenu === 'Oui' ? 'oui' : 'non'}">${etudiant.obtenu}</td>
        `;
        tbody.appendChild(tr);
    });
}

/**
 * Updates statistics display (count, average, above average)
 * @param {Array} etudiants - Array of student objects
 */
function mettreAJourStatistiques(etudiants) {
    const nombreEtudiants = etudiants.length;
    const sommeNotes = etudiants.reduce((total, etudiant) => total + etudiant.note, 0);
    const moyenne = nombreEtudiants > 0 ? (sommeNotes / nombreEtudiants).toFixed(2) : 0;
    const auDessusMoyenne = etudiants.filter(etudiant => etudiant.note > parseFloat(moyenne)).length;
    
    // Update DOM elements with calculated values
    document.getElementById('nombre-etudiants').textContent = nombreEtudiants;
    document.getElementById('moyenne').textContent = moyenne;
    document.getElementById('auDessusMoyenne').textContent = auDessusMoyenne;
}

/**
 * Adds a new student from form input
 * @param {Array} etudiants - Array of student objects to modify
 */
function ajouterEtudiant(etudiants) {
    // Hide previous error messages
    document.querySelectorAll('.error-message').forEach(el => {
        el.style.display = 'none';
    });

    const inputNom = document.getElementById('nom');
    const inputNote = document.getElementById('note');
    const noms = inputNom.value.trim().split(/\s+/); // Split name into parts
    
    // Validate name - must have at least first and last name with 2+ characters each
    if (noms.length < 2 || noms[0].length < 2 || noms[1].length < 2) {
        document.querySelector('#form-etudiant .form-group:nth-child(1) .error-message').style.display = 'block';
        return;
    }
    
    // Validate grade - must be a number between 0 and 20
    const note = parseFloat(inputNote.value);
    if (isNaN(note) || note < 0 || note > 20) {
        document.querySelector('#form-etudiant .form-group:nth-child(2) .error-message').style.display = 'block';
        return;
    }
    
    // Add new student to array
    etudiants.push({
        nom: formatNom(noms[0]), // Format last name
        prenom: formatNom(noms[1]), // Format first name
        note: note, // Store grade
        obtenu: note >= 12 ? 'Oui' : 'Non' // Determine if passed
    });
    
    // Update display with new student
    etudiants.sort((a, b) => b.note - a.note); // Re-sort by grade
    afficherTableau(etudiants); // Update table
    mettreAJourStatistiques(etudiants); // Update statistics
    
    // Reset form inputs
    inputNom.value = '';
    inputNote.value = '0';
}