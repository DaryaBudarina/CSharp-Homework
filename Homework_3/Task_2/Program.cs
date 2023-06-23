/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Print (string text)
{  
   Console.WriteLine(text); 
} 
int GetIntNumber()
{ 
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number; 
} 
 
double distance (int x1, int y1, int z1, int x2, int y2, int z2)
{ 
    double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)); 
    return result; 
} 
Print("Ввод x1, y1, z1, x2, y2, z2: "); 
int x1 = GetIntNumber(); 
int y1 = GetIntNumber(); 
int z1 = GetIntNumber();  
int x2 = GetIntNumber(); 
int y2 = GetIntNumber(); 
int z2 = GetIntNumber(); 

double result = distance(x1, y1, z1, x2, y2, z2); 
Print($"Расстояние между точками в 3D пространстве = {result}");
