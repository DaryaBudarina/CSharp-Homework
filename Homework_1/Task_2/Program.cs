/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
// Вариант для рандомных чисел:
//int n1 = new Random() .Next();
//Console.WriteLine(n1);
//int n2 = new Random() .Next();
//Console.WriteLine(n2);
//int n3 = new Random() .Next();
//Console.WriteLine(n3);

Console.Write("Введите число 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

// if(n2 > n1)
// {
//    Console.WriteLine($"max = " + Math.Max(n2, n3));
// }
// else
// {
//        Console.WriteLine($"max = " + Math.Max(n1, n3));
// }

if(n1 > n2)
{
    max = n1;
    if(n1 < n3)
    {
        max = n3;
    }
}
else
{
    max = n2;
    if(n2 < n3)
    {
        max = n3;
    }
}

Console.WriteLine($"Max= {max}");