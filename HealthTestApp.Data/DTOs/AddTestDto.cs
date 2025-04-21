using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTestApp.Data.DTOs
{
    public class AddTestDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Type { get; set; }
        public string Difficulty { get; set; }
        public string Duration { get; set; }
    }
}
