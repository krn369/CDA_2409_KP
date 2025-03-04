const zoneScore = document.querySelector("span")
const buttonAjouter = document.querySelector("#ajouter")
const boutonReinitialiser = document.querySelector("#reinitialiser")
let score = 0

const comptage = () => {
    score++;
    zoneScore.innerText = score;
}

const reinitialiser = () => {
    score = 0;
    zoneScore.innerText = score;
}

boutonAjouter.addEventListener("click", comptage);
boutonReinitialiser.addEventListener("click", reinitialiser);