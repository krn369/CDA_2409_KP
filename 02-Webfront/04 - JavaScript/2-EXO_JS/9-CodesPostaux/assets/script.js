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

// Step 2: Add an event listener to the search input field
document.getElementById('citySearch').addEventListener('input', function () {
    const inputValue = this.value.trim().toLowerCase(); // Make input value case-insensitive and trim whitespace
    const datalist = document.getElementById('citySuggestions');
    const cityInfoDiv = document.getElementById('cityInfo');

    // Clear previous suggestions and city info if the input is empty
    datalist.innerHTML = '';
    if (inputValue === '') {
        cityInfoDiv.innerHTML = ''; // Clear the city info if the input is empty
        cityInfoDiv.className = ''; // Remove any styling
        return;
    }

    // Filter cities by postal code or city name (case-insensitive)
    const filteredCities = cities.filter(city => 
        city.codePostal.startsWith(inputValue) || city.nomCommune.toLowerCase().startsWith(inputValue)
    );

    // Add the filtered cities to the datalist
    filteredCities.forEach(city => {
        const option = document.createElement('option');
        option.value = city.nomCommune; // Display the city name in the suggestions
        option.setAttribute('data-postal', city.codePostal); // Store the postal code in a data attribute
        datalist.appendChild(option);
    });
});

// Step 3: Add an event listener to the search button
document.getElementById('searchButton').addEventListener('click', function () {
    const inputValue = document.getElementById('citySearch').value.trim().toLowerCase();
    const cityInfoDiv = document.getElementById('cityInfo');

    // Try to find a city that matches the input value in either name or postal code
    const selectedCity = cities.find(city => 
        city.nomCommune.toLowerCase() === inputValue || city.codePostal.startsWith(inputValue)
    );

    if (selectedCity) {
        // Display the city information with positive styling
        cityInfoDiv.innerHTML = `
            <h2>${selectedCity.nomCommune}</h2>
            <p>Code Postal : ${selectedCity.codePostal}</p>
            <p>Code Commune : ${selectedCity.codeCommune}</p>
            <p>Libellé d'Acheminement : ${selectedCity.libelleAcheminement}</p>
        `;
        cityInfoDiv.className = 'positive'; // Add positive class
    } else {
        // If no city is found, display a message with negative styling
        cityInfoDiv.innerHTML = '<p>Aucune ville trouvée. Veuillez réessayer.</p>';
        cityInfoDiv.className = 'negative'; // Add negative class
    }
});