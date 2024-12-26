using Tyuiu.OsadetsAA.Sprint7.V7.Lib;
namespace Tyuiu.OsadetsAA.Sprint7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateAverageArea()
        {
            var areas = new List<double> { 50.5, 153.94, 6.0, 40.0 };
            var res = DataService.CalculateAverageArea(areas);
            double wait = 62.61;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CalculateMinArea()
        {
            var areas = new List<double> { 50.5, 153.94, 6.0, 40.0 };
            var res = DataService.CalculateMinArea(areas);
            double wait = 6.0;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CalculateMaxArea()
        {
            var areas = new List<double> { 50.5, 153.94, 6.0, 40.0 };
            var res = DataService.CalculateMaxArea(areas);
            double wait = 153.94;
            Assert.AreEqual(wait, res);
        }
    }
}