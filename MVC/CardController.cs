using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PSPTest.Models;

namespace PSPTest.MVC
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Confirm(string redirectUrl)
        {
            var model = new SecurityValidateModel() { RedirectUrl = redirectUrl };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Confirm(SecurityValidateModel model)
        {
            var success = false;
            if (model.Password == "123")
            {
                success = true;
            }

            return Redirect($"{model.RedirectUrl}?success={success}");
        }
    }
}