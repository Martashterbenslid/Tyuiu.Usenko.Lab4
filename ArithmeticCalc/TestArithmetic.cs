using ArithmeticCalc.Lib;
namespace ArithmeticCalc
{
    [TestClass]
    public class TestArithmetic
    {
        [TestMethod]
        public void TestCalcPower()
        {
            var calculator = new Arithmetic();
            double a = 2;
            double b = 3;
            double result = calculator.CalcPower(a, b);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestSquareRoot()
        {
            var calculator = new Arithmetic();
            double a = 16;
            double result = calculator.SquareRoot(a);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestCalcLog()
        {
            var calculator = new Arithmetic();
            double a = 8;
            double b = 2;
            double result = calculator.CalcLog(a, b);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestCalcSin()
        {
            var calculator = new Arithmetic();
            double a = -30;
            double result = calculator.CalcSin(a);
            Assert.AreEqual(0.988, result, 0.001);
        }
        [TestMethod]
        public void TestCalcCos()
        {
            var calculator = new Arithmetic();
            double a = 45;
            double result = calculator.CalcCos(a);
            Assert.AreEqual(0.5, result, 0.1);
        }
    }
}