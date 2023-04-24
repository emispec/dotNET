/*
DELEGADOS

Referencia a un metodo
Declarar una varible que nos lleva a un metodo.

<modificador de acceso> delegate <tipo de retorno> <nombre> (<parametros>[]);

public delegate void ImprimirDocDelegado(string path);
*/

System.Console.WriteLine("Escribe un mensaje para el delegado: ");
string msg = Console.ReadLine();
/*
ImprimirDelegadoClase obj = ImprimirDelegadoClase();
obj.EjemploDelegado(msg);
*/

//usando Action<string>
/*
ImprimirActionClase obj = new ImprimirActionClase();
obj.EjemploAction(msg);
*/
//USANDO ANONIMO
ImprimirConDelegadoAnonimo obj = new ImprimirConDelegadoAnonimo();
obj.EjemploConDelegadoAnonimo(msg);


public delegate void ImprimirDelegado(string value);

public class ImprimirDelegadoClase
{
    private void Imprimir(string value)
    {
        Console.WriteLine($"he recibido este valor: {value}");
    }

    public void EjemploDelegado(string str)
    {
        //declaracion
        ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Imprimir);
        //invocacion - call al metodo
        imprimirDelegado(str);

    }
}

public class ImprimirActionClase
{
    private void Imprimir(string msg)
    {
        Console.WriteLine(msg);
    }
    public void EjemploAction(string msg)
    {
        Action<string> imprimirDelegadoAction = Imprimir;
        imprimirDelegadoAction(msg);
    }
}

public class ImprimirConDelegadoAnonimo
{
    public void EjemploConDelegadoAnonimo(string msg)
    {
        /* Definicion anonima normal
        Action<string> imprimirConAction = delegate (string msg)
        {
            Console.WriteLine($"Desde delegado anonimo: {msg}");
        };
        */
        //definicion con Lambda
        Action<string> imprimirConActionLambda = x => System.Console.WriteLine($"Imprimir desde anonima lambda {x}");
        //imprimirConAction(msg);
        imprimirConActionLambda(msg);

        //FUNC
        Func<int, string> resultado = v => $"el resultado es: {v} ";
        System.Console.WriteLine(resultado(5));
        //recibe un int y devuelve string

        //PREDICATE
        Predicate<int> esMayor = e => e >= 18;
        bool mayorDeEdad = esMayor(21); //TRUE
    }
}

