using FamilyBudget.DataAccess.Context;
using FamilyBudget.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.DataAccess.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly FamilyBudgetDbContext _dbContext;

        public BudgetRepository(FamilyBudgetDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<Budget>> GetAllUserBudgetsById(int userId)
        {
            return await _dbContext.Budgets.Where(user => user.Id == userId).ToListAsync();
        }

        public async Task<Budget> GetBudgetById(int id)
        {
            return await _dbContext.Budgets.FirstAsync(budget  => budget.Id == id);
        }

        public async Task<List<Budget>> CreateBudgetAsync(Budget budget)
        {
            _dbContext.Budgets.Add(budget);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Budgets.ToListAsync();
        }
    }
}
