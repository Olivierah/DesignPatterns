namespace DesignPatterns
{
    public class DescontoPorMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
