using System;
namespace Date;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        Console.WriteLine($"Current month is :{date.Month}");
        DateTime pastDate=date.AddDays(-3);
        Console.WriteLine($"3 days before day :{pastDate.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"12 hours format time for today:{date.ToString("dd/MM/yyyy hh:mm:ss tt")}");
    }
}
