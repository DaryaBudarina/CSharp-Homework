/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1*x + b1, y = k2*x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Напр.:b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
double Number(string name)
{
    System.Console.Write($"Введите значение {name}");
    return Convert.ToDouble(Console.ReadLine());
}

double pointX(double b2, double b1, double k1, double k2)
{
    double point = 0;
    point = -(b1 - b2) / (k1 - k2);
    return point;
}

double pointY(double k1, double x, double b1)
{
    double point = 0;
    point = k1 * x + b1;
    return point;
}

double b1 = Number("b1 = ");
double k1 = Number("k1 = ");
double b2 = Number("b2 = ");
double k2 = Number("k2 = ");

Console.WriteLine($"Пересечение в точке: ({pointX(b2, b1, k1, k2)};{pointY(k1, pointX(b2, b1, k1, k2), b1)})");