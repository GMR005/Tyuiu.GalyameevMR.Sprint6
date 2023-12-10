using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GalyameevMR.Sprint6.Task0.V22.Lib 
{
    public class DataService : ISprint6Task0V22
    {
        public double Calculate(int x)
        {
           double y = 0.7*Math.Pow(x,3) + 1.52*Math.Pow(x,2);
            y = Math.Round(y, 2); 
            return y;

        }
    }
}
