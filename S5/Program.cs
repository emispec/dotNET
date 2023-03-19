/*
Ejercicio 1 - If

Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón

Nota: puedes poner un precio fijo de un producto o uno variable.
*/

int precio = 100;

Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su email: ");
string email = Console.ReadLine();
Console.WriteLine("Posee cupon de descuento 10%? si / no: ");
string cupon = Console.ReadLine().ToLower();

if (cupon == "si") {
    Console.WriteLine($"El precio es de ${precio}. Con su descuento el nuevo total es: {precio - ((precio*10)/100)}");
} else {
    Console.WriteLine($"El precio es de ${precio}.");
}

/*
Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#
*/

List<string> lang = new List<string>() { "C#", "Java", "C++" };

foreach (var item in lang)
{
   Console.WriteLine(item);
}

Console.WriteLine("Seleccione uno de los tres lenguajes: ");
string opcion = Console.ReadLine().ToLower();

switch(opcion) {
    case "c#":
        Console.WriteLine("Hola mundo C# !");
        break;
    case "java":
        Console.WriteLine("Hola mundo Java !");
        break;
    case "c++":
        Console.WriteLine("Hola mundo C++ !");
        break;
    default:
        Console.WriteLine("No conozco ese lenguaje.");
        break;
}