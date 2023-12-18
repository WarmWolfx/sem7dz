// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
num(n, m);

int num(int n, int m)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        m++;
        return num(n, m);
    }
    else
        return 0;
}
