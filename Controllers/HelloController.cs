using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PortfolioI.Controllers;
public class HelloController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("projects")] // We will go over this in more detail on the next page    

    public ViewResult Projects()
    {
        return View("Projects");
    }

    [HttpGet("contact")] // We will go over this in more detail on the next page    

    public ViewResult Contact()
    {
        return View("Contact");
    }


}