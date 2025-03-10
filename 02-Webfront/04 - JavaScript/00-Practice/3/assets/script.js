fetch("./assets/alldata.json")
.then(response => {return response.json()})
.then( (data) => {console.log(data)})