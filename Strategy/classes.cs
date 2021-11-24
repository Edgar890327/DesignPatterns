namespace Strategy
{
    public interface IStrategy
    {
        double Operation(double a, double b) => a + b;
    }

    public class AddStrategy : IStrategy { }

    public class SubstractStrategy : IStrategy
    {
        public double Operation(double a, double b) => a - b;
    }

    public class MultStrategy : IStrategy
    {
        public double Operation(double a, double b) => a * b;
    }

    public class DivStrategy : IStrategy
    {
        public double Operation(double a, double b) => a / b;
    }

    public class GaussStrategy : IStrategy
    {
        public double Operation(double a, double b) => a>b?GaussOperation(a)-GaussOperation(b-1):Operation(b,a);

        private double GaussOperation(double n)
        {
            return (n + 1) * n / 2;
        }
    }

}
