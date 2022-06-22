using DesignPatterns.Patterns.Builder;

namespace DesignPatterns.Patterns
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simula envio por SMS");
        }
    }
}
