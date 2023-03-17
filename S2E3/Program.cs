/*
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