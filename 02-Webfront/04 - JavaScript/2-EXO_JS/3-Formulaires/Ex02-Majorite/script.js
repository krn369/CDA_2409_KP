document.getElementById('validateButton').addEventListener('click', function() {
    const firstName = document.getElementById('firstName').value.trim();
    const age = document.getElementById('age').value.trim();
    const resultDiv = document.getElementById('result');
    const majorityStatusDiv = document.getElementById('majorityStatus');

    if (firstName && !isNaN(age) && age > 0) {
        resultDiv.textContent = `Bonjour ${firstName}, votre âge est : ${age}.`;
        if (age >= 18) {
            majorityStatusDiv.textContent = 'Vous êtes majeur.';
        } else {
            majorityStatusDiv.textContent = 'Vous êtes mineur.';
        }
    } else {
        resultDiv.textContent = 'Compléter/corriger le formulaire';
        majorityStatusDiv.textContent = '';
    }
});

document.getElementById('clearButton').addEventListener('click', function() {
    document.getElementById('firstName').value = '';
    document.getElementById('age').value = '';
    document.getElementById('result').textContent = '';
    document.getElementById('majorityStatus').textContent = '';
});