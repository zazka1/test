using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSPTest.Models;

namespace PSPTest.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Validate(ValidatePaymentModel model)
        {
            if (model.Is3D)
            {
                return Redirect("https://localhost:44321/");
            }
            if (model.CVV == "123")
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Bank3DSUrl()
        {
            return Ok("https://localhost:44321/card/confirm");
        }
    }
}