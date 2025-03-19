document.addEventListener('DOMContentLoaded', async function () {
    try {
        // Step 1: Load the JSON data
        const response = await fetch('./data/cars.json');
        if (!response.ok) {
            throw new Error('Error loading data');
        }
        const data = await response.json();

        // Step 2: Get DOM elements
        const inputVoiture = document.getElementById('carName');
        const btnRechercher = document.getElementById('validate');
        const resultDiv = document.getElementById('result');

        // Step 3: Function to clear results
        function clearResults() {
            resultDiv.innerHTML = ''; // Clear the results container
        }

        // Step 4: Function to handle search
        function lancerRecherche(event) {
            event.preventDefault(); // Prevent form submission

            const searchTerm = inputVoiture.value.trim().toLowerCase(); // Get and trim the search term
            clearResults(); // Clear previous results

            if (searchTerm === '') {
                // If the search term is empty, do nothing or show a message
                return;
            }

            // Step 5: Filter the cars that match the search term
            const matches = data.filter(car => car.car_name.toLowerCase().includes(searchTerm));

            if (matches.length > 0) {
                // If matches are found, display them with the "positive" class
                matches.forEach(car => {
                    const carInfo = document.createElement('div');
                    carInfo.classList.add('positive'); // Add the positive class
                    carInfo.innerHTML = `
                        <p><strong>ID:</strong> ${car.car_id}</p>
                        <p><strong>Name:</strong> ${car.car_name}</p>
                        <p><strong>Model:</strong> ${car.car_model}</p>
                        <p><strong>Origin:</strong> ${car.car_origin}</p>
                        <hr>
                    `;
                    resultDiv.appendChild(carInfo);
                });
            } else {
                // If no matches are found, display a "No results found" message with the "negative" class
                const noResults = document.createElement('div');
                noResults.classList.add('negative'); // Add the negative class
                noResults.innerHTML = '<p>No results found.</p>';
                resultDiv.appendChild(noResults);
            }
        }

        // Step 6: Add event listeners
        btnRechercher.addEventListener('click', lancerRecherche);

        // Clear results when the input field is cleared
        inputVoiture.addEventListener('input', function () {
            if (this.value.trim() === '') {
                clearResults(); // Clear results if the input is empty
            }
        });
    } catch (error) {
        // Step 7: Handle errors
        console.error('Error:', error);
        document.getElementById('result').innerHTML = '<p>Error loading data.</p>';
    }
});