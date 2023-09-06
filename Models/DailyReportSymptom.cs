using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeFuel.Models
{
    public class DailyReportSymptom
    {
        [Key]
        [ForeignKey("DailyReport")]
        public int DailyReportId { get; set; }
        [Key]
        [ForeignKey("Symptom")]
        public int SymptomId { get; set; }
        public DailyReport DailyReport { get; set; } = null!;
        public Symptom Symptom { get; set; } = null!;

    }
}
