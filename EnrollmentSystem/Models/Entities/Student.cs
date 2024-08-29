using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Entities
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(25)]
        public string ?Firstname { get; set; }
        [MaxLength(25)]
        public string Lastname { get; set; } = string.Empty;
    }
}
