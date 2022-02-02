using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test
{
    [TestClass]
    public class ValoracionesTest
    {
        [TestMethod]
        public void calcularValoracionMaxima()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(0.5f);
            CalcularValoraciones resultado = libro.PublicarValoraciones();
            Assert.AreEqual(5, resultado.valoracionMaxima);
        }

        [TestMethod]
        public void calcularValoracionMinima()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(0.5f);
            CalcularValoraciones resultado = libro.PublicarValoraciones();
            Assert.AreEqual(0.5, resultado.valoracionMinima);
        }

        [TestMethod]
        public void calcularPromedio()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(0.5f);
            CalcularValoraciones resultado = libro.PublicarValoraciones();
            Assert.AreEqual(2.714286f, resultado.valoracionPromedio,0.01);
        }

    }
}
