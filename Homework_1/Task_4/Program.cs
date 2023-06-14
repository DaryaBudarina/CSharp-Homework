/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int evenN = 2;

if(n > 1)
{
    while(evenN <= n)
    {
        Console.Write(evenN + " ");
        evenN += 2;
    }
}