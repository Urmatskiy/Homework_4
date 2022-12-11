// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int enterData(string text)
{
    Console.Write(text);
    int c = int.Parse(Console.ReadLine());
    return c;
}

int sumOfDigits(int number)
{
    int sum = 0;
    int var = number;
    while (var > 0)
    {
        sum = sum + (var % 10);
        var = var / 10;
    }
    return sum;
}

int number = enterData("Введите число: ");
int result = sumOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {result}");

