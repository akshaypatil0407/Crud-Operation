using System.ComponentModel.DataAnnotations;

namespace EmployeeInformation.Models
{
    public class Employee_Details
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }
        public DateTime DOB { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string Age { get; set; }
        public string Address { get; set; }
    }
}
