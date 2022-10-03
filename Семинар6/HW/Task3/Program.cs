// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Если кол-во элементов нечетное, то элемент посередине не учитывать.
//Результат сложения вывести на экран.
//1, 3, 8, 3, 2 -> 11
//8, 3, 4, 2 -> 28


//1 определить элементы массива, укажим максимальный.
Console.Write("Пожалуйста введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

int index = 0;
int num = 1;
while(index < N)
{
    array[index] = new Random().Next(1, 100);
    Console.Write(array[index] + " ");
    num ++;
    index ++;
}

//2 - найти произведение 1 и последнего
int sum = 0;
int tmp = 0;
for (int i = 0; i < array.Length; i++)
{
    if(N % 2 ==0)
    {
        
        sum = array[i] * array[-1];
        
    }
    tmp -= 1;
}

Console.WriteLine(sum);