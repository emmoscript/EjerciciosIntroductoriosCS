// Primer Ejercicio Suma de digitos

using System;

public class Programa
{
    static void Main()
    {
      Console.WriteLine("Digite el numero de dos digitos: ");
      try
      {
      int num = Convert.ToInt32(Console.ReadLine());
      if (num.ToString().Length == 2) {
          int suma = (num / 10) + (num % 10);
          Console.WriteLine("La suma de los dos digitos es: " + suma);
      }
      else
      {
          Console.WriteLine("El numero no es de dos digitos.");
      }
      }
      catch (Exception ex) {
      
        Console.WriteLine("No es un numero.");
    }
  }
}
