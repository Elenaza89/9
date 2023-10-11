//Задача 66
/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Задайте целое число M");
Int32.TryParse(Console.ReadLine(), out int M);
Console.WriteLine("Задайте целое число N");
Int32.TryParse(Console.ReadLine(), out int N);

Console.WriteLine(GetSumm(M, N));

int GetSumm(int m, int n)
{
    int i = m;
    int sum = m;    

    if(i< n)
    {
       sum += GetSumm(++i, n);
    }
    return sum;
}
