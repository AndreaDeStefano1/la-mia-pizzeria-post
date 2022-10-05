using la_mia_pizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza() { Id = 1, Name = "Margherita", Description = "Pomodoro, mozzarella, basilico", Image = "/img/pizza.jpg", Price = 4.5 });
            pizzaList.Add(new Pizza() { Id = 2, Name = "Divola", Description = "Pomodoro, salame, mozzarella", Image = "/img/pizza.jpg", Price = 5 });
            pizzaList.Add(new Pizza() { Id = 3, Name = "marinara", Description = "Pomodoro, mozzarella, basilico", Image = "/img/pizza.jpg", Price = 3.5 });
            return View(pizzaList);
        }
        public IActionResult Show(int id)
        {
            List<Pizza> pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza() { Id = 1, Name = "Margherita", Description = "Pomodoro, mozzarella, basilico", Image = "/img/pizza.jpg", Price = 4.5 });
            pizzaList.Add(new Pizza() { Id = 2, Name = "Divola", Description = "Pomodoro, salame, mozzarella", Image = "/img/pizza.jpg", Price = 5 });
            pizzaList.Add(new Pizza() { Id = 3, Name = "marinara", Description = "Pomodoro, mozzarella, basilico", Image = "/img/pizza.jpg", Price = 3.5 });
            Pizza pizza = pizzaList[id];
            return View(pizza);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}