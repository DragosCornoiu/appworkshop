using System.ComponentModel.DataAnnotations;
using appworkshop.Base.Entities;

namespace appworkshop.Features.Users;

public class User : Entitiy
{
    public string Username { get; set; }
    [EmailAddress] public string Email { get; set; }
    public string Password { get; set; }
}