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
        private string _valoracionesLetras;
        public string ValoracionesLetras
        {
            get
            {
                return _valoracionesLetras;
            }
        }

        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
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

            AsignarLetraValoracion(calculo.ValoracionPromedio);

            return calculo;
        }

        private void AsignarLetraValoracion(float VL)
        {
            if (VL <= 5 && VL > 4)
            {
                _valoracionesLetras = "A";
            }
            else if (VL <= 4 && VL > 3)
            {
                _valoracionesLetras = "B";
            }
            else if (VL <= 3 && VL > 2)
            {
                _valoracionesLetras = "C";
            }
            else if (VL <= 2 && VL > 1)
            {
                _valoracionesLetras = "D";
            }
            else //if (VL<=1 && VL >= 0){
                _valoracionesLetras = "E";
        }
    }
}


