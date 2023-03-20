using System.Text;
using System.Security.AccessControl;
//STRINGS
string str = "abcde";

//accedemos a una posicion en concreto del string
Console.WriteLine(str[1]); // b

//literales

Console.WriteLine();

//Caracteres escapados
// \r = rows. para filas
// \t = caracter de tabulador.
string columns = "column 1\tcolumn 2\tcolumn 3";
string contenido = "contenido\tcontenido\tcontenido";
// \n = salto de linea
Console.WriteLine(columns+"\n"+contenido);

//mensaje multilinea @" msg "
//es mas eficiente que estar poniendo \n linea por linea.

Console.WriteLine(@"hola,
este es un mensaje
multilinea.");

//interpolacion $" mensaje {var}"

var persona = (nombre: "carlos", nacimiento: 1989, lenguaje: "python");
Console.WriteLine($"El programador {persona.nombre} de {2023 - persona.nacimiento}, se especializa en el lenguaje {persona.lenguaje}. ");

//subcadenas 
string msg = "Este es mi mensaje";

// substring: 2 argumentos. el indice de donde empieza y termina.
string msg2 = msg.Substring(0,10); // "este es mi"
Console.WriteLine(msg2);

// replace: 2 argumentos. que queremos reemplazar y porque lo queremos reemplazar.
string msg3 = msg.Replace("mensaje","saludo");
Console.WriteLine(msg3);

// Trim: elimina espacios al ppio y final de la cadena. para limpiar espacios.
string msg4 = msg3.Trim();

//indexOf: para encontrar caracter. nos devuelve el indice donde lo encuentra. (entero)
int indice = msg.IndexOf("m");
Console.WriteLine(indice);

// Stringbuilder


//importamos asi o usamos un globalusings
StringBuilder strBuilder = new StringBuilder("hola, mundo !");
Console.WriteLine(strBuilder[0]); //H
Console.WriteLine(strBuilder); // Hola, mundo.

//Transformar una cadena a numero si es posible
int i = 0;
string s = "121212";
// TryParse va a cambiar un string a numero. Si es posible en este caso se guarda un boolean True en la variable result, sino false.
//Los argumentos son (lo que recibe, out donde se guarda); En este caso tomamos el string s y si podemos convertirlo se guardara en la variable i.
bool result = int.TryParse(s, out i);
Console.WriteLine(result + ", i: "+i); // True, i: 121212

//ej2 pasando de string a float:
float h = 0f;
string x = "12122.122";
bool resultado = float.TryParse(x, out h);
Console.WriteLine(resultado + ", h: "+h);

//ARRAYS

int[] arr = new int[2];

string[] names = new string[2];
names[0] = "John";
names[1] = "Michael";

//recorriendo el array con un foreach
foreach(string name in names) {
    Console.WriteLine(name);
}
//lo mismo que el forEach pero con un FOR
for (int j = 0; j < names.Length; j++)
{
    Console.WriteLine(names[j]);
}

//asignando directactamente los valores
int[] numbers = {7, 5, 2, 1, 6};

//usamos un Sort que es un metood de array para ordenar de menor a mayor los elementos.
Array.Sort(numbers);

foreach(int num in numbers) {
    Console.WriteLine(num);
}

// Array en 2 dimensiones

int[,] miArr2D = new int[2, 2];

//guardando datos
miArr2D[0,0] = 1;
miArr2D[0,1] = 2;
miArr2D[1,0] = 3;
miArr2D[1,1] = 4;

for (int k = 0; k < miArr2D.GetLength(0); k++)
{
    for (int l = 0; l < miArr2D.GetLength(1); l++)
    {
        Console.WriteLine(miArr2D[k,l]);
    }
}