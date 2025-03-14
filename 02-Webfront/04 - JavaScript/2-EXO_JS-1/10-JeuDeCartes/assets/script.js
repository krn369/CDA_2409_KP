// Load the JSON file
fetch('./assets/cardgame.json')
    .then(response => response.json()) // Parse the JSON data
    .then(data => {
        const tableBody = document.querySelector("#card-table tbody"); // Get the table body

        // Variables to store statistics
        let mostPlayedCard = null; // Most played card
        let bestRatioCard = null; // Card with the best victory/defeat ratio
        let bestRatio = 0; // Best ratio value

        // Loop through the data and populate the table
        data.forEach(card => {
            let row = document.createElement("tr"); // Create a new table row
            
            // Add card data to the row
            row.innerHTML = `
                <td>${card.id}</td>
                <td>${card.name}</td>
                <td>${card.level}</td>
                <td>${card.power}</td>
                <td>${card.attack}</td>
                <td>${card.armor}</td>
                <td>${card.damage}</td>
                <td>${card.mitigation}</td>
                <td>${card.played}</td>
                <td>${card.victory}</td>
                <td>${card.defeat}</td>
                <td>${card.draw}</td>
            `;

            tableBody.appendChild(row); // Add the row to the table

            // Find the most played card
            if (!mostPlayedCard || card.played > mostPlayedCard.played) {
                mostPlayedCard = card;
            }

            // Find the card with the best victory/defeat ratio
            if (card.defeat > 0) {
                let ratio = card.victory / card.defeat; // Calculate ratio
                if (!bestRatioCard || ratio > bestRatio) {
                    bestRatio = ratio;
                    bestRatioCard = card;
                }
            }
        });

        // Display statistics
        document.getElementById("most-played").innerText = 
            `Most played card: ${mostPlayedCard.name} with ${mostPlayedCard.played} games and ${mostPlayedCard.victory} victories.`;

        document.getElementById("best-ratio").innerText = 
            `Best victory/defeat ratio: ${bestRatioCard.name} with ${bestRatioCard.played} games, ${bestRatioCard.victory} victories, and a ratio of ${bestRatio.toFixed(2)}.`;
    })
    .catch(error => console.error("Error loading JSON file:", error)); // Handle errors

// Theme toggle functionality
const themeSwitch = document.getElementById('theme-switch'); // Get the toggle switch
const body = document.body; // Get the body element
const toggleText = document.querySelector('.toggle-text'); // Get the toggle text

// Check for saved theme in localStorage
const savedTheme = localStorage.getItem('theme'); // Get saved theme
if (savedTheme) {
    body.setAttribute('data-theme', savedTheme); // Apply saved theme
    themeSwitch.checked = savedTheme === 'light'; // Set toggle state
    updateToggleText(savedTheme); // Update toggle text
}

// Change theme when toggle is clicked
themeSwitch.addEventListener('change', () => {
    if (themeSwitch.checked) {
        body.setAttribute('data-theme', 'light'); // Set light theme
        localStorage.setItem('theme', 'light'); // Save theme to localStorage
    } else {
        body.setAttribute('data-theme', 'dark'); // Set dark theme
        localStorage.setItem('theme', 'dark'); // Save theme to localStorage
    }
    updateToggleText(body.getAttribute('data-theme')); // Update toggle text
});

// Function to update toggle text
function updateToggleText(theme) {
    if (theme === 'light') {
        toggleText.innerText = 'Dark Mode'; // Set text to "Dark Mode"
    } else {
        toggleText.innerText = 'Light Mode'; // Set text to "Light Mode"
    }
}