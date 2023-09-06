using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeFuel.Models
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; } = null!;

        [Required]
        public DateOnly BirthDate { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<DailyReportSymptom> DailyReportSymptoms { get; set; } = new List<DailyReportSymptom>();
    }
}
