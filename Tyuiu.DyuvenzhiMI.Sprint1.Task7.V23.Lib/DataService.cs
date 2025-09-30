
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DyuvenzhiMI.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            var d1 = x - Math.Pow(10, Math.Sin(x));
            var d2 = (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));
            var d3 = Math.Cos(Math.Pow(x, 2) - y);
            var res = d1 + d2 + d3;

            return Math.Round(res, 3);

        }
    }
}
