/*
PARCIAL 1
Emiliano Sebastian

Le solicito al usuario que ingrese costo fijo, costo variable y precio de venta, y almaceno esos datos en un array de 3 posiciones previamente declarado.
Luego imprimo por pantalla el resultado del punto de equilibrio, realizando el calculo en la misma linea.

*/

//Imprimo un saludo por pantalla
System.Console.WriteLine("Bienvenidos a la calculadora del parcial 1");

//Declaro un array que contenga 3 posiciones/datos
double[] datos = new double[3];

//Solicito al usuario que ingrese costo fijo y lo guardo en la posicion 0
System.Console.WriteLine("ingrese costo fijo: ");
datos[0] = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("ingrese costo variable: ");
datos[1] = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("ingrese precio de venta: ");
datos[2] = Convert.ToDouble(Console.ReadLine());

//Calculo el punto de equilibrio y muestro el resultado por pantalla.
System.Console.WriteLine($"Se deberian vender {datos[0]/(datos[1]- datos[2])} unidades para alcanzar el punto de equilibrio.");

