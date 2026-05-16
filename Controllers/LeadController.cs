using Microsoft.AspNetCore.Mvc;

namespace task1.Controllers
{
    public class LeadController : Controller
    {
        public IActionResult Index()
        {
            // Set default session values to avoid null reference issues in the view
            HttpContext.Session.SetInt32("CountryId", 4); // Default to UAE
            HttpContext.Session.SetInt32("RateType", 2);
            HttpContext.Session.SetInt32("SubtypeId", 1);
            HttpContext.Session.SetInt32("RPLId", 6);

            return View();
        }

        [HttpGet]
        public IActionResult NationalityList()
        {
            return Json(new { usernation = new[] { 
                new { id = 1, nationality = "Emirati" }, 
                new { id = 2, nationality = "Bahraini" }, 
                new { id = 3, nationality = "Omani" },
                new { id = 4, nationality = "Saudi" },
                new { id = 5, nationality = "Indian" }
            } });
        }

        [HttpGet]
        public IActionResult ProductList(int labId, int prdcTp, int leadClientId)
        {
            return Json(new { products = new[] { 
                new { 
                    productId = 1, 
                    productName = "Complete Blood Count", 
                    shortName = "CBC", 
                    productCode = "T001", 
                    billedAmount = 150, 
                    currencyCode = "AED", 
                    decimalPoints = 2, 
                    labId = 1,
                    gender = "ALL",
                    maleSAge = 0, maleEAge = 100,
                    femaleSAge = 0, femaleEAge = 100,
                    isMyProfile = 0
                },
                new { 
                    productId = 2, 
                    productName = "Lipid Profile", 
                    shortName = "LIPID", 
                    productCode = "T002", 
                    billedAmount = 250, 
                    currencyCode = "AED", 
                    decimalPoints = 2, 
                    labId = 1,
                    gender = "ALL",
                    maleSAge = 18, maleEAge = 100,
                    femaleSAge = 18, femaleEAge = 100,
                    isMyProfile = 1
                }
            } });
        }

        [HttpPost]
        public IActionResult producttestlist(int ProductId)
        {
            return Json(new { d = new[] { 
                new { sampletypeid = 1, profiles = "EDTA", productCode = "T001" } 
            } });
        }

        [HttpPost]
        public IActionResult Getbooking(int leadId, int productId, int blockId)
        {
            return Json(new { data = new[] { 
                new { 
                    column1 = "John Doe", column2 = "john@example.com", column3 = "971501234567", column4 = "784-1234-1234567-1",
                    column8 = "L0001", column9 = "1", column12 = "1", column13 = "2", column14 = "AED", column26 = "1", column27 = "1", column29 = "0"
                }
            } });
        }

        [HttpPost]
        public IActionResult GetCRSPartners(int locationId, int isActive, string globalSearch)
        {
            // Dummy data for CRS partners
            return Json(new
            {
                success = true,
                data = new[]
                {
                    new { id = 1, crsName = "Partner A", crsCode = "PA001" },
                    new { id = 2, crsName = "Partner B", crsCode = "PB002" }
                }
            });
        }

        [HttpPost]
        public IActionResult B2COrderEntry([FromBody] object orderRows)
        {
            // Dummy success response for order entry
            return Json(new
            {
                _resId = "1",
                _resMsg = "Order Entry done Successfully."
            });
        }
    }
}
