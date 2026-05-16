using Microsoft.AspNetCore.Mvc;

namespace task1.Controllers
{
    public class CommonController : Controller
    {
        [HttpGet]
        public IActionResult getPayModeList()
        {
            return Json(new { comClLst = new[] { 
                new { commonId = 1, commonCode = "Cash" }, 
                new { commonId = 2, commonCode = "Card" }, 
                new { commonId = 3, commonCode = "Online" } 
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
        public IActionResult getCreditCardList()
        {
            return Json(new { comClLst = new[] { 
                new { commonId = 1, commonCode = "Visa" }, 
                new { commonId = 2, commonCode = "MasterCard" } 
            } });
        }
    }
}
