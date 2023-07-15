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
int SumDigitOfNumber2(string number)
{
    int[] arr = new int[number.Length];
    for (int i = 0; i < number.Length; i++) // преобразует строку в массив цифр
    {
        arr[i] = int.Parse(number[i].ToString());
    }
    int sum = 0;
    for (int k = 0; k < arr.Length; k++) // считает сумму элементов массива
    {
        sum = sum + arr[k];
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

