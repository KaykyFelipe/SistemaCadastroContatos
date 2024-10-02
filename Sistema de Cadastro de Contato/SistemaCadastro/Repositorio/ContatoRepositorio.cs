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
            this._bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
           _bancoContext.Set<ContatoModel>().Add(contato); //salvar no banco de dados 
           _bancoContext.SaveChanges();  

           return contato;
        }

        public List<ContatoModel> BuscarContatos()
        {
            return _bancoContext.Set<ContatoModel>().ToList();
        }

        public ContatoModel ListarId(int id)
        {
            return _bancoContext.Set<ContatoModel>().FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarId(contato.Id);

            if(contatoDB == null)throw new Exception("Houve um erro na atualização do contato!!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Numero = contato.Numero;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;


            
        }

        public bool Remover(int id)
        {
            ContatoModel contatoDB = ListarId(id);

            if(contatoDB == null)throw new Exception("Houve um erro na Remoção do contato!!");

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
            
            return true;


            
        }

      
    }
}