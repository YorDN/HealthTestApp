using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTestApp.Data.Models
{
    public class RuffierDicksonTestData
    {
        public List<MeasurementEntry> Measurements { get; set; } = new();   
        public List<double> Medians { get; set; } = new(Enumerable.Repeat(0.0, 3));
        public Dictionary<string, double> Outputs { get; set; } = new();
        public RuffierDicksonTestData()
        {
            Measurements = Enumerable.Range(0, 8).Select(_ => new MeasurementEntry()).ToList();

        }

    }
}
