USE agence_kiloutout;

    -- QUESTION PROCEDURE STOKEE OU DECLENCHEUR SQL A IMPLEMENTER --
    

    	DELIMITER |
      CREATE TRIGGER check_rent_limit
      BEFORE INSERT ON logement
      FOR EACH ROW
      BEGIN
 			IF NEW.logement_loyer_mensuel >= 2000 THEN
				SIGNAL SQLSTATE '45000'
                SET MESSAGE_TEXT = 'LE LOYER MENSUEL DOIT ETRE STRICTMENT INFERIEUR A 2000 €.';				
            END IF;     
      END; | 
      DELIMITER ;
      
      
DROP TRIGGER IF EXISTS check_rent_limit;


    

      
 -- -------------------------------   TESTING TRIGGER   ----------------------------------     
      
INSERT INTO proprietaire
(proprietaire_id, proprietaire_nom, proprietaire_prenom, proprietaire_adresse, proprietaire_telephone)
VALUES 
(4," DEV", "Mr Mike", "637 rue Jean Jaurès, 59690 Vieux-Condé", "06.02.03.04.05");


INSERT INTO logement
(logement_id, logement_type, logement_surface, logement_adresse, logement_loyer_mensuel, locataire_id, proprietaire_id)
VALUES
(1006, "Appartement", 30, "23 rue des Macarons, 68100 Mulhouse", 320, NULL, 4);

INSERT INTO contrat
(contrat_id, contrat_duree, contrat_pourcentage, proprietaire_id, logement_id)
VALUES
(16, "20 ans", 6, 4, 1006);

INSERT INTO logement
(logement_id, logement_type, logement_surface, logement_adresse, logement_loyer_mensuel, locataire_id, proprietaire_id)
VALUES
(1007, "Maison", 205, "97 rue de la frangipane, 68270 Wittenheim", 2050, NULL, 4);

INSERT INTO contrat
(contrat_id, contrat_duree, contrat_pourcentage, proprietaire_id, logement_id)
VALUES
(17, "20 ans", 3, 4, 1007);

			
	  