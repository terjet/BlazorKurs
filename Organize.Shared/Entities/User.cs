using System.ComponentModel.DataAnnotations;

namespace Organize.Shared.Entities;
public class User
{
    [Required]
    public string? UserName {get;set;}

    [Required(ErrorMessage = "Password is required!")]
    public string? Password {get;set;}
    
}