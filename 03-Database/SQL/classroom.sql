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


SELECT AVG(marks) 
FROM student;

SELECT name
FROM student
WHERE  marks > 82;


SELECT city, avg(marks)
FROM student
GROUP BY city
ORDER BY avg(marks);

SELECT city, count(rollno)
FROM student
GROUP BY city
HAVING max(marks) > 90;

SET SQL_SAFE_UPDATES = 0;

UPDATE student
SET grade = "A"
WHERE marks BETWEEN 80 AND 95;

UPDATE student
SET grade = "C"
WHERE marks BETWEEN 40 AND 60;

UPDATE student
SET grade = "B"
WHERE marks BETWEEN 60 AND 80;

UPDATE student
SET grade = "O"
WHERE marks > 95;

SELECT * FROM student;

CREATE TABLE dept (
id INT PRIMARY KEY,
name VARCHAR(50)
);

INSERT INTO dept
VALUES
(101, "english"),
(102, "IT");

UPDATE dept
SET id = 103
WHERE id = 102;

CREATE TABLE teacher (
id INT PRIMARY KEY,
name VARCHAR(50),
dept_id INT,
FOREIGN KEY (dept_id)  REFERENCES dept(id)
ON UPDATE CASCADE
ON DELETE CASCADE
);



INSERT INTO teacher
VALUES
(101,"Adam", 101),
(102, "Eve", 102);

SELECT * FROM teacher;
SELECT * FROM dept;


ALTER TABLE student
ADD COLUMN age INT; 

ALTER TABLE student
DROP COLUMN age;



ALTER TABLE student
ADD COLUMN age INT NOT NULL DEFAULT 19;

ALTER TABLE student
MODIFY COLUMN age VARCHAR(2);

ALTER TABLE student
CHANGE age stu_age INT;


INSERT INTO student
(rollno, name, marks, stu_age)
VALUES
(107,"BOB",68,100);



ALTER TABLE student
RENAME TO students;

SELECT * FROM student;

ALTER TABLE students
RENAME TO student;

CREATE TABLE stu (
id INT PRIMARY KEY,
name VARCHAR (50)
);



INSERT INTO stu (id,name)
VALUES
(101, "karan"),
(102, "bob"),
(103, "casey");


CREATE TABLE course (
id INT PRIMARY KEY,
course VARCHAR(50)
);

INSERT INTO course (id, course)
VALUES
(102,"english"),
(105,"math"),
(103,"science"),
(107,"computer science");


SELECT * FROM course;

SELECT *
FROM stu 
INNER JOIN course 
ON stu.id = course.id;

SELECT *
FROM stu as s
RIGHT JOIN course as c
ON s.id = c.id;

SELECT * FROM stu as a
LEFT JOIN course as b
ON a.id = b.id
UNION 
SELECT * FROM stu as a
RIGHT JOIN course as b
ON a.id = b.id;



SELECT * FROM stu as a
LEFT JOIN course as b
ON a.id = b.id
WHERE b.id IS NULL; 

SELECT * FROM stu as a
RIGHT JOIN course as b
ON a.id = b.id
WHERE a.id IS NULL; 


CREATE TABLE employee (
id INT PRIMARY KEY,
name VARCHAR (50),
manager_id INT
);

INSERT INTO employee (id, name, manager_id)
VALUES
(101,"karan",103),
(102,"rojita",104),
(103,"khusi",NULL),
(104,"ramesita",103);

SELECT * FROM employee;

SELECT a.name as manager_name, b.name 
FROM employee as a
JOIN employee as b
ON a.id = b.manager_id;

SELECT name FROM employee
UNION ALL
SELECT name FROM stu;

SELECT name FROM employee
UNION 
SELECT name FROM stu;




