// Step 1: Load the data from the zipcodes.json file
let cities = [];

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
    const inputValue = this.value; // Get the value from the input field
    const datalist = document.getElementById('citySuggestions');

    // Clear previous suggestions
    datalist.innerHTML = '';

    // Filter cities that match the input value
    const filteredCities = cities.filter(city => city.codePostal.includes(inputValue));

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
    const inputValue = document.getElementById('citySearch').value;
    const cityInfoDiv = document.getElementById('cityInfo');

    // Find the city that matches the input value
    const selectedCity = cities.find(city => city.nomCommune === inputValue);

    if (selectedCity) {
        // Display the city information
        cityInfoDiv.innerHTML = `
            <h2>${selectedCity.nomCommune}</h2>
            <p>Code Postal : ${selectedCity.codePostal}</p>
            <p>Code Commune : ${selectedCity.codeCommune}</p>
            <p>Libellé d'Acheminement : ${selectedCity.libelleAcheminement}</p>
        `;
    } else {
        // If no city is found, display a message
        cityInfoDiv.innerHTML = '<p>Aucune ville trouvée. Veuillez réessayer.</p>';
    }
});