namespace myfinance_web_dotnet_domain.Entities;

public class Transacao
{
    public int? id { get; set; }
    public string Historico { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
    public int PlanoConta { get; set; }
    public PlanoConta PlanoConta { get; set; }
}
