let cities = [
    { codePostal: "10000", nomCommune: "Troyes", codeCommune: "10387", libelleAcheminement: "TROYES" },
    { codePostal: "10100", nomCommune: "Romilly-sur-Seine", codeCommune: "10323", libelleAcheminement: "ROMILLY SUR SEINE" },
    { codePostal: "11000", nomCommune: "Carcassonne", codeCommune: "11069", libelleAcheminement: "CARCASSONNE" },
    { codePostal: "10200", nomCommune: "Bar-sur-Aube", codeCommune: "10033", libelleAcheminement: "BAR SUR AUBE" }
];

document.getElementById('citySearch').addEventListener('input', function () {
    const inputValue = this.value.toLowerCase(); // Make the search case-insensitive
    const datalist = document.getElementById('citySuggestions');
    datalist.innerHTML = '';
    const filteredCities = cities.filter(city => 
        city.nomCommune.toLowerCase().startsWith(inputValue) || city.codePostal.startsWith(inputValue)
    );
    filteredCities.forEach(city => {
        const option = document.createElement('option');
        option.value = city.nomCommune; // Show the city name as the value
        option.setAttribute('data-postal', city.codePostal);
        datalist.appendChild(option);
    });
});

document.getElementById('searchButton').addEventListener('click', function () {
    const inputValue = document.getElementById('citySearch').value.trim();
    const cityInfoDiv = document.getElementById('cityInfo');
    const selectedOption = document.querySelector(`#citySuggestions option[value="${inputValue}"]`);
    
    if (selectedOption) {
        const postalCode = selectedOption.getAttribute('data-postal');
        const selectedCity = cities.find(city => city.codePostal === postalCode);
        if (selectedCity) {
            cityInfoDiv.innerHTML = `<h2>${selectedCity.nomCommune}</h2><p>Code Postal: ${selectedCity.codePostal}</p><p>Code Commune: ${selectedCity.codeCommune}</p><p>Libellé d'Acheminement: ${selectedCity.libelleAcheminement}</p>`;
        } else {
            cityInfoDiv.innerHTML = '<p>Aucune ville trouvée.</p>';
        }
    } else {
        cityInfoDiv.innerHTML = '<p>Sélectionnez une ville.</p>';
    }
});
