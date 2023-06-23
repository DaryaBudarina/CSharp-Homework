/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
for (int i = 1; i <= N; i++)
{
    a[i - 1] = (int)Math.Pow(i, 3);
}
System.Console.WriteLine("Ответ: " + String.Join(", ", a));