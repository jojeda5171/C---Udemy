using System;
using System.Collections.Generic;

namespace Valoraciones
{
    public enum IdiomaLibro
    {
        none, EN, ES, GE, IT
    }
    public class LibroValoraciones
    {
        private string _nombre;
        public string Nombre
        {
            get {
                return _nombre;
            }
            set {
                if (!String.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }   
        }
        public IdiomaLibro Idioma;
        private List<float> valoraciones;
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
                calculo.ValoracionMinima = Math.Min(valoracion, calculo.ValoracionMinima);
                calculo.ValoracionMaxima = Math.Max(valoracion, calculo.ValoracionMaxima);
                sumaValoraciones += valoracion;
            }
            calculo.ValoracionPromedio = sumaValoraciones / valoraciones.Count;
            return calculo;
        }
    }
}
