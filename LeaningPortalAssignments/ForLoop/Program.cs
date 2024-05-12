using System;
namespace ForLoop;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the 10 nubers");
        int[] a=new int[10];
        int num=10;
        for(int i=0;i<num;i++)
        {
            a[i]=int.Parse(Console.ReadLine());
        }

        int sum=0;
        for(int i=0;i<10;i++)
        {
            sum+=a[i];
        }
        Console.WriteLine("Sum is "+sum);
        Console.WriteLine("Average is "+sum/10);
    }

    
}
