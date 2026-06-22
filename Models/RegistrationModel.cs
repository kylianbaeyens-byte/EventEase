using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Models;

// Backs the registration form. Data annotations validate user input
// (name + a well-formed email) before a registration is accepted.
public class RegistrationModel
{
    [Required(ErrorMessage = "Your name is required.")]
    [StringLength(100, ErrorMessage = "Name must be 100 characters or fewer.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;
}
