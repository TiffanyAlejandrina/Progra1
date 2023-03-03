using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 20;

        Console.WriteLine("Los múltiplos de 4 menores o iguales que " + numero + " son:");
        for (int i = 1; i <= numero; i++)
        {
            if (i % 4 == 0)
                Console.WriteLine(i);
        }
    }
}

