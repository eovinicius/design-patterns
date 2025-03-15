namespace Proxy;

public class ReportGenerete : IReportGenerete
{
    public string Generete()
    {
        //Logica para simular a busca de um relatorio do banco de dados
        Thread.Sleep(10000);

        return "Relatorio";
    }
}
