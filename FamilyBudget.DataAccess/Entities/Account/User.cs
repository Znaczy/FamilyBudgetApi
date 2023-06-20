using Microsoft.AspNetCore.Identity;

namespace FamilyBudget.DataAccess.Entities.Account
{
    public class User : IdentityUser<int>
    {
        public IEnumerable<Budget> Budgets { get; set; }
    }
}
