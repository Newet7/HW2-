//Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int start = 100;
int stop = 999;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

int dig_first_and_second = value / 10;
int dig_last_first_and_second = dig_first_and_second%10;

Console.WriteLine(dig_last_first_and_second);

