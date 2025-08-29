using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace BlazorEmployeeCRUD.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }






        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Name must be 2–15 characters.")]
        [RegularExpression(
        @"^(?=.*[a-z])(?=.*[A-Z])(?!\s)[A-Za-z][A-Za-z ]{1,14}$",
        ErrorMessage = "Name must include upper & lower case, no leading space, only letters & spaces.")]
        public string Name { get; set; }






        [Required]
        [RegularExpression(@"^[A-Za-z]{3,10}$",
    ErrorMessage = "Should Contain minimum 3 characters")]
        public string Position { get; set; }






        public DateOnly DOB { get; set; }




        public bool Status { get; set; } = true;
    }
}
