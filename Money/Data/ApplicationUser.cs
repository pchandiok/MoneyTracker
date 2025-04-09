using Microsoft.AspNetCore.Identity;
using Money.Models;

#nullable disable

namespace Money.Data;
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public ICollection<Bank> Banks { get; set; }
}

#nullable enable