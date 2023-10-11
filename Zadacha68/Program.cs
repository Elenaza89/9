/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


Console.WriteLine("Задайте целое число M");
Int32.TryParse(Console.ReadLine(), out int M);
Console.WriteLine("Задайте целое число N");
Int32.TryParse(Console.ReadLine(), out int N);

Console.WriteLine( Akkerman(M, N));

int Akkerman( int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (m != 0 && n == 0)
            return Akkerman(m - 1, 1);
        else
            return Akkerman(m-1,Akkerman(m,n-1));
    }
}