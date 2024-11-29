using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Introduce el tamaño del cuadrado de asteriscos: ");
        int tamaño = int.Parse(Console.ReadLine());

  
        Console.WriteLine("\nCuadrado de asteriscos:");
        for (int i = 1; i <= tamaño; i++)  
        {
            for (int j = 1; j <= tamaño; j++)  
            {
                Console.Write("* ");  
            }
            Console.WriteLine();  
        }
        
        Console.Write("\nIntroduce la altura de la pirámide invertida: ");
        int altura = int.Parse(Console.ReadLine());

       Console.WriteLine("\nPirámide invertida de asteriscos:");
        for (int i = altura; i >= 1; i--) 
        {
            for (int j = 1; j <= i; j++)  
            {
                Console.Write("* ");  
            }
            Console.WriteLine();  
        }
    }
}
