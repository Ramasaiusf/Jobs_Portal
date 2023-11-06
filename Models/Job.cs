using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Jobs_Portal.Models
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }

        [StringLength(255)]
        public string PostingType { get; set; }

        [StringLength(255)]
        public string Agency { get; set; }

        public int NumberOfPositions { get; set; }

        public int LevelID { get; set; }

        [StringLength(255)]
        public string ResidencyRequirement { get; set; }

        [StringLength(255)]
        public string RecruitmentContact { get; set; }

        [StringLength(255)]
        public string SalaryFrequency { get; set; }

        public double SalaryRangeFrom { get; set; }

        public double SalaryRangeTo { get; set; }

        [StringLength(50)]
        public string FullTimePartTimeIndicator { get; set; }

        public int TitleCodeNo { get; set; }

        public int TitleCodeNo1 { get; set; } // Another column in the Job table

        [StringLength(255)]
        public string WorkLocationAgency { get; set; }

        [StringLength(255)]
        public string DivisionWorkUnit { get; set; }

        [Column(TypeName = "text")]
        public string MinimumQualRequirements { get; set; }

        [Column(TypeName = "text")]
        public string JobDescription { get; set; }

        [Column(TypeName = "text")]
        public string PreferredSkills { get; set; }

        [Column(TypeName = "text")]
        public string ToApply { get; set; }

        [StringLength(255)]
        public string HoursShift { get; set; }

        public DateTime PostingDate { get; set; }

        public DateTime PostUntil { get; set; }

        public DateTime PostingUpdated { get; set; }

        public DateTime ProcessDate { get; set; }

        [StringLength(255)]
        public string WorkLocation1 { get; set; }

        [Column(TypeName = "text")]
        public string AdditionalInformation { get; set; }

        // Navigation properties
        [ForeignKey("TitleCodeNo")]
        public Title Title { get; set; }

        [ForeignKey("LevelID")]
        public Level Level { get; set; }
    }
}
