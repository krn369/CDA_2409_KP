// Step 1: Load the data from the zipcodes.json file
let cities = [];

// Fetch the cities data from the local JSON file
fetch('./assets/zipcodes.json') // Ensure the path to the JSON file is correct
    .then(response => {
        if (!response.ok) {
            throw new Error('Erreur de réseau');
        }
        return response.json();
    })
    .then(data => {
        cities = data; // Store the data in the cities array
        console.log('Données chargées avec succès:', cities); // Debugging: Check if data is loaded
    })
    .catch(error => console.error('Erreur lors du chargement des données :', error));

// Function to search for cities
function searchCity() {
    const inputValue = document.getElementById('citySearch').value.trim().toLowerCase();
    const cityInfoDiv = document.getElementById('cityInfo');

    // If input is empty, clear city info and return
    if (inputValue === '') {
        cityInfoDiv.innerHTML = '';
        cityInfoDiv.className = '';
        return;
    }

    // Extract city name or postal code from the input
    const match = inputValue.match(/^(.*?)(\(\d{5}\))?$/); // Extract city name or postal code
    const searchQuery = match ? match[1].trim().toLowerCase() : inputValue;

    // Find all matching cities
    const matchedCities = cities.filter(city => 
        city.nomCommune.toLowerCase() === searchQuery || city.codePostal === searchQuery
    );

    if (matchedCities.length > 0) {
        // Display all matching cities
        cityInfoDiv.innerHTML = matchedCities.map(city => `
            <div class="city-block">
                <h2>${city.nomCommune}</h2>
                <p><strong>Code Postal:</strong> ${city.codePostal}</p>
                <p><strong>Code Commune:</strong> ${city.codeCommune}</p>
                <p><strong>Libellé d'Acheminement:</strong> ${city.libelleAcheminement}</p>
            </div>
        `).join(''); // Join all city blocks into a single HTML string
        cityInfoDiv.className = 'positive'; // Add styling class
    } else {
        // If no city is found, display a message
        cityInfoDiv.innerHTML = '<p>Aucune ville trouvée. Veuillez réessayer.</p>';
        cityInfoDiv.className = 'negative'; // Add styling class
    }
}

// Step 2: Add an event listener to the search input field (for suggestions)
document.getElementById('citySearch').addEventListener('input', function () {
    const inputValue = this.value.trim().toLowerCase();
    const datalist = document.getElementById('citySuggestions');
    const cityInfoDiv = document.getElementById('cityInfo');

    // Clear previous suggestions
    datalist.innerHTML = '';

    // If the input is empty, clear city info
    if (inputValue === '') {
        cityInfoDiv.innerHTML = ''; // Clear city info
        cityInfoDiv.className = ''; // Remove styling
        return;
    }

    // Filter cities by postal code OR city name
    const filteredCities = cities.filter(city => 
        city.codePostal.startsWith(inputValue) || city.nomCommune.toLowerCase().startsWith(inputValue)
    );

    // Add filtered results to the datalist
    const seen = new Set(); // To avoid duplicate options
    filteredCities.forEach(city => {
        const optionText = `${city.nomCommune} (${city.codePostal})`;
        if (!seen.has(optionText)) {
            seen.add(optionText);
            const option = document.createElement('option');
            option.value = optionText; // Show both city and postal code in suggestions
            datalist.appendChild(option);
        }
    });
});

// Step 3: Add an event listener to the search button
document.getElementById('searchButton').addEventListener('click', searchCity);

// Step 4: Add an event listener for "Enter" key inside the search input
document.getElementById('citySearch').addEventListener('keydown', function (event) {
    if (event.key === 'Enter') {
        event.preventDefault(); // Prevent default form submission behavior
        searchCity(); // Trigger search function
    }
});

// Step 5: Ensure selecting a datalist option triggers the search
document.getElementById('citySearch').addEventListener('change', function () {
    searchCity();
});
