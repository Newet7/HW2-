// (Дополнительная, необязательная задача): Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу,
//которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)

Console.Write("Пожалуйста введите кол-во интересных случайных чисел: ");
int N = Convert.ToInt32(Console.ReadLine());


//int num = 22;

int start = 0;
int stop = 999999;

int num = new Random().Next(start, stop+1);
Console.WriteLine(num);

int count_sum = 0;
int count_pro = 1;
int tmp = num;
int pro = 0;
int sum = 0;

while(tmp!=0)
{
    int ost = tmp % 10; //22%10 = 2
    if (ost != 0) // 2 != 0
    {
        count_sum = count_sum + ost; // то 0=0+2
        count_pro = count_pro * count_pro; // 1=1*2
    }
    tmp = tmp / 10;
    if(tmp%10==0)
    tmp = tmp / 10;
}

int interes_num = 1;

if(count_pro / count_sum == 0)
{
    interes_num = count_pro;
    
}

if(interes_num > 1)
{
    Console.WriteLine("интересное число " + interes_num);
}


//1. найти "интересное" число - задача 2*2 делитя на 2+2 = "интересное число"

//2. введите N число "интересных" случайных чисел

//3. создать массив с "интересными" числами
int[] array = new int[N];

