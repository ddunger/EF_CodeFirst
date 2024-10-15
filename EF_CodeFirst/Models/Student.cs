using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }


        [Column(TypeName = "nchar(50)")]
        public string StudentName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Width { get; set; }
    }
}
