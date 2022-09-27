// Задайте массив натуральных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//1 - создать массив, 5 эл-ов

//2 - найти минимальный эл-т массива

//3 - найти максимальный эл-т массива

//4 - найти разницу между мин и макс эл-м сассивов.

int N = 5;
int [] array = new int[N];

Random rnd = new Random();
for (int i=0; i<N; i++)
{
    array[i] = rnd.Next(1,100);
    Console.WriteLine(array[i]);
}

//2 - найти минимальный эл-т массива
int min_count = array[0];

for (int i = 0; i < N; i++)
{
    if (min_count > array[i])
    {
        min_count = array[i];
    }
}
Console.WriteLine($"число {min_count} минимальный эл-т массива");

//3 - найти максимальный эл-т массива

int max_count = array[0];

for (int i = 0; i < N; i++)
{
    if (max_count < array[i])
    {
        max_count = array[i];
    }
}
Console.WriteLine($"число {max_count} максимальный эл-т массива");
Console.WriteLine($"разница между максимальным и мин равна {max_count-min_count}");