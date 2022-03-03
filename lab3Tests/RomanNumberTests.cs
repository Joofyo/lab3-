using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void ZeroExceptionTest()
        {
            RomanNumber a;
            Assert.ThrowsException<RomanNumberException>(() => a = new(0));
        }
        [TestMethod()]
        public void ZeroExceptionTest2()
        {
            RomanNumber a = new(10);
            RomanNumber b = new(11);
            Assert.ThrowsException<RomanNumberException>(() => a - b);
        }
        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber a = new(45);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber a = new(21);
            string result = "XXI";
            Assert.AreEqual(a.ToString(), result);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber a = new(110);
            RomanNumber b = (RomanNumber)a.Clone();
            Assert.AreNotSame(a, b);
        }

        [TestMethod()]
        public void ArraySortTest()
        {
            RomanNumber a = new(110);
            RomanNumber b = new(420);
            RomanNumber c = new(22);
            RomanNumber d = new(11);
            RomanNumber[] result = { d, c, a, b };
            RomanNumber[] massive = { a, b, c, d };

            Array.Sort(massive);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(massive[i], result[i]);
            }
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber a = new(110);
            RomanNumber b = new(110);
            int expected = 0;
            int actual = a.CompareTo(b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            RomanNumber a = new(110);
            RomanNumber b = new(420);
            RomanNumber result = new(530);
            Assert.AreEqual(result.ToString(), (a + b).ToString());
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber a = new(1450);
            RomanNumber b = new(420);
            RomanNumber result = new(1030);
            Assert.AreEqual(result.ToString(), (a - b).ToString());
        }
        [TestMethod()]
        public void DivTest()
        {
            RomanNumber a = new(333);
            RomanNumber b = new(109);
            RomanNumber result = new(3);
            Assert.AreEqual(result.ToString(), (a / b).ToString());
        }
        [TestMethod()]
        public void MulTest()
        {
            RomanNumber a = new(9);
            RomanNumber b = new(7);
            RomanNumber result = new(63);
            Assert.AreEqual(result.ToString(), (a * b).ToString());
        }
    }
}