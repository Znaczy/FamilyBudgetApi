using FamilyBudget.DataAccess.Entities.Account;

namespace FamilyBudget.Api.Dtos
{
    public class BudgetDto
    {
        public int Id { get; set; }
        public User User { get; set; }

        public List<UserTransaction> Transactions { get; set; }
    }
}
