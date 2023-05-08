using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.ViewModels
{
    public class SignupViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
