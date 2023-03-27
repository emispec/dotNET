// TXT: creacion, escritura y lectura

//importar libreria input/output
using System.IO;

/*
Los archivos podemos abrirlos en modo lectura, modo escitura(sobreescribe), y en modo append (que añade sin borrar).
*/

//Crear un archivo y escribir en el mismo(SI modifica y borra lo anterior escrito)
//usando StreamWriter

try
{
    // el segundo argumento del streamreader es un bool para saber si entramos en modo append.
    StreamWriter sw = new StreamWriter("miArchivo.txt", true);
    sw.WriteLine("Probando escribir en el archivo...");
    sw.WriteLine("escribiendo ...");
    sw.WriteLine("Añadiendo linea... -> append ");
    sw.Close();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: "+ ex.Message);
}

//leer un archivo en la carpeta del proyecto
//usando StreamReader
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

