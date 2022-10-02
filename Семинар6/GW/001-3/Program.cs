// 

Console.Write("Десятичное: ");
int decimaNumber = Convert.ToInt32(Console.ReadLine());
int [] array = new int [100];
// int i = 0;
int remainder;
string result = string.Empty;
while (decimaNumber > 0)
{
    remainder = decimaNumber % 2;
    decimaNumber /= 2;
    //array[i] = remainder;
    result = remainder.ToString() + result;
    // Console.Write (array[i]);
    //i++;
}

Console.WriteLine("Двоич {0}" , result);