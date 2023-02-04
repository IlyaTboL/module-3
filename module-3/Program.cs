class MainClass
{

    static void Main(string[] args)
    {
        string Name = "Илья";
        int Age = 28;
        bool Pet = true;
        double Size = 44.5;
       
        Console.WriteLine("Меня зовут " + Name);
        Console.WriteLine($"Мне {Age} лет ");
        Console.WriteLine($"У меня есть питомец? {Pet}.");
        Console.WriteLine($"Мой размер обуви {Size}");

        Console.ReadKey();

    }
}
