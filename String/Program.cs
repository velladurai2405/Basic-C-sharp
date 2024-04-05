using System;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enetr the main string: ");
        string mainString=Console.ReadLine(); 
        Console.Write("Enetr the sub string: ");
        string subString=Console.ReadLine();
        string[] a=mainString.Split(subString);
        Console.WriteLine(a.Length-1);
    }
}

