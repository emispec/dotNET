using System;
//Generic
/*
Generic<string> str = new Generic<string>();

str.Campo = "dato";

Console.WriteLine($"Generic.Campo : {str.Campo}");
Console.WriteLine($"Tipo de Generic.Campo : {str.Campo.GetType().FullName}");
public class Generic<T>
{
    public T Campo { get; set; }
}
*/

//HERENCIA Y POLIMORFISMO

Vehiculo vehiculo = new Vehiculo();
vehiculo.Arrancar();

Coche coche = new Coche();
coche.Arrancar();
coche.DetenerCoche();
coche.TocarBocina();

Moto moto = new Moto();
moto.TocarBocina();




class Vehiculo 
{
    public float combustible { get; set; }
    public int aforo { get; set; }

    public void Arrancar()
    {
        Console.WriteLine("Arrancando...");
    }

    public virtual void TocarBocina()
    {

    }

}

class Coche : Vehiculo {
    public int ruedas { get; set; } 

    public void DetenerCoche()
    {
        Console.WriteLine("Deteniendo...");
    }

    public override void TocarBocina()
    {
        Console.WriteLine("Prummm (bocina de auto)");
    }
}

class Moto : Vehiculo {
    public int ruedas { get; set; } 

    public void DetenerCoche()
    {
        Console.WriteLine("Deteniendo...");
    }

    public override void TocarBocina()
    {
        Console.WriteLine("Piii Piii (bocina de moto)");
    }
}

//INTERFACES
// se implementan con palabra reservada interface y el nombre de la misma empieza con con I mayuscula.


public interface IVehiculo
{
    public string Marca {get; set;}
    //declaro un metodo pero no especifico como va a ser la implementacion. eso depende de cada clase que la herede.
    void Cambio();
}

class Cuatri : IVehiculo
{
    public string Marca {get; set;}
    void IVehiculo.Cambio()
    {
        Console.WriteLine("Cambio de marcha");
    }
}

