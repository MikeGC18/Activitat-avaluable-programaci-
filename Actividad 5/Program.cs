using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
       
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        Console.WriteLine("a) El tercer número es: " + numeros[2]);
        Console.WriteLine("\nb) Los 5 primeros números son:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine(); 

        int mitad = numeros.Count / 2;
        Console.WriteLine("\nc) La primera mitad de la lista es:");
        foreach (var numero in numeros.GetRange(0, mitad))
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine(); 

        Console.WriteLine("\nd) Todos los números en orden inverso:");
        numeros.Reverse();
        foreach (var numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine(); 
    }
}
