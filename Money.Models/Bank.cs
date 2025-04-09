using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Money.Data;

#nullable disable

namespace Money.Models;

public class Bank
{
    [Key]
    [Required(ErrorMessage = "Account Number is required")]
    public string AccountNumber { get; set; }

    [Required(ErrorMessage = "Bank Name is required")]
    public string Name { get; set; }

    public string AccountType { get; set; }
    public decimal Balance { get; set; }
    public string ApplicationUserId { get; set; }

    [ForeignKey("ApplicationUserId")]
    public ApplicationUser ApplicationUser { get; set; }

}

#nullable enable