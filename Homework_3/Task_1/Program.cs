/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// палиндром - число, одинаково читающееся в обоих направлениях

string IsPalindrom(string number)
{
    number = number.ToLowerInvariant();

    if (number.Length == 5)
    {
        for (int start = 0, end = number.Length - 1; start < end; ++start, --end)
        {
            if (number[start] != number[end])
            {
                return $"Нет, {number} - это не палиндром";
                }
        }
        return $"Да, {number} - это палиндром";
    }
    return $"Ошибка: Число {number} - не пятизначное";
}

Console.Write("Введите пятизначное число: ");
string Num = Console.ReadLine();
Console.WriteLine(IsPalindrom(Num));