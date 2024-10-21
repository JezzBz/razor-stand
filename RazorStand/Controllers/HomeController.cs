using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RazorStand.Models;
using VJeek.Fartsa.Emailing.Host.Models.Generation.Common;
using VJeek.Fartsa.Emailing.Host.Models.Generation.Promo;
using VJeek.Fartsa.Emailing.Host.Models.Generation.User;

namespace RazorStand.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("promocode")]
    public IActionResult Promo()
    {
        return View("Promo/PromocodeEmail", new PromocodeEmail
        {
            User = new User
            {
                Name = "Name"
            },
            Promoaction = new Promoaction
            {
                Id = "1",
                Title = "Кешбек"
            },
            Code = Guid.NewGuid().ToString(),
            Url = "fartsa.tech",
            Base64Url = "aHR0cHM6Ly9mYXJ0c2EudGVjaC9jb2RlL3Rva2VuL0g0c0lBQUFBQUFBQUE2dFdVaW1wTEVoVnNsSnlTeXdxS1U3VWN5d295TWxNVGl6SnpNX1RjODR2U2dVU3VibEFka0JSZm01LWNuNUtha2gtZG1xZWpnSU81VW82U25DVm5pbEtWaGFHdFFEUkY4VDZZd0FBQUE"
        });
    }
    
    [Route("confirmation")]
    public IActionResult Confirmation()
    {
        return View("User/EmailConfirmation", new EmailConfirmation
        {
            User = new User
            {
                Name =  "Max"
            },
            ConfirmationUrl = "fartsa.tech",
            Code = "1232132"
        });
    }
    
    [Route("invitation")]
    public IActionResult Invitation()
    {
        return View("User/Invitation", new Invitation
        {
            PromoactionTitle = "Кешбек",
            Link = "fartsa.tech",
            BusinessName = "ООО Айкон"
        });
    }
    
    [Route("registration")]
    public IActionResult Registration()
    {
        return View("User/RegistrationRequest", new RegistrationRequest
        {
            User = new User
            {
                Name = "ООО Айкон"
            }
        });
    }
    
    
    [Route("statusing")]
    public IActionResult Statusing()
    {
        return View("User/StatusingResult", new StatusingResult
        {
            User = new User
            {
                Name = "ООО Айкон"
            },
            Success = false,
            Url = "fartsa.tech",
            Message = "Так надо"
        });
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