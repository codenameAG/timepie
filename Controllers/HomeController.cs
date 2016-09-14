
using Microsoft.AspNetCore.Mvc;
using capp.TimePie.Models;

namespace capp.TimePie
{
    
    public class HomeController : Controller
    {        
        public User Index(long id)
        {
            var user= new User(){Id=id, LoginId="a@a.com", FullName="Amit Gaonkar"};
            return user;
        }

        [Microsoft.AspNetCore.Mvc.RouteAttribute("help/{topic}")]
        public IActionResult HomeHelp(string topic)
        {            
            return Content($"<h1>You choose Topic - {topic}</h1>", "text/html");
        }
    }
}