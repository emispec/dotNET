/* Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
*/
Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido");
string apellido = Console.ReadLine();
Console.WriteLine("Cual es su edad?");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe programar?");
string programar = Console.ReadLine();
//SALIDA
Console.WriteLine("Bienvenido "+nombre+" "+apellido+" , su edad es "+edad+" y usted "+programar+" sabe programar.");