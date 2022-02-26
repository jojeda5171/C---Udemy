using System;
using System.Collections.Generic;

namespace Valoraciones
{
    public class LibroValoraciones
    {
        public string Nombre;
        public List<float> valoraciones;
        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

        public CalcularValoraciones PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0;
            foreach (float valoracion in valoraciones)
            {
                calculo.valoracionMinima = Math.Min(valoracion, calculo.valoracionMinima);
                calculo.valoracionMaxima = Math.Max(valoracion, calculo.valoracionMaxima);
                sumaValoraciones += valoracion;
            }
            calculo.valoracionPromedio = sumaValoraciones / valoraciones.Count;
            return calculo;
        }
    }
}
