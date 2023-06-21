using FamilyBudget.Api.Dtos;
using FamilyBudget.DataAccess.Entities.Account;
using FamilyBudget.DataAccess.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetRepository _budgetRepository;

        public BudgetController(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        [Authorize(Roles = "AppUser")]
        [HttpGet("{id}")]
        public async Task<ActionResult<List<BudgetDto>>> GetAllUserBudgetsByIdAsync(int userId)
        {
            var budgets = await _budgetRepository.GetAllUserBudgetsById(userId);
            //map to BudgetDTO
            return Ok(budgets);
        }

        [Authorize(Roles = "AppUser")]
        [HttpPost]
        public async Task<ActionResult<List<BudgetDto>>> CreateBudgetAsync(BudgetDto budgetDto)
        {
            var budget = new Budget()
            {
                User = budgetDto.User
            };

            var list = _budgetRepository.CreateBudgetAsync(budget);
            //map to dto and return list
            return Ok();
        }
    }
}
