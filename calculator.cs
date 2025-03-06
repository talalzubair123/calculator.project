using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name:Talal Zubair");
        Console.WriteLine("Roll Number: 24-ST-086");
       
        int a, b;
        Console.Write("Enter two numbers: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Product: {a * b}");
    }
}
