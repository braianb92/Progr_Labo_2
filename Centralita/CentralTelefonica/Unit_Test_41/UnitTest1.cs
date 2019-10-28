using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test_41
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LlamadasNotNull_a()
        {
            //Arrange
            Centralita centralita = new Centralita();

            //Act

            //Assert
            Assert.IsNotNull(centralita.Llamadas);
            
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaExceptionMismaLlamadaLocal_b()
        {
            //Arrange
            Centralita centralita = new Centralita();
            Local llamada1 = new Local("America", (float)20.3, "Europa", (float)2.5);
            Local llamada2 = new Local("America", (float)20.3, "Europa", (float)2.5);

            //Act
            centralita = centralita + llamada1;
            centralita = centralita + llamada2;

            // assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaExceptionMismaLlamadaProvincial_c()
        {
            //Arrange
            Centralita centralita = new Centralita();
            Provincial llamada1 = new Provincial("Jujuy", Provincial.Franja.Franja_2, (float)20.5, "Buenos Aires");
            Provincial llamada2 = new Provincial("Jujuy", Provincial.Franja.Franja_2, (float)20.5, "Buenos Aires");

            //Act
            centralita = centralita + llamada1;
            centralita = centralita + llamada2;

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void MismaLlamadaPorTipo_d()
        {
            //Arrange
            Centralita centralita = new Centralita();

            //Act
            Local local1 = new Local("America", (float)20.3, "Europa", (float)2.5);
            Local local2 = new Local("America", (float)20.3, "Europa", (float)2.5);

            Provincial provincial1 = new Provincial("America", Provincial.Franja.Franja_2, (float)20.3, "Europa");
            Provincial provincial2 = new Provincial("America", Provincial.Franja.Franja_2, (float)20.3, "Europa");

            //Assert
            Assert.AreNotEqual(local1, provincial1);
            Assert.AreNotEqual(provincial2, local2);

            Assert.AreEqual(local1, local2);
            Assert.AreEqual(provincial1, provincial2);

        }
    }
}
