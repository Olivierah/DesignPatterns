using DesignPatterns.Patterns.Builder;

namespace DesignPatterns.Patterns
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simula salvamento no banco");
        }
    }
}
