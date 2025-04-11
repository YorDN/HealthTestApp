using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthTestApp.Data.Models
{
    public class TestResult
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Test")]
        public Guid TestId { get; set; }

        public int MinScore { get; set; }

        public int MaxScore { get; set; }

        public string? Interpretation { get; set; }

        public Test Test { get; set; }
    }
}