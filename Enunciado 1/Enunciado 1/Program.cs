using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        while (n <= 0)
        {
            Console.Write("Ingrese un número entero positivo: ");
            int.TryParse(Console.ReadLine(), out n);
        }
        Console.WriteLine($"La suma de los primeros {n} números pares es {(n * (n + 1))}");
    }
}

