using System.ComponentModel.DataAnnotations;

namespace TeacherAPI.Models
{
    public enum DegreeType
    {
        Bachelor,
        Doctorate,
    }
    public class Teacher
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [EnumDataType(typeof(DegreeType))]
        public string Degree { get; set; }
    }
}
