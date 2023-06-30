/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int[] Numbers(string text = "Ввести числа через запятую: ")
{
    System.Console.Write("Ввести числа через запятую: ");
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(String.Join(",", array));
}
 
int NumMoreZero(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    return sum;
}

int[] array = Numbers();
PrintArray(array);
System.Console.WriteLine($"Колличество значений больше 0 = {NumMoreZero(array)}");