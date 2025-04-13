using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTestApp.Data.Models
{
    public class RuffierDicksonTestData
    {
        public List<MeasurementEntry> Measurements { get; set; } = new();   
        public List<string> Medians { get; set; } = new(Enumerable.Repeat("", 3));
        public Dictionary<string, string> Outputs { get; set; } = new();
        public RuffierDicksonTestData()
        {
            for (int i = 0; i < 8; i++)
            {
                //To pre-fill the List with 8 measurements.
                Measurements.Add(new MeasurementEntry());
            }
        }

    }
}
