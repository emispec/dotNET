/*
//DateTime
var ahora = DateTime.Now;
var hora = ahora.ToLongTimeString();
var fecha = ahora.ToShortDateString();
Console.WriteLine(ahora);
Console.WriteLine(hora);
Console.WriteLine(fecha);

//le paso horas y minutos (tmb segundos, miliseg..)
TimeOnly soloHora = new TimeOnly(15,0);
Console.WriteLine(soloHora);
//le paso año, mes, y dia.
DateOnly soloFecha = new DateOnly(1986,9,4);
Console.WriteLine(soloFecha);
*/

//INTERFACES
/*
var persona = new Persona();
Console.WriteLine($"Bienvenido {persona.Nombre}");

public class Persona : IPersonas
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int Edad {get; set;}
    public bool EnActivo {get; set;}
    public DateOnly FechaNacimiento {get; set;}

    //Metodos
    public Persona()
    {
        PreguntarDatos();
        EscribirDatos();
    }
    public void PreguntarDatos() 
    {
        Console.WriteLine("Cual es tu nombre?");
        var nombre = Console.ReadLine();
        if (nombre == null)
        {
            Console.WriteLine("introduzca un nombre valido.");
        }
        else
        {
            Nombre = nombre;
        }
        Console.WriteLine("Cual es tu fecha nacimiento");
        var fecha = Console.ReadLine();
        FechaNacimiento = DateOnly.Parse(fecha);
    }

    public void EscribirDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}, Nacimiento: {FechaNacimiento}");
    }
}

public interface IPersonas
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int Edad {get; set;}
    public bool EnActivo {get; set;}
    public DateOnly FechaNacimiento {get; set;}

    //Metodos

    public void PreguntarDatos();
    public void EscribirDatos();
}
*/

