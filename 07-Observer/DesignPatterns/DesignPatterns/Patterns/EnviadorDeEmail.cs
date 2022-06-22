using DesignPatterns.Patterns.Builder;

namespace DesignPatterns.Patterns
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simula envio de e-mail");
        }
    }
}
