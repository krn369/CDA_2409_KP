document.getElementById('validateButton').addEventListener('click', function() {
    const firstName = document.getElementById('firstName').value.trim();
    const age = parseInt(document.getElementById('age').value.trim(), 10);
    const resultDiv = document.getElementById('result');
    const majorityStatusDiv = document.getElementById('majorityStatus');
    const retirementStatusDiv = document.getElementById('retirementStatus');

    if (firstName && !isNaN(age) && age > 0) {
        resultDiv.textContent = `Bonjour ${firstName}, votre âge est : ${age}.`;
        if (age >= 18) {
            majorityStatusDiv.textContent = 'Vous êtes majeur.';
        } else {
            majorityStatusDiv.textContent = 'Vous êtes mineur.';
        }

        if (age < 64) {
            const yearsLeft = 64 - age;
            retirementStatusDiv.textContent = `Il vous reste ${yearsLeft} année(s) avant la retraite.`;
        } else if (age > 64) {
            const yearsSince = age - 64;
            retirementStatusDiv.textContent = `Vous êtes à la retraite depuis ${yearsSince} année(s).`;
        } else {
            retirementStatusDiv.textContent = 'Vous prenez votre retraite cette année !';
        }
    } else {
        resultDiv.textContent = 'Compléter/corriger le formulaire';
        majorityStatusDiv.textContent = '';
        retirementStatusDiv.textContent = '';
    }
});

document.getElementById('clearButton').addEventListener('click', function() {
    document.getElementById('firstName').value = '';
    document.getElementById('age').value = '';
    document.getElementById('result').textContent = '';
    document.getElementById('majorityStatus').textContent = '';
    document.getElementById('retirementStatus').textContent = '';
});