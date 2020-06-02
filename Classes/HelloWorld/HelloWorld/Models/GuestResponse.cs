using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }
        [Phone]
        [Required(ErrorMessage = "Please enter your Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your attend status")]
        public bool? WillAttend { get; set; }
    }
}
