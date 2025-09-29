
using Tyuiu.DyuvenzhiMI.Sprint1.Task3.V19.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 3;
            double x2 = 2;
            double y1 = 2;
            double y2 = 1;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(true, res);
        }
    }
}
