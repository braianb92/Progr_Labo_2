using System;
using System.Collections.Generic;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException (typeof(SateliteException))]
        public void SatelitesIgualesException()
        {
            //Arrange
            Planeta<Satelite> jupiter = new Planeta<Satelite>(100,30,"Jupiter",2,Tipo.Rocoso);
            Satelite satelite1 = new Satelite(10, 10, "Luna");
            Satelite satelite2 = new Satelite(5, 20, "Luna");

            //Act
            bool aux1 = jupiter + satelite1;
            bool aux2 = jupiter + satelite2;

            //Assert handled by ExpectedException.
        }

        [TestMethod]
        public void GuardarSateliteXml()
        {
            //Arrange
            Satelite satelite = new Satelite(10, 10, "Luna");

            //Act & Assert
            Assert.IsTrue(satelite.GuardarXML());
            
        }

        [TestMethod]
        public void GuardarPlaneta()
        {
            //Arrange
            Planeta<Satelite> jupiter = new Planeta<Satelite>(100, 30, "Jupiter", 2, Tipo.Rocoso);

            //Act & Assert
            Assert.IsTrue(AstroExtension.GuardarPlanTxt(jupiter));
        }

        [TestMethod]
        public void SateliteDB_Guardar()
        {
            //Arrange
            SateliteDB database = new SateliteDB();
            Satelite satelite = new Satelite(200, 100, "Luna");
            //Act & Assert
            Assert.IsTrue(database.Guardar(satelite));
        }

        [TestMethod]
        public void SateliteDB_Leer()
        {
            //Arrange
            SateliteDB database = new SateliteDB();

            List<Satelite> listaSatelites = new List<Satelite>();
            //Act & Assert
            listaSatelites = database.Leer();
            Assert.IsNotNull(listaSatelites);
            foreach (Satelite satelite in listaSatelites)
            {
                Assert.IsTrue(satelite.GuardarXML());
            }
            
        }

    }
}
