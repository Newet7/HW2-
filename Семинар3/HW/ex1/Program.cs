// принимает на вход 5-ти значное число
// проверяет его на полиндромность

Console.Write("Пожалуйста введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = N;
int result = 0;

while (N > 0)
{
    result *= 10;
    result += N % 10;  
    N /= 10; 

}

if (result==num)
{
    Console.WriteLine("да");
    
}
else
{
    Console.WriteLine("No");
}

