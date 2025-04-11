using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthTestApp.Data.Models
{
    public class TestQuestion
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Test")]
        public Guid TestId { get; set; }

        public string? QuestionText { get; set; }

        public int Order { get; set; }

        public Test Test { get; set; }
        public ICollection<TestAnswer> Answers { get; set; }
    }
}