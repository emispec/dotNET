//Crear archivos TXT y realizar operaciones

//importar libreria input/output
using System.IO;

string texto;

try
{
    StreamReader sr = new StreamReader("miArchivo.txt");
    var linea = sr.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close(); //cerramos el stream asociado al archivo.
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: "+ ex.Message);
}
finally
{
    Console.WriteLine("Final del try-catch-finally");
}
