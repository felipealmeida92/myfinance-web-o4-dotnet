using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Repository.Interfaces;
using myfinance_web_netcore.Services.Interfaces;

namespace myfinance_web_netcore.Service.PlanoContaService
{

    public class PlanoContaService : IPlanoContaService
    {
        IPlanoContaRepository _planoContaRepository;
        public PlanoContaService(IPlanoContaRepository planoContaRepository)
        {
            _planoContaRepository = planoContaRepository;
        }

        public void CadastrarPlanoConta(PlanoContaModel input)
        {
            var planoConta = new PlanoConta(){
                    Id = input.Id,
                    Descricao = input.Descricao,
                    Tipo = input.Tipo
                };
                _planoContaRepository.Cadastrar(planoConta);
        }

        public List<PlanoContaModel> ListaPlanoContaModel()
        {
            var listaPlanoContas = _planoContaRepository.ListarRegistros();
            var listaPlanoContaModel = new List<PlanoContaModel>();

            foreach (var item in listaPlanoContas)
            {
                var planoContaModel = new PlanoContaModel(){
                    Id = item.Id,
                    Descricao = item.Descricao,
                    Tipo = item.Tipo
                };

                listaPlanoContaModel.Add(planoContaModel);
            }

            return listaPlanoContaModel;
        }
    }
}