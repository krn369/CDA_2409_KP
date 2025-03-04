document.getElementById('validateButton').addEventListener('click', function() {
    const firstName = document.getElementById('firstName').value.trim();
    const age = document.getElementById('age').value.trim();
    const resultDiv = document.getElementById('result');

    if (firstName && !isNaN(age) && age > 0) {
        resultDiv.textContent = `Bonjour ${firstName}, vous avez ${age} ans.`;
    } else {
        resultDiv.textContent = 'Compléter/corriger le formulaire';
    }
});

document.getElementById('clearButton').addEventListener('click', function() {
    document.getElementById('firstName').value = '';
    document.getElementById('age').value = '';
    document.getElementById('result').textContent = '';
});