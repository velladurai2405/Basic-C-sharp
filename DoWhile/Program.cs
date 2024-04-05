using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
        string s="";
        Console.WriteLine("Enter The numbe: ");
         int num=int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Entered number is even.");

            }
            else if(num%2==1)
            {
                Console.WriteLine("Entered number is odd.");
            }
        do{
           
            Console.WriteLine("Do you want to continue: yes or no");
            s=Console.ReadLine();
            if(s=="no")
            {
                break;
            }
            else if(s!="yes")
            {
                Console.WriteLine("enterd correct value.");
                s="yes";

            }
        }
        while(s=="yes");
        
    }
}
