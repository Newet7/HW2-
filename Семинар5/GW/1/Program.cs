//Задайте произвольный целочисленный массив. Напишите программу, которая определяет, 
//присутствует ли заданное пользователем число в массиве.

//Примечание
//Проверку принадлежности числа массиву реализовать в отдельной функции/ длина массива 10

//1. Задать массив
int N = 10;
int [] array = new int[N];

Console.Write("Введите число поиска:  ");
int num = Convert.ToInt32(Console.ReadLine());

// int Nu = 0;
// Nu = randSto - randStop;

//1.2 Заполняем массив
Random rnd = new Random();
for (int i=0; i<N; i++)
{
    array[i] = rnd.Next(1,10);
    
}



void task (int num)
{
    for (int i = 0; i < N; i++)
    {
        if (num == array [i])
        {
            Console.Write($"число {num} совпадает с число в массиве");
            break;
        }
        else 
        {
            Console.Write($"число {num} не совпадает с число в массиве");
            break;
        }
    } 
}

task(num);

//доп. задание - как сделать чтоб результат не дублировался если повторяющихся чисел несколько? break else not break...