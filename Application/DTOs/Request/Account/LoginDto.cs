using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Request.Account
{
    public class LoginDto
    {
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Student Identity must contain only digits.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Student Identity must contain exactly 6 digits.")]
        public string StudentId { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
