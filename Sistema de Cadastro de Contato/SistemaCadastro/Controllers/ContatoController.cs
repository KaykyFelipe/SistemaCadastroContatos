using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaCadastro.Models;
using SistemaCadastro.Repositorio;

namespace SistemaCadastro.Controllers;

public class ContatoController : Controller
{

    private readonly IContatoRepositorio _contatoRepositorio;//fazendo a injeção de dependencia

    public ContatoController(IContatoRepositorio contatoRepositorio){

        _contatoRepositorio = contatoRepositorio;
    }

    public IActionResult Index()
    {
        

        return View();
    }

    public IActionResult Criar()
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepositorio.Adicionar(contato);

        return RedirectToAction("Index"); //redireciona para index

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