using System.ComponentModel.DataAnnotations;

namespace FamilyBudget.DataAccess.Entities.Account
{
    public class UserTransaction
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
        public TransactionType Type { get; set; }
    }
}