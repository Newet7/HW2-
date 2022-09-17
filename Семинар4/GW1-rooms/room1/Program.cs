

int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
int tmp = num;

while (tmp >0)
{
    int ost = tmp % 10;
    if (ost % 2 == 0)
    {
        count ++;
    }
    tmp = tmp / 10;
}

Console.WriteLine(count);