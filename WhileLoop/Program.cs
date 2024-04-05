using System;
using System.Runtime.Intrinsics.Arm;
namespace WhileLoop;

class Program{
    public static void Main(string[] args)
    {
        int i=0;
        while(i>=0&&i<=25)
        {
            Console.WriteLine(i++);
        }

        Console.WriteLine("Enter a valid number: ");
        bool isValid=int.TryParse(Console.ReadLine(),out int result);
        while(!isValid)
        {
            Console.WriteLine("Enter a valid number: ");
            isValid=int.TryParse(Console.ReadLine(),out result);

        }

    }
}