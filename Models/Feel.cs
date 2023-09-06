using System.ComponentModel.DataAnnotations;

namespace LifeFuel.Models
{
    public class Feel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public virtual ICollection<DailyReport> DailyReports { get; set; } = new List<DailyReport>();
    }
}
