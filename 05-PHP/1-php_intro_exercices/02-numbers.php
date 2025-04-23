
<?php

//  Retourne la somme de deux entiers

function getSum(int $a, int $b) : string
{
    $sum = $a + $b;
    return "The sum of given 2 numbers is : $sum <br>";
}

// test de la fonction
echo getSum(54545645, 345654); 

#------------------------------------------------------------------------------------#

//  Retourne la soustraction de deux entiers
function getSub(int $a, int $b) : int
{
    return $a - $b;
}

// test de la fonction
$sub = getSub(215648, 54612); 
echo "The substraction of given 2 numbers is : $sub. <br>";


#------------------------------------------------------------------------------------#

// Retourner la multiplication des deux valeurs
function getMulti(float $a, float $b) : string
{
    $mul = $a * $b;
    return "The multiplication of given 2 numbers is : $mul <br>";
}

// test de la fonction
echo getMulti(2314.645, 465.987); 

#------------------------------------------------------------------------------------#

//  retourner la division des deux valeurs
function getDiv(int $x, int $y) : float
{
    if( $y == 0){
        return 0.0;
    }
    $result =  $x / $y;
    return round($result, 2);  // Limitez le résultat à 2 décimales (arrondi)
}

// test de la fonction
$div = getDiv(23154, 333 );
echo "The divison of given 2 numbers is : $div";


?>
