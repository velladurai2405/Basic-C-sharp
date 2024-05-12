using System;
namespace String5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string1");
        string str1 = Console.ReadLine();
        char[] a=new char[str1.Length];
        a=str1.ToCharArray();
        Console.WriteLine("Enter a string2");
        string str2 = Console.ReadLine();
        char[] b=new char[str2.Length];
        b=str2.ToCharArray();
        for (int i = 0; i < 4; i++)
        {
           Console.Write(a[i]);
        }
   
        for (int i = str2.Length-3; i<str2.Length; i++)
        {
           Console.Write(b[i]);
          
        }

    }
}
