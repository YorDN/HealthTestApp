using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTestApp.Data.Models.Enumerations;

namespace HealthTestApp.Data.Models
{
    public class Test
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(255)]
        [Required]
        public required string Name { get; set; }

        public string? Description { get; set; }

        public string Difficulty { get; set; } = "Normal";

        public int EstimatedDuration { get; set; }

        [MaxLength(10)]
        [Required]
        public required TestType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<TestQuestion> Questions { get; set; } = new List<TestQuestion>();
        public ICollection<TestResult> Results { get; set; } = new List<TestResult>();
    }
}
