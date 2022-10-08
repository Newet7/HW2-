// Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//Случайные целые числа

int strsCount = Convert.ToInt32(Console.ReadLine());
int columnsCount = Convert.ToInt32(Console.ReadLine());

// введите число поиска
Console.Write("Введите число поиска:  ");
int num = Convert.ToInt32(Console.ReadLine());

//1 allocate memory for array
int [,] twoDimArray = new int [strsCount,columnsCount];
//2 
Random rnd = new Random();

for (int i = 0; i < strsCount; i++)
{
    for (int j = 0; j < columnsCount; j++) // следующая строка
    {
        twoDimArray[i,j] = rnd.Next(1, 5);
        Console.Write(twoDimArray[i,j] + " ");
    }
    Console.WriteLine();
}

void task (int num)
{
    for (int i = 0; i < strsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++) // следующая строка
        {
            if (num != twoDimArray[i,j])
            {
                Console.WriteLine($"число {num} не совпадает с число в массиве");
            }
            else {
                Console.WriteLine($"число {num} совпадает с число в массиве");
            }
        }
    }
}
task(num);

