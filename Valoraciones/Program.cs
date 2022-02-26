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
            libro.Nombre = "El libro de valoraciones de José";
            libro.Nombre =null;
            Console.WriteLine(libro.Nombre);
            libro.Idioma = IdiomaLibro.ES;
            //SpeechSynthesizer hablar = new SpeechSynthesizer();
            Vector3D miVector;
            miVector.x = 10; miVector.y=20; miVector.z = 30.30f;

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

            float valoracionMax = publicar.ValoracionMaxima;
            float valoracionMin = publicar.ValoracionMinima;
            float promedioValoraciones = publicar.ValoracionPromedio;

            // valoracionMinima
            EscribirValoraciones("Valoracion Minima: ", (int)valoracionMin);

            // valoracionMaxima
            EscribirValoraciones("Valoracion Maxima: ", valoracionMax);

            // promedioValoraciones
            EscribirValoraciones("Promedio: ", promedioValoraciones);

            //Console.Beep();
            Console.ReadLine();
        }

        private static void EscribirValoraciones(string descripcion, float valoracion)
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
        private static void EscribirValoraciones(string descripcion, int valoracion)
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
    }
}
