using System;

class DeterminarNumero
{
    static void Main()
    {
        
        Console.Write("Introduce un número: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
    }
}

