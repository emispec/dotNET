using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//SEALED NO nos permite hacer otra instancia de esa clase.
public sealed class Singleton
{
    static Singleton()
    {

    }

    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        //lazy inicialization
        return _instance ??= new Singleton();
        /*
        Es lo mismo que esto:
        if(_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
        */
    }

    public static void MiMetodo()
    {
        Console.WriteLine("Hola desde MiMetodo");
    }
}