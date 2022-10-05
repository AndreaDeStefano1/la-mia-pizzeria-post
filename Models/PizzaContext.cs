﻿using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizzeria;Integrated Security=True");
        }
    }
}
