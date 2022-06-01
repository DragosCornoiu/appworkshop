using System.ComponentModel.DataAnnotations;

namespace appworkshop.Features.Users;

public class UserRequest
{
    [Required] public string Username { get; set; }
    [Required] public string Password { get; set; }
    [Required] [EmailAddress] public string Email { get; set; }
}