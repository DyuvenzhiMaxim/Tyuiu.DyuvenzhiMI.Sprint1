
using Microsoft.Testing.Platform.MSBuild;
using Tyuiu.DyuvenzhiMI.Sprint1.Task6.V16.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string strTest = "Привет! Как дела?";
            Boolean res = ds.CheckSpecSymbols(strTest);
            Boolean wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
