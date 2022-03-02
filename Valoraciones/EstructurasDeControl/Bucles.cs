using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    class Bucles
    {
        //Funcionalidad: Recorrer colecciones de datos (Array, ArrayList, listas, diccionarios)

        public void BuclesForEach()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };

            //con numericos
            foreach(int n in array1)
            {
                Console.WriteLine("For each int: "+n.ToString());
            }

            //Con Strings
            string[] array2 = { "Hola", "Mundo" };
            foreach(string s in array2)
            {
                Console.WriteLine("For each string: " + s);
            }
        }

        public void BuclesForLoop()
        {
            //Array de Enteros
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            for (int i = 0; i < array1.Length; i++)     //tamaño=6 ojo con <= se sale de rango
            //for(int i=0; i<6; i++)
            {
                //break;
                //continue;
                //return;
                goto Hola;
                Console.WriteLine("For loop int: " + array1[i].ToString());

                Hola:
                Console.WriteLine("Me salte el bucle");
            }

            //Array con Strings
            string[] array2 = { "Hola", "Mundo" };
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("For loop string: " + array2[i]);
            }
        }
        public void BuclesWhlie()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            while(x < 6)
            {
                Console.WriteLine("While int "  + array1[x].ToString());
                x++;
            }


            String[] array2 = { "Hola", "Mundo" };
            int y = 0;
            while (y < 2)
            {
                Console.WriteLine("While string " + array2[y]);
                y++;
            }
        }

        public void BuclesDoWhile()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            do
            {
                Console.WriteLine("Do While int " + array1[x].ToString());
                x++;
            } while (x < 6);


            String[] array2 = { "Hola", "Mundo" };
            int y = 0;
            do
            {
                Console.WriteLine("Do While string " + array2[y]);
                y++;
            } while (y < 2);
        }
    }
}
