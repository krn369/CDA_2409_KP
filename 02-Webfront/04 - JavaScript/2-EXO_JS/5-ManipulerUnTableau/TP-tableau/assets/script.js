// Initial list of people
const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];
people.push("Ariana Grande");

// Apply styles to the body
document.body.style.backgroundColor = "#536B78";
document.body.style.color = "#ACCBE1";
document.body.style.fontFamily = "Verdana, sans-serif";

// Style the h1 element
document.querySelector("h1").setAttribute("style", "margin-left: 50px; font-family: Tahoma;");

// Display the list of people
for (let i = 0; i < people.length; i++) {
    let monItem = document.createElement("li");
    monItem.setAttribute("style", "font-family: Tahoma; font-size: 1.6rem; margin-bottom: 10px;");
    monItem.textContent = people[i];
    document.querySelector("#list").appendChild(monItem);
}

// Style the main container
const wrapper = document.querySelector("main");
wrapper.setAttribute("style", "border: 1px solid #ACCBE1; border-radius: 10px; width: 80%; margin: 50px auto; padding: 20px;");

// Create the table
function createTable() {
    const myTable = document.createElement("table");
    myTable.setAttribute("style", "width: 100%; border-collapse: collapse; margin-top: 20px;");
    wrapper.appendChild(myTable);

    const myTableHead = myTable.createTHead();  
    const myTableBody = myTable.createTBody();

    // Create the header row
    const myRow = myTableHead.insertRow();
    addCellTitle(myRow, "Nom");
    addCellTitle(myRow, "Prénom");
    addCellTitle(myRow, "Email");
    addCellTitle(myRow, "Supprimer");

    // Populate the table with data
    for (let i = 0; i < people.length; i++) {
        const personSplit = people[i].split(" ");
        const row = myTableBody.insertRow();
        row.setAttribute("style", "border: 2px solid #7B9CB4;");

        // Add cells for Nom, Prénom, and Email
        addCell(row, personSplit[1]); // Nom
        addCell(row, personSplit[0]); // Prénom
        addCell(row, `${personSplit[1].toLowerCase()}.${personSplit[0].toLowerCase()}@example.com`); // Email

        // Add the "Supprimer" button
        const btnSuppr = document.createElement("button");
        btnSuppr.textContent = "X";
        btnSuppr.setAttribute("style", "border: 2px solid #7B9CB4; background-color: #637081; color: #ACCBE1; font-weight: bold; padding: 5px 10px; cursor: pointer;");
        btnSuppr.addEventListener("click", () => {
            people.splice(i, 1); // Remove the person from the array
            myTableBody.removeChild(row); // Remove the row from the table
        });

        const cellSuppr = row.insertCell();
        cellSuppr.setAttribute("style", "text-align: center; border: 2px solid #7B9CB4;");
        cellSuppr.appendChild(btnSuppr);
    }
}

// Function to add a header cell
function addCellTitle(row, cellContent) {
    const cell = document.createElement("th");
    cell.textContent = cellContent;
    cell.setAttribute("style", "border: 2px solid #7B9CB4; padding: 10px; background-color: #637081;");
    row.appendChild(cell);
}

// Function to add a regular cell
function addCell(row, cellContent) {
    const cell = row.insertCell();
    cell.textContent = cellContent;
    cell.setAttribute("style", "border: 2px solid #7B9CB4; padding: 10px;");
}

// Call the function to create the table
createTable();