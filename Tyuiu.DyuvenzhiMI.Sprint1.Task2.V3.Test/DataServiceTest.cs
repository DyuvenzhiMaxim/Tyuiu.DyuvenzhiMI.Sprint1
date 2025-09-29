
using Tyuiu.DyuvenzhiMI.Sprint1.Task2.V3.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint1.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertHourToMin(x);
            Assert.AreEqual(x*60, res);
        }
    }
}
