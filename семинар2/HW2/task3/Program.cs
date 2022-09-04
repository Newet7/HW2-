//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int a = Convert.ToInt32(Console.ReadLine());

while(a < 7 ){
    if (a ==6)
{
    Console.Write("yes");
}
    if (a ==7)
{
    Console.Write("yes");
}
    else{
    
    Console.Write("no");
}

}
