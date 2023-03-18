/* 
E1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
*/
Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido");
string apellido = Console.ReadLine();
Console.WriteLine("Cual es su edad?");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe programar?");
string programar = Console.ReadLine();

Console.WriteLine("Bienvenido "+nombre+" "+apellido+" , su edad es "+edad+" y usted "+programar+" sabe programar.");

/* 
E2
Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

//COCHE
int puertas = 3;
int rodado = 17;
string marca = "BMW";
bool itvVigente = true;

Console.WriteLine("Marca: "+marca+" / Ptas: "+puertas+" / Rodado: "+rodado);
Console.WriteLine("ITV: "+itvVigente);

//MESA
float peso = 273.23f;
float largo = 2.50f;
string material = "Marmol";
string color = "Negro";

Console.WriteLine("Peso: "+peso+" / Largo: "+largo+" / Material: "+material+" / Color: "+color);

/* 
E3
Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

int num = 12;
Console.WriteLine(num>=18);

const char a = 'a';
char letra = 'a';
Console.WriteLine(letra == a);

Console.WriteLine((a == letra) && (num >= 5));

Console.WriteLine((3 > 2) && (6 == 4));