namespace FamilyBudget.DataAccess.Entities.Account
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Budget Budget { get; set;}
    }
}
