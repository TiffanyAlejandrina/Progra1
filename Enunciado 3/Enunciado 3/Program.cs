using System;

class Program
{
    static bool EsPrimo(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int numero = 20;

        Console.WriteLine("Los números primos menores o iguales que " + numero + " son:");
        for (int i = 1; i <= numero; i++)
        {
            if (EsPrimo(i))
                Console.WriteLine(i);
        }
    }
}

