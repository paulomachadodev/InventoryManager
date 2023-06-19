using InventoryManager.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.Presentation.Controllers.V1
{
    public class TransactionController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Register(TransactionRegisterViewModel model)
        {
            return Ok();
        }
    }
}
