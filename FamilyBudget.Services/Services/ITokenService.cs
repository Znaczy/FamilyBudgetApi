using FamilyBudget.DataAccess.Entities.Account;

namespace FamilyBudget.Services.Services
{
    public interface ITokenService
    {
        public string CreateToken(User user, IEnumerable<string> roles);
    }
}

