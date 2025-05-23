<?php

// Retourner le nom de l'inventeur de la formule <<E = MC²>>
function getMC2()
 {
    return "Albert Einstein";
 }

// test de la fonction
echo getMC2();

#------------------------------------------------------------------------------------#
// Retourner la concaténation des deux valeurs
function getUserName(string $fname, string $lname): string
{
  return  "<br>".$fname.$lname . "<br>";
}
// test de la fonction
echo getUserName("Karan","Pariyar");

#------------------------------------------------------------------------------------#

// Retourner la concaténation des deux valeurs avec un espace entre les 2, le prénom en minuscule et le nom en MAJUSCULE

function getFullName(string $lname, string $fname) : string
{
    return strtolower($fname) ." ". strtoupper($lname);
}

// test de la fonction
echo getFullName("pariyar", "KARAN");

#------------------------------------------------------------------------------------#

// Retourner une chaîne de caractères sous la forme : « Bonjour prénom, nom. Connaissez-vous Einstein ? » Réutiliser les fonctions : getFullName() & getMC2()


function askUser(string $lname, string $fname) : string {
    $fullName = getFullName($lname, $fname);
    $inventor = getMC2();
    return " <br> Bonjour " . $fullName.", ". " Connaissez-vous " . $inventor . " ?";
}

// test de la fonction
echo askUser("pariyar", "KARAN"); 

?>