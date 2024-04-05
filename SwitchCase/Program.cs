using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number1");
        double num1=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number1");
        double num2=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter what you want to perform: ");
        string operation=Console.ReadLine();
        switch(operation)
        {
            case "+":
            {
                Console.WriteLine(num1+num2);
                break;

            }
            case "-":
            {
                Console.WriteLine(num1-num2);
                break;

            }
            case "*":
            {
                Console.WriteLine(num1*num2);
                break;

            }
            case "/":
            {
                Console.WriteLine(num1/num2);
                break;

            }
             case "%":
            {
                Console.WriteLine(num1%num2);
                break;

            }
            default:
            {
                Console.WriteLine("Enter valid input");
                break;

            }
        }
        
      
        
    }
}
