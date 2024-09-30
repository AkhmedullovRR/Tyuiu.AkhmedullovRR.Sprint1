using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AkhmedullovRR.Sprint1.Task2.V1.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(1, res);
        }
    }
}