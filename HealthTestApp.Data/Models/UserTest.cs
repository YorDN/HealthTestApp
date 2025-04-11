using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTestApp.Data.Models
{
    public class UserTest
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }

        [ForeignKey("Test")]
        public Guid TestId { get; set; }

        public int Score { get; set; }

        public string? Result { get; set; }

        public DateTime TakenAt { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Test Test { get; set; }
    }
}
