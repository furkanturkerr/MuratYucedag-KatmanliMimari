using Microsoft.AspNetCore.Identity;

namespace EntityLayer;

public class AppUser:IdentityUser<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Gender { get; set; }
}