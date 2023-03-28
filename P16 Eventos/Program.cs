//EVENTOS

SuscriptorCalc calculadora = new SuscriptorCalc(1,2);

calculadora.ResultadoSuma();
calculadora.ResultadoResta();

//DELEGATE

public class Editor
{
    public delegate void EjemploEvento();
    public event EjemploEvento ejemploEvento;
}

public class EditorCalc
{
    public delegate void EjemploDelegado();
    public event EjemploDelegado ejemploEvento;

    public void Sumar(int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            System.Console.WriteLine($"La suma es: {a + b}");
        }
        else
        {
            System.Console.WriteLine("no tienes una subscripcion al evento!");
        }
    }

    public void Restar(int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            System.Console.WriteLine($"La resta es: {a - b}");
        }
        else
        {
            System.Console.WriteLine("No tiens una subscripcion al evento !");
        }
    }
    public void Saludar()
    {
        System.Console.WriteLine("Hola");
    }
}

//SUSCRIPTOR

public class SuscriptorCalc
{
    EditorCalc editor;

    private readonly int A;
    private readonly int B;

    public void EjemploEventHandler()
    {
        System.Console.WriteLine("Se imprime el resultado de la operacion: ");
    }
    
    public SuscriptorCalc(int a, int b)
    {
        editor = new EditorCalc();
        A = a;
        B = b;
        editor.ejemploEvento += EjemploEventHandler;
    }

    public void ResultadoSuma()
    {
        editor.Sumar(A,B);
    }

    public void ResultadoResta()
    {
        editor.Restar(A,B);
        editor.Saludar();
    }
}
