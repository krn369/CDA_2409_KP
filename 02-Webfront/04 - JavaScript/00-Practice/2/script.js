const people = ["Mike Dev", "John Makenzie", "Léa Grande"];

const liste = document.querySelector("#inscrit");
liste.setAttribute("style", "list-style-type: none; color: #ACCBE1");

document.body.style.backgroundColor = "#536B78";
document.body.style.color = "#ACCBE1";
document.querySelector("h1").setAttribute("style", "border:2px dashed #ACCBE1");

for (let i = 0; i < people.length; i++) {
  let monItem = document.createElement("li");
  monItem.setAttribute("style", "font_family:tahoma; font-size: 1.6rem");
  monItem.textContent = people[i];
  liste.appendChild(monItem);
}

function CrerCookie(nomCookie, valeurCookie) {
  let datejour = new Date();

  let dateExpite = new Date(
    datejour.getFullYear(),
    datejour.getMonth(),
    datejour.getDate() + 1
  );

  dateExpire = dateExpire.toISOString();
  document.cookie =
    nomCookie +
    "=" +
    valeurCookie +
    ";expires=" +
    dateExpire +
    ";SameSite = Strict";
}

const btnC = document.querySelector("#btnCookie");
btnC.addEventListener("click", function () {
  let user = document.querySelector("#username").value;
  CrerCookie("Nom", user);
  window.location.assign("destination.html");
});