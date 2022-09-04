int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int reminder = 0;

if (a % b ==0)
{
    Console.Write("b кратно a");
}

else{
    reminder = a%b;
    Console.WriteLine("не кратно, остаток " + reminder);
}
