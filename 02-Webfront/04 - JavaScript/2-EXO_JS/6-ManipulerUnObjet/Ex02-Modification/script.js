const myEmployee = {
    lastname: "Doe",
    firstname: "John",
    birthday: "1981-11-12",
    salary: 2150
};

document.getElementById('editFirstname').value = myEmployee.firstname;
document.getElementById('editLastname').value = myEmployee.lastname;
document.getElementById('editBirthday').value = myEmployee.birthday;
document.getElementById('editSalary').value = myEmployee.salary;

document.getElementById('editForm').addEventListener('submit', function(event) {
    event.preventDefault();

    const firstname = document.getElementById('editFirstname').value;
    const lastname = document.getElementById('editLastname').value;
    const birthday = document.getElementById('editBirthday').value;
    const salary = parseFloat(document.getElementById('editSalary').value);

    // Contrôles de saisie
    if (!/^[A-Za-z]{2,}$/.test(firstname)) {
        alert("Le prénom doit contenir au moins 2 lettres.");
        return;
    }

    if (!/^[A-Za-z]{2,}$/.test(lastname)) {
        alert("Le nom doit contenir au moins 2 lettres.");
        return;
    }

    const today = new Date();
    const birthDate = new Date(birthday);
    if (birthDate >= today) {
        alert("La date de naissance doit être dans le passé.");
        return;
    }

    if (salary < myEmployee.salary) {
        alert("Le salaire ne peut pas être inférieur au salaire précédent.");
        return;
    }

    // Mise à jour des informations
    myEmployee.firstname = firstname;
    myEmployee.lastname = lastname;
    myEmployee.birthday = birthday;
    myEmployee.salary = salary;

    document.getElementById('firstname').textContent = firstname;
    document.getElementById('lastname').textContent = lastname;
    document.getElementById('birthday').textContent = birthday;
    document.getElementById('salary').textContent = salary + ' €';

    // Générer l'email
    const email = `${firstname.toLowerCase()}.${lastname.toLowerCase()}@example.com`;
    document.getElementById('email').textContent = email;

    alert("Profil mis à jour avec succès !");
});