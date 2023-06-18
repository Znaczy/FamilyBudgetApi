using System.ComponentModel.DataAnnotations;

namespace FamilyBudget.Api.Dtos
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        public List<BudgetDto> Budgets { get; set; }
    }
}