using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace LV4RPPOON
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            ArrayPrint(results, rowCount);
            return results;
        }

        public double[] PerColumnAverage(double[][] data)
        {
            int columnCount = data[0].Length;
            int rowCount = data.Length;
            double[] results = new double[columnCount];
            double[] elementPerColumn = new double[rowCount];
            for (int j = 0; j < columnCount; j++)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    elementPerColumn[i] = data[i][j];
                }
                results[j] = elementPerColumn.Average();
            }

            ArrayPrint(results, columnCount);
            return results;
        }
        public void ArrayPrint(double[] array, int rowCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine("\n");
        }
    }
}
