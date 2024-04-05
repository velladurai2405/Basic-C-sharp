using System;
namespace Methods;
class Program{
    public static void Main(string[] args)
    {
        
        string s="";
        bool flag=false;
        do{
        Console.Write("Enetr the number 1: ");
        double num1=double.Parse(Console.ReadLine());
        Console.Write("Enetr the number 2: ");
        double num2=double.Parse(Console.ReadLine());
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        int num3=int.Parse(Console.ReadLine());
        switch(num3)
        {
            case 1:
            {
                Console.WriteLine(Addition(num1,num2));
                break;
            }
            case 2:
            {
                Console.WriteLine(Subtraction(num1,num2));
                break;
            }
            case 3:
            {
                Console.WriteLine(Multiplication(num1,num2));
                break;
            }
            case 4:
            {
                Console.WriteLine(Division(num1,num2));
                break;
            }
        }
        static double Addition(double num1,double num2)
        {
            double sum=num1+num2;
            return sum;
        }
        static double Subtraction(double num1,double num2)
        {
            double sub=num1-num2;
            return sub;
        }
        static double Multiplication(double num1,double num2)
        {
            double mul=num1*num2;
            return mul;
        }
        static double Division(double num1,double num2)
        {
            double div=num1/num2;
            return div;
        }
        Console.WriteLine("Do you want to repeat the process again:yes/no");
        s=Console.ReadLine();
        if(s=="yes")
        {
            flag=true;
        }
        else if(s=="no")
        {
            flag=false;
        }
        
        }while(flag);
        
    }
}
