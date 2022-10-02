//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

int N = Console.ReadLine();
int num = new Random().Next(1, 100);
int [] array = new int[N];
int N = array.Length;
int i = 0;

while (num > 0)
{
    array[i] = num % 2;
    num = num /2;
}
