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
        
        List <ContatoModel> contatos = _contatoRepositorio.BuscarContatos();

        return View(contatos);
    }

    public IActionResult Criar()
    {
        

        return View(); //redireciona para index

    }
    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepositorio.Adicionar(contato);

        return RedirectToAction("Index"); //redireciona para index

    }

    public IActionResult Editar(int id)
    {
      ContatoModel contato = _contatoRepositorio.ListarId(id);

        return View(contato);
    }

[HttpPost]
    public IActionResult Atualizar(ContatoModel contato)
    {
        _contatoRepositorio.Atualizar(contato);

        return RedirectToAction("Index"); //redireciona para index

    }

    public IActionResult ConfirmarRemover(int id)
    {
      ContatoModel contato = _contatoRepositorio.ListarId(id);   
        return View(contato);
    }

     public IActionResult Remover(int id)
    {
         _contatoRepositorio.Remover(id);

        return RedirectToAction("Index"); //redireciona para index

    }
}