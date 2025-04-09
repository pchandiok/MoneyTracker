using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Money.Data;

namespace Money.Models;
public class Bank
{
    [Key]
    public string AccountNumber { get; set; }
    public string Name { get; set; }
    public string AccountType { get; set; }
    public decimal Balance { get; set; }
    public string ApplicationUserId { get; set; }

    [ForeignKey("ApplicationUserId")]
    public ApplicationUser ApplicationUser { get; set; }
}
