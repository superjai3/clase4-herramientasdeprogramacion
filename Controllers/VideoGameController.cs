using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using clase4.Models;
using System.ComponentModel;

namespace clase4.Controllers;

public class VideoGameController : Controller
{
    private readonly ILogger<VideoGameController> _logger;

    public VideoGameController(ILogger<VideoGameController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    { 
        var gamelist= new List<Game>();
        
        var game1 = new Game ();
        game1.Name = "Fifa 2023";
        game1.IsMultiPlayer = true;
        gamelist.Add(game1);

        var game2 = new Game ();
        game2.Name = "Mortal Kombat";
        game2.IsMultiPlayer = true;
        gamelist.Add(game2);

        var game3 = new Game ();
        game3.Name = "Mario Bros";
        game3.IsMultiPlayer = true;
        gamelist.Add(game3);

        return View(gamelist);
    }

    //[Route("private/videogame/newgame")]
     public IActionResult NewGame()
    {
        return View();
    }
}