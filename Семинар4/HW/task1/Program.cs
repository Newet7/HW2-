//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()
//3, 5 -> 243
//2, 4 -> 16

Console.Write("Пожалуйста введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

//Math.Pow(x, stepen);
//Обратите внимание, что метод принимает значения типа double, если мы объявим тип int, то ошибки не будет:
//int x = A;
//int stepen = B;
//Console.WriteLine("A^B = " + Math.Pow(x, stepen));

//или проще записать int i = Convert.ToInt32(Math.Pow(A, B));
//Console.WriteLine(i);

int k = 0;
int c = 1;

while (k != B) //
{
    k++;
    c = c * A;
}

Console.WriteLine(c);
