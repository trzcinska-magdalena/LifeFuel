using System.ComponentModel.DataAnnotations;

namespace LifeFuel.Models
{
    public class Symptom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public virtual ICollection<DailyReportSymptom> DailyReportSymptoms { get; set; } = new List<DailyReportSymptom>();
    }
}
