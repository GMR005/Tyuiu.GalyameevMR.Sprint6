using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalyameevMR.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] tab = new double[size];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double checkToZero = Math.Sin(x) + 3;
                double value;

                if (checkToZero == 0)
                {
                    value = 0;
                }
                else
                {
                    value = ((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x);
                }

                tab[i] = Math.Round(value, 2);
                i++;
            }

            return tab;
        }
    }
}
