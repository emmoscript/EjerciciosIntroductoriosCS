// Cuarto ejercicio
// Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

using System;

public class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número de dos dígitos");
        int numero1 = int.Parse(Console.ReadLine());

        // Validar que el primer número sea de dos dígitos
        if (Math.Abs(numero1) < 10 || Math.Abs(numero1) > 99) {
            Console.WriteLine("Error: Ingrese un número de dos dígitos válido para el primer número.");
            return;
        }

        Console.WriteLine("Ingrese el segundo número de dos dígitos");
        int numero2 = int.Parse(Console.ReadLine());

        if (Math.Abs(numero2) < 10 || Math.Abs(numero2) > 99) {
            Console.WriteLine("Error: Ingrese un número de dos dígitos válido para el segundo número.");
            return;
        }

        int suma = numero1 + numero2;

        if (suma % 2 == 0) {
            Console.WriteLine("La suma de los dos números es " + suma);
            Console.WriteLine("Es un número par.");
        } else {
            Console.WriteLine("La suma de los dos números es " + suma);
            Console.WriteLine("No es un número par.");
        }
    }
}
