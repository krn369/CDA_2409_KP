# Exercice 2a.1 : Tri de nombres
Lire 2 nombres entier A et B puis les afficher dans l’ordre croissant.

VARIABLES

    A, B, C: NOMBRES ENTIERS
    nombres: TABLEAU DE NOMBRES ENTIERS

TRAITMENT

    // Demander à l'utilisateur de saisir trois nombres entiers
    
    ÉCRIRE "Entrez le premier nombre (A) :"
    LIRE A
    ÉCRIRE "Entrez le deuxième nombre (B) :"
    LIRE B
    ÉCRIRE "Entrez le troisième nombre (C) :"
    LIRE C

    // Mettre les nombres dans un tableau
    nombres <- [A, B, C]

    // Trier le tableau
    TRIER nombres

    // Afficher les nombres dans l'ordre croissant
    ÉCRIRE "Les nombres dans l'ordre croissant sont :"
    POUR CHAQUE nombre DANS nombres
        ÉCRIRE nombre
    FIN POUR
