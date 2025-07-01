using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Task4.Models;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Info()
        {
            var model = new UserModel();
            model.Name = TempData["Name"] as string;
            model.Email = TempData["Email"] as string;
            return View(model);
        }

        public Task<IActionResult> Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["Name"] = model.Name;
                TempData["Email"] = model.Email;
                return Task.FromResult<IActionResult>(RedirectToAction(nameof(Info)));
            }
            return Task.FromResult<IActionResult>(View(model));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
