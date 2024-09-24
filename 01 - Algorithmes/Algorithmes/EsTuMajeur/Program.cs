using System;

class Program
{
    static void Main()
    {
        Console.Write("Entrez votre âge: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Vous n’êtes pas encore né");
        }
        else if (age < 18)
        {
            Console.WriteLine("Vous êtes mineur");
        }
        else
        {
            Console.WriteLine("Vous êtes majeur");
        }
    }
}

