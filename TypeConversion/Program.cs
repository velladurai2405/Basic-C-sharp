using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name=Console.ReadLine();
        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        double mark1=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        double mark2=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        double mark3=double.Parse(Console.ReadLine());
        Console.Write("Enter grade: ");
        string grade=Console.ReadLine();
        Console.Write("Enter mobile number: ");
        double mobile=double.Parse(Console.ReadLine());
        Console.Write("Enter your Mail ID: ");
        string mailId=Console.ReadLine();
        Console.WriteLine("Trainee Details Are: ");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Mobile: "+mobile);
        Console.WriteLine("Marks1: "+mark1);
        Console.WriteLine("Marks2: "+mark2);
        Console.WriteLine("Marks3: "+mark3);
        double total=mark1+mark2+mark3;
        double avg=total/3;
        Console.WriteLine("Total: "+total);
        Console.WriteLine("Average: "+avg);
        Console.WriteLine("Grade: "+grade);
        Console.WriteLine("Mail Id: "+mailId);
    }
}
