namespace DesignPatterns.Patterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto adicional");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento atualmente finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento atualmente finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento atualmente finalizado");
        }
    }
}
