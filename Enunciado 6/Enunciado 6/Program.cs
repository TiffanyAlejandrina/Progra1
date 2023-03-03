using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 10;
        int[] cuadrados = new int[numero];

        for (int i = 1; i <= numero; i++)
        {
            cuadrados[i - 1] = i * i;
        }

        Console.WriteLine("Los cuadrados de los números enteros menores o iguales que " + numero + " son:");
        for (int i = 0; i < cuadrados.Length; i++)
        {
            Console.WriteLine(cuadrados[i]);
        }
    }
}
