using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите свое имя:");
        string name = Console.ReadLine();

        Console.Write("Введите свой возраст:");
        byte age = checked((byte)int.Parse(Console.ReadLine()));

        Console.WriteLine("Ваше имя {0} и вам {1} лет", name, age);

        Console.WriteLine("Какой ваш любимый день недели?");
            DayOfWeek day = checked((DayOfWeek) int.Parse(Console.ReadLine()));
        Console.WriteLine(" Ваш любимый день {0}", day);
    }
}