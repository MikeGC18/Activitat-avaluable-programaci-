using System;

class PromedioNumeros
{
    static void Main()
    {
        int suma = 0;
        int contador = 0;
        int numero;
        string respuesta;

        while (true)
        {
            Console.Write("Introduce un número: ");
            numero = int.Parse(Console.ReadLine());

            suma += numero;  
            contador++;     

            Console.Write("¿Quieres ingresar otro número? (s/n): ");
            respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s")
            {
                break;
            }
        }

        if (contador > 0)
        {
            double promedio = (double)suma / contador;
            Console.WriteLine($"\nEl promedio de los números ingresados es: {promedio}");

            if (promedio > 10)
            {
                Console.WriteLine("El promedio es mayor que 10.");
            }
            else if (promedio < 10)
            {
                Console.WriteLine("El promedio es menor que 10.");
            }
            else
            {
                Console.WriteLine("El promedio es igual a 10.");
            }
        }
        else
        {
            Console.WriteLine("No se ingresaron números.");
        }

        Console.WriteLine("\nNúmeros ingresados de forma ascendente:");
        for (int i = 1; i <= contador; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}


