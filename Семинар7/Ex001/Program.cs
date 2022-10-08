//Случайные целые числа

int strsCount = Convert.ToInt32(Console.ReadLine());
int columnsCount = Convert.ToInt32(Console.ReadLine());

//1 allocate memory for array
int [,] twoDimArray = new int [strsCount,columnsCount];
//2 
Random rnd = new Random();

for (int i = 0, j = 0; i < strsCount && j < columnsCount; i++, j++)
{
    twoDimArray[i,j] = rnd.Next(1, 100);
    Console.WriteLine("\t", twoDimArray[i,j]);
}
Console.WriteLine();