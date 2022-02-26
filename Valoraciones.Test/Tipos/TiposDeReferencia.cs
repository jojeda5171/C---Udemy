using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test.Tipos
{
    [TestClass]
    public class TiposDeReferencia
    {
        [TestMethod]
        public void VariablesTiposReferencia()
        {
            LibroValoraciones l1 = new LibroValoraciones();
            l1.Nombre = "Libro José";
            LibroValoraciones l2 = l1;
            l1.Nombre = "Libro";
            Assert.AreEqual(l1.Nombre, l2.Nombre);
        }
    }
}
