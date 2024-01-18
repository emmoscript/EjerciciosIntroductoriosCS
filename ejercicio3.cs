// Tercer ejercicio
// Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.

using System;

public class Programa
{
    static void Main()
    {
        int num;
        Console.WriteLine("Ingrese un numero de dos digitos: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        // Validar que el número sea de dos dígitos
        if (Math.Abs(num) < 10 || Math.Abs(num) > 99)
        {
            Console.WriteLine("Error: Ingrese un número de dos dígitos.");
            return;
        }

        bool esPrimo = true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo) {
            Console.WriteLine($"{num} es un número primo.");
        }
        else {
            Console.WriteLine($"{num} no es un número primo.");
        }

        if (num < 0){
            Console.WriteLine($"{num} es un número negativo.");
        }
        else {
            Console.WriteLine($"{num} no es un número negativo.");
        }
    }
}
