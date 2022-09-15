//Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.

int start = 1;
int stop = 1000000;
//int reminder = 0;
int a = 7;
int b = 23;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

while (value % a ==0){
    if(value % b ==0){
        Console.WriteLine(value + " кратно " + a + " и " + b);
        break;
    }
    
    
}


