using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace factorialTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatFactorial5Is120()
        {
            long result = calcFactorial.Program.calcFactorial(5);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void TestThatFactorial5Is1()
        {
            long result = calcFactorial.Program.calcFactorial(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestThatFactorial5Is2()
        {
            long result = calcFactorial.Program.calcFactorial(2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestThatFactorial5Is3()
        {
            long result = calcFactorial.Program.calcFactorial(3);
            Assert.AreEqual(6, result);
        }


        [TestMethod]
        public void TestThatFactorial5Is8()
        {
            long result = calcFactorial.Program.calcFactorial(8);
            Assert.AreEqual(40320, result);
        }


        [TestMethod]
        public void TestThatFactorial5Is7()
        {
            long result = calcFactorial.Program.calcFactorial(7);
            Assert.AreEqual(5040, result);
        }


        [TestMethod]
        public void TestThatFactorial5Is6()
        {
            long result = calcFactorial.Program.calcFactorial(6);
            Assert.AreEqual(720, result);
        }

    }
}
