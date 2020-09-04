using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2.Code;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrelievo()
        {
            //arrange: imposto i dati di input
            var conto = new Conto(5000);
            //act: chiamo il metodo da testare
            conto.PrelevaSoldi(1000);
            //assert: verifico il risultato del metodo
            Assert.AreEqual(conto.Saldo, 4000);
        }
        [TestMethod]
        public void TestPrelievoMaggioreDelSaldo()
        {
            //arrange: imposto i dati di input
            var conto = new Conto(5000);
            //act and assert: chiamo il metodo da testare e verifico il risultato del metodo
            Assert.ThrowsException<Exception>(()=> { conto.PrelevaSoldi(6000); });
        }

    }
}
