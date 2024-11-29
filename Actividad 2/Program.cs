using System;

class AdivinaNumero
{
    static void Main()
    {
        int numeroSecreto = 5; // Número a adivinar
        int intento = 0;

        Console.WriteLine("Adivina el número secreto (entre 1 y 10):");

        while (intento != numeroSecreto)
        {
            Console.Write("Introduce tu número: ");
            intento = int.Parse(Console.ReadLine());

            if (intento < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
            else
            {
                Console.WriteLine("¡Felicidades! Has adivinado el número.");
            }
        }
    }
}



