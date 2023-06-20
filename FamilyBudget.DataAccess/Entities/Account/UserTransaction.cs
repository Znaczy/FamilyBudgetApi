namespace FamilyBudget.DataAccess.Entities.Account
{
    public class UserTransaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Category Category { get; set; }
        public List<Filter> Filters { get; set; }
    }
}