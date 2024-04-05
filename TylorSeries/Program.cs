using System;
namespace TylorSeries;
class Program{
    public static void Main(string[] args)
    {
        double n=double.Parse(Console.ReadLine());
                double m=double.Parse(Console.ReadLine());
                double sum=0,j=1,num=1;
                for(double i=0;i<m;i++)
                {
                    double k=i;
                    num=j/Factorial(k);
                    j*=2;
                    sum+=num;

                }
                Console.WriteLine(Math.Round(sum,2));
                double Factorial(double k)
                {
                    double fact=1;
                    if(k==0||k==1)
                    {
                        return 1;
                    }
                    else if(k>1)
                    {
                        fact=k*Factorial(k-1);
                    }
                    return fact;
                }
    }
}

