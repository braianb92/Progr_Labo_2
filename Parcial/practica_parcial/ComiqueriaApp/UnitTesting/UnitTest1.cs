using System;
using System.IO;
using ComiqueriaLogic;
using ComiqueriaLogic.StaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SerializeXml()
        {
            Producto producto = new Producto();
            Venta venta = new Venta();

            producto.Descripcion = "Harina";
            producto.Precio = 18.10;
            producto.Stock = 100;
            venta.PrecioFinal = 20.40;
            venta.Producto = producto;

            Assert.IsTrue(Serializador<Venta>.GuardarXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta.xml")),venta));          
        }

        [TestMethod]
        public void SerializeXmlBinary()
        {
            Producto producto = new Producto();
            Venta venta = new Venta();

            producto.Descripcion = "Harina";
            producto.Precio = 18.10;
            producto.Stock = 100;
            venta.PrecioFinal = 20.40;
            venta.Producto = producto;

            Assert.IsTrue(Serializador<Venta>.GuardarBinaryXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"VentaBin.bin")), venta));
        }

        [TestMethod]
        public void LeerXml()
        {
            Assert.IsTrue(Serializador<Venta>.LeerXml("Venta.xml", out Venta venta));
            Assert.IsTrue(Serializador<Venta>.GuardarXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"VentaLeida.xml")), venta));

        }

        [TestMethod]
        public void LeerXmlBinary()
        {
            Assert.IsTrue(Serializador<Venta>.LeerBinaryXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"VentaBin.bin")), out Venta venta));
            Assert.IsTrue(Serializador<Venta>.GuardarBinaryXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"VentaBinariaLeida.bin")), venta));

        }

        [TestMethod]
        public void ComiqueriaDB_Insertar()
        {
            Producto producto = new Producto();
            producto.Descripcion = "Harina";
            producto.Precio = 18.10;
            producto.Stock = 100;

            Assert.IsTrue(ComiqueriaDB.Insertar(producto));

        }
    }
}
