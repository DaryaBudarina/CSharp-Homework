/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string description)
{
    Console.Write($"{description}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int m = GetNumber("Ввести m = ");
int n = GetNumber("Ввести n = ");

if (n >= 0 && m >= 0)
{
    int akkermanFunction = Akkerman(m, n);
    Console.Write($"m = {m}, n = {n} -> A(m,n) = {akkermanFunction} ");
}
else Console.WriteLine($"Одно или оба введеных числа не являе(-ю)тся неотрицательным(-и)");