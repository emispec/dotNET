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

///////////////////////
//Declarando un array conociendo el numero de elementos pero sin saber los elementos

int size = 4;
int[,] arr2D = new int[size,size];

for (int j = 0; j < size; j++)
{
    for (int k = 0; k < size; k++)
    {
        arr2D[j,k] = j + k;
        Console.Write(arr2D[j,k] + "\t");
    }
    Console.WriteLine();
}

//declarando una matriz y asignamos los valores que tiene
int[,] matriz2 = {{1,2,3}, {3,4,6} };
int rows = 2;
int cols = 3;

for (int j = 0; j < rows; j++)
{
    for (int k = 0; k < cols; k++)
    {
        Console.Write(matriz2[j,k] + " ");
    }
    Console.WriteLine();
}

//cuando filas y columnas no son conocidas
int[][] matriz4 = new int[3][];
matriz4[0] = new int[4] {1,2,3,4}; // en la fila 0 asignamos 4 cols con estos valores
matriz4[1] = new int[4] {3,4,5,6};
//rank y length para obtener info de su estructura y taaño:
Console.WriteLine($"Tamaño: {matriz2.Length}"); //num total de elementos de elementos del array.
Console.WriteLine($"Rank: {matriz2.Rank}"); //numero dimensiones del array.

//SUMA DE MATRICES
/*

using System;

class Program
{
    static void Main()
    {
        int[,] matriz1 = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        int[,] matriz2 = new int[,]
        {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        int[,] resultado = SumarMatrices(matriz1, matriz2);

        // Imprimir la matriz resultante
        for (int i = 0; i < resultado.GetLength(0); i++)
        {
            for (int j = 0; j < resultado.GetLength(1); j++)
            {
                Console.Write("{0} ", resultado[i, j]);
            }
            Console.WriteLine();
        }
    }

    static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        // Verificar que ambas matrices tengan las mismas dimensiones
        if (matriz1.GetLength(0) != matriz2.GetLength(0) ||
            matriz1.GetLength(1) != matriz2.GetLength(1))
        {
            throw new ArgumentException("Las matrices deben tener las mismas dimensiones.");
        }

        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        // Sumar los elementos correspondientes de cada matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }
}



*/
/*
OUTPUT
10 10 10
10 10 10
10 10 10
*/