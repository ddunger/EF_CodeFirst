using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }

        [StringLength(250)]
        public string GradeName { get; set; }

        [StringLength(250)]
        public string Section { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
