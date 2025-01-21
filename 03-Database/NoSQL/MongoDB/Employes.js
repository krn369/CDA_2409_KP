// CREATION DE BASE ET COLLECTIONS EN BD MONGODB ET MANIPULATIONS DE BASE CRUD

// use employes

db.createCollection("emp")
db.createCollection("dept")

/* db.posts.insertOne({
        title: "Introduction to MongoDB",
        content: "MongoDB is a NoSQL database.",
        author: "John Doe",
        tags: ["mongodb", "nosql", "database"]
        }) 
*/

db.emp.insertMany(
        [
                {
                  "_id": 7369,
                  "ename": "SMITH",
                  "job": "CLERK",
                  "mgr": 7902,
                  "hiredate": "1980-17-12",
                  "sal": 800,
                  "comm": 0,
                  "deptno": 20,
                  "dname": "RESEARCH",
                  "city": "DALLAS"
                },
                {
                  "_id": 7499,
                  "ename": "ALLEN",
                  "job": "SALESMAN",
                  "mgr": 7698,
                  "hiredate": "1981-02-20",
                  "sal": 1600,
                  "comm": 0,
                  "deptno": 30,
                  "dname": "SALES",
                  "city": "CHICAGO"
                },
                {
                  "_id": 7521,
                  "ename": "WARD",
                  "job": "SALESMAN",
                  "mgr": 7698,
                  "hiredate": "1981-02-22",
                  "sal": 1250,
                  "comm": 500,
                  "deptno": 30,
                  "dname": "SALES",
                  "city": "CHICAGO"
                },
                {
                  "_id": 7566,
                  "ename": "JONES",
                  "job": "MANAGER",
                  "mgr": 7839,
                  "hiredate": "1981-04-02",
                  "sal": 2975,
                  "comm": 0,
                  "deptno": 20,
                  "dname": "RESEARCH",
                  "city": "DALLAS"
                },
                {
                  "_id": 7654,
                  "ename": "MARTIN",
                  "job": "SALESMAN",
                  "mgr": 7698,
                  "hiredate": "1981-09-28",
                  "sal": 1250,
                  "comm": 1400,
                  "deptno": 30,
                  "dname": "SALES",
                  "city": "CHICAGO"
                },
                {
                  "_id": 7698,
                  "ename": "BLAKE",
                  "job": "MANAGER",
                  "mgr": 7839,
                  "hiredate": "1981-05-01",
                  "sal": 2850,
                  "comm": 0,
                  "deptno": 30,
                  "dname": "SALES",
                  "city": "CHICAGO"
                },
                {
                  "_id": 7782,
                  "ename": "CLARK",
                  "job": "MANAGER",
                  "mgr": 7839,
                  "hiredate": "1981-05-09",
                  "sal": 2450,
                  "comm": 0,
                  "deptno": 10,
                  "dname": "ACCOUNTING",
                  "city": "NEW YORK"
                },
                {
                  "_id": 7788,
                  "ename": "SCOTT",
                  "job": "ANALYST",
                  "mgr": 7566,
                  "hiredate": "1982-12-09",
                  "sal": 3000,
                  "comm": 0,
                  "deptno": 20,
                  "dname": "RESEARCH",
                  "city": "DALLAS"
                },
                {
                  "_id": 7839,
                  "ename": "KING",
                  "job": "PRESIDENT",
                  "mgr": null,
                  "hiredate": "1981-09-17",
                  "sal": 5000,
                  "comm": 0,
                  "deptno": 10,
                  "dname": "ACCOUNTING",
                  "city": "NEW YORK"
                },
                {
                  "_id": 7876,
                  "ename": "ADAMS",
                  "job": "CLERK",
                  "mgr": 7788,
                  "hiredate": "1983-01-12",
                  "sal": 1100,
                  "comm": 0,
                  "deptno": 20,
                  "dname": "RESEARCH",
                  "city": "DALLAS"
                },
                {
                  "_id": 7900,
                  "ename": "JAMES",
                  "job": "CLERK",
                  "mgr": 7698,
                  "hiredate": "1981-03-12",
                  "sal": 950,
                  "comm": 0,
                  "deptno": 30,
                  "dname": "SALES",
                  "city": "CHICAGO"
                },
                {
                  "_id": 7902,
                  "ename": "FORD",
                  "job": "ANALYST",
                  "mgr": 7566,
                  "hiredate": "1981-12-03",
                  "sal": 3000,
                  "comm": 0,
                  "deptno": 10,
                  "dname": "ACCOUNTING",
                  "city": "DALLAS"
                },
                {
                  "_id": 7934,
                  "ename": "MILLER",
                  "job": "CLERK",
                  "mgr": 7782,
                  "hiredate": "1982-01-23",
                  "sal": 1300,
                  "comm": 0,
                  "deptno": 10,
                  "dname": "ACCOUNTING",
                  "city": "NEW YORK"
                },
                {
                  "_id": 7844,
                  "ename": "TURNER",
                  "job": "SALESMAN",
                  "mgr": 7698,
                  "hiredate": "1981-09-08",
                  "sal": 1500,
                  "comm": 0,
                  "deptno": 30,
                  "dname": "SALES",
                  "city": "CHICAGO"
                }
              ]              
)



db.dept.insertMany ([
        {
                "_id": 10,
                "dname": "ACCOUNTING",
                "loc": "NEW YORK",                
        },

        {
                "_id": 20,
                "dname": "RESEARCH",
                "loc": "DALLAS",
        },

        {
                "_id": 30,
                "dname": "SALES",
                "loc": "CHICAGO",
        },

        {
                "_id": 40,
                "dname": "OPERATIONS",
                "loc": "BOSTON",
        }
])

// 1. Donner nom, job, numéro et salaire de tous les employés,puis seulement des employés du département 10
db.emp.find({},{dname:1, job:1, _id:1, sal:1,})

db.emp.find({deptno: 10},{dname:1, job:1, _id:1, sal:1,})

// 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800

db.emp.find({ $and: [{job:"MANAGER", sal:{$gt:2800}}] }, { _id:0, dname:1, job:1, sal:1})

// 3. Donner la liste des MANAGER n'appartenant pas au département 30

db.emp.find({$and: [{ job:"MANAGER", deptno:{$ne: 30}}]})

// 4. Liste des employés de salaire compris entre 1200 et 1400

db.emp.find({ $and: [{sal : {$gt:1200, $lt: 1400}}]})

// 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique

db.emp.find({ deptno: {$in: [10,30]}}).sort({ename:1})

// 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants

db.emp.find({deptno:30}, {_id: 0, ename: 1, sal: 1}).sort({sal:1})

// 7. Liste de tous les employés classés par emploi et salaires décroissants

db.emp.find().sort({job: 1,sal: -1})

// 8. Liste des différents emplois

db.emp.distinct("job")

// 9. Donner le nom du département où travaille ALLEN

db.emp.find({ename : {$eq : "ALLEN"}}, {dname : 1, _id : 0} )

// 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.

db.emp.find({},{dname:1, ename:1, job:1, sal:1 , _id:0 }).sort({dname:1, sal:-1 })

// 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions

/*
        this aggregation pipeline filters the employees to include only those with the job title "SALESMAN" and then projects a new document structure that includes the employee's name, salary, commission, and a new field totalSal which is the sum of the salary and commission.
*/

db.emp.aggregate([
        {
          $match: {job: "SALESMAN"}
        },
        {
         $project: {
                ename:1, sal:1, comm:1, _id:0,
                totalSal: {$sum: ["$sal", "$comm"]}
         }       
        }
])

// 12. Donner le salaire le plus élevé par département


/*
         this aggregation pipeline groups employees by their department name and finds the highest salary in each department. The result will be a document for each department with the department name and the highest salary in that department.
*/

db.emp.aggregate([
        {
          $group: {
            _id: "$dname",
            highestSalary: { $max: "$sal" }
          }
        }
      ])

//13. Donner département par département masse salariale, nombre d'employés, salaire moyen par typed'emploi.

/*
       this aggregation pipeline will provide the payroll, number of employees, and average salary for each department, broken down by type of employment
*/


db.emp.aggregate([
        {
            $group: {
                _id: {
                    dname: "$dname",
                    job: "$job"
                },
                totalPayroll: { $sum: "$sal" },
                numberOfEmployees: { $sum: 1 },
                averageSalary: { $avg: "$sal" }
            }
        },
        {
            $project: {
                _id: 0,
                dname: "$_id.dname",
                job: "$_id.job",
                totalPayroll: 1,
                numberOfEmployees: 1,
                averageSalary: 1
            }
        }
    ])