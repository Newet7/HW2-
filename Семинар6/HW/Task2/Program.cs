//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//Рекомендую учесть три возможных случая расположения двух прямых.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Пожалуйста введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

// k1*x+b1=k2*x+b2 выразим от сюда Х = (b2-b1)/(k1-k2)

int x = (b2-b1)/(k1-k2);

int y = k1 * (b2-b1)/(k1-k2) + b1;

//int y = k1 * x + b1;
//int y = k2 * x + b2;

Console.WriteLine($"Пересечение в точке: ({x};{y})");

