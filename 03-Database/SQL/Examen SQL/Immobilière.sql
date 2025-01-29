DROP DATABASE IF EXISTS agence_KILOUTOUT;
CREATE DATABASE IF NOT EXISTS agence_KILOUTOUT;
USE agence_KILOUTOUT;

CREATE TABLE proprietaire(
   proprietaire_id INT,
   proprietaire_nom VARCHAR(100) NOT NULL,
   proprietaire_prenom VARCHAR(100) NOT NULL,
   proprietaire_adresse VARCHAR(255) NOT NULL,
   proprietaire_telephone VARCHAR(14) NOT NULL,
   PRIMARY KEY(proprietaire_id)
);

INSERT INTO proprietaire
(proprietaire_id, proprietaire_nom, proprietaire_prenom, proprietaire_adresse, proprietaire_telephone)
VALUES
(1,"Durant","Mr Pascal", "10 rue de la marine, 68000 Colmar", "03.89.89.87.87"),
(2,"Martinez","Mme Joëlle","18 avenue des peupliers, 68100 Mulhouse","03.89.12.13.14"),
(3,"Bowé","Mme Samira","21 rue du musée, 67000 Strasbourg","07.32.21.16.65");

CREATE TABLE locataire(
   locataire_id INT,
   location_period VARCHAR(20) NOT NULL,
   location_Date DATE NOT NULL,
   locataire_nom VARCHAR(100) NOT NULL,
   locataire_prenom VARCHAR(100) NOT NULL,
   locataire_telephone VARCHAR(14) NOT NULL,
   PRIMARY KEY(locataire_id)
);


INSERT INTO locataire 
(locataire_id, location_period, location_Date, locataire_nom, locataire_prenom, locataire_telephone)
VALUES
(101,"6 ans", "2025-02-01", "Dubosc", "Mme Jacqueline", "06.99.99.88.77"),
(102, "3 ans", "2024-11-01", "Di Marco", "Mr Philippe", "09.72.73.74.75");


CREATE TABLE logement(
   logement_id INT,
   logement_type VARCHAR(100) NOT NULL,
   logement_surface INT NOT NULL,
   logement_adresse VARCHAR(255) NOT NULL,
   logement_loyer_mensuel INT NOT NULL,
   locataire_id INT,
   proprietaire_id INT NOT NULL,
   PRIMARY KEY(logement_id),
   FOREIGN KEY(locataire_id) REFERENCES locataire(locataire_id),
   FOREIGN KEY(proprietaire_id) REFERENCES proprietaire(proprietaire_id)
);

INSERT INTO logement
(logement_id, logement_type, logement_surface, logement_adresse, logement_loyer_mensuel, locataire_id, proprietaire_id)
VALUES
(1001, "Appartement",100,"32 rue de Cherbourg, 68100 Mulhouse", 800, NULL, 1),
(1002, "Appartement", 65, "325 boulevard des majorettes, 68000 Colmar", 490, 101, 1),
(1003, "Maison", 160, "11 rue de Mulhouse, 68400 Riedisheim", 1450, NULL, 2),
(1004, "Appartement", 85, "17A avenue des peupliers, 68100 Mulhouse", 750, NULL, 2),
(1005, "Appartement", 70, "17B avenue des peupliers, 68100 Mulhouse", 625, 102, 3);

CREATE TABLE contrat(
   contrat_id INT,
   contrat_duree VARCHAR(20) NOT NULL,
   contrat_pourcentage INT NOT NULL,
   proprietaire_id INT NOT NULL,
   logement_id INT NOT NULL,
   PRIMARY KEY(contrat_id),
   UNIQUE(logement_id),
   FOREIGN KEY(proprietaire_id) REFERENCES proprietaire(proprietaire_id),
   FOREIGN KEY(logement_id) REFERENCES logement(logement_id)
);

INSERT INTO contrat
(contrat_id, contrat_duree, contrat_pourcentage, proprietaire_id, logement_id)
VALUES
(11, "10 ans", 5, 1, 1001),
(12, "10 ans", 8, 1, 1002),
(13, "10 ans", 5, 2, 1003),
(14, "10 ans", 10, 2, 1004),
(15, "8 ans", 10, 3, 1005);


SELECT * FROM contrat;
SELECT * FROM locataire;
SELECT * FROM proprietaire;
SELECT * FROM logement; 

