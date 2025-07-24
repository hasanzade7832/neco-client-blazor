namespace BlazorApp12.Models;

using System.ComponentModel.DataAnnotations;

public class LoginModel
{
    [Required(ErrorMessage = "ایمیل الزامی است")]
    [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "کلمه عبور الزامی است")]
    public string? Password { get; set; }
}
