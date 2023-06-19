using InventoryManager.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.Presentation.Controllers.V1
{
    public class MerchandiseController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Register(MerchandiseRegisterViewModel model) 
        {
            return Ok();
        }
    }
}
