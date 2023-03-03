using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 20;
        int i = 1;

        Console.WriteLine("La secuencia de números enteros positivos que comienzan en 1 y se suma en 3 hasta que se alcance un valor mayor que " + numero + " es:");
        while (i <= numero)
        {
            Console.WriteLine(i);
            i += 3;
        }
    }
}

