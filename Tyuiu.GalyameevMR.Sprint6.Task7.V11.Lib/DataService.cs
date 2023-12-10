using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.GalyameevMR.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[5,j] < 0)
                    {
                        matrix[5, j] = 9;
                    }
                }
            }
            return matrix;


        }
    }
}
