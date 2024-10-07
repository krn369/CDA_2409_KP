internal class Program
{
    private static void Main(string[] args)
    {
        /*
         In C#, the ref keyword is used to pass arguments by reference rather than by value. This means that any changes made to the parameter inside 
         the method will be reflected in that variable when control returns to the calling method.
         */

        int A = 1;

        Toto(ref A); 

        Console.WriteLine("A : " + A);
    }

    static void Toto(ref int B)
    {
        B++;
        Console.WriteLine("B : " + B);
    }
}