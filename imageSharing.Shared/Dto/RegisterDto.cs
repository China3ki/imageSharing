using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace imageSharing.Shared.Dto
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Email is required!"), EmailAddress(ErrorMessage = "Email is not valid!")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Nickname is required!")]
        public string Nickname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required!"), MinLength(8), RegularExpression("^(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z0-9]).+$", ErrorMessage = "Password is not valid!")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Confirmed password is required"), Compare(nameof(Nickname), ErrorMessage = "Password are no the same!")]
        public string ConfirmedPassword { get; set; } = string.Empty;
    }
}
