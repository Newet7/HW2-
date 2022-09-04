int start = 10;
int stop = 10;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

if (value % 10 == 0) {
    Console.Write("третей цифры нет");
}

