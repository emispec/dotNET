/*
Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
*/

Console.WriteLine("Ingrese un numero del 1-10: ");
int num = Convert.ToInt32(Console.ReadLine());

int contador = 1;

while(contador <= 10){
    Console.WriteLine($"{contador} x {num} = {contador*num}");
    contador++;
}

/*
Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
*/

int numero = 0;
int contadorPositivo = 0;
int contadorNegativo = 0;

do {
    Console.WriteLine("Ingrese un numero (con 0 se frena ejecucion): ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero > 0) {
    Console.WriteLine("El numero es positivo !");
    contadorPositivo++;
} else if (numero < 0) {
    Console.WriteLine("El numero es negativo !");
    contadorNegativo++;
} else {
    Console.WriteLine("El numero es 0. Se finaliza el programa");
    Console.WriteLine($"El total de numeros positivos es: {contadorPositivo}");
    Console.WriteLine($"El total de numeros negativos es: {contadorNegativo}");
}
} while(numero != 0);


/*
Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* *

* *

***
*/

Console.Write("Introduce el ancho: ");
int ancho = Int32.Parse(Console.ReadLine());

Console.Write("Introduce el alto: ");
int alto = Int32.Parse(Console.ReadLine());

Console.Write("Introduce 0 para no rellenar o 1 para rellenar: ");
int relleno = Int32.Parse(Console.ReadLine());

Console.Write("Introduce el número de cuadrados o rectángulos que se deben dibujar: ");
int cantidad = Int32.Parse(Console.ReadLine());

for (int c = 0; c < cantidad; c++) {
    if (ancho == alto) {
        for (int i = 0; i < alto; i++) {
            for (int j = 0; j < ancho; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else {
        for (int i = 0; i < alto; i++) {
            for (int j = 0; j < ancho; j++) {
                if (i == 0 || i == alto - 1 || j == 0 || j == ancho - 1 || relleno == 1) {
                    Console.Write("*");
                }
                else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}