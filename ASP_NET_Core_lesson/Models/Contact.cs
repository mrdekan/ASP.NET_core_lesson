using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Core_lesson.Models
{
    public class Contact
    {
        [Display(Name = "Enter your name:")]
        [Required(ErrorMessage = "You need to enter a name")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        [MaxLength(20, ErrorMessage = "Name is too long")]
        public string Name { get; set; }


        [Display(Name = "Enter your surname:")]
        [Required(ErrorMessage = "You need to enter a surname")]
        [MinLength(2, ErrorMessage = "Surname is too short")]
        [MaxLength(30, ErrorMessage = "Surname is too long")]
        public string Surname { get; set; }


        [Display(Name = "Enter your age:")]
        [Required(ErrorMessage = "You need to enter an age")]
        //[Range(10, 120, ErrorMessage = "Invalid age")]
        public int? Age { get; set; }


        [Display(Name = "Enter your Email:")]
        [Required(ErrorMessage = "You need to enter an Email")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }


        [Display(Name = "Enter your message:")]
        [Required(ErrorMessage = "You need to enter a mesage")]
        public string Message { get; set; }

    }
}
