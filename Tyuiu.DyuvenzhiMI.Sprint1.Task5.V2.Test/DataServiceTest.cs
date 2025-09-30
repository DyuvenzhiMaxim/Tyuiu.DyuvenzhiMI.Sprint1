
using Tyuiu.DyuvenzhiMI.Sprint1.Task5.V2.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double Fahrenheit = 39.2;
            var res = ds.FahrenheitToСelsius(Fahrenheit);
            Assert.AreEqual(4, res);
        }
    }
}
