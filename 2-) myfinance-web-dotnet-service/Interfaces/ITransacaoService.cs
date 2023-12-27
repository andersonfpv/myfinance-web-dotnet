using myfinance_web_dotnet_domain.Entities;


namespace myfinance_web_dotnet_service.Interfaces
{
    public interface ITransacaoSerivce
    {
        void Cadastrar(Transacao Entidade);
        void Excluir(int Id);
        Lista<Transacao> ListaRegistros();
        Transacao RetornarRegistros(int Id);

    }
}