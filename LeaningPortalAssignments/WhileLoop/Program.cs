using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Which is city is capital of india");
        Console.WriteLine("1.Chennai");
        Console.WriteLine("2.Delhi");
        Console.WriteLine("3.Mumbai");
        Console.WriteLine("4.Kolkata");
        string press = "Y";
        while (press == "Y")
        {
            Console.Write("Enter the choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 2)
            {
                Console.WriteLine("True");
                press = "N";
            }
            else
            {
                Console.WriteLine("Incorrect");
                Console.WriteLine("Press Y to continue, Press N to close");
                press = Console.ReadLine();
            }
        }
    }
}