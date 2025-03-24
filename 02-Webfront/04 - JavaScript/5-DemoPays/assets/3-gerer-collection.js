/**
 * Load and display country data from JSON file
 */
async function loadAndDisplayCountries() {
    try {
        // 1. Fetch the country data from JSON file
        const response = await fetch('data/collectionPays.json');
        
        // Check if the request was successful
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        
        // 2. Parse the JSON data
        const countries = await response.json();
        const tableBody = document.getElementById('mesPays');
        
        // 3. Clear any existing table content
        tableBody.innerHTML = '';
        
        // 4. Create and append table rows for each country
        countries.forEach(country => {
            // Create a new table row
            const row = document.createElement('tr');
            
            // Create and append country code cell
            const codeCell = document.createElement('td');
            codeCell.textContent = country.country_code;
            row.appendChild(codeCell);
            
            // Create and append country name cell
            const nameCell = document.createElement('td');
            nameCell.textContent = country.country_name;
            row.appendChild(nameCell);
            
            // Add the row to the table
            tableBody.appendChild(row);
        });
        
    } catch (error) {
        console.error('Error loading country data:', error);
        
        // 5. Display error message in the table
        const tableBody = document.getElementById('mesPays');
        tableBody.innerHTML = `
            <tr>
                <td colspan="2" class="error-message">
                    Failed to load country data: ${error.message}
                </td>
            </tr>
        `;
    }
}

// Wait for DOM to be fully loaded before executing
document.addEventListener('DOMContentLoaded', loadAndDisplayCountries);