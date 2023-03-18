/*
Ejercicio 1

Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
*/
Cliente cliente1 = new Cliente("Carlos Sanchez", "15 44431-5323", "Usuario123@gmail.com",true);

cliente1.PresentarDatos();

Cliente cliente2 = cliente1 with { Nombre = "Arturo Rodriguez", Telefono = "15 888-1312", Email = "pepe@gmail.com", NuevoCliente = false};

cliente2.PresentarDatos();

public struct Cliente {
    public Cliente(string nombre, string telefono, string email, bool nuevoCliente){
        Nombre = nombre;
        Telefono = telefono;
        Email = email;
        NuevoCliente = nuevoCliente;
    }

    public string Nombre {get; set;}
    public string Telefono {get; set;}
    public string Email {get; set;}
    public bool NuevoCliente {get; set;}

    //public override string ToString() => $"Nombre: {Nombre} / Telefono: {Telefono} / Email: {Email} / Nuevo: {NuevoCliente}";

    public void PresentarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Teléfono: {Telefono}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"¿Es nuevo cliente?: {(NuevoCliente ? "Sí" : "No")}");
    }
}