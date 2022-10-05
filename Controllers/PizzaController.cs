﻿using la_mia_pizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
            
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizze = db.Pizzas.OrderByDescending(pizza => pizza.Id).ToList<Pizza>();
                return View(pizze);
            }
            
        }
        public IActionResult Show(int id)
        {
            
     
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", pizza);
            }
            using (PizzaContext db = new PizzaContext())
            {
                Pizza p = new Pizza();
                p.Name = pizza.Name;
                p.Description = pizza.Description;
                p.Image = pizza.Image;
                p.Price = pizza.Price;
                db.Add(p);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}