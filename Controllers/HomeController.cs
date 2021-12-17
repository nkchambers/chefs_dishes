using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using chefs_dishes.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace chefs_dishes.Controllers
{
    public class HomeController : Controller 
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }


        //GET INDEX SHOWING ALL CHEFS
        [HttpGet("")]
        public ViewResult Index()
        {
            IndexView ViewModel = new IndexView()
            {
                AllChefs = _context.chefs
                    .Include(chf => chf.DishesCreated)
                    .ToList(),
                //AllDishes = _context.dishes
                  //  .Include(dsh => dsh.CreatedBy)
                    //.ToList()
            };
            
            return View(ViewModel);
        }


        //GET NEW CHEF FORM
        [HttpGet("chef/new")]
        public IActionResult NewChef()
        {
            return View();
        }


        //CREATE CHEF IN DB - POST METHOD
        [HttpPost("chef/create")]
        public IActionResult CreateChef(Chef fromForm)
        {   
            if(ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else 
            {
                return View("NewChef");
            }
        }
    }
}