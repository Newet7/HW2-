int start = 100;
int stop = 999;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

int dig_first_and_second = value / 10;
int dig_last_first_and_second = dig_first_and_second%10;

Console.WriteLine(dig_last_first_and_second);

