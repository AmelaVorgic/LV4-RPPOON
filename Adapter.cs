using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace LV4RPPOON
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            double[][] matrix = new double[dataset.GetData().Count][];
            int i = 0;
            foreach (List<double> list in dataset.GetData())
            {
                matrix[i] = list.ToArray<double>();
                i++;
            }

            return matrix;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
