//1. Create array 
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

//2. Заполнение массива
//int len = array.Length;
int index = 0;
while(index < N)
{
    array[index] = new Random().Next(1, 10+1);
    Console.Write(array[index] + " ");
    index ++;
}

//3. Avarage (mean) среднее арифметическое чисел
int sum = 0;
for (int i=0; i<N; i++)
{
    sum += array[i];
}
double mean = sum / (double)N;
Console.WriteLine(mean);
