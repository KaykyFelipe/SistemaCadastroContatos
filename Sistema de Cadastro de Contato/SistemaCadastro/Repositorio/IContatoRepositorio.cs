using SistemaCadastro.Models;

public interface IContatoRepositorio{


    ContatoModel Adicionar(ContatoModel contato);

    List<ContatoModel> BuscarContatos();

    ContatoModel ListarId(int Id);

    ContatoModel Atualizar(ContatoModel contato);

    bool Remover(int id);


}