
using Tyuiu.DyuvenzhiMI.Sprint1.Task4.V14.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint1.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1; double y = 2;
            var res = ds.Calculate(x, y);

            Console.WriteLine("Ответ: " + res);

            Assert.AreEqual(0.236, res);
        }
    }
}
