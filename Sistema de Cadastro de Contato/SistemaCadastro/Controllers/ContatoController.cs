using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaCadastro.Models;

namespace SistemaCadastro.Controllers;

public class ContatoController : Controller
{

    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult Criar()
    {
        
        return View();
    }

    public IActionResult Editar()
    {
        
        return View();
    }

    public IActionResult ConfirmarRemover()
    {
        
        return View();
    }
}