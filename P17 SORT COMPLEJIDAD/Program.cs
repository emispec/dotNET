using System.Diagnostics;
int[] arr;
System.Console.WriteLine("Introduce el numero de elementos: ");
var N = Convert.ToUInt32(Console.ReadLine());

arr = new int[N];

for (int i = 0; i < N; i++)
{
    arr[i] = 1;
}
Stopwatch crono = new Stopwatch();
crono.Start();

for (int j = 0; j < N; j++)
{
    for (int k = 0; k < N; k++)
    {
        arr[k] = j + k; 
    }
}
crono.Stop();
System.Console.WriteLine($"Para N: {N} elementos, se tarda: {crono.Elapsed}");