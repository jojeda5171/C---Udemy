using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    public class Condicionales
    {
        //Comparaciones que devuelven V/F

        int num = 10;
        int num2 = 20;
        public void CondicionalBasico()
        {
            if (num == 2)
            {
                Console.WriteLine("Son iguales");
            }
        }

        public void CondicionalBasico2()
        {
            if (num == 2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
        }

        public void CondicionalAnidado()
        {
            if (num == 2)
            {
                Console.WriteLine("Son iguales");
            }
            else if (num >= num2)
            {
                Console.WriteLine(num + " Es mayor o igual a: " + num2);
            }
            else //if (num <= num2)
            {
                Console.WriteLine(num + " Es menor o igual a: " + num2);
            }
        }

        public void CondicionalAnidadoNoRecomendado()
        {
            if (num == num2 && num > num2)
            {
                MiMetodo();
            }
            else if (num >= num2)
            {
                Console.WriteLine(num + " Es mayor o igual que: " + num2);
            }
            else
            {

            }
        }

        public void ComprobacionesConRetorno()
        {
            int resultado1 = Prueba(0);
            int resultado2 = Prueba(50);
            int resultado3 = Prueba(-1);

            Console.WriteLine("Resuldado1: " + resultado1);
            Console.WriteLine("Resuldado2: " + resultado2);
            Console.WriteLine("Resuldado3: " + resultado3);
        }

        static int Prueba(int valor)
        {
            if (valor == 0)
            {
                return -1;
            }
            else if (valor <= 10)
            {
                return 0;
            }
            else if (valor <= 100)
            {
                return 1;
            }
            else
            {
                return 1;
            }
        }

        private void MiMetodo()
        {
            throw new NotImplementedException();
        }
    }
}
