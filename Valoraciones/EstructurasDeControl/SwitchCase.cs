using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    class SwitchCase
    {
        public void EjemploSwitchCase1()
        {
            int caseSwitch = 1;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                default:
                    Console.WriteLine("Caso por defecto");
                    break;
            }
        }

        public void EjemploSwitchCase2()
        {
            int switchExpression = 3;
            switch (switchExpression)
            {
                case 0:

                case 1:
                    Console.WriteLine("Caso 0 o 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                case 7 - 4:
                    Console.WriteLine("Caso 3");
                    break;
                default:
                    Console.WriteLine("Caso por defecto");
                    break;
            }
        }

        public void EjemploSwitchCase3()
        {
            Console.WriteLine("Elige el tamaño del vaso");
            Console.WriteLine("Tamaño vaso: 1=pequeño 2=mediano 3=Grande");
            Console.WriteLine("Ingresa tu seleccion: ");
            string str = Console.ReadLine();
            int cost = 0;
            switch (str)
            {
                case "1":

                case "pequeño":
                    cost += 25;
                    break;
                case "2":
                    
                case "mediano":
                    cost += 25;
                    goto case "1"; //regresa al caso 1
                case "3":

                case "grande":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Seleccion no valida. Ingresa 1, 2 o 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("El coste es de {0} centimos.", cost);
            }
            Console.WriteLine("Gracias por elegir un vaso");
        }
    }
}
