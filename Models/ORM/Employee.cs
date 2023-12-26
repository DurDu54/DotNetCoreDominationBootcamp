using System.ComponentModel.DataAnnotations;

namespace DotNetCoreDominationBootcampDay3.Models.ORM
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad boş geçilemez.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad boş geçilemez.")]
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }

}
