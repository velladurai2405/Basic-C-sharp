using System;
namespace String1;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string str=Console.ReadLine();
        char[] a=new char[str.Length];
        a=str.ToCharArray();

        for(int i=0;i<str.Length;i++)
        {
            if(i%2==0)
            {
                Console.Write(a[i]);
            }
        }
    }
}
