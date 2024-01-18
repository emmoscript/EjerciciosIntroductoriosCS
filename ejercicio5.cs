// Quinto ejercicio
// Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.

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

        int mayor = dig1;
        int posicion = 1;

        if (dig2 > mayor) {
            mayor = dig2;
            posicion = 2;
        }

        if (dig3 > mayor) {
            mayor = dig3;
            posicion = 3;
        }

        Console.WriteLine($"El mayor dígito es {mayor} y se encuentra en la posición {posicion}");
    }
}
