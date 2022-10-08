// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Случайные целые числа

int strsCount = Convert.ToInt32(Console.ReadLine());
int columnsCount = Convert.ToInt32(Console.ReadLine());

//1 allocate memory for array
int [,] twoDimArray = new int [strsCount,columnsCount];
//2 
Random rnd = new Random();

for (int i = 0; i < strsCount; i++)
{
    for (int j = 0; j < columnsCount; j++) // следующая строка
    {
        twoDimArray[i,j] = rnd.Next(1, 100);
        Console.Write(twoDimArray[i,j] + " ");
    }
    Console.WriteLine();
}
//3 найти сумму чисел в столбце, и подлить сумму на их кол-во

Console.WriteLine("Среднее арифметическое каждого столбца: ");
//Console.WriteLine(twoDimArray.GetLength(0));
for (int j = 0; j < twoDimArray.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        sum += twoDimArray[i, j];
    }
    Console.Write($"{ sum / twoDimArray.GetLength(0)} ");
}
Console.ReadLine();

