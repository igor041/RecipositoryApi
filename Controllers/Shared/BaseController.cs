using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipositoryApi.Controllers.Shared
{
    public class BaseController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("throwErrorBase")]
        public virtual ActionResult ThrowError(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException($"Throwing Error From:");
            }

            return Ok(true);
        }
    }
}
