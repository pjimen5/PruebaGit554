using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT554
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ImprimirPersona_PriscillaYGuayaquil_DebeRetornarPriscillaDeGuayaquil()
        {
            String strNombre = "Priscilla";
            String strLugarNac = "Guayaquil";
            String valorEsperado = "Priscilla de Guayaquil";

            CapaLogica.Persona persona = new CapaLogica.Persona(strNombre,strLugarNac);

            var valorObtenido = persona.ImprimirPersona();

            Assert.AreEqual(valorEsperado, valorObtenido);

        }
        [TestMethod]
        public void ImprimirPersona_PriscillaYVacio_DebeRetornarPriscilla()
        {
            String strNombre = "Priscilla";
            String strLugarNac = " ";
            String valorEsperado = "Priscilla";

            CapaLogica.Persona persona = new CapaLogica.Persona(strNombre, strLugarNac);

            var valorObtenido = persona.ImprimirPersona();

            Assert.AreEqual(valorEsperado, valorObtenido);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ImprimirPersona_VacioYCualquierEntrada_DebeRetornarException()
        {
            String strNombre = null;
            String strLugarNac = "";
       

            CapaLogica.Persona persona = new CapaLogica.Persona(strNombre, strLugarNac);

            var valorObtenido = persona.ImprimirPersona();
        }

    }
}
