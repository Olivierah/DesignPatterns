namespace DesignPatterns.Patterns
{
    public class CriadorDeNotaFiscal
    {
        //Propriedades

        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public string Observacoes { get; set; }

        public IList<ItemDaNota> TodosItens = new List<ItemDaNota>();


        // Métodos
        public NotaFiscal Construtor()
        {
            return new NotaFiscal(
                RazaoSocial,
                CNPJ,
                Data,
                ValorTotal,
                Impostos,
                TodosItens,
                Observacoes
                );
        }

        public CriadorDeNotaFiscal ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public CriadorDeNotaFiscal ComCNPJ(string cnpj)
        {
            CNPJ = cnpj;
            return this;
        }

        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public CriadorDeNotaFiscal DataDeEmissao()
        {
            Data = DateTime.Now;
            return this;
        }

    }
}
