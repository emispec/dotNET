//usings necesarios
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

//ASINCRONIA
Stopwatch sw = Stopwatch.StartNew();
//funcion sin nombre lambda
var task1 = new Task(()=>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 1: {crono.Elapsed}");

});

//Task 2
var task2 = new Task(()=>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1500);
    crono.Stop();
    Console.WriteLine($"Task 2: {crono.Elapsed}");

});

//Task 3
var task3 = new Task(()=>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(2500);
    crono.Stop();
    Console.WriteLine($"Task 3: {crono.Elapsed}");

});


task1.Start();
task2.Start();
task3.Start();

await task1;
await task2;
await task3;

var str = await RandomAsync();
Console.WriteLine(str);

sw.Stop();
Console.WriteLine($"Todo el programa demora {sw.Elapsed}");


static async Task<string> RandomAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    Thread.Sleep(1000);
    sw.Stop();
    var str = $"{num.ToString()} calculado en: {sw.Elapsed}";
    return str;
}