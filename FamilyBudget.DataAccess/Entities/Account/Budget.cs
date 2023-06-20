using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FamilyBudget.DataAccess.Entities.Account
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }

        public List<UserTransaction> Transactions { get; set; }
        
    }
}