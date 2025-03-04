document.getElementById('calculateButton').addEventListener('click', function() {
    const birthDateTime = document.getElementById('birthDateTime').value;
    const resultDiv = document.getElementById('result');
    const now = new Date();
    const selectedDate = new Date(birthDateTime);

    if (selectedDate > now) {
        resultDiv.textContent = 'Sélectionnez une date dans le passé.';
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
    }
});