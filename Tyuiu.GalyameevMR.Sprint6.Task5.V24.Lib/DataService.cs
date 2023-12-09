using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.GalyameevMR.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> list = new List<double>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double x = Convert.ToDouble(line);
                    if (x == 0)
                    {
                        list.Add(x);
                    }
                }
            }
            double[] array = list.ToArray();
            return array;
        }
      
    }
}
