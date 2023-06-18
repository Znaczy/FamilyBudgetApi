namespace FamilyBudget.DataAccess.Entities.Account
{
    public class UserTransaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public List<Category> Categories { get; set; }
        public List<Filter> Fliters { get; set; }
    }
}