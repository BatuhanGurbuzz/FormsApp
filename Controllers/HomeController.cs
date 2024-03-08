using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsApp.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {
    }

    public IActionResult Index(string searchString, string category)
    {
        var products = Repository.Products;

        if(!String.IsNullOrEmpty(searchString)){
            searchString = searchString.Trim().ToLower();

            ViewBag.SearchString = searchString;

            products = products.Where(a => a.Name != null && a.Name.ToLower().Contains(searchString)).ToList();
        }

        if(!String.IsNullOrEmpty(category) && category != "0"){
            products = products.Where(c => c.CategoryID == int.Parse(category)).ToList();
        }

        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryID", "CategoryName");

        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
}
