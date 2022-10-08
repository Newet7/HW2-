//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Clear();

int [,] arr = new int [4,4];
Random rnd = new Random();

void updArray(int[,] arr)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++) // следующая строка
        {
            if (i%2==0 && j%2==0 && i != 0) // умножаем индексы
            {
                arr[i,j] = func(arr[i,j]);
            }
        }
    }
}

int func(int element){
    return element * element;
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++) // следующая строка
    {
        arr[i,j] = rnd.Next(1, 9); //изначальный вид двумерного массива
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}
System.Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++) // следующая строка
    {
        
        if (i%2==0 && j%2==0 && i != 0) // умножаем индексы
        {
            arr[i,j] = func(arr[i,j]);
        }
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}






// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 4; j++) // следующая строка
//     {
//         arr[i,j] = rnd.Next(1, 9); //изначальный вид двумерного массива
//         if (i%2==0 && j%2==0 && i != 0) // умножаем индексы
//         {
//             arr[i,j] = arr[i,j] * arr[i,j];
//         }
//         Console.Write(arr[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// System.Console.WriteLine();