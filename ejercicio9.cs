// Noveno ejercicio
// Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.

using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("Ingrese un número entero de cuatro dígitos: ");
      int numero = int.Parse(Console.ReadLine());
      
      int dig1 = numero / 1000;
      int dig2 = (numero / 100) % 10;
      int dig3 = (numero / 10) % 10;
      int dig4 = numero % 10;
      
      if (dig2 == dig3) {
          Console.WriteLine("El segundo dígito es igual al penúltimo.");
      } else {
          Console.WriteLine("El segundo dígito no es igual al penúltimo.");
      }
    }
}
