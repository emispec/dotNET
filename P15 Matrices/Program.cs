// Matrices

//1D -> 1 indice

int[] numeros = { 1, 2, 3, 4, 5 };
string[] nombres = { "Juan", "Pedro", "María", "Luisa" };

Console.WriteLine("Imprimiendo array de números:");
ImprimirArray(numeros);

Console.WriteLine("\nImprimiendo array de nombres:");
ImprimirArray(nombres);

static void ImprimirArray<T>(T[] array)
{
    foreach (T elemento in array)
    {
        Console.Write(elemento + " ");
    }
}

//2D

int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine(matrix[i, j]); // Imprime cada uno de los elementos de la matriz
    }
}

//3D
int[,,] matriz = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        for (int k = 0; k < matriz.GetLength(2); k++)
        {
            Console.WriteLine(matriz[i, j, k]); // Imprime cada uno de los elementos de la matriz
        }
    }
}