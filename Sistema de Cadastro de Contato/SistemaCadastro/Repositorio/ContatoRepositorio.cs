using SistemaCadastro.Data;
using SistemaCadastro.Models;
using SistemaCadastro.Repositorio;

namespace SistemaCadastro.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;


        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
           _bancoContext.Set<ContatoModel>().Add(contato); //salvar no banco de dados 
           _bancoContext.SaveChanges();  

           return contato;
        }
    }
}