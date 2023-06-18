namespace FamilyBudget.DataAccess.Entities.Account
{
    public class Budget
    {
        public int Id { get; set; }
        public User User { get; set; }
        public decimal Balance { get; set; }

        public List<UserTransaction> Transactions { get; set; }
        
    }
}