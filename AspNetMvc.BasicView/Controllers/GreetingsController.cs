using System.Web.Mvc;

namespace AspNetMvc.BasicView
{
    public class GreetingsController : Controller
    {
        // You can run this action by going to http://localhost:63307/Greetings/Hello. The action
        // simply displays the appropriate view.
        // The return type isn't just a string, but an ActionResult. ActionResult encapsulates the
        // entire HTTP response message, including body, headers, response code, cookies, etc.
        public ActionResult Hello()
        {
            // ASP.NET MVC automatically finds the correct view. It uses the name of the controller
            // (Greetings) to find the correct folder and the name of the action (Hello) to find
            // the correct file. In this case the view is in Views/Greetings/Hello.cshtml.
            return View();
        }

        // You can run this action by going to http://localhost:63307/Greetings/Goodbye.
        public ActionResult Goodbye()
        {
            // The view is in Views/Greetings/Goodbye.cshtml.
            return View();
        }
    }
}