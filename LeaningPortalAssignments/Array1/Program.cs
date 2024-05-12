using System;
namespace Array2;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the 5 nubers");
        int[] a=new int[5];
        int num=5;
        int t;
        for(int i=0;i<num;i++)
        {
            a[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<5;i++)
        {
            for(int j=i+1;j<5;j++)
            {
                if(a[i]<a[j])
                {
                    t=a[i];
                    a[i]=a[j];
                    a[j]=t;
                }
            }
            
        }
        for(int i=a.Length-1;i>=0;i--)
        {
            if(a[i]!=0)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
