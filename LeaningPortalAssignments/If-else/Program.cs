using System;
namespace IfStatement;

class program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the grade: ");
        string grade= Console.ReadLine();
        if(grade=="A")
        {
            Console.WriteLine("Grade A denotes 9 Points");
        }
        else if(grade=="B")
        {
             Console.WriteLine("Grade B denotes 8 Points");
            
        } 
        else if(grade=="C")
        {
             Console.WriteLine("Grade C denotes 7 Points");
            
        }  
        else if(grade=="D")
        {
             Console.WriteLine("Grade D denotes 6 Points");
            
        }  
    }
}
