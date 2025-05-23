<?php

// Créer une fonction « isMajor() » acceptant un argument de type int. Elle devra retourner un booléen. Si l’âge est supérieur ou égal à 18, elle doit retourner true. Sinon elle doit retourner false.

function isMajor(int $age) : bool
{
    if ($age < 18) {
        return false;
    }
    return true;
}

// Exemples d'utilisation sans ternary operator
if (isMajor(18)) {
    echo 'true'."<br>"; 
} else {
    echo 'false'."<br>";
}


// avec ternary operator
echo isMajor(12) ? 'true' : 'false'."<br>";


#------------------------------------------------------------------------------------#

// Créer une fonction <<getRetired()>> acceptant an argument de type int. Elle devra retourner un string. Cette fonction permet de calculer le nombre d'années restant aant la retraite ou le nombre d'années depuis la retraite. Pour cet exercice, l'âge de la retraite est fixé à 60 ans.

function getRetired(int $age) : string {
    $retirementAge = 60;

    if ($age < 0) {
        return "Vous n'êtes pas encore né";
    }
    elseif ($age < $retirementAge) {
        $yearsLeft = $retirementAge - $age;
        return "Il vous rest $yearsLeft ans avant la retraite";
    }
    elseif ($age == $retirementAge){
        return "Vous êtes à la retraite cette année";
    }
    else {
        $yearsRetired = $age -$retirementAge;
        return "Vous êtes à la retraite depuis $yearsRetired ans";
    }
}

// test de la fonction
echo getRetired(12)."<br>";
echo getRetired(60)."<br>";
echo getRetired(72)."<br>";
echo getRetired(-2)."<br>";

#------------------------------------------------------------------------------------#

// Créer une fonction « getMax() » acceptant 3 arguments de type float. Cette fonction doit retourner la valeur du plus grand des 3 nombres. Limitez le résultat à 3 décimales. Si au moins 2 des valeurs fournies sont égales la fonction retourne 0.

function getMax(float $a, float $b, float $c) : float {
    if ($a == $b || $a == $c || $b == $c){
        return 0;
    }

    $maxValue = max($a, $b, $c);

    return round($maxValue, 3);
}

// test de la fonction
echo getMax(123.456, 159.3265, 12)."<br>";
echo getMax(1.23456, 2.34567, 3.45678)."<br>"; 
echo getMax(1.23456, 1.23456, 3.45678)."<br>"; 

#------------------------------------------------------------------------------------#
// Cette fonction capitalCity() utilise la structure switch pour vérifier le pays fourni en argument et retourner le nom de la capitale correspondante. Si le pays ne fait pas partie de la liste, elle retourne "Capitale inconnue".

function capitalCity(string $country) : string {
    switch ($country) {
        case "France":
            return "Paris";
        case "Allemagne":
            return "Berlin";
        case "Italie":
            return "Rome";
        case "Maroc":
            return "Rabat";
        case "Espagne":
            return "Madrid";
        case "Portugal":
            return "Lisbonne";
        case "Angleterre":
            return "Londres";
        default:
            return "Capitale inconnue";
    }
}

// test de la fonction
echo capitalCity("France")."<br>"; 
echo capitalCity("Allemagne")."<br>"; 
echo capitalCity("Italie")."<br>"; 
echo capitalCity("Maroc")."<br>"; 
echo capitalCity("Espagne")."<br>"; 
echo capitalCity("Portugal")."<br>"; 
echo capitalCity("Angleterre")."<br>";
echo capitalCity("Belgique")."<br>";


?>