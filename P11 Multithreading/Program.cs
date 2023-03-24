//MULTITHREADING
using System;
using System.Diagnostics;
using System.Threading;

//queremos delegar en hilos secundarios las tareas que nos demandan mas tiempo
/*
//sin MT
Stopwatch crono = new Stopwatch();
crono.Start();

//tarea 1
Thread.Sleep(1000);
//tarea 1
for (int i = 0; i < 100000; i++)
{
    i *=1;
}
//tarea 1
Thread.Sleep(1000);

crono.Stop();
Console.WriteLine("Este programa ha tardado " + crono.Elapsed);
*/

//Main Thread
Thread hiloPrincipal = Thread.CurrentThread;
hiloPrincipal.Name = "hilo principal";
Console.WriteLine($"Estamos en el hilo: {hiloPrincipal.Name}");

Stopwatch crono = Stopwatch.StartNew();

//TASK 1
var task1 = new Task( ()=> {
    Stopwatch crono = Stopwatch.StartNew();

    Thread.Sleep(1000); //parar este hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"1. Este hilo ha tardado: {crono.Elapsed}");
});

//TASK 2
var task2 = new Task( ()=> {
    Stopwatch crono = Stopwatch.StartNew();

    Thread.Sleep(1000); //parar este hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"2. Este hilo ha tardado: {crono.Elapsed}");
});

//TASK 3
var task3 = new Task( ()=> {
    Stopwatch crono = Stopwatch.StartNew();

    Thread.Sleep(1000); //parar este hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"3. Este hilo ha tardado: {crono.Elapsed}");
});

//inicializamos las tasks
task1.Start();
task2.Start();
task3.Start();

//Recibir las tareas
await Task.WhenAll(task1, task2, task3);
/* Podemos usar await task para cada tarea individual o de forma colectiva con WhenAll.
await task1;
await task2;
await task3;
*/
crono.Stop();
Console.WriteLine($" Todo el programa ha tardado: {crono.Elapsed}");
//Recolectamos los tasks completados

// Finalizamos el programa

/*
static void IniciarHilos()
{
    Console.WriteLine($"iniciando hilo nuevo...");
    Console.WriteLine("Finalizando tareas");
}
*/