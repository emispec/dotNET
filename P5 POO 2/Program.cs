using System.Globalization;
//LINQ

//1.Nuestro origen de datos
int[] numbers = new int[10] {1,2,3,4,5,6,7,8,9,10};
string[] words = new string[5] {"Ana", "Maria", "Juan", "Carlos", "Pepe"};
//2. obtener datos con una consulta
//seleccionar numeros pares.

var pares =
    from numero in numbers
    where (numero %2) == 0
    select numero;
//seleccionar numeros impares
var impares =
    from numero in numbers
    where (numero %2) == 1
    select numero;
//Conslta en nombres
var nombres =
    from el in words
    where (el.Length > 3)
    select el;
//3. Ejecutar la consulta
foreach (var num in pares)
{
    Console.WriteLine(num);
}

foreach (var num in impares)
{
    Console.WriteLine(num);
}

EscribirConsulta(words);

void EscribirConsulta(string[] nombres)
{
    foreach (var el in nombres)
    {
        Console.WriteLine(el);
    }
}