using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PoleschukKR.Sprint1.TaskReview.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double schet = x - Math.Pow(10, Math.Sin(x)) + ((20 * Math.Pow (x, 2)) / (3 * Math.Pow (x, 3))) + Math.Cos (Math.Pow(x, 2) - y);
            double res = Math.Round(schet, 3);
            return res;
        }
    }
}
