int [] arr = new int []{1,2,3,4,5};

for (int i=0; i<arr.Length/2; i++)
{
    int tmp = arr[i];
    arr[i] = arr[arr.Length - (i+1)];
    arr[arr.Length - (i+1)] = tmp;
}
Console.Write("END");
//Process.Start();
