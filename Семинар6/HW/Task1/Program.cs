//Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


Console.Write("Пожалуйста введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

int index = 0;
int len = array.Length;
while(index<N)
{
    Console.Write("Пожалуйста введите число массива: ");
    array[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}
// for (int i = 0; i < N; i++)
// {
//     Console.Write("Пожалуйста введите число массива: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.Write("числа больше 0 в массиве: " + count);

