using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasKaratsuba
{
    /// <summary>
    /// Descripción resumida de PruebaCaracteres
    /// </summary>
    [TestClass]
    public class PruebaCaracteres
    {
        LogicLayer.Karatsuba target = new LogicLayer.Karatsuba();
        public PruebaCaracteres()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la ejecución de pruebas actual.
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

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCaracteres()
        {
            Int64 resultado = 144;
            Assert.AreEqual(resultado, target.calcular("$%&$".ToString(),")/()6".ToString()));
        }

        [TestMethod]
        public void TestNegativos()
        {
            Int64 resultado = 144;
            Assert.AreEqual(resultado, target.calcular("-12".ToString(),"12".ToString()));
        }

        [TestMethod]
        public void TestEnterosGrandes()
        {
            Int64 resultado = 317683937781748827;
            Assert.AreEqual(resultado, target.calcular("987654321".ToString(), "321654987".ToString()));
        }

        [TestMethod]
        public void TestLongitudImpar()
        {
            Int64 resultado = 317682461985;
            Assert.AreEqual(resultado, target.calcular("98765".ToString(), "3216549".ToString()));
        }
    }
}
