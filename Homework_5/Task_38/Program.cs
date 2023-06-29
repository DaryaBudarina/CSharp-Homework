/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальной и минимальной вещественой частью элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 0.22 - 0.15 = 0.07
*/

double[] CreateArrayDouble(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        double d = rand.NextDouble();
        array[i] = Math.Round(rand.Next(0, 99) + rand.NextDouble(), 2);
    }
    return array;
}

void SearchMaxMin(double[] array, out double min, out double max)
{
    min = max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
}

double DifferenceMinMax(double min, double max)
{
    return Math.Round(max - min, 2);
}

Console.Clear();
System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayDouble(size);
System.Console.WriteLine("[" + string.Join("; ", array) + "]");
SearchMaxMin(array, out double min, out double max);
System.Console.WriteLine($" Max = {max}, Min = {min}");
System.Console.Write($" Разница между максимальной и минимальной вещественой частью элементов массива: {max} - {min} = {DifferenceMinMax(min, max)}");