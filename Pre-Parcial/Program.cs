/*
Diseñar un programa para calcular la nota final del exámen de matemáticas

Requerimientos
* El programa debe iniciarse solicitando la cantidad de respuestas correctas
* El programa debe solicitar, luego, la cantidad de respuestas incorrectas
* El programa debe solicitar, luego, la cantidad de respuestas en blanco.
* El programa debe, finalmente, mostrar la nota del alumno.
* Para calcular la nota se suma 1 punto por cada respuesta correcta y se resta 0.5 puntos por cada respuesta incorrecta. Si hay más del 25% de las respuesta en blanco, entonces se restan 2 puntos a la nota final.

Mandar comprimido a sebastian.ledesma@istea.com.ar
*/

System.Console.WriteLine("Ingrese cantidad de respuestas correctas: ");
int correctas = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ingrese cantidad de respuestas incorrectas: ");
int incorrectas = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ingrese cantidad de respuestas en blanco: ");
int enBlanco = Convert.ToInt32(Console.ReadLine());

int respTotales = correctas + incorrectas + enBlanco;

double nota = correctas - (0.5*incorrectas);

if(enBlanco > (respTotales*25/100))
{
    nota -= 2;
}

System.Console.WriteLine($"La nota final es: {nota}");