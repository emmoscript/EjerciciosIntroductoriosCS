// Sexto ejercicio
// Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero de tres dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        int dig1 = numero / 100;
        int dig2 = (numero / 10) % 10;
        int dig3 = numero % 10;

        // Verificar si algún dígito es múltiplo de los otros
        if (dig1 % dig2 == 0 || dig1 % dig3 == 0)
        {
            Console.WriteLine($"El primer dígito ({dig1}) es múltiplo de al menos uno de los otros dígitos.");
        }
        else if (dig2 % dig1 == 0 || dig2 % dig3 == 0)
        {
            Console.WriteLine($"El segundo dígito ({dig2}) es múltiplo de al menos uno de los otros dígitos.");
        }
        else if (dig3 % dig1 == 0 || dig3 % dig2 == 0)
        {
            Console.WriteLine($"El tercer dígito ({dig3}) es múltiplo de al menos uno de los otros dígitos.");
        }
        else
        {
            Console.WriteLine("Ningún dígito es múltiplo de los otros.");
        }
    }
}
