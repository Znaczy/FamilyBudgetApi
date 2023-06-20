namespace FamilyBudget.DataAccess.Entities.Account
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Budget Budget { get; set;}
    }
}
