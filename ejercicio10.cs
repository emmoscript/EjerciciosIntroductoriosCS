// Décimo ejercicio
// Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número entero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número entero:");
        int numero2 = int.Parse(Console.ReadLine());

        int diferencia = Math.Abs(numero1 - numero2);

        if (diferencia <= 10) {
            int menor = Math.Min(numero1, numero2);
            int mayor = Math.Max(numero1, numero2);

            Console.WriteLine($"Los enteros comprendidos entre {menor} y {mayor} son:");

            for (int i = menor; i <= mayor; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
        else {
            Console.WriteLine("La diferencia entre los dos números es mayor a 10, no se mostrarán los números enteros comprendidos.");
        }
    }
}
