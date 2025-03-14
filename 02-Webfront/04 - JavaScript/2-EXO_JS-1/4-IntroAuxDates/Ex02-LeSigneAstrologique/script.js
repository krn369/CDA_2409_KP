document.getElementById('calculateButton').addEventListener('click', function() {
    const birthDateTime = document.getElementById('birthDateTime').value;
    const resultDiv = document.getElementById('result');
    const astrologicalSignDiv = document.getElementById('astrologicalSign');
    const now = new Date();
    const selectedDate = new Date(birthDateTime);

    if (selectedDate > now) {
        resultDiv.textContent = 'Sélectionnez une date dans le passé.';
        astrologicalSignDiv.textContent = '';
    } else {
        const formattedDate = selectedDate.toLocaleDateString('fr-FR', {
            day: '2-digit',
            month: '2-digit',
            year: 'numeric',
            hour: '2-digit',
            minute: '2-digit',
            second: '2-digit'
        });
        const yearsPassed = now.getFullYear() - selectedDate.getFullYear();
        resultDiv.innerHTML = `Vous êtes né le <strong>${formattedDate}</strong>.<br>Il s'est écoulé <strong>${yearsPassed}</strong> années depuis votre naissance.`;

        const month = selectedDate.getMonth() + 1; // Months are 0-based
        const day = selectedDate.getDate();
        const sign = getAstrologicalSign(month, day);
        astrologicalSignDiv.innerHTML = `Votre signe astrologique : <strong>${sign}</strong>.`;
    }
});

function getAstrologicalSign(month, day) {
    if ((month === 1 && day >= 20) || (month === 2 && day <= 18)) {
        return 'Verseau';
    } else if ((month === 2 && day >= 19) || (month === 3 && day <= 20)) {
        return 'Poissons';
    } else if ((month === 3 && day >= 21) || (month === 4 && day <= 19)) {
        return 'Bélier';
    } else if ((month === 4 && day >= 20) || (month === 5 && day <= 20)) {
        return 'Taureau';
    } else if ((month === 5 && day >= 21) || (month === 6 && day <= 20)) {
        return 'Gémeaux';
    } else if ((month === 6 && day >= 21) || (month === 7 && day <= 22)) {
        return 'Cancer';
    } else if ((month === 7 && day >= 23) || (month === 8 && day <= 22)) {
        return 'Lion';
    } else if ((month === 8 && day >= 23) || (month === 9 && day <= 22)) {
        return 'Vierge';
    } else if ((month === 9 && day >= 23) || (month === 10 && day <= 22)) {
        return 'Balance';
    } else if ((month === 10 && day >= 23) || (month === 11 && day <= 21)) {
        return 'Scorpion';
    } else if ((month === 11 && day >= 22) || (month === 12 && day <= 21)) {
        return 'Sagittaire';
    } else {
        return 'Capricorne';
    }
}