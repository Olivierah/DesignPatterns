using DesignPatterns.Patterns;

namespace DesignPatterns
{
    public class Orcamento
    {
        //Propriedades
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }
        public EstadoDeUmOrcamento EstadoAtual { get; set; }




        //Construtor
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }




        //Métodos
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }


        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
