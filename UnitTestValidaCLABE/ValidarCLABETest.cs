using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidaCLABE;

namespace UnitTestValidaCLABE
{
    [TestClass]
    public class ValidarCLABETest
    {

        [TestMethod]
        public void TestValidar()
        {
            string CLABE = "{Cuenta CALBE}";
            Assert.IsTrue(ValidarCLABE.Validar(CLABE).Valido);
        }
    }
}
