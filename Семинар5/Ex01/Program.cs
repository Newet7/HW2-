//Решение задач совместная работа

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9]. Найдите сумму отрицательных и положительных элементов массива

//1. Задать массив
int N = 5;
int [] array = new int[N];

//1.2 Заполняем массив
for (int i=0; i<N; i++)
{
    array[i] = new Random().Next(-9,10);
}


//2. Объявим переменные 
int negSum = 0;
int posSum = 0;

//3. Перебрать элементы массива используя цикл (Search proccessing of array)
for (int i = 0; i < N; i++)
{
    if (array [i] < 0)
    {
        negSum += array[i];
    }
    else
    {
        posSum += array[i];
    }
}

//4
Console.WriteLine(negSum+" "+posSum);