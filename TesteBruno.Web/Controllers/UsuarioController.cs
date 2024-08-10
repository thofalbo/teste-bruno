using Microsoft.AspNetCore.Mvc;

namespace TesteBruno.Web.Controllers;

public class UsuarioController : Controller
{
    public UsuarioController()
    {

    }

    public IActionResult Index()
    {
        return View("_NaoEAIndex");
    }
}
