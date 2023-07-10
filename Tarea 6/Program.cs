/*
1. La aplicación debe solicitar la cantidad de ventas a procesar
2. La aplicación debe permitir cargar una a una las ventas
3. La aplicación debe ofrecer un menu de opciones para generar reportes (1)
   1. Venta máxima
   2. Venta mínima
   3. Venta promedio
   4. Rendimiento por venta (2)
   5. Máximo rendimiento
   6. Mínimo rendimiento

Aclaraciones:

1. El código C# debe contar con una función definida para cada reporte. Es decir, en el código deben existir seis funciones, una para cada reporte, junto con la lógica principal del programa
2. El rendimiento por venta se calcula así: Para la primera venta, el rendimiento es cero. Para el resto se obtiene dividiendo la venta actual por la anterior (actual/anterior)
*/

// CARGA DE DATOS
System.Console.WriteLine("Ingrese la cantidad de ventas a procesar: ");
int cantidadVentas = Convert.ToInt32(Console.ReadLine());

double[] ventas = new double[cantidadVentas];

for (int i = 0; i < ventas.Length; i++)
{
    System.Console.WriteLine("Introducir el monto de la venta: ");
    ventas[i] = Convert.ToDouble(Console.ReadLine());
}

// MENU
System.Console.WriteLine(@"
Seleccione la opcion
---------------------
1. Venta maximo
2. Venta minimo
3. Venta promedio
4. Rendimiento por venta
5. Maximo rendimiento
6. Minimo rendimiento
7. Salir
");

int opcionMenu = Convert.ToInt32(Console.ReadLine());

switch (opcionMenu)
    {
        case 1:
            Console.WriteLine($"La venta maxima es {ventaMax()}");
            break;

        case 2:
            Console.WriteLine($"La venta minima es {ventaMin()}");
            break;

        case 3:
            Console.WriteLine($"La venta promedio es {ventaProm()}");
            break;

        case 4:
            Console.WriteLine(rendimientoPorVenta(ventas));
            break;
        case 5:
            Console.WriteLine($"El maximo rendimiento: {rendimientoMaximo(ventas)}");
            break;

        case 6:
            Console.WriteLine($"El minimo rendimiento: {rendimientoMinimo(ventas)}");
            break;

        case 7:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opcion invalida");
            break;
    }

//FUNCIONES
// 1
double ventaMax() {
    return ventas.Max();
}
//2
double ventaMin() {
    return ventas.Min();
}
//3
double ventaProm() {
    return ventas.Average();
}
//4
static string rendimientoPorVenta(double[] ventas) {
    string mensaje = "Rendimientos por venta:\n";

    for (int i = 1; i < ventas.Length; i++)
    {
        double rendimientoVenta = ventas[i] / ventas[i - 1];
        mensaje += $"Venta {i}: {rendimientoVenta}\n";
    }

    return mensaje;
}
//5
double rendimientoMaximo(double[] ventas) {
    double maxRen = 0;

    for (int i = 1; i < ventas.Length; i++)
    {
        double rendimientoVenta = ventas[i] / ventas[i - 1];
        if (rendimientoVenta > maxRen)
        {
            maxRen = rendimientoVenta;
        }
    }

    return maxRen;
}
//6
double rendimientoMinimo(double[] ventas) {
    double minRen = 0;

    for (int i = 1; i < ventas.Length; i++)
    {
        double rendimientoVenta = ventas[i] / ventas[i - 1];
        if (i == 1 || rendimientoVenta < minRen)
        {
            minRen = rendimientoVenta;
        }
    }

    return minRen;
}