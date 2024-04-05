using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string[] a=new string[5];
        int num=5;
        for(int i=0;i<num;i++)
        {
            a[i]=Console.ReadLine();
        }
        Console.WriteLine("Enter the name");
        string name=Console.ReadLine();
        bool flag1=false;
        int index=0;
        for(int i=0;i<5;i++)
        {
            if(a[i]==name)
            {
                flag1=true;
                index=i;

            }
        }
        if(flag1==true)
        {
            Console.WriteLine("the name is there");
            Console.WriteLine(index);

        }
        else
        {
            Console.WriteLine("not there");
        }
        foreach(string i in a)
        {
            if(i==name)
            {
                flag1=true;

            }
           
        }
         if(flag1==true)
            {
                Console.WriteLine("the name is there");

            }
            else
            {
                Console.WriteLine("not there");
            }
    }
}
