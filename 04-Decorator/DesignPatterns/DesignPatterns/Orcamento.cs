namespace DesignPatterns
{
    public class Orcamento
    {
        //Propriedades
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }
       
        //Construtor
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        //Métodos
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
