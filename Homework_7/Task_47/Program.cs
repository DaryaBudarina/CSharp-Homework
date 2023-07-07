/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

double [,] CreateArrayDouble(int m, int n)
{ 
    Random rand = new Random(); 
    double [,] array = new double [n,m]; 
    for (int i = 0; i < n; i++) 
    { 
        for (int j = 0; j < m; j++) 
        { 
            array[i,j] = Math.Round(rand.Next(-9, 10) + rand.NextDouble(), 1); 
        } 
    } 
    return array; 
} 
 
void PrintArrayDouble (double [,] array)
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

System.Console.Write("Ввести количество стобцов n: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести количество строк m: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateArrayDouble(m, n);
PrintArrayDouble(array);