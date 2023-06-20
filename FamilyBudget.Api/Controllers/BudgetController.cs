using FamilyBudget.Api.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        // GET: BudgetController
        public async Task<ActionResult<List<BudgetDto>>> Index()
        {
            return Ok();
        }
    }
}
