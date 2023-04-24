using System.Security.AccessControl;
using System.Net;
using System.Collections.Generic;
//COLLECTIONS
/*
//coleccion de strings
var coches = new List<string>();
//agregando elementos a la lista
coches.Add("Ford");
coches.Add("BMW");
coches.Add("Peugeot");

//recorrer la List
foreach (var item in coches)
{
    Console.WriteLine(item);
}

//crear otra list asignandole sus valores por defecto
var coches2 = new List<string> {"Fiat" , "Audi", "VW"};

//creamos lista elemento a partir del metodo static crearlista.
List<Elemento> elemento = CrearLista();

//query en LINQ donde seleccionamos los elementos con numero atomico menor a 20.
var query = from el in elemento where el.NumeroAtomico < 20 select el;

//de esta forma no se imprime una list
Console.WriteLine(query);

//imprimimos con foreach el resultado de query que es un array.
foreach (var el in query)
{
    Console.WriteLine($"Nombre: {el.Nombre}, Simbolo: {el.Simbolo}, Numero: {el.NumeroAtomico}");
}

static List<Elemento> CrearLista()
{
    return new List<Elemento>
    {
        { new Elemento() {Simbolo = "K", Nombre = "Potasio",NumeroAtomico = 19 }},
        { new Elemento() {Simbolo = "Na", Nombre = "Sodio",NumeroAtomico = 20 }},
        { new Elemento() {Simbolo = "Ca", Nombre = "Calcio",NumeroAtomico = 22 }}
    };
}

public class Elemento
{
    public string Simbolo {get; set;}
    public string Nombre {get; set;}
    public int NumeroAtomico {get; set; }
}
*/
/*
using System;
using System.Collections.Generic;

public class Car : IComparable<Car>
{
    public string Color { get; set; }
    public int MaxSpeed { get; set; }

    public Car(string color, int maxSpeed)
    {
        Color = color;
        MaxSpeed = maxSpeed;
    }

    public int CompareTo(Car other)
    {
        return other.MaxSpeed.CompareTo(MaxSpeed);
    }

    public override string ToString()
    {
        return $"Color: {Color}, Max Speed: {MaxSpeed}";
    }
}

public class Program
{
    public static void Main()
    {
        // Crear una lista con 6 automóviles con colores aleatorios y velocidades máximas aleatorias
        Random random = new Random();
        List<Car> cars = new List<Car>();
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Black", "White" };
        for (int i = 0; i < 6; i++)
        {
            string color = colors[random.Next(colors.Length)];
            int maxSpeed = random.Next(100, 201); // La velocidad máxima será un número aleatorio entre 100 y 200
            cars.Add(new Car(color, maxSpeed));
        }

        // Imprimir la lista de automóviles sin ordenar
        Console.WriteLine("Lista de automóviles sin ordenar:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }

        // Ordenar la lista de automóviles por velocidad máxima descendente utilizando el método Sort y el interfaz IComparable
        cars.Sort();

        // Imprimir la lista de automóviles ordenada
        Console.WriteLine("\nLista de automóviles ordenada por velocidad máxima descendente:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
*/

