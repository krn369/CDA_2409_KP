Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50,101);

System.Console.WriteLine($"First roll : {roll1}");
System.Console.WriteLine($"Second roll : {roll2}");
System.Console.WriteLine($"Third roll : {roll3}");

