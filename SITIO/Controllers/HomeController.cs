using System.Diagnostics;
using CORE.Interfaces.Http;
using Microsoft.AspNetCore.Mvc;
using SITIO.Models;

namespace SITIO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IApiInterna _api;

    public HomeController(ILogger<HomeController> logger, IApiInterna api)
    {
        _logger = logger;
        this._api = api;
    }

    public IActionResult Index()
    {
        var result = _api.GetAll();
        if (!string.IsNullOrEmpty(result.mensaje))
        {
            ViewBag.error = result.mensaje;
            _logger.LogInformation(result.mensaje);
        }

        return View(result.lista);
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
