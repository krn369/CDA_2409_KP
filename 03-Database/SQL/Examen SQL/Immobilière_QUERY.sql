USE agence_kiloutout;

/* 1. Sélectionner l'adresse, le montant du loyer, le pourcentage aloué à l'agence des logements sous gestion. Les logements sont triés par loyes du plus cher au moins cher */

	SELECT l.logement_adresse AS "Adresse du logement", 
    l.logement_loyer_mensuel AS "Montant du loyer", 
    c.contrat_pourcentage AS "Pourcentage alloué à l'agence"
	FROM logement l
	INNER JOIN contrat c 
			ON l.logement_id = c.logement_id
	ORDER BY l.logement_loyer_mensuel DESC;
    
    --  2. Sélectionner les logements qui sont loués avec pour chaque logement loué --
    -- -------------------------------------------------------------------------------------- --
		-- a. L'adresse du logement et le montant du loyer  --
    
			SELECT 
				l.logement_adresse AS "Adresse du logement", 
				l.logement_loyer_mensuel AS "Montant du loyer"
            FROM 
				logement l
			INNER JOIN 
				locataire lc 
                ON l.locataire_id = lc.locataire_id                    
            ORDER BY lc.location_date ASC; 		

	 -- -------------------------------------------------------------------------------------- --			
                
		-- b. le nom et prénom du propriétaire   --
			
            -- SELECT concat(proprietaire_prenom, ' ', proprietaire_nom) AS "Prenom et Nom des Proprietaires ou les logements sont loués" --
			SELECT 
				p.proprietaire_prenom  AS "Prénom du propriétaire",
				p.proprietaire_nom AS "Nom du propriétaire"
            FROM logement l
            INNER JOIN proprietaire p ON l.proprietaire_id = p.proprietaire_id
            INNER JOIN locataire lc ON l.locataire_id = lc.locataire_id
            ORDER BY lc.location_Date ASC;
	-- -------------------------------------------------------------------------------------- --
    
	   -- c. le nom, prénom et numéro de téléphone du locataire  --
		
			SELECT
				lc.locataire_nom AS "Nom du locataire",
                lc.locataire_prenom AS "Prénom du locataire", 
                lc.locataire_telephone AS "Téléphone du locataire"
            FROM 
				locataire lc
            INNER JOIN 
				logement l 
                ON lc.locataire_id = l.locataire_id
            ORDER BY lc.location_Date ASC;  
   -- -------------------------------------------------------------------------------------- --         
			
    
	-- d. La période de location  --
			
		SELECT lc.location_period AS "La période de location"
        FROM locataire lc
		INNER JOIN logement l ON lc.locataire_id = l.locataire_id
		ORDER BY lc.location_Date ASC;          
        
   -- -------------------------------------------------------------------------------------- --   
   
 -- 3. Sélectionner toutes les information des propiétaires avec, pour chaque propriétaire: 
 
	-- a. Le nombre de logements qui lui appartiennent --
		
        SELECT 
			p.proprietaire_id, 
			CONCAT(p.proprietaire_prenom, ' ', p.proprietaire_nom) AS "Proprietaire_Info", 
            p.proprietaire_adresse, 
            p.proprietaire_telephone, 
            count(l.proprietaire_id ) AS "Nombre de logements"
        FROM proprietaire p
        JOIN logement l ON p.proprietaire_id = l.proprietaire_id
        GROUP BY p.proprietaire_id, p.proprietaire_prenom, p.proprietaire_nom, p.proprietaire_adresse, p.proprietaire_telephone ;
   -- -------------------------------------------------------------------------------------- --   
    
    -- b. Le montant total des loyers de ces logements(loués ou non) --
		
			SELECT 
				p.proprietaire_id,
                p.proprietaire_nom,
                p.proprietaire_prenom,
                p.proprietaire_adresse,
                p.proprietaire_telephone,
                
			SUM(l.logement_loyer_mensuel) AS "Total Loyer"
            FROM proprietaire p
            JOIN logement l ON l.proprietaire_id = p.proprietaire_id
            GROUP BY 
				p.proprietaire_id,
                p.proprietaire_nom,
                p.proprietaire_prenom,
                p.proprietaire_adresse,
                p.proprietaire_telephone;
    -- -------------------------------------------------------------------------------------- --    
    

	
        
		
