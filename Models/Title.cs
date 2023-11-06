using System.ComponentModel.DataAnnotations;

namespace Jobs_Portal.Models
{
    public class Title
    {
        public Title()
        {
            Jobs = new HashSet<Job>();
        }

        [Key]
        public int TitleCodeNo { get; set; }

        [Required]
        [StringLength(255)]
        public required string BusinessTitle { get; set; }

        [StringLength(255)]
        public required string TitleClassification { get; set; }

        [StringLength(255)]
        public required string CivilServiceTitle { get; set; }

        public required ICollection<Job> Jobs { get; set; }
    }
}
