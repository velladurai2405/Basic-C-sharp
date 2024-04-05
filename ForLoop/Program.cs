using System;
using System.Diagnostics.CodeAnalysis;
namespace ForLoop;
class Progarm{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number1: ");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number2: ");
        int num2=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=num1;i<=num2;i++)
        {
            sum+=i*i;
        }
        Console.WriteLine(sum);
    }
}