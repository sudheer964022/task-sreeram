using Microsoft.AspNetCore.Mvc;

namespace task1.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult GetBalance()
        {
            return Json(new
            {
                isCash = 1,
                msb = 100,
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
            return Json(new { comClLst = new[] { 
                new { commonId = 1, commonCode = "Direct", commonName = "Direct" }, 
                new { commonId = 2, commonCode = "CRS", commonName = "CRS" } 
            } });
        }

        [HttpGet]
        public IActionResult getCashierList()
        {
            return Json(new { products = new[] { 
                new { id = 1, cashierName = "Cashier 1", cashierval = "Cashier 1" }, 
                new { id = 2, cashierName = "Cashier 2", cashierval = "Cashier 2" } 
            } });
        }

        [HttpGet]
        public IActionResult getRefByList()
        {
            return Json(new { comClLst = new[] { 
                new { commonId = 1, commonCode = "Self" }, 
                new { commonId = 2, commonCode = "Dr. House" } 
            } });
        }

        [HttpGet]
        public IActionResult getBTechList()
        {
            return Json(new { products = new[] { 
                new { id = 1, btechval = "BTech 1" }, 
                new { id = 2, btechval = "BTech 2" } 
            } });
        }

        [HttpGet]
        public IActionResult Getdistance(string distance)
        {
            return Json(new { distances = new[] { 
                new { distanceprice = 50, code = "AED" } 
            } });
        }

        [HttpPost]
        public IActionResult getDSAList(int rplId, int statusId)
        {
            return Json(new { data = new[] { 
                new { column0 = 1, column2 = "DSA Partner 1", column1 = "DSA001" } 
            } });
        }

        [HttpGet]
        public IActionResult Lead()
        {
            return Content("Order List Page Placeholder");
        }
    }
}
