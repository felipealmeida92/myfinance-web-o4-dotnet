using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services.Interfaces;

namespace myfinance_web_netcore.Application.ObterPlanoConta
{
    public class ObterPlanoConta : IObterPlanoConta
    {
        private readonly IPlanoContaService _planoContaService;
        public ObterPlanoConta(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }
        List<PlanoContaModel> IObterPlanoConta.GetListaPlanoContaModel()
        {

            return _planoContaService.ListaPlanoContaModel();
        }
    }
}