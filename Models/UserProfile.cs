using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeFuel.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; } = null!;

        [Required]
        [MinLength(3)]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<DailyReport> DailyReports { get; set; } = new List<DailyReport>();
    }
}
