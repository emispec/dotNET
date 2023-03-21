/*
Elegir 5 fórmulas de tu preferencia y armar una aplicación en C# para cada una de ellas.

Sugerencias:
- Interés simple: IS = Capital * Interes * Plazo
- Punto de Equilibrio: PE = Costos FIjos / (Precio de Venta - Costos Variables)
- ¿Tengo muchos gastos fijos? = Gastos Fijos / Ingresos
- ¿Tengo muchos gastos variables? = Gastos Variables / Ingresos
- Funciones trigonométricas como seno y coseno
*/

//MAIN
SelectorOperacion();

//------  FUNCIONES -------
void SelectorOperacion() {
    Console.WriteLine("Seleccione el numero de la operacion que desea");
    Console.WriteLine(@"1) Interes simple
2) Punto de equilibrio
3) Calculadora de gasto fijo
4) Calculadora de gastos variables
5) Trigonometria: Coseno");
    string? opcion = Console.ReadLine();
    Selector(opcion);
}

//SELECCION DE OPCION
void Selector(string opcion)
{
    switch(opcion)
    {
    case "1":
        Console.WriteLine($"Su interes simple es: {Operacion1()}");
        break;
    case "2":
        Console.WriteLine($"Su punto de equilibrio es: {Operacion2()}");
        break;
    case "3":
        Console.WriteLine($"Sus gastos fijos son de ${Operacion3()}.");
        break;
    case "4":
        Console.WriteLine($"Sus gastos variables son de ${Operacion4()}.");
        break;
    case "5":
        Console.WriteLine($"El coseno es {Operacion5()}.");
        break;
    default:
        Console.WriteLine("No reconozco la opcion.\n Pruebe de nuevo.");
        SelectorOperacion();
        break;
    }
}

//OPERACION 1
double Operacion1()
{
    Console.WriteLine("Ingrese su capital: ");
    double capital = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese su interes: (EJ 6% = 0.06) ");
    double interes = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el plazo en meses: ");
    int meses = Convert.ToInt32(Console.ReadLine());

    return (capital * interes) * meses;
}

//OPERACION 2
double Operacion2()
{
    Console.WriteLine("Ingrese costos fijos: ");
    double costosFijos = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el precio de venta: ");
    double precioVEnta = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese costos variables: ");
    double costosVariables = Convert.ToDouble(Console.ReadLine());

    return Math.Round(costosFijos / (precioVEnta - costosVariables),2);
}

//OPERACION 3
double Operacion3()
{
    Console.WriteLine("Ingrese sus gastos fijos: ");
    double gastosFijos = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese sus ingresos: ");
    double ingresos = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese costos variables: ");

    return gastosFijos / ingresos;
}

//OPERACION 4
double Operacion4()
{
    Console.WriteLine("Ingrese sus gastos variables: ");
    double gastosVariables = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese sus ingresos: ");
    double ingresos = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese costos variables: ");

    return gastosVariables / ingresos;
}

//OPERACION 5
double Operacion5()
{
    Console.WriteLine("Ingrese numero para calcular su coseno: ");
    double num = Convert.ToDouble(Console.ReadLine());

    return Math.Round(Math.Cos(num),5);
}