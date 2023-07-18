using myfinance_web_netcore.Application.ObterPlanoConta;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services.Interfaces;

namespace myfinance_web_netcore.Application.CadastrarPlanoConta
{
    public class CadastrarPlanoConta : ICadastrarPlanoConta
    {
        private readonly IPlanoContaService _planoContaService;
        public CadastrarPlanoConta(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }

        public void Cadastrar(PlanoContaModel input)
        {
            _planoContaService.CadastrarPlanoConta(input);
        }
    }
}