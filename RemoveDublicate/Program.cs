using System;
using System.Globalization;
namespace RemoveDublicate;
class Program{
    public static void Main(string[] args)
    {
        
    string s=Console.ReadLine();
    char[] a=s.ToCharArray();
    for(int i=0;i<a.Length;i++)
    {
        for(int j=i+1;j<a.Length;j++)
        {
            if(a[i]==a[j])
            {
                a[j]=' ';

            }
        }
    }
    for(int i=0;i<a.Length;i++)
        {
            if(a[i]!=' ')
            {
                Console.Write(a[i]);
            }
        }
    }
}
