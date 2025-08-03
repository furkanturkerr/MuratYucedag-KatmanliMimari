using System.ComponentModel.DataAnnotations;

namespace Demo.Models;

public class UserEditViewModel
{
    [Required(ErrorMessage = "Lütfen isim değeri giriniz.")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Lütfen soyisim değeri giriniz.")]
    public string SurName { get; set; }
    
    [Required(ErrorMessage = "Lütfen mail giriniz.")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Lütfen şifre giriniz.")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
    [Compare("Password", ErrorMessage = "Lütfen şifrelerinizin eşleştiğinden emin olun.")]
    public string ConfirmPassword { get; set; }
}