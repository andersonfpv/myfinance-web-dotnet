using myfinance_web_dotnet_domain.Entities;


namespace myfinance_web_dotnet_service.Interfaces
{
    public interface IPlanoContaSerivce
    {
        void Cadastrar(PlanoContaSerivce Entidade);
        void Excluir(int Id);
        Lista<PlanoConta> ListaRegistros();
        PlanoConta RetornarRegistros(int Id);

    }
}