const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];

function generateEmail(firstName, lastName) {
    return `${firstName.toLowerCase()}.${lastName.toLowerCase()}@example.com`;
}

function displayPeople() {
    const listElement = document.getElementById('people-list');
    const tableBody = document.querySelector('#people-table tbody');

    people.forEach(person => {
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
        `;
        tableBody.appendChild(row);
    });
}

document.addEventListener('DOMContentLoaded', displayPeople);