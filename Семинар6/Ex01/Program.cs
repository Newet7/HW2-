// Рекурсия

int get_factorial(int x)
{
    Console.WriteLine(x); // вывод 4 3 2 1
    if (x==1)
    {
        Console.WriteLine("IF");
        return 1;
    }
    else
    {
        //Console.WriteLine("HERE:" + x);
        //return x*get_factorial(x-1);
        
        int tmp = get_factorial(x-1);
        Console.WriteLine("reverse:" + tmp);
        return x*tmp;

    }
}

get_factorial(4);  