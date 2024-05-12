using System;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();
        char[] a = new char[str.Length];
        a = str.ToCharArray();

        for (int i = str.Length-1; i>=0 ; i--)
        {
            Console.Write(a[i]);
        }
    }
}
