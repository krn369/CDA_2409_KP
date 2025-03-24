// Country class to manage country data and validation
class Pays {
    constructor(code, nom) {
        this.code = this.validateCode(code);
        this.nom = this.validateName(nom);
    }

    validateCode(code) {
        const cleanedCode = code.trim();
        if (!/^[A-Za-z]{2}$/.test(cleanedCode)) {
            throw new Error('Le code pays doit contenir exactement 2 lettres non accentuées');
        }
        return cleanedCode.toUpperCase();
    }

    validateName(nom) {
        const cleanedName = nom.trim();
        if (!/^[A-Za-zÀ-ÿ\s]{4,}$/.test(cleanedName)) {
            throw new Error('Le nom du pays doit contenir au moins 4 caractères valides');
        }
        return cleanedName.charAt(0).toUpperCase() + cleanedName.slice(1).toLowerCase();
    }
}

// Main application
document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('countryForm');
    const tableBody = document.getElementById('countryTableBody');
    const resultDiv = document.getElementById('result');
    let countries = JSON.parse(localStorage.getItem('countries')) || [];

    // Initialize UI
    updateCountryTable();
    document.getElementById('titre').textContent = 'Ajouter un pays';

    // Form submission handler
    form.addEventListener('submit', (e) => {
        e.preventDefault();
        resultDiv.textContent = '';
        resultDiv.className = '';

        try {
            const code = document.getElementById('codePays').value;
            const nom = document.getElementById('nomPays').value;

            const nouveauPays = new Pays(code, nom);
            countries.push({
                code: nouveauPays.code,
                nom: nouveauPays.nom
            });

            saveCountries();
            updateCountryTable();
            form.reset();

            showMessage('Pays ajouté avec succès!', 'success');
        } catch (error) {
            showMessage(error.message, 'error');
        }
    });

    // Update country table display
    function updateCountryTable() {
        tableBody.innerHTML = '';
        
        if (countries.length === 0) {
            tableBody.innerHTML = `
                <tr>
                    <td colspan="3" class="empty-message">Aucun pays ajouté pour le moment</td>
                </tr>
            `;
            return;
        }

        countries.forEach((country, index) => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${country.code}</td>
                <td>${country.nom}</td>
                <td>
                    <button class="delete-btn" data-index="${index}">Supprimer</button>
                </td>
            `;
            tableBody.appendChild(row);
        });

        // Add event listeners to delete buttons
        document.querySelectorAll('.delete-btn').forEach(btn => {
            btn.addEventListener('click', (e) => {
                const index = parseInt(e.target.dataset.index);
                countries.splice(index, 1);
                saveCountries();
                updateCountryTable();
                showMessage('Pays supprimé avec succès', 'success');
            });
        });
    }

    // Save countries to localStorage
    function saveCountries() {
        localStorage.setItem('countries', JSON.stringify(countries));
    }

    // Show status messages
    function showMessage(message, type) {
        resultDiv.textContent = message;
        resultDiv.className = type;
    }
});