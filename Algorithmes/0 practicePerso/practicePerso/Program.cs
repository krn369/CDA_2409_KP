using System;

class PrepaidCard
{
    // Class to represent a user
    class User
    {
        public string Name;
        public double Balance;

        public User(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }

    static void Main()
    {
        // Initialize users
        User[] users = new User[5];
        users[0] = new User("Alice", 10.0);
        users[1] = new User("Bob", 5.0);
        users[2] = new User("Charlie", 3.0);
        users[3] = new User("David", 8.0);
        users[4] = new User("Eve", 6.0);

        // Meal price
        double mealPrice = 4.0;

        // Ask for user name
        Console.WriteLine("Enter the user's name:");
        string userName = Console.ReadLine();

        // Find the user
        User foundUser = null;
        foreach (var user in users)
        {
            if (user.Name.Equals(userName, StringComparison.OrdinalIgnoreCase))
            {
                foundUser = user;
                break;
            }
        }

        // Check if user is found and has enough balance
        if (foundUser != null)
        {
            Console.WriteLine($"User found: {foundUser.Name}, Balance: {foundUser.Balance}€");

            if (foundUser.Balance >= mealPrice)
            {
                foundUser.Balance -= mealPrice;
                Console.WriteLine($"Meal paid. New balance: {foundUser.Balance}€");
            }
            else
            {
                Console.WriteLine("Insufficient funds to pay for the meal.");
            }
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }
}
