using System;
namespace String4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();
        string[] arr=new string[10];
        arr=str.Split(",");
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
