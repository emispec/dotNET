//TUPLAS
//1
(string, double, int) miTupla = ("Cesar", 1.1d, 9);

Console.WriteLine(miTupla);
Console.WriteLine($"1: {miTupla.Item1}, 2: {miTupla.Item2}, 3: {miTupla.Item3}");

//2
int miSuma = 0;
for (int i = 0; i <= 100; i++ )
{
    miSuma += i;
}

double cociente = 5 / 30d;

(int Suma, double Division) otraTupla = (miSuma, cociente);

Console.WriteLine($"1: {otraTupla.Item1}, 2: {otraTupla.Item2}");