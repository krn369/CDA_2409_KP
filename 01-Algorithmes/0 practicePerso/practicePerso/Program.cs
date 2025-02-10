using System;

namespace MyNamespace
{


    public class Person
    {
        private string firstname;
        private string lastname;
        private DateOnly birthday;

        public Person(string firstname, string lastname, DateOnly birthday)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = birthday;
        }
    }
     
    public class MyApp
    {
       public static void Main(string[] args)
        {
            Person p1 = new Person("Karan", "PARIYAR", new DateOnly(1998, 09, 14));
            Person p2 = new Person("Rojita", "RANJITKAR", new DateOnly(1998, 08, 15));

            Console.WriteLine("Hello OOP");

            List<Person> people = [p1, p2];
            Console.WriteLine(people.Count);    
        }

    }

}

