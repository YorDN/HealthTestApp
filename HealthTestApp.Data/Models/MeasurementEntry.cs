using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTestApp.Data.Models
{
    public class MeasurementEntry
    {
        public string Systolic { get; set; } = string.Empty;
        public string Diastolic { get; set; } = string.Empty;
        public string HeartRate { get; set; } = string.Empty;
    }
}
