using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase4.Models;
using Clase4.Services;

namespace Clase4.Controllers;

public class MovieController : Controller
{
    // private readonly ILogger<HomeController> _logger;
    //  public HomeController(ILogger<HomeController> logger)
    //     {}
    public MovieController()
    {
        // _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new List<Movie>();
        model = MovieService.GetAll();
        return View(model);
    }

    public IActionResult Detail(string id)
    {
        var model = MovieService.Get(id);
        return View(model);
    }


    public IActionResult Create()
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult Create(Movie movie){
        if(!ModelState.IsValid){
            return RedirectToAction("Create");
        }

        MovieService.Add(movie);

        return RedirectToAction("Index");
    }

    public IActionResult Delete(string id){
        var movieToDelete = Get(code);
        if (movieToDelete != null){
            Movies.Remove(movieToDelete);
      }
    }


    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}
