// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int enterData(string text)
{
    Console.Write(text);
    int c = int.Parse(Console.ReadLine());
    return c;
}

int exponentiation(int number, int degree)
{
    int result = number;
    for (int i = 0; i < degree - 1; i++)
    {
        result = result * number;
    }
    return result;
}

int number1 = enterData("Введите первое число: ");
int number2 = enterData("Введите второе число: ");

int result = exponentiation(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} = {result}");