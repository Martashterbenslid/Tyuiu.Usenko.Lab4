namespace ArithmeticCalc.Lib
{
    public class Arithmetic
    {
        public double CalcPower(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Отрицательное число!");
            }
            return Math.Sqrt(a);
        }
        public double CalcLog(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Неверные входные значения! Выберете число > 0");
            }
            return Math.Log(a, b);
        }
        public double CalcSin(double a)
        {
            return Math.Sin(a);
        }

        public double CalcCos(double a)
        {
            return Math.Cos(a);
        }
    }
}