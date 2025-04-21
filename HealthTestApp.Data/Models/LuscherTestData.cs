using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HealthTestApp.Data.Models
{
    public class LuscherTestData
    {
        // Test sequence data
        [JsonPropertyName("firstRound")]
        public List<string> FirstRound { get; set; } = new List<string>();

        [JsonPropertyName("secondRound")]
        public List<string> SecondRound { get; set; } = new List<string>();

        // Calculated results
        [JsonPropertyName("stressLevel")]
        public int StressLevel { get; set; }

        [JsonPropertyName("stressDescription")]
        public string StressDescription { get; set; }

        [JsonPropertyName("primaryTraits")]
        public List<string> PrimaryTraits { get; set; } = new List<string>();

        [JsonPropertyName("emotionalNeeds")]
        public string EmotionalNeeds { get; set; }

        [JsonPropertyName("suppressedTraits")]
        public List<string> SuppressedTraits { get; set; } = new List<string>();

        [JsonPropertyName("sequenceAnalysis")]
        public string SequenceAnalysis { get; set; }

        [JsonPropertyName("recommendations")]
        public List<string> Recommendations { get; set; } = new List<string>();

        // Summary scores/results for quick display
        [JsonPropertyName("primaryColor")]
        public string PrimaryColor { get; set; }

        [JsonPropertyName("rejectedColor")]
        public string RejectedColor { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    }
}
