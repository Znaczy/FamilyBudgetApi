using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        // GET: BudgetController
        public ActionResult Index()
        {
            var je = "test";
            return Ok();
        }

        // GET: BudgetController/Details/5
        public ActionResult Details(int id)
        {
            return Ok();
        }

        // GET: BudgetController/Create
        public ActionResult Create()
        {
            return Ok();
        }

        // POST: BudgetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: BudgetController/Edit/5
        public ActionResult Edit(int id)
        {
            return Ok();
        }

        // POST: BudgetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: BudgetController/Delete/5
        public ActionResult Delete(int id)
        {
            return Ok();
        }

        // POST: BudgetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }
    }
}
