using System;

// Обьявление класса MainClass
class MainClass
{
    // Обьявление метода Main
    public static void Main(string[] args)
    {
        // Запрос данных у пользователя
        Console.Write("Введите свое имя: ");
        // Присвоение переменной name
        var name = Console.ReadLine();
        // Запрос данных у пользователя
        Console.Write("введите ваш возраст:");
        // Присвоение переменной age и конвертация из типа string в int
        var age = Convert.ToInt32(Console.ReadLine());
        // Запрос данных пользователя
        Console.Write("Введите дату рождения в формате dd.mm.yyyy: ");
        // присвоение переменой birthdate
        var birthdate = Console.ReadLine();
        // Вывод прлученых данных от пользователя
        Console.WriteLine(" Вас зовут {0} \n Вы родились {1} \n Вам {2} лет" , name, birthdate, age);
    }
}