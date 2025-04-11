using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTestApp.Data.Models.Enumerations;

namespace HealthTestApp.Data.Models
{
    public class PhysicalMetric
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }

        [MaxLength(50)]
        [Required]
        public required MetricType MetricType { get; set; }

        [MaxLength(50)]
        public string Value { get; set; }

        public DateTime RecordedAt { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
