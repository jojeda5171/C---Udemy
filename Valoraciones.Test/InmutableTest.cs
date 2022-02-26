using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void MyTestMethod()
        {
            string nombre = "José";
            nombre = nombre.ToUpper();
            Assert.AreEqual("JOSÉ", nombre);

            LibroValoraciones libro1 = new LibroValoraciones();
            libro1.Nombre = "José";
            libro1.Nombre = libro1.Nombre.ToUpper();
            Assert.AreEqual("JOSÉ", libro1.Nombre);

            DateTime fecha = new DateTime(1999, 01, 24);
            fecha = fecha.AddDays(1);
            Assert.AreEqual(25, fecha.Day);
        }
    }
}
