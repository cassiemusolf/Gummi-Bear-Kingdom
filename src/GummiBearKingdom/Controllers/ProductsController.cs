using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;


namespace GummiBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        private GummiBearDbContext db = new GummiBearDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
  
    public IActionResult Details(int id)
    {
        var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
        return View(thisProduct);
    }
  }
}
