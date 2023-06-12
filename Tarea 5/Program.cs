/*
Obligatorios
 El usuario debe ingresar la cantidad de registros a cargar (+1)
 El usuario debe introducir el monto, con decimales, del abono
registrado (+1)
 Una vez transcurrida la carga de todos los registros, se deben
mostrar las siguientes estadísticas descriptivas: máximo,
mínimo, promedio, cantidad y sumatoria (+2)

Recomendados
 [+2] La aplicación de consola debe proveer un menú que permita
al usuario listar todos los datos y acceder a cada una de las
estadísticas descriptivas, por separado
 [+2] La compañía quiere aplicar un ajuste por prima de riesgo a
cada abono, y ver el resultado en pantalla.
o El ajuste se calcula así:

NuevoAbono = Abono * (1 + Prima)
Prima = AbonoMax / AbonoMin

 [+1] Dar al usuario la posibilidad de introducir el monto de la
prima, en vez de calcularla por código

*/

System.Console.WriteLine("Ingrese la cantidad de registros: ");
int registros = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Introducir valor PRIMA: ");
double prima = Convert.ToDouble(Console.ReadLine());

double[] datos = new double[registros];
double[] datosConPrima = new double[registros];

for (int i = 0; i < datos.Length; i++)
{
    System.Console.WriteLine("Introducir el monto del abono: ");
    datos[i] = Convert.ToDouble(Console.ReadLine());

    datosConPrima[i] = datos[i] * (1 + prima);
}

// ESTADISTICAS
double maximo = datos.Max();
double minimo = datos.Min();
double promedio = datos.Average();
double sumatoria = datos.Sum();

// MENU
System.Console.WriteLine(@"
Seleccione la opcion
---------------------
1. Maximo
2. Minimo
3. Promedio
4. Cantidad
5. Sumatoria
6. Ver valores
7. Ver valores (con PRIMA)
8. Salir
");

int opcionMenu = Convert.ToInt32(Console.ReadLine());

switch (opcionMenu)
    {
        case 1:
            Console.WriteLine($"El valor máximo es: {maximo}");
            break;

        case 2:
            Console.WriteLine($"El valor mínimo es: {minimo}");
            break;

        case 3:
            Console.WriteLine($"El promedio es: {promedio}");
            break;

        case 4:
            Console.WriteLine($"La cantidad de números es: {registros}");
            break;

        case 5:
            Console.WriteLine($"La sumatoria es: {sumatoria}");
            break;

        case 6:
            Console.WriteLine("Los numeros son:");
            foreach (int dato in datos)
            {
                Console.WriteLine(dato);
            }
            break;

        case 7:
            Console.WriteLine("Los valores con prima son:");
            foreach (int dato in datosConPrima)
            {
                Console.WriteLine(dato);
            }
            break;

        case 8:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opcion invalida");
            break;
    }
