using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthTestApp.Data.Models
{
    public class TestAnswer
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Question")]
        public Guid QuestionId { get; set; }

        public string? AnswerText { get; set; }

        public int Score { get; set; }

        public TestQuestion Question { get; set; }
    }
}