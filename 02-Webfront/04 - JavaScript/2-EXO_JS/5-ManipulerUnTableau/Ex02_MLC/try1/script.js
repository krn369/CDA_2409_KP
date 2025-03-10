const people = ['Mike Dev', 'John Makenzie',  'Léa Grande'];

function generateEmail(firstName, lastName) {
    return `${firstName.toLowerCase()}.${lastName.toLowerCase()}@example.com`;
}

function displayPeople() {
    const listElement = document.getElementById('people-list');
    const tableBody = document.querySelector('#people-table tbody');

    // Clear existing content
    listElement.innerHTML = '';
    tableBody.innerHTML = '';

    people.forEach((person, index) => {
        const [firstName, lastName] = person.split(' ');
        const email = generateEmail(firstName, lastName);

        // Add to the list
        const listItem = document.createElement('li');
        listItem.textContent = person;
        listElement.appendChild(listItem);

        // Add to the table
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${lastName}</td>
            <td>${firstName}</td>
            <td>${email}</td>
            <td><button class="delete" data-index="${index}">X</button></td>
        `;
        tableBody.appendChild(row);
    });

    // Add event listeners to delete buttons
    const deleteButtons = document.querySelectorAll('.delete');
    deleteButtons.forEach(button => {
        button.addEventListener('click', () => {
            const index = button.getAttribute('data-index');
            people.splice(index, 1); // Remove the person from the array
            displayPeople(); // Refresh the list and table
        });
    });
}

function addPerson(firstName, lastName) {
    const fullName = `${firstName} ${lastName}`;

    // Check if the person already exists
    if (people.includes(fullName)) {
        alert('Cette personne existe déjà !');
        return;
    }

    // Add the new person
    people.push(fullName);
    displayPeople(); // Refresh the list and table
    document.getElementById('message').textContent = `${fullName} ajouté !`;
}

// Handle form submission
document.getElementById('add-person-form').addEventListener('submit', (event) => {
    event.preventDefault(); // Prevent the form from submitting

    const firstName = document.getElementById('first-name').value.trim();
    const lastName = document.getElementById('last-name').value.trim();

    // Validate input
    if (firstName.length < 2 || lastName.length < 2) {
        alert('Le nom et le prénom doivent contenir au moins 2 lettres.');
        return;
    }

    if (!/^[A-Za-zÀ-ÖØ-öø-ÿ\s'-]+$/.test(firstName) || !/^[A-Za-zÀ-ÖØ-öø-ÿ\s'-]+$/.test(lastName)) {
        alert('Le nom et le prénom ne peuvent contenir que des lettres.');
        return;
    }

    // Add the person
    addPerson(firstName, lastName);

    // Clear the form
    document.getElementById('add-person-form').reset();
});

// Display people when the page loads
document.addEventListener('DOMContentLoaded', displayPeople);