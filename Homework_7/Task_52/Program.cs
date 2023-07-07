/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int [,] CreateArray(int m, int n)
{ 
    Random rand = new Random(); 
    int [,] array = new int [n,m]; 
    for (int i = 0; i < n; i++) 
    { 
        for (int j = 0; j < m; j++) 
        { 
            array[i,j] = rand.Next(0, 10); 
        } 
    } 
    return array; 
} 
 
void PrintArray(int [,] array)
{ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
}

double[] GetAverage(int[,] array)
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    double[] average = new double[width];
    int sum = 0;
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            sum += array[j, i];
        }
        average [i] = Math.Round((double)sum / height, 2);
        sum = 0;
    }
    return average;
}

System.Console.Write("Ввести количество столбцов n => ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести количество строк m => ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateArray(m, n);
PrintArray(array);
double[] answer = GetAverage(array);
System.Console.Write($"Среднее арифметическое элементов каждого столбца: {String.Join("; ", answer)}");