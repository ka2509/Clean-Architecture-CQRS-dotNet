using Domain.Const;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Request.Account
{
    public class RegisterDto
    {
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Student Identity must contain only digits.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Student Identity must contain exactly 6 digits.")]
        public string StudentId { get; set; }
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required, Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public string Address { get; set; } = string.Empty;
    }
}
