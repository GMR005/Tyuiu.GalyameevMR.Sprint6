using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalyameevMR.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] tab = new double[size];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double checkToZero = Math.Cos(x) + x;
                double value;

                if (Math.Abs(checkToZero) < double.Epsilon)
                {
                    value = 0;
                }
                else
                {
                    value = ((2 * x - 3) / (Math.Cos(x) + x)) + 5;
                }

                tab[i] = Math.Round(value, 2);
                i++;
            }

            return tab;
        }
    }
}
