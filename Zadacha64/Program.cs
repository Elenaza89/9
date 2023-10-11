// Задача 64
/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1
*/
Console.WriteLine("Задайте целое число N");

Int32.TryParse(Console.ReadLine(), out int N);

string str = string.Empty;
for (int i = N; i >= 1; i--)
{
    str = WriteNumber(i, str);
}
Console.WriteLine(str);

string WriteNumber(int i, string s)
{
    return (i == N) ? $"{i}": $"{s}, {i}";
}

