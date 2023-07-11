/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

int n = GetNumber("Введите натуральное число N = ");

int GetNumber(string description)
{
    Console.Write($"{description}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string RealDigits(int num)
{
    if(num == 1)
    {
        return num.ToString();
    } 
    return num + ", " + RealDigits(num-1);
}

if (n >= 1) 
{
    Console.WriteLine($"N = {n} ->  {RealDigits(n)}");
}
else Console.WriteLine($"Число {n} не является натуральным");