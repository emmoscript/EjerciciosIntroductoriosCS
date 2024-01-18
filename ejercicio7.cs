// Séptimo ejercicio
// Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.

using System;

class Program
{
    static void Main()
    {
        int num, mayor;

        Console.Write("Ingrese el primer número: ");
        num = int.Parse(Console.ReadLine());
        mayor = num;

        Console.Write("Ingrese el segundo número: ");
        num = int.Parse(Console.ReadLine());

        if (num > mayor) {
            mayor = num;
        }

        Console.Write("Ingrese el tercer número: ");
        num = int.Parse(Console.ReadLine());
        if (num > mayor) {
            mayor = num;
        }

        Console.WriteLine($"El número mayor es: {mayor}");
    }
}
