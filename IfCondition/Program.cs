﻿using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the marks: ");
        int marks=int.Parse(Console.ReadLine());
        if(marks>=81&& marks<=100)
        {
            Console.WriteLine("Grade A");
        }
        else if(marks>=61&& marks<=80)
        {
             Console.WriteLine("Grade B");
            
        } 
        else if(marks>=36&& marks<=60)
        {
             Console.WriteLine("Grade C");
            
        }  
        else if(marks<36&& marks>=0)
        {
             Console.WriteLine("Grade D");
            
        }  
        else
        {
            Console.WriteLine("Invalid Input");

        }  
    }
}
