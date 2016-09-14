
using Microsoft.AspNetCore.Mvc;

namespace capp.TimePie
{
    public class HomeController : Controller
    {
        public string Index(string id)
        {
            return $"Hello, {id}";
        }

       
    }
}