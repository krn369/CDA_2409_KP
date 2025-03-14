// Initial list of people
const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];

// DOM Elements
const inputPrenom = document.querySelector("#prenom");
const inputNom = document.querySelector("#nom");
const btnAjouter = document.querySelector("#btnAjouter");
const zoneAffichage = document.querySelector("#zoneAffichage");
const ul = document.querySelector("ul");
const tbody = document.querySelector("tbody");

// Function to display the list of people
const AffichageListe = () => {
    ul.innerHTML = ""; // Clear the list before re-rendering
    for (let i = 0; i < people.length; i++) {
        const li = document.createElement("li");
        li.innerText = people[i];
        ul.appendChild(li);
    }
};

// Function to display the table of people
const AffichageTableau = () => {
    tbody.innerHTML = ""; // Clear the table before re-rendering
    for (let i = 0; i < people.length; i++) {
        const personSplit = people[i].split(" ");
        const tr = document.createElement("tr");

        // Create table cells for name, surname, and email
        const tdNom = document.createElement("td");
        tdNom.innerText = personSplit[1]; // Last name
        const tdPrenom = document.createElement("td");
        tdPrenom.innerText = personSplit[0]; // First name
        const tdEmail = document.createElement("td");
        tdEmail.innerText = `${personSplit[1].toLowerCase()}.${personSplit[0].toLowerCase()}@example.com`; // Email

        // Create the delete button
        const btnSuppr = document.createElement("button");
        btnSuppr.innerText = "X";
        btnSuppr.classList.add("btnSuppr");

        // Add event listener to delete button
        btnSuppr.addEventListener("click", () => {
            people.splice(i, 1); // Remove the person from the array
            AffichageListe(); // Re-render the list
            AffichageTableau(); // Re-render the table
        });

        // Create a td element for the button
        const tdSuppr = document.createElement("td");
        tdSuppr.appendChild(btnSuppr); // Add the button to the td

        // Append cells to the table row
        tr.appendChild(tdNom);
        tr.appendChild(tdPrenom);
        tr.appendChild(tdEmail);
        tr.appendChild(tdSuppr); // Append the td containing the button
        tbody.appendChild(tr);
    }
};

// Event listener for the "Add" button
btnAjouter.addEventListener("click", (e) => {
    e.preventDefault(); // Prevent form submission
    ul.innerHTML = ""; // Clear the list
    tbody.innerHTML = ""; // Clear the table

    // Check if the person already exists
    let personneExistante = false;
    const nouvellePersonne = `${inputPrenom.value} ${inputNom.value}`;
    for (let i = 0; i < people.length; i++) {
        if (people[i] === nouvellePersonne) {
            personneExistante = true;
            break;
        }
    }

    // Add the new person if they don't already exist and the input is valid
    if (inputPrenom.value.length > 1 && inputNom.value.length > 1 && !personneExistante) {
        people.push(nouvellePersonne);
        zoneAffichage.innerText = `${inputPrenom.value} ${inputNom.value} ajouté !`;
    } else {
        zoneAffichage.innerText = "Erreur : Personne déjà existante ou champs invalides.";
    }

    // Re-render the list and table
    AffichageListe();
    AffichageTableau();

    // Clear the input fields
    inputPrenom.value = "";
    inputNom.value = "";
});

// Initial rendering of the list and table
AffichageListe();
AffichageTableau();