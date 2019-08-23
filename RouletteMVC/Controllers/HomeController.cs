using Microsoft.AspNetCore.Mvc;
using System.Linq;
using RouletteMVC.Models;

namespace RouletteMVC.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    var player = new Player(1000);
        //    var game = new GameBoard(player);
        //    var ball = new Ball();
        //    //return View();

        //    //var products = new[] {
        //    //    new { Name = "Kayak", Price = 275M },
        //    //    new { Name = "Lifejacket", Price = 48.95M },
        //    //    new { Name = "Soccer ball", Price = 19.50M },
        //    //    new { Name = "Corner flag", Price = 34.95M }
        //    //};

        //    //return View(products.Select(p =>
        //    //    $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));

        //    return View(game.IsColor(ball, "red"));
        //}
        public ViewResult Index()
        {
            ViewBag.Greeting = "Welcome to the Casino!";
            return View("GameForm");
        }

        //[HttpGet]
        public ViewResult GameForm()
        {
            return View("GameForm");
        }

        [HttpPost]
        public ViewResult GameForm(GameBoard gameBoard)
        {

            return View();
            //if (ModelState.IsValid)
            //{
            //    _dbContext.GuestResponses.Add(guestResponse);
            //    _dbContext.SaveChanges();
            //    return View("Thanks", guestResponse);
            //}
            //else
            //{
            //    // there is a validation error
            //    return View();
            //}
        }




    }
}
