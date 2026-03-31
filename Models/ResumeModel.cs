using System.ComponentModel.DataAnnotations;

namespace resume.Models
{
    public class ResumeModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Phone number is required")]
        public string Phone { get; set; } = "";

        [Required(ErrorMessage = "Career objective is required")]
        public string Objective { get; set; } = "";

        [Required(ErrorMessage = "Education is required")]
        public string Education { get; set; } = "";

        [Required(ErrorMessage = "Skills are required")]
        public string Skills { get; set; } = "";

        [Required(ErrorMessage = "Experience is required")]
        public string Experience { get; set; } = "";

        [Required(ErrorMessage = "Achievements are required")]
        public string Achievements { get; set; } = "";

        [Required]
        public string Template { get; set; } = "classic";
    }
}

