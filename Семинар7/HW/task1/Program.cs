// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными (тип double) числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//Случайные вещественными (тип double) числа


int strsCount = Convert.ToInt32(Console.ReadLine());
int columnsCount = Convert.ToInt32(Console.ReadLine());

//1 allocate memory for array
double [,] twoDimArray = new double [strsCount,columnsCount];
//2 
Random rnd = new Random();

for (int i = 0; i < strsCount; i++)
{
    for (int j = 0; j < columnsCount; j++) // следующая строка
    {
        twoDimArray[i,j] = rnd.NextDouble()*10000;
        Console.Write(twoDimArray[i,j] + " ");
    }
    Console.WriteLine();
}

