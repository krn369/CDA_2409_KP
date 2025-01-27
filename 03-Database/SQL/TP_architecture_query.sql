/*
	Pour commencer l'entrainement  à l'ECF BDD MERISE  voici un TP à faire. (pour les CDA et les DWWM )
	Avec les 2 scripts suivant vous installerez une base de données : "db_architecte"  avec un certain nombre de tables en relation.
	Et vous y ajouterez un jeu de données à l'aide du 2ème fichiers SQL ( 02_TP_architecture_DML). 
	Ensuite vous réaliserez les requêtes suivantes : 
*/

USE db_architecte;


/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' 
	 Filter the customers based on their phone numbers starting with ‘04’ and then select their IDs and names.
*/

SELECT client_ref, client_nom FROM clients WHERE client_telephone LIKE '04%';


/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers
	 Return the ID, name, and type of all customers who are classified as individuals
 */

SELECT c.client_ref, c.client_nom, t.type_client_libelle
FROM clients AS c
JOIN type_clients AS t  ON c.type_client_id = t.type_client_id
WHERE t.type_client_libelle = "Particulier";


/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers 
	Return the ID, name, and type of all customers who are not classified as individuals
*/

SELECT c.client_ref, c.client_nom, t.type_client_libelle
FROM clients AS c
JOIN type_clients AS t  ON c.type_client_id = t.type_client_id
WHERE t.type_client_libelle != "Particulier";


/* 4. Sélectionner les projets qui ont été livrés en retard 
	Select projects that were delivered late.
*/

SELECT projet_ref, projet_date_depot,  projet_date_fin_prevue, projet_date_fin_effective as projet_date_fin_effective_en_RETARD
FROM  projets
WHERE projet_date_fin_prevue < projet_date_fin_effective;


/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets  avec le nom du client et le nom de l'architecte associés au projet
	Retrieve information about projects, including submission dates, expected completion dates, areas, prices, client names, and architect names.
 */




SELECT p.projet_date_depot, p.projet_date_fin_prevue, p.projet_superficie_totale, p.projet_superficie_batie, p.projet_prix, c.client_nom, e.emp_nom AS Architecte_nom, e.emp_prenom AS Architecte_prenom
FROM projets AS p
JOIN clients AS c ON p.client_ref = c.client_ref
JOIN employes AS e ON p.emp_matricule = e.emp_matricule
JOIN fonctions  f ON e.fonction_id = f.fonction_id
WHERE f.fonction_nom = "Architecte";
  
    
/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte
	Select all projects (dates, areas, prices) with the number of participants other than the client and the architect
 */
    
    SELECT 
    p.projet_ref,
    p.projet_date_depot,
    p.projet_superficie_totale,
    p.projet_prix,
    COUNT(pa.emp_matricule) AS "Nombre de participants (hors client et architecte)"
FROM 
    projets p
JOIN 
    participer pa ON pa.projet_ref = p.projet_ref
JOIN 
    employes e ON pa.emp_matricule = e.emp_matricule
JOIN 
    fonctions f ON e.fonction_id = f.fonction_id
WHERE 
    f.fonction_nom != 'Architecte'
GROUP BY 
    p.projet_ref,
    p.projet_date_depot,
    p.projet_superficie_totale,
    p.projet_prix
ORDER BY 
    p.projet_ref DESC;
   

/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué
Select the types of projects with, for each of them, the number of associated projects and the average price charged.
 */
 
SELECT 
    tp.type_projet_libelle AS "Type of Project",
    COUNT(p.projet_ref) AS "Number of Projects",
    ROUND(AVG(p.projet_prix) , 2) AS "Average Price Charged" 
FROM 
    projets p
INNER JOIN
    type_projets tp ON p.type_projet_id = tp.type_projet_id
GROUP BY 
    tp.type_projet_libelle;

/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande 
		Select the types of works with, for each of them, the largest project area
*/
 SELECT * FROM participer;
  SELECT * FROM type_projets;
  SELECT * FROM projets;
  SELECT * FROM employes;
  SELECT * FROM fonctions;
  SELECT * FROM adresses;
  
  SELECT 
    tt.type_travaux_libelle AS "Type of Work",
    MAX(p.projet_superficie_totale) AS "Largest Project Area"
FROM 
    projets p
INNER JOIN 
    type_travaux tt ON p.type_travaux_id = tt.type_travaux_id
GROUP BY 
    tt.type_travaux_libelle;



  


/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. 
	Select all projects (dates, prices) with the client’s information (name, phone number, address), the type of works, and the type of project
*/
	SELECT 
    p.projet_date_depot AS "Submission Date",
    p.projet_prix AS "Price",
    c.client_nom AS "Client Name",
     a.adresse_code_postal AS "Postal Code",
    CONCAT(a.adresse_code_postal, ' ', a.adresse_ville, ' ', a.adresse_num_voie, ' ', a.adresse_voie) AS "Address",
    tt.type_travaux_libelle AS "Type of Work",
    tp.type_projet_libelle AS "Type of Project"
FROM 
    clients c
INNER JOIN 
    projets p ON p.client_ref = c.client_ref
INNER JOIN 
    adresses a ON c.adresse_id = a.adresse_id
INNER JOIN 
    type_travaux tt ON p.type_travaux_id = tt.type_travaux_id
INNER JOIN 
    type_projets tp ON p.type_projet_id = tp.type_projet_id;


/* 10. Sélectionner les projets dont l'adresse est identique au client associé
	Select the projects whose address is identical to the associated client’s address
 */
	SELECT 
    p.projet_ref, 
    c.client_nom
FROM 
    projets p
INNER JOIN 
    clients c ON p.client_ref = c.client_ref
INNER JOIN 
    adresses a_proj ON p.adresse_id = a_proj.adresse_id
INNER JOIN 
    adresses a_client ON c.adresse_id = a_client.adresse_id
WHERE 
    p.adresse_id = c.adresse_id;


-- afficher les projets d'un architecte --- Pour un nom d'architecte en variable, donner la reference des projects sont il est responsable (verifier sa fonction )

delimiter |
CREATE PROCEDURE RechercheProjetsparArchitecte (IN nom_emp VARCHAR(50))
BEGIN
SELECT projet_ref
FROM projets
INNER JOIN employes ON projects.emp_matricule=employes.emp_matricule
WHERE employes.emp_nom = nom_emp;
END |

DELIMITER;

SET @nom_employes:="roussotte";

CALL RechercheProjetsparArchitecte(@nom_employes);
CALL RechercheProjetsparArchitecte("Golay");
CALL RechercheProjets("Roussotte")


DELIMITER |
CREATE PROCEDURE budgetTotal (IN nom_emp VARCHAR(50), OUT totalBudget DECIMAL(10,2), OUT nbProjets INT)
BEGIN
SELECT fonctions.fonction_nom
FROM fonctions
NATURAL JOIN employes
WHERE employes.emp_nom=  nom_emp;

SELECT IFNULL (SUM (projet_prix),0) INTO totalBudget
FROM projets
INNER JOIN employes ON employes.emp_matricule = projets.emp.emp_matricule
WHERE employes.emp_nom = nom_emp;

SELECT IFNULL (count(projet_ref),0) INTO nbProjets
FROM projets
INNER JOIN employes ON employes.emp_matricule = projets.emp_matricule
WHERE employes.emp_nom = nom_emp;

END|
DELIMITER;

SET @ nom := "Golay";

CALL budgetTotal(@nom, @montant, @nb);

SELECT @montant  AS "Somme des projets";
SELECT @nb AS "Nombre de projets";

