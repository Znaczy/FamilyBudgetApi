using FamilyBudget.DataAccess.Context;
using FamilyBudget.DataAccess.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Services.Services
{
    public class UserService : IUserService
    {
        private readonly FamilyBudgetDbContext _context;

        public UserService(FamilyBudgetDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
