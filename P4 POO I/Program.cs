/*
//PUBLIC

Persona alumno = new Persona();
alumno.nombre = "Roger";
alumno.fechaNacimiento = Convert.ToDateTime("10/10/1996");
alumno.registrar();

public class Persona
{
    //Atributos
    public string nombre;
    public DateTime fechaNacimiento;
    private int edad;

    //Metodos
    public void registrar()
    {
        calcularEdad(fechaNacimiento);
        Console.WriteLine($"{nombre} con {edad} años de edad, ha sido registrado correctamente.");
    }

    private void calcularEdad(DateTime fechaNacimientoPersona)
    {
        DateTime fechaActual = DateTime.Now;
        edad = fechaActual.Year - fechaNacimientoPersona.Year;
    }

}
*/
//EJ Private

//MAIN
Console.WriteLine(Persona.experiencia);
Persona.mostrarExperiencia();
Persona alumno = new Persona();


public class Persona
{
    //Atributos
    public static string experiencia = "C#";
    private string _nombre;
    private DateTime _fechaNacimiento;
    private int _edad;
    

    //Metodos
    public int Edad
    {
        get
        {
            return _edad;
        }

        private set
        {
            _edad = value;
        }
    }

    public string Nombre
    {
        get
        {
            return _nombre;
        }

        private set
        {
            _nombre = value;
        }
    }

    public DateTime fechaNacimiento
    {
        get
        {
            return _fechaNacimiento;
        }

        private set
        {
            _fechaNacimiento = value;
        }
    }

    //Metodos
    private void registrar()
    {
        calcularEdad(_fechaNacimiento);
        Console.WriteLine($"{_nombre} con {_edad} años de edad, ha sido registrado correctamente.");
    }

    private void calcularEdad(DateTime fechaNacimientoPersona)
    {
        DateTime fechaActual = DateTime.Now;
        _edad = fechaActual.Year - fechaNacimientoPersona.Year;
    }

    public static void mostrarExperiencia()
    {
        Console.WriteLine($"La experiencia es en {experiencia}");
    }
}