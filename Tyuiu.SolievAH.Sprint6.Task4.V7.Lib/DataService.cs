using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SolievAH.Sprint6.Task4.V7.Lib
{
    public class DataService : ISprint6Task4V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] resArr;
            int len = (stopValue - startValue) + 1;
            resArr = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 == 0)
                {
                    resArr[count] = 0;
                    count++;
                    continue;
                }
                else
                {
                    y = Math.Round((Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x), 2);
                    resArr[count] = y;
                    count++;
                    
                }

            }
            return resArr;
        }
        
    }
}
