using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 10;
        int[] resultados = new int[numero];

        for (int e = 1; e <= numero; e++)
        {
            int cuadrado = e * e;
            resultados[e - 1] = cuadrado;
        }

        Console.WriteLine("Los cuadrados son:");
        foreach (int resultado in resultados)
        {
            Console.WriteLine(resultado);
        }
    }
}

