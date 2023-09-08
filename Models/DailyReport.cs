using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeFuel.Models
{
    public class DailyReport
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserProfile")]
        public int UserProfileId { get; set; }
        public int FeelId { get; set; }
        public int Energy { get; set; }
        public int Hunger { get; set; }
        public virtual ICollection<DailyReportSymptom> DailyReportSymptoms { get; set; } = new List<DailyReportSymptom>();
        public virtual Feel Feel { get; set; } = null!;
        public virtual UserProfile UserProfile { get; set; } = null!;

    }
}
