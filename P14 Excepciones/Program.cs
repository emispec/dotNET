// Excepciones

try
{
    Console.WriteLine($"1 entre 0: {DivisionSegura(1, 0)}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERR:  {ex.Message}");
}
//si capturamos la Exception podemos continuar con el programa.
Console.WriteLine($"1 entre 2: {DivisionSegura(1,2)}");

int[] arr = new int[3];
arr[0] = 0;
arr[1] = 1;
arr[2] = 2;
//Console.WriteLine(arr[3]); probar error "index outside the bounds of the array"

try
{
    Console.WriteLine(arr[3]);
}
catch (Exception ex)
{
    Console.WriteLine($"ERR: {ex.Message}");
}
finally
{
    //logica para que el usuario verifique si el valor es correcto.
    Console.WriteLine("Es correcto el valor que aparece?");
}



static double DivisionSegura(double a, double b)
{
    if (a == 0 || b == 0)
    {
        throw new DivideByZeroException();
    }
    return a/b;
}


// NullReferenceException
try
{
    object obj = null;
    obj.ToString();
}
catch (Exception ex)
{
    Console.WriteLine($"ERR: {ex.Message}");
}


//ArgumentOutOfRangeException
try
{
    string str = "string";
    str.Substring(0, str.Length + 1);
}
catch (Exception ex)
{
    Console.WriteLine($"ERR: {ex.Message}");
}

