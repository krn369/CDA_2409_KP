USE employe;

/* -------------------------------------------------- Première partie -------------------------------------------------------- */

-- 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10 --
SELECT ename, job, empno, sal FROM emp;
SELECT ename, job, empno, sal FROM emp WHERE deptno = 10 ;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800 --
SELECT ename, job, sal FROM emp WHERE job = 'MANAGER' AND sal > 2800;

-- 3. Donner la liste des MANAGER n'appartenant pas au département 30 --
 SELECT * FROM emp WHERE job = 'MANAGER' AND deptno !=  30;

-- 4. Liste des employés de salaire compris entre 1200 et 1400 --
SELECT * FROM emp WHERE sal BETWEEN 1200 AND 1400;

-- 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique --
SELECT * FROM emp WHERE deptno IN (10,30)
ORDER BY ename ASC;

--  6. Liste des employés du département 30 classés dans l'ordre des salaires croissants --
SELECT * FROM emp WHERE deptno = 30
ORDER BY sal ASC;

-- 7. Liste de tous les employés classés par emploi et salaires décroissants --
SELECT ename, job, sal FROM emp
ORDER BY sal DESC;

-- 8. Liste des différents emplois --
-- 9. Donner le nom du département où travaille ALLEN --
-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants. --
 
-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions --


















