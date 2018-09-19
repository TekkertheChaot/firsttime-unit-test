using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivByZero()
        {
            Bruch b = new Bruch(1,0);
            double res = b.proceed();
            Assert.AreEqual(0, b.proceed());
        }

        [TestMethod]
        public void TestShorten()
        {
            //double z = 4;
            //double 
            Bruch b = new Bruch(4,2);
            Boolean boo = b.shorten();
            Assert.IsTrue(boo);
            Assert.AreEqual(2, b.zaehler);
            Assert.AreEqual(1, b.nenner);

        }
        [TestMethod]
        public void TestShortenNegZaehler()
        {
            //double z = 4;
            //double 
            Bruch b = new Bruch(-4, 2);
            Boolean boo = b.shorten();
            Assert.IsTrue(boo);
            Assert.AreEqual(-2, b.zaehler);
            Assert.AreEqual(1, b.nenner);

        }
    }
}
