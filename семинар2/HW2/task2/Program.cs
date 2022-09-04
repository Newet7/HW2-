//Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

int start = 1;
int stop = 65536;
int reminder = 0;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

while (value / 100 == 0) {
    Console.Write("третей цифры нет");
    break;
}
while (value <= 999){
    
    reminder = (value % 10);
    //Console.WriteLine(value % 10);
    break;
}
while (value >= 1000){
    
    reminder = ((value % 100)/10);
    //Console.WriteLine((value % 100)/10);
    break;
}
while (value >= 10000){
    
    reminder = ((value % 1000)/100);
    //Console.WriteLine((value % 1000)/100);
    break;
}
Console.WriteLine(reminder);
