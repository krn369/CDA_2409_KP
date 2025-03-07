const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];
people.push("Ariana Grande");
document.body.style.backgroundColor = "#536B78";
document.body.style.color = "#ACCBE1";
document.querySelector("h1").setAttribute("style", "margin-left:50px; font-family:tahoma");

for (let i = 0; i < people.length; i++) {
    let monItem = document.createElement("li");
    monItem.setAttribute("style", "font-family:tahoma; font-size:1.6rem");
    monItem.textContent = people[i];
    document.querySelector("#list").appendChild(monItem);
}

document.querySelector("main").setAttribute("style", "border: 1px solid #ACCBE1; border-radius: 10px; width: 80%; margin-top:50px; margin-left: auto; margin-right:auto;); ");

const wrapper = document.querySelector("main");



function createTable() {
    const myTable = document.createElement("table");
    wrapper.appendChild(myTable);

    const myTableHead = myTable.createTHead();  
    const myTableBody = myTable.createTBody();

    const myRow = myTableHead.insertRow();
    addCellTitle(myRow, "Nom");
    addCellTitle(myRow, "Prénom");
    addCellTitle(myRow, "Email");
    addCellTitle(myRow, "Supprimer");

}


createTable();


function addCellTitle(row, cellContent) {
    const cell = document.createElement("th");
    cell.textContent = cellContent;
    row.appendChild(cell);
}