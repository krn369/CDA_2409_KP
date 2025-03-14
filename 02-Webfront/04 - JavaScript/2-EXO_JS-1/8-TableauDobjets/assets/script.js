// List of users with their details
const users = [
    {
        id: 1,
        lastname: "Doe",
        firstname: "John",
        birthday: "1981-11-12",
        salary: 2250,
        password: "1234"
    },
    {
        id: 2,
        lastname: "Grande",
        firstname: "Léa",
        birthday: "2001-08-28",
        salary: 2165,
        password: "123456"
    },
    {
        id: 3,
        lastname: "Makenzie",
        firstname: "Roy",
        birthday: "1992-07-12",
        salary: 2090,
        password: "azerty"
    }
];

// Add an event listener to the login form
document.getElementById('login-form').addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent the form from submitting the traditional way
    const username = document.getElementById('username').value; // Get the entered username
    const password = document.getElementById('password').value; // Get the entered password

    // Find the user with matching username and password
    const user = users.find(u => `${u.firstname.toLowerCase()}.${u.lastname.toLowerCase()}` === username.toLowerCase() && u.password === password);

    if (user) {
        showUserInfo(user); // If user is found, show their info
    } else {
        showError("Identifiant ou mot de passe incorrect"); // If not, show an error message
    }
});

// Add an event listener to the logout button
document.getElementById('logout-button').addEventListener('click', function() {
    document.getElementById('user-info').classList.add('hidden'); // Hide user info section
    document.getElementById('login-form').classList.remove('hidden'); // Show login form
});

// Function to show error messages
function showError(message) {
    const errorMessage = document.getElementById('error-message');
    errorMessage.textContent = message; // Set the error message text
    errorMessage.classList.remove('hidden'); // Show the error message
    setTimeout(() => {
        errorMessage.classList.add('hidden'); // Hide the error message after 5 seconds
    }, 5000);
}

// Function to display user information
function showUserInfo(user) {
    document.getElementById('login-form').classList.add('hidden'); // Hide the login form
    document.getElementById('user-info').classList.remove('hidden'); // Show the user info section
    document.getElementById('welcome-message').textContent = `Bonjour ${user.firstname} ${user.lastname}`; // Set the welcome message

    const tableBody = document.getElementById('user-table').getElementsByTagName('tbody')[0];
    tableBody.innerHTML = ''; // Clear the table body

    // Loop through all users and add their details to the table
    users.forEach(u => {
        const row = tableBody.insertRow();
        if (u.id === user.id) {
            row.classList.add('highlight'); // Highlight the row of the logged-in user
        }
        row.insertCell(0).textContent = u.lastname; // Add last name to the table
        row.insertCell(1).textContent = u.firstname; // Add first name to the table
        row.insertCell(2).textContent = u.birthday; // Add birthday to the table
        row.insertCell(3).textContent = `${u.firstname.toLowerCase()}.${u.lastname.toLowerCase()}@example.com`; // Add email to the table
        row.insertCell(4).textContent = `${u.salary} €`; // Add salary to the table
    });
}