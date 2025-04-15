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
        public List<double> BloodPressureMedians { get; set; } = new( Enumerable.Repeat(0.0, 8));
        public List<double> PulsePressures { get; set; } = new(Enumerable.Repeat(0.0, 8));
        public List<double> EjectedBloodMasses { get; set; } = new(Enumerable.Repeat(0.0, 8));
        public List<CardiacDuration> CardiacDurations { get; set; } = new();
        public List<double> ExternalWorks { get; set; } =  new(Enumerable.Repeat(0.0, 8));
        public List<double> KineticWorks { get; set; } = new(Enumerable.Repeat(0.0, 8));
        public List<double> TotalWorks { get; set; } = new(Enumerable.Repeat(0.0, 8));
        public List<double> AveragePowers { get; set; } = new(Enumerable.Repeat(0.0, 8));
        public Dictionary<string, double> Outputs { get; set; } = new();

        public RuffierDicksonTestData()
        {
            Measurements = Enumerable.Range(0, 8).Select(_ => new MeasurementEntry()).ToList();
            CardiacDurations = Enumerable.Range(0, 8).Select(d => new CardiacDuration()).ToList();
        }

    }
    public class CardiacDuration()
    {
        public double CardiacCycleDurationSeconds { get; set; }
        public double SystoleDurationSeconds { get; set; }
    }
}
