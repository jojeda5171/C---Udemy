using System;

namespace EdadLegal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad=int.Parse(Console.ReadLine());
            if (edad>=18)
            {
                Console.WriteLine("Tu nombre es: " + nombre + " y eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Tu nombre es: " + nombre + " y NO eres mayor de edad");
            }
        }
    }
}
