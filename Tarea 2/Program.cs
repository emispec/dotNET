/*
- Desarrollar una calculadora del precio final de un artículo. El usuario debe ingresar el peso y el precio por kg del artículo. El precio final sería el resultado de multiplicar el peso por el precio por kg.

- Nivel 2: Considerar en el ejercicio que el usuario puede ingresar el peso en gramos y miligramos

- Nivel 3: El precio final se ve afectado por impuestos, que suman el 21% al precio final.

- Nivel 4: Considerar costos de envío. Para ello, el programa debe solicitar al usuario el método de envío. Los métodos de envío son los siguientes: retiro en el local (gratis), envío a Capital (+5%), envío al interior de Argentina (+10%), envío al extranjero (+15%)
*/
System.Console.WriteLine(@"Seleccione unidad:
1) Kg
2) Gr
3) Mg");

int unidad;
while (!int.TryParse(Console.ReadLine(), out unidad) || unidad < 1 || unidad > 3)
{
    System.Console.WriteLine("La opción ingresada no es válida. Intente de nuevo.");
    System.Console.WriteLine(@"Seleccione unidad:
    1) Kg
    2) Gr
    3) Mg");
}

System.Console.WriteLine("Ingrese el peso: ");

double peso;
while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
{
    System.Console.WriteLine("El peso ingresado no es válido. Intente de nuevo.");
    System.Console.WriteLine("Ingrese el peso: ");
}

System.Console.WriteLine("Ingrese el precio por kilo: ");

double precio;
while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
{
    System.Console.WriteLine("El precio ingresado no es válido. Intente de nuevo.");
    System.Console.WriteLine("Ingrese el precio por kilo: ");
}

System.Console.WriteLine(@"Seleccione envio:
1) Retiro en local (Gratis)
2) Envio a capital (5%)
3) Envio al interior (10%)
4) Envio al extranjero (15%)");

int envio;
while (!int.TryParse(Console.ReadLine(), out envio) || envio < 1 || envio > 4)
{
    System.Console.WriteLine("La opción ingresada no es válida. Intente de nuevo.");
    System.Console.WriteLine(@"Seleccione envio:
    1) Retiro en local (Gratis)
    2) Envio a capital (5%)
    3) Envio al interior (10%)
    4) Envio al extranjero (15%)");
}

double impuesto = 0.21;
double total;

if (unidad == 2)
{
    total = precio * (peso/1000);
}
else if (unidad == 3)
{
    total = precio * (peso/1000000);
}
else
{
    total = precio * peso;
}

if (envio == 2)
{
    total += total*0.05;
}
else if (envio == 3)
{
    total += total*0.10;
}
else if (envio == 4)
{
    total += total*0.15;
}

total += total*impuesto;

System.Console.WriteLine($"Su total es: ${Math.Round(total, 2)}");
