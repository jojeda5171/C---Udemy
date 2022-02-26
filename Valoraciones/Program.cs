using System;
using System.Speech.Synthesis;

namespace Valoraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear el objeto libro
            LibroValoraciones libro = new LibroValoraciones();
            //SpeechSynthesizer hablar = new SpeechSynthesizer();

            // Asignar valoraciones
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(0.5f);

            //hablar.Speak("Este es el promedio de las valoraciones");

            // Publicar valoraciones
            CalcularValoraciones publicar = libro.PublicarValoraciones();

            // valoracionMinima
            Console.WriteLine("Valoracion Minima: " + publicar.ValoracionMinima);

            // valoracionMaxima
            Console.WriteLine("Valoracion Maxima: " + publicar.ValoracionMaxima);

            // promedioValoraciones
            Console.WriteLine("Promedio: " + publicar.ValoracionPromedio);

            //Console.Beep();
            Console.ReadLine();
        }
    }
}
