using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Введите сумму денег для конвертации:");
        double amount = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите курс конвертации (например, 1.12 для EUR/USD):");
        double rate = double.Parse(Console.ReadLine());

        double convertedAmount = amount * rate;
        Console.WriteLine($"Сумма после конвертации: {convertedAmount}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadLine();
    }
}
