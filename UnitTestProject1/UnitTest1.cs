using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Bruch b = new Bruch(1, 0);
            double res = b.proceed();
        }

        [TestMethod]
        public void TestShorte()
        {
            Bruch b = new Bruch(4, 2);
            Boolean boo = b.shorten();
            Assert.IsTrue(boo);
            Assert.AreEqual(2, b.zaehler);
            Assert.AreEqual(1, b.nenner);

        }
        [TestMethod]
        public void TestShortenNegZaehler()
        {
            Bruch b = new Bruch(-40, 20);
            b.proceed();
            Assert.AreEqual(-2, b.zaehler);
            Assert.AreEqual(1, b.nenner);

        }
        [TestMethod]
        public void TestNotShortable()
        {
            Bruch b = new Bruch(-40, 3);
            b.proceed();
            Assert.AreEqual(-40, b.zaehler);
            Assert.AreEqual(3, b.nenner);

        }
    }
}
