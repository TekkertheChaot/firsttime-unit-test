﻿using System;
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
        public void TestShortable()
        {
            Bruch b = new Bruch(4,2);
            Boolean boo = b.shorten();
            Assert.IsTrue(boo);
        }
    }
}