//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int a = Convert.ToInt32(Console.ReadLine());

while(a <= 5 ){
    Console.Write("no");
    break;
}
while(a>5){
    Console.Write("yes");
    break;
}
