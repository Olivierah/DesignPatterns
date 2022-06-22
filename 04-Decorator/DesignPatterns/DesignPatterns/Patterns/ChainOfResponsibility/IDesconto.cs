
namespace DesignPatterns
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        public IDesconto Proximo { get; set; }
    }
}
