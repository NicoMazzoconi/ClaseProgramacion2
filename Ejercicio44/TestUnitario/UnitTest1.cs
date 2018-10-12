using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio44;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Centralita testCent = new Centralita("TestUnitario");
            Assert.IsNotNull(testCent.Llamadas);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Centralita testCent = new Centralita("TestUnitario");
            Local llamada = new Local("Pehuajo", 12, "Capital", 25);
            Local llamada2 = new Local("Pehuajo", 2, "Capital", 45);

            try
            {
                testCent += llamada;
                testCent += llamada2;
            }
            catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, );
            }

            
        }
    }
}
