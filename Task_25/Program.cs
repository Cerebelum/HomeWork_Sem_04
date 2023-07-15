// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Вариант 1. Возведение в степень через Math.Pow
// double RaiseToPower(double x, double y)
// {
//     double result;
//     result = Math.Pow(x, y);
//     return result;
// }

// double Prompt(string text)
// {
//     Console.Write(text);
//     return Convert.ToDouble(Console.ReadLine());
// }

// double a = Prompt("Введите число А: "); // для дробных чисел разделитель ","
// double b = Prompt("Введите число В: ");
// double c = RaiseToPower(a, b);
// Console.Write($"Число {a} в степени {b} равно: {c}");

// Вариант 2. Возведение в степень с помощью цикла
double RaiseToPowerLoop(double x, double y)
{
    double result = x;
    for (int i = 1; i < y; i++)
    {
        result *= x;
    }
    return result;
}

double Prompt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double a = Prompt("Введите число А: "); // для дробных чисел разделитель ","
double b = Prompt("Введите число В: ");
double c = RaiseToPowerLoop(a, b);
Console.Write($"Число {a} в степени {b} равно: {c}");
