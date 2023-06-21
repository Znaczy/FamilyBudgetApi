using FamilyBudget.DataAccess.Entities.Account;

namespace FamilyBudget.DataAccess.Repositories
{
    public interface IBudgetRepository
    {
        public Task<List<Budget>> GetAllUserBudgetsById(int userId);
        public Task<List<Budget>> CreateBudgetAsync(Budget budget);

    }
}