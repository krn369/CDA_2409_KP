/*
	CREATE TABLE student (
rollno INT PRIMARY KEY, 
name VARCHAR(50)
);

INSERT INTO student
(rollno, name)
VALUES
(101, "Karan"),
(102, "Rojita"),
(103, "Khusi");

SELECT * FROM student;

 	INSERT INTO student 
	(rollno, name)
	VALUES
	(104, "shyam");


	INSERT INTO student VALUES (104, "shyam");

	CREATE TABLE emp 
	(id INT,
	salary INT DEFAULT 25000);

	INSERT INTO emp (id)  VALUES (101);

	SELECT * FROM emp;

	CREATE TABLE city
	(id INT PRIMARY KEY,
	city VARCHAR(50),
	age INT,
	CONSTRAINT age_check CHECK (age >= 18 AND city="Delhi")
	);


	CREATE TABLE newTAB (
	age INT CHECK (age >= 18)
	);

	SHOW TABLES;

	DROP TABLE emp;
	DROP TABLE student;
    
*/


DROP DATABASE IF EXISTS college;
CREATE DATABASE IF NOT EXISTS college;


USE college;

CREATE TABLE student (
rollno INT PRIMARY KEY,
name VARCHAR(50),
marks INT NOT NULL,
grade VARCHAR(1),
city VARCHAR(20)
);

INSERT INTO student
(rollno, name, marks, grade, city)
VALUES
(101,"KARAN",99,"A","PARIS"),
(102,"ROJITA",89,"B","KATHMANDU"),
(103,"KHUSI",95,"A","DALLAS"),
(104,"RAMESH",98,"A","LONDON"),
(105,"SITA","78","B","BHAKTAPUR"),
(106,"NANICHORI",51,"C","BHAKTAPUR");


SELECT * FROM student WHERE marks > 80;
SELECT * FROM student WHERE city = "BHAKTAPUR" AND marks > 75;
SELECT * FROM student WHERE marks > 90 OR city = "BHAKTAPUR";
SELECT * FROM student WHERE city IN ("PARIS","KATHMANDU");
SELECT * FROM student WHERE city NOT IN ("PARIS","KATHMANDU");

SELECT * FROM student WHERE marks > 75 LIMIT 4;

SELECT * FROM student ORDER BY name ASC;
SELECT * FROM student ORDER BY city DESC;
SELECT * FROM student ORDER BY marks DESC LIMIT 3;

SELECT max(marks) FROM student;
SELECT min(marks) FROM student;
SELECT avg(marks) FROM student;
SELECT count(rollno) FROM student;

SELECT city,name, count(rollno)
FROM student
GROUP BY city,name;


SELECT city, avg(marks)
FROM student
GROUP BY city;

SELECT grade, count(rollno)
FROM student
GROUP  BY grade
ORDER BY grade;

SELECT city, count(name)
FROM student
GROUP BY city
HAVING max(marks) > 90;


SELECT city
FROM student
WHERE grade =  "A"
GROUP BY CITY
HAVING max(marks) >= 90
ORDER BY city DESC;

SET SQL_SAFE_UPDATES = 0;

 UPDATE student
 SET grade = "B"
 WHERE marks BETWEEN 75 AND 85;
 
 SELECT * FROM student;
