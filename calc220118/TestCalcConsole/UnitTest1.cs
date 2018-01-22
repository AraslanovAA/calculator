using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calc220118;

namespace TestCalcConsole
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSumm()
        {
            //arrang
            var x = 10;
            var y = 1;
            var Calc_ = new Calc();
            //act
            var result = Calc_.Summ(x, y);

            //assert
            Assert.AreEqual(result, 11);
        }
        [TestMethod]
        public void TestSub()
        {
            //arrang
            var x = 10;
            var y = 1;
            var Calc_ = new Calc();
            //act
            var result = Calc_.Sub(x, y);

            //assert
            Assert.AreEqual(result, 9);
        }

        [TestMethod]
        public void TestSumm_double()//double суммирвоание
        {
            //arrang
            var x = 10.5;
            var y = 1;
            var Calc_ = new Calc();
            //act
            var result = Calc_.Summ(x, y);

            //assert
            Assert.AreEqual(result, 11.5);
        }

        [TestMethod]
        public void TestSub_double()//double вычитание
        {
            //arrang
            var x = 10.5;
            var y = 1;
            var Calc_ = new Calc();
            //act
            var result = Calc_.Sub(x, y);

            //assert
            Assert.AreEqual(result, 9.5);
        }

        [TestMethod]
        public void TestDiv()//тест деление
        {
            //arrang
            var x = 10.5;
            var y = 1;
            var Calc_ = new Calc();
            //act
            var result = Calc_.Div(x, y);

            //assert
            Assert.AreEqual(result, 10.5);
        }

        [TestMethod]
        public void TestDiv_2()//тест деления на ноль
        {
            //arrang
            var x = 10.5;
            var y = 0;
            var Calc_ = new Calc();
            //act
            var result = Calc_.Div(x, y);

            //assert
            Assert.AreEqual(result, 1);//  что должно происходить при обработанном исключении  - загадка, будет 1
        }

        [TestMethod]
        public void TestMult()//тест умножение
        {
            //arrang
            var x = 10.5;
            var y = 1;
            var Calc_ = new Calc();
            //act
            var result = Calc_.mult(x, y);

            //assert
            Assert.AreEqual(result, 10.5);
        }

        [TestMethod]
        public void TestPow2()//тест возведение в куб
        {
            //arrang
            var x = 0.5;
            var Calc_ = new Calc();
            //act
            var result = Calc_.pow2(x);

            //assert
            Assert.AreEqual(result, 0.25);
        }

        [TestMethod]
        public void TestPow3()//тест возведение в куб
        {
            //arrang
            var x = 0.5;
            var Calc_ = new Calc();
            //act
            var result = Calc_.pow3(x);

            //assert
            Assert.AreEqual(result, 0.125);
        }
    }
}
