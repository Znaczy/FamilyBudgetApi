using FamilyBudget.DataAccess.Entities.Account;
using Microsoft.Identity.Client;

namespace FamilyBudget.Services.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();
    }
}