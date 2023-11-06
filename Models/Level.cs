using System.ComponentModel.DataAnnotations;

namespace Jobs_Portal.Models
{
    public class Level
    {
        public Level()
        {
            Jobs = new HashSet<Job>();
        }

        [Key]
        public int LevelID { get; set; }

        [Required]
        [StringLength(255)]
        public required string CareerLevel { get; set; }

        [StringLength(255)]
        public required string JobCategory { get; set; }

        public required ICollection<Job> Jobs { get; set; }
    }
}
