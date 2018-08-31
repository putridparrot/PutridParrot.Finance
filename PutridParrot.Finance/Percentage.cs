namespace PutridParrot.Finance
{
    public class Percentage
    {
        private readonly double _value;

        private Percentage(double value)
        {
            _value = value;
        }

        public static Percentage FromDecimal(double value)
        {
            return new Percentage(value);
        }

        public static Percentage FromPercentage(double value)
        {
            return new Percentage(value / 100);
        }

        public double ToDecimal()
        {
            return _value;
        }

        public double ToPercentage()
        {
            return _value * 100;
        }

        public override string ToString()
        {
            return $"{ToDecimal()}%";
        }
    }
}
