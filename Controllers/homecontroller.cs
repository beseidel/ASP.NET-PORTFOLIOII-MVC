
using Microsoft.AspNetCore.Mvc;
namespace PortfolioII    //be sure to use your own project's namespace!

{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        // [HttpGet]       //type of request
        // [Route("")]     //associated route string (exclude the leading /)

        [HttpGet("")]

        public ViewResult Index()
        // public string Index()
        {

            // return "Hello World from HomeController!";
            //  this Hello World will show  above in the browser.  
            return View();
            // if there are no arguments in the return View();, then the computer will look for the name of the ViewResult which is Index here.   and it will find the action called Index. 
        }



        // Other code
        [HttpGet]
        [Route("Projects")]
        // GET requests to "localhost:5000" go here

        public ViewResult Projects()
        {
            // Method body
            return View();
        }



        [HttpGet("Contact")]
        // GET requests to "localhost:5000/about" go here
        public ViewResult Contact()
        {
            return View();// Method body
        }

        [HttpGet("razorfun")]
        // GET requests to "localhost:5000/about" go here
        public ViewResult Razorfun()
        {
            return View();// Method body
        }


        // [HttpGet("showtime")]
        // // GET requests to "localhost:5000/about" go here
        // public ViewResult Showtime()
        // {
        //     return View();
        // }

        // public class HomeController : Controller

        [HttpGet]
        [Route("Showtime")]
        public IActionResult Showtime()
        {
            return View();
        }

        // remember to use [HttpPost] attributes!


        // *********************
        [HttpGet("form")]
        public ActionResult Form()
        {
            return View("Form");
        }

        [HttpPost("result")]
        public ActionResult Result(string name, string location, string language, string textarea)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.textarea = textarea;

            return View();
        }

        //Redirect back to Index if trying to access result page through GET
        [HttpGet("result")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Index");
        }



        // ***********************

    }

    // [HttpPost]
    // [Route("submission")]
    // POST requests to "localhost:5000/submission" go here        // (Don't worry about form submissions for now, we will get to those later!)
    // public string FormSubmission(string formInput)
    // {
    //     // Method body
    // }
}



