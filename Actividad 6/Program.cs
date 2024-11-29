using System;

// a) codifica un fragmento de código que vaya pidiendo al usuario una palabra hasta que
// contenga la letra secreta. La letra secreta es la “m”, y la sabe el programa, pero no el usuario.
// class Programa
// {
//     static void Main()
//     {
       
//         char letraSecreta = 'm';
//         string palabra = "";
//         while (!palabra.Contains(letraSecreta))
//         {
//             Console.Write("Introduce una palabra: ");
//             palabra = Console.ReadLine(); 

//             if (!palabra.Contains(letraSecreta))
//             {
//                 Console.WriteLine("La palabra no contiene la letra secreta 'm'. Intenta nuevamente.");
//             }
//         }
//         Console.WriteLine("¡Felicidades! La palabra contiene la letra secreta 'm'.");
//     }
// }





// b) codifica un programa que pida al usuario una frase y que muestre por consola, uno a uno,
// los caracteres que componen la frase y la posición que ocupa cada uno de ellos.


// using System;

// class Programa
// {
//     static void Main()
//     {
        
//         Console.Write("Introduce una frase: ");
//         string frase = Console.ReadLine(); 

        
//         for (int i = 0; i < frase.Length; i++)
//         {
//             Console.WriteLine($"Caracter en la posición {i}: {frase[i]}");
//         }
//     }
// }
