using System;

class RechercherUnNombre {

    static void Main(string[] args)
    {

        int[] nombres = { 8, 16, 32, 64, 128, 256, 512 };

       Console.WriteLine("Entrez un nombre à rechercher :");
       int nombre = int.Parse(Console.ReadLine());

        int index = Array.IndexOf(nombres, nombre);

        if (index != -1)
        {
            Console.WriteLine("Nombre trouvé à l'indice : " + index);
        }
        else
        {
            Console.WriteLine("Nombre non trouvé");
        }

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write(nombres[i] + " ");
            

           
        }
    }
}


