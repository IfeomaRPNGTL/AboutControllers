using AboutControllers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ControllerTutorials
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult() {Content = "Hello from index", ContentType = "text/plain"};
            //return Content("Hello from Ifeoma", "text/plain");

            return Content("<h1>Welcome</h1> <h2>Hello Venus!</h2>", "text/html");
        }

        [Route("/person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                Age = 34,
                FirstName = "Maltida",
                LastName = "Olado"
            };
            return new JsonResult(person);

        }

        //[Route("/contact-us/{mobile:regex(^\\d{{10}}$)}")]
        //public string Contact()
        //{
        //    return "Hello from contact page";
        //}

        [Route("file-download")]
        public VirtualFileResult FileDownload()
        {
            return new VirtualFileResult("/Account-statement.pdf", "application/pdf");
        }
    }
}
