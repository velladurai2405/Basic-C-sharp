using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the 10 nubers");
        int[] a=new int[10];
        int[] b=new int[10];
        int j=0;
        int num=10;
        for(int i=0;i<num;i++)
        {
            a[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<10;i++)
        {
            if(a[i]%2==0)
            {
                Console.Write(a[i]+" ");
            }
            else if(a[i]%2==1){               
                b[j++]=a[i];                  
            }
        }
        for(int i=b.Length-1;i>=0;i--)
        {
            if(b[i]!=0)
            {
                Console.Write(b[i]+" ");
            }
        }
        
    }
}
