using FamilyBudget.DataAccess.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.DataAccess.Context
{
    public class FamilyBudgetDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public FamilyBudgetDbContext(DbContextOptions<FamilyBudgetDbContext> options) : base(options)
        {
            
        }

        public DbSet<Budget> Budgets { get; set; }
    }
}
