using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeFuel.Models
{
    [PrimaryKey(nameof(DailyReportId), nameof(SymptomId))]
    public class DailyReportSymptom
    {
        //[Key, Column(Order = 0)]
        [ForeignKey("DailyReport")]
        public int DailyReportId { get; set; }
        //[Key, Column(Order = 1)]
        [ForeignKey("Symptom")]
        public int SymptomId { get; set; }
        public DailyReport DailyReport { get; set; } = null!;
        public Symptom Symptom { get; set; } = null!;

    }
}
