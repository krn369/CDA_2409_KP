# Créer mon 1er projet .NET Console
A la racine du dépôt :

Créer un répertoire “01 - Algorithmes”

Dans ce répertoire, créer un sous-dossier “TriDeNombre”

Ouvrir le terminal dans ce dossier

Créer un projet console en tapant la commande :

dotnet new console

Effectuer un COMMIT avec le message “creation projet TriDeNombe”

Implémenter le code correspondant à la demande suivante :

Lire 3 nombres entier A, B et C (fournis par l'utilisateur) puis les afficher dans l’ordre croissant.

Pour tester votre programme, tapez la commande dotnet run dans votre terminal.

Lorsque vous avez terminé, effectuer un COMMIT vec le message “Fin TriDeNombre” puis pousser votre travail sur GitHub.

Rendez-vous ensuite sur GitHub puis créer un nouveau PULL REQUEST et fusionnez votre travail effectué sur la branche develop vers la branche main. (Ne supprimez pas la branche develop).

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
