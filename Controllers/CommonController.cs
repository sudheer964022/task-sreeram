using Microsoft.AspNetCore.Mvc;

namespace task1.Controllers
{
    public class CommonController : Controller
    {
        [HttpGet]
        public IActionResult getPayModeList()
        {
            return Json(new { paymode = new[] { 
                new { id = 1, payMode = "Cash" }, 
                new { id = 2, payMode = "Card" }, 
                new { id = 3, payMode = "Online" } 
            } });
        }

        [HttpGet]
        public IActionResult getGenderList()
        {
            return Json(new { gender = new[] { 
                new { id = 1, gender = "Male" }, 
                new { id = 2, gender = "Female" }, 
                new { id = 3, gender = "Other" } 
            } });
        }

        [HttpGet]
        public IActionResult getAgeTypeList()
        {
            return Json(new { agetype = new[] { 
                new { id = "Y", ageType = "Years" }, 
                new { id = "M", ageType = "Months" }, 
                new { id = "D", ageType = "Days" } 
            } });
        }

        [HttpGet]
        public IActionResult getTitleList()
        {
            return Json(new { title = new[] { 
                new { id = 1, title = "Mr." }, 
                new { id = 2, title = "Mrs." }, 
                new { id = 3, title = "Ms." },
                new { id = 4, title = "Dr." } 
            } });
        }

        [HttpGet]
        public IActionResult getBranchList()
        {
            return Json(new { branch = new[] { 
                new { id = 1, branchName = "Main Branch" }, 
                new { id = 2, branchName = "City Center" } 
            } });
        }

        [HttpGet]
        public IActionResult CreditCards()
        {
            return Json(new { data = new[] { 
                new { id = 1, cardName = "Visa" }, 
                new { id = 2, cardName = "MasterCard" } 
            } });
        }

        [HttpGet]
        public IActionResult cashier()
        {
            return Json(new { data = new[] { 
                new { id = 1, cashierName = "John Doe" }, 
                new { id = 2, cashierName = "Jane Smith" } 
            } });
        }

        [HttpGet]
        public IActionResult Source()
        {
            return Json(new { data = new[] { 
                new { id = 1, sourceName = "Walk-in" }, 
                new { id = 2, sourceName = "CRS" },
                new { id = 3, sourceName = "Website" }
            } });
        }

        [HttpGet]
        public IActionResult refby()
        {
            return Json(new { data = new[] { 
                new { id = 1, doctorName = "Dr. House" }, 
                new { id = 2, doctorName = "Dr. Watson" } 
            } });
        }
    }
}
