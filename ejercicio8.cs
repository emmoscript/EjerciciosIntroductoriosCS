// Octavo ejercicio
// Leer un número entero de cinco dígitos y determinar si es un número Capicúa. Ej. 15651, 59895.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número entero de cinco digitos : ");
        string originalString = Console.ReadLine();
        char[] stringArray = originalString.ToCharArray();
        Array.Reverse(stringArray);
        string reverseString = new string(stringArray);

        if (reverseString == originalString) {
            Console.WriteLine("Es un número capicúa.");
        } else {
            Console.WriteLine("No es un número capicúa.");
        }
    }
}
