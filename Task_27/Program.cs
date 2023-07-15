// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант 1. Через остаток от деления на 10
// int SumDigitOfNumber(int number)
// {
//     int result = 0;
//     for (int i = number; i > 0;)
//     {
//         result = result + i % 10;
//         i = i / 10;
//     }
//     return result;
// }

// int Prompt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int num = Prompt("Введите число: ");
// Console.Write($"Сумма цифр числа {num} равна: {SumDigitOfNumber(num)}");

// Вариант 2. Через преобразование числа в массив цифр
int SumDigitOfNumber2(string number) // преобразует в массив и выдает сумму
{
    int[] arr = new int[number.Length];
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        arr[i] = int.Parse(number[i].ToString());
        sum = sum + arr[i];
    }
    return sum;
}

string Prompt(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string num = Prompt("Введите число: ");
int sumValue = SumDigitOfNumber2(num);
Console.Write($"Сумма цифр числа {num} равна: {sumValue}");
