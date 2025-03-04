document.getElementById('validateButton').addEventListener('click', function() {
    const firstName = document.getElementById('firstName').value.trim();
    const age = parseInt(document.getElementById('age').value.trim(), 10);
    const resultDiv = document.getElementById('result');
    const majorityStatusDiv = document.getElementById('majorityStatus');
    const retirementStatusDiv = document.getElementById('retirementStatus');

    if (firstName && !isNaN(age) && age > 0) {
        resultDiv.innerHTML = `Bonjour <strong>${firstName}</strong>, votre âge est : <strong>${age}</strong>.`;
        if (age >= 18) {
            majorityStatusDiv.innerHTML = 'Vous êtes <strong>majeur</strong>.';
        } else {
            majorityStatusDiv.innerHTML = 'Vous êtes <strong>mineur</strong>.';
        }

        if (age < 64) {
            const yearsLeft = 64 - age;
            retirementStatusDiv.innerHTML = `Il vous reste <strong>${yearsLeft} année(s)</strong> avant la retraite.`;
        } else if (age > 64) {
            const yearsSince = age - 64;
            retirementStatusDiv.innerHTML = `Vous êtes à la retraite depuis <strong>${yearsSince} année(s)</strong>.`;
        } else {
            retirementStatusDiv.innerHTML = 'Vous prenez votre retraite <strong>cette année</strong> !';
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