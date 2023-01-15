using System.ComponentModel.DataAnnotations;

namespace Proj.Models;
public class User
{
    [Required(ErrorMessage = "Please enter your name !")]
    [Display(Name = "User Name")]
    [MaxLength(10, ErrorMessage = "Please enter just 10 chars")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please enter your Fmaily !")]
    [Display(Name = "User Family")]
    public string? Family { get; set; }

    [Required(ErrorMessage = "Please Enter your password !")]
    [Display(Name = "User Password")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage ="Please enter 8 chars")]
    public string? Password { get; set; }
}