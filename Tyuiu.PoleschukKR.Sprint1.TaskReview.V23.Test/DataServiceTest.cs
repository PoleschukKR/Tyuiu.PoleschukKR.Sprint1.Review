using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint1.TaskReview.V23.Lib;

namespace Tyuiu.PoleschukKR.Sprint1.TaskReview.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = -3.772;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);
        }
    }
}
