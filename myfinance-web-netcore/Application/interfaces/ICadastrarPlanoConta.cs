using myfinance_web_netcore.Models;
namespace myfinance_web_netcore.Application.ObterPlanoConta
{
    public interface ICadastrarPlanoConta
    {
        void Cadastrar(PlanoContaModel input);
    }
}