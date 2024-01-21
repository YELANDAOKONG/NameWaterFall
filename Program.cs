namespace NameWaterFall;

using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Random ran = new Random();
        bool color = true;
        if (args.Contains("--nocolor"))
        {
            color = false;
        }
        if (args.Contains("--help"))
        {
            Console.WriteLine("Usage: NameWaterFall [--nocolor] [--help]");
            return;            
        }
        // input username
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Enter String: ");
        string strs = Console.ReadLine();
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        while (true)
        {
            Thread.Sleep(50);
            Console.Write(name + GenerateRandomSpacesString() + strs + GenerateRandomSpacesString());
            if (color)
            {
                int color1 = ran.Next(0, 15);
                int color2 = ran.Next(0, 15);
                Console.ForegroundColor = (ConsoleColor)color1;
                Console.BackgroundColor = (ConsoleColor)color2;
            }

        }
    }
    
    
    public static string GenerateRandomSpacesString()
    {
        Random random = new Random();
        int length = random.Next(1, 21);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            sb.Append(" ");
        }

        return sb.ToString();
    }
    
}