using NUnit.Framework;
using Muchenia;
using System.Linq;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] mas = {1, 2, 3, 5, 7, 11, 13, 17, 19};
            Assert.AreEqual(Eratnosfer.ListFalseIndeces(Eratnosfer.GetMatrix(20)).ToArray(), mas);
        }

        [Test]
        public void Test2()
        {
            int[] mas = {1, 2, 3, 5, 7};
            Assert.AreEqual(Eratnosfer.ListFalseIndeces(Eratnosfer.GetMatrix(10)).ToArray(), mas);
        }

        [Test]
        public void Test3()
        {
            int[] mas = { 1, 2, 3, 5, 7, 11, 13 };
            Assert.AreEqual(Eratnosfer.ListFalseIndeces(Eratnosfer.GetMatrix(16)).ToArray(), mas);
        }

        [Test]
        public void Test4()
        {
            List<int> Dif = new List<int> { 1, 2, 6, 8, 10 };
            int[] Result = new int[3] { 4, 6, 2};
            Assert.AreEqual(Eratnosfer.MaxDiff1(Dif), Result);
        }

        [Test]
        public void Test5()
        {
            List<int> Dif = new List<int> { 1, 6, 10, 40 };
            int[] Result = new int[3] { 30, 40, 10};
            Assert.AreEqual(Eratnosfer.MaxDiff1(Dif), Result);
        }

        [Test]
        public void Test6()
        {
            List<int> Dif = new List<int> { 1, 6, 7, 8, 10, 12, 13, 20, 21};
            int[] Result = new int[2] { 4, 1};
            Assert.AreEqual(Eratnosfer.MaxSimpleNum(Dif, 22), Result);
        }

        [Test]
        public void Test7()
        {
            List<int> Dif = new List<int> { 1, 6, 7, 8, 11, 12, 13, 22, 21 };
            int[] Result = new int[2] { 2, 3 };
            Assert.AreEqual(Eratnosfer.MinSimpleNum(Dif, 30, 1), Result);
        }
    }
}