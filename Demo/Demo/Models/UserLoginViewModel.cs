using System.ComponentModel.DataAnnotations;

namespace Demo.Models;

public class UserLoginViewModel
{
    [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
    public string Usernme { get; set; }
    [Required(ErrorMessage = "Lütfen şifre giriniz.")]
    public string Password { get; set; }
}