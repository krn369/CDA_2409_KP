<?php
/*
Affiche "Hello World !"
*/

function helloWorld(): void
{
    echo"Hello World !  <br>";
    
}

// test de la fonction (la fonction affiche directement le résultat)
helloWorld();

#------------------------------------------------------------------------------------#

/*
    Retourne "Hello $name !" ou "Hello Nobody !" si $name est vide
    @param string $name le nom à afficher
*/

function hello(string $name):string
{
    if(empty($name)){
        return "Hello Nobody! <br>";
    }
    return "Hello $name! <br>";
}

// test de la fonction (la fonction n'affiche rien. "echo" affichera la valeur retournée par la fonction)

echo hello("Karan"); // Affiche : Hello Karan!

echo hello(""); // Affiche : Hello Nobody!

echo phpversion();

?>

