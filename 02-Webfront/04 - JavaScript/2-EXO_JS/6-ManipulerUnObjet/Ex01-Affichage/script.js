document.getElementById('editForm').addEventListener('submit', function(event) {
    event.preventDefault();

    const lastname = document.getElementById('editLastname').value;
    const firstname = document.getElementById('editFirstname').value;
    const birthday = document.getElementById('editBirthday').value;
    const salary = document.getElementById('editSalary').value;

    if (lastname) document.getElementById('lastname').textContent = lastname;
    if (firstname) document.getElementById('firstname').textContent = firstname;
    if (birthday) document.getElementById('birthday').textContent = birthday;
    if (salary) document.getElementById('salary').textContent = salary + ' €';

    // Générer l'email
    const email = `${firstname.toLowerCase()}.${lastname.toLowerCase()}@example.com`;
    document.getElementById('email').textContent = email;
});