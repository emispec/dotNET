//FUNCIONES


//EJ 1

int resultado = CalcularCuadrado(2);

int CalcularCuadrado(int m){
    return m+m;
}

Console.WriteLine(resultado);

//EJ 2
CalcularAprobado(5);
CalcularAprobado(1);
CalcularAprobado(10);

void CalcularAprobado(int a) {
    if(a < 5) {
        Console.WriteLine("Estas reprobado.");
    } else if(a == 5) {
        Console.WriteLine("Aprobado raspando");
    } else {
        Console.WriteLine("Estas aprobado !");
    }
}

// Funciones anonimas
// (input-parameters) => expression
int[] numbers = {2, 3, 4, 5};
var squaredNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squaredNumbers));

//METODOS
/*
var moto = new Motos();

moto.Arrancar();
class Motos {
    public void Arrancar() {
        Console.WriteLine("arrancando !!");
    }
}
*/
// STATIC


Motos.Arrancar();

var moto = new Motos();
//Retorno de metodos
int gasolina = moto.CantidadGasolina();
Console.WriteLine($"Nos quedan {gasolina} litros de combustible");

//Sobrecarga de metodos
float calculo = moto.CalcularSuma(2.3f, 2.7f);
Console.WriteLine(calculo);

class Motos {

    public static void Arrancar() {
        Console.WriteLine("Arrancando la moto !");
    }

    public int CantidadGasolina(){
        int gasolina = 20;
        return gasolina;
    }

    //Sobrecarga de metodos
    // 1 metodo que acepta 2 int, otro con 3 int, y uno con 2 floats. todos con la misma firma.
    public int CalcularSuma(int a, int b) {
        return a + b;
    }

    public int CalcularSuma(int a, int b, int c) {
        return a + b + c;
    }

    public float CalcularSuma(float a, float b) {
        return a + b;
    }

}
