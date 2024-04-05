using System;
namespace AgeCalculator;
class Program{
    public static void Main(string[] args)
    {
                DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                TimeSpan span=date2-date1;
                double age=span.TotalDays/365;
                Console.WriteLine($"Age : {Math.Floor(age)}");
                Console.WriteLine($"Day : {date1.DayOfWeek}");
                double days=span.TotalDays;
                Console.WriteLine($"Number of days : {Math.Floor(days)}");
                double hours=span.TotalHours;
                Console.WriteLine($"Number of hours : {Math.Floor(hours)}");
                double minutes=span.TotalMinutes;
                Console.WriteLine($"Number of minutes : {Math.Floor(minutes)}");
        
    }
}
