/*
	Pour commencer l'entrainement  à l'ECF BDD MERISE  voici un TP à faire. (pour les CDA et les DWWM )
	Avec les 2 scripts suivant vous installerez une base de données : "db_architecte"  avec un certain nombre de tables en relation.
	Et vous y ajouterez un jeu de données à l'aide du 2ème fichiers SQL ( 02_TP_architecture_DML). 
	Ensuite vous réaliserez les requêtes suivantes : 
*/

USE db_architecte;

SELECT * FROM clients;


/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' */

SELECT client_nom FROM clients WHERE client_telephone


/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers */


/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers */


/* 4. Sélectionner les projets qui ont été livrés en retard */


/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets 


    avec le nom du client et le nom de l'architecte associés au projet */
    
    
/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte */


/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué */


/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande */


/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. */


/* 10. Sélectionner les projets dont l'adresse est identique au client associé */