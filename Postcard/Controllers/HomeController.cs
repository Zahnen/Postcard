using Microsoft.AspNetCore.Mvc;

namespace Postcard.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public string Letter() { return "Our virtual postcard will go here soon!"; }

  }
}