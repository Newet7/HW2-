//Console. Write ("Введите через пробел координаты первой точки: ");
//Point a = Point.Parse(Console.ReadLine());
//Console. Write ("Введите через пробел координаты второй точки: ");
//Point b = Point.Parse(Console.ReadLine());
//Console. WriteLine($"Расстояние от точки {a} до точки {b} равно {a. Distance (b)}");



// C# program to find
// distance between
// two points in 3 D.
//using System;
 
class GFG
{
     
// Function for
// distance
static void distance(float x1, float y1,
                     float z1, float x2,
                     float y2, float z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine("Distance is \n" + d);
    return;
}
 
// Driver code
public static void Main()
{
    float x1 = Convert.ToInt32(Console.ReadLine());
    float y1 = Convert.ToInt32(Console.ReadLine());
    float z1 = Convert.ToInt32(Console.ReadLine());
    float x2 = Convert.ToInt32(Console.ReadLine());
    float y2 = Convert.ToInt32(Console.ReadLine());
    float z2 = Convert.ToInt32(Console.ReadLine());
     
    // function call
    // for distance
    distance(x1, y1, z1,
             x2, y2, z2);
}
}


