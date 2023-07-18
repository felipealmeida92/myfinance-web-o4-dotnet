using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Models;
namespace myfinance_web_netcore.Repository
{

    public interface IRepository<TEntity> where TEntity:class
    {
        void Cadastrar(TEntity Entidade);
        void Excluir(int id);
        List<TEntity> ListarRegistros();
        TEntity RetornarRegistro(int Id);
    }
}