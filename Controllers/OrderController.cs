using Microsoft.AspNetCore.Mvc;

namespace task1.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult GetBalance()
        {
            // Returning a dummy response to satisfy the frontend AJAX call
            return Json(new
            {
                isCash = 1,
                msb = 100, // Minimum billing amount
                discountSlabs = new[] 
                { 
                    new { thresholdAmount = 500, discountPercentage = 5 },
                    new { thresholdAmount = 1000, discountPercentage = 10 }
                }
            });
        }

        [HttpGet]
        public IActionResult getB2CSourceList()
        {
            return Json(new { data = new[] { 
                new { id = 1, sourceName = "Direct" }, 
                new { id = 2, sourceName = "Social Media" } 
            } });
        }

        [HttpGet]
        public IActionResult getCashierList()
        {
            return Json(new { data = new[] { 
                new { id = 1, cashierName = "Cashier 1" }, 
                new { id = 2, cashierName = "Cashier 2" } 
            } });
        }

        [HttpGet]
        public IActionResult getRefByList()
        {
            return Json(new { data = new[] { 
                new { id = 1, doctorName = "Self" }, 
                new { id = 2, doctorName = "Referral Doctor" } 
            } });
        }

        [HttpGet]
        public IActionResult Lead()
        {
            // This is just to satisfy the redirection if order entry succeeds
            return Content("Order List Page Placeholder");
        }
    }
}
