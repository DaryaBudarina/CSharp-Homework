/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int GetNumber(string description)
{
    Console.Write($"{description}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void SumRealDigits(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    SumRealDigits(m, n - 1, sum);
}

int m = GetNumber("Ввести M = ");
int n = GetNumber("Ввести N = ");

if (n >= 1 && m >= 1)
{
    int temp = m;
    if (m > n)
    {
        m = n;
        n = temp;
    }
    Console.Write($"M = {m}, N = {n} ->");
    SumRealDigits(m, n, temp = 0);
}
else Console.WriteLine($"Одно или оба введеных числа не является натуральным(-и)");